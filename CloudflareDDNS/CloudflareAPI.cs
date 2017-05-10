using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using static CloudflareDDNS.CloudflareJson;

namespace CloudflareDDNS
{
    public class CloudflareAPI
    {
        const string apiUrl = "https://www.cloudflare.com/api_json?";
        const string readRecsFmt = apiUrl + "a=rec_load_all&tkn={0}&email={1}&z={2}";
        const string editRecFmt = apiUrl + "a=rec_edit&tkn={0}&email={1}&z={2}&id={3}&type={4}&name={5}&content={6}&service_mode={7}&ttl={8}";

        public RootObject readRecords(string tkn, string email, string z)
        {
            string url = string.Format(readRecsFmt, tkn, email, z);
            return readJson(url);
        }

        public RootObject editRecord(string tkn, string email, string z, string id, string type, string name, string content, string service_mode = "0", string ttl = "1")
        {
            string url = string.Format(editRecFmt, tkn, email, z, id, type, name, content, service_mode, ttl);
            return readJson(url);
        }

        RootObject readJson(string URL)
        {
            RootObject json = null;
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            try
            {
                using (WebClient web = new WebClient())
                {
                    string jsonString = web.DownloadString(URL);
                    json = jsonSerializer.Deserialize<RootObject>(jsonString);
                    return json;
                }
            }
            catch (Exception)
            {
                return json;
            }
        }
    }
}
