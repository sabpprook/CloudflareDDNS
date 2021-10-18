using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CloudflareDDNS
{
    public class API
    {
        private static string API_URL = "https://api.cloudflare.com/client/v4/";
        private static JavaScriptSerializer jss = new JavaScriptSerializer();

        public static Object GetZones(string Key, string Email)
        {
            using (var wc = new WebClient())
            {
                string result = null;
                wc.Headers.Add("X-Auth-Email", Email);
                wc.Headers.Add("X-Auth-Key", Key);
                wc.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                try
                {
                    result = wc.DownloadString($"{API_URL}zones");
                    Logger.Write($"Info | API::GetZones({Key}, {Email}) | {result}");
                    return jss.Deserialize<Object>(result);
                }
                catch (Exception e)
                {
                    Logger.Write($"Error | API::GetZones({Key}, {Email}) | {e.Message}");
                    return new Object();
                }
            }
        }

        public static Object GetDNSRecords(string Key, string Email, Result Zone)
        {
            using (var wc = new WebClient())
            {
                string result = null;
                wc.Headers.Add("X-Auth-Email", Email);
                wc.Headers.Add("X-Auth-Key", Key);
                wc.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                try
                {
                    result = wc.DownloadString($"{API_URL}zones/{Zone.id}/dns_records");
                    Logger.Write($"Info | API::GetDNSRecords({Key}, {Email}, {Zone.id}) | {result}");
                    return jss.Deserialize<Object>(result);
                }
                catch (Exception e)
                {
                    Logger.Write($"Error | API::GetDNSRecords({Key}, {Email}, {Zone.id}) | {e.Message}");
                    return new Object();
                }
            }
        }

        public static void UpdateDNSRecord(List<Result> syncList, string IPv4, string IPv6)
        {
            foreach (var rec in syncList)
            {
                var ip = "";
                if (rec.type == "A") ip = IPv4;
                if (rec.type == "AAAA") ip = IPv6;
                using (var wc = new WebClient())
                {
                    string result = null;
                    wc.Headers.Add("X-Auth-Email", rec.email);
                    wc.Headers.Add("X-Auth-Key", rec.key);
                    wc.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    try
                    {
                        var data = new Dictionary<string, object>();
                        data.Add("type", rec.type);
                        data.Add("name", rec.name);
                        data.Add("content", ip);
                        data.Add("ttl", rec.ttl);
                        data.Add("proxied", rec.proxied);
                        result = wc.UploadString($"{API_URL}zones/{rec.zone_id}/dns_records/{rec.id}", "PUT", jss.Serialize(data));
                        Logger.Write($"Info | API::UpdateDNSRecord | {result}");
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"Error | API::UpdateDNSRecord | {e.Message} | {result}");
                    }
                }
            }
        }

        public static DNSRecord GetDNSRecordInfo(Result record)
        {
            using (var wc = new WebClient())
            {
                string result = null;
                wc.Headers.Add("X-Auth-Email", record.email);
                wc.Headers.Add("X-Auth-Key", record.key);
                wc.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                try
                {
                    result = wc.DownloadString($"{API_URL}zones/{record.zone_id}/dns_records/{record.id}");
                    Logger.Write($"Info | API::GetDNSRecordInfo | {result}");
                    return jss.Deserialize<DNSRecord>(result);
                }
                catch (Exception e)
                {
                    Logger.Write($"Error | API::GetDNSRecordInfo | {e.Message}");
                    return new DNSRecord();
                }
            }
        }

        public class Object
        {
            public List<Result> result { get; set; }
            public bool success { get; set; }
        }

        public class DNSRecord
        {
            public Result result { get; set; }
            public bool success { get; set; }
        }

        [Serializable]
        public class Result
        {
            public string key { get; set; }
            public string email { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string content { get; set; }
            public bool proxied { get; set; }
            public int ttl { get; set; }
            public string zone_id { get; set; }
            public string zone_name { get; set; }
            public override string ToString()
            {
                return name;
            }
        }
    }
}
