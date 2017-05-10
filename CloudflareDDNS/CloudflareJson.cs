using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudflareDDNS
{
    public class CloudflareJson
    {
        public class Request
        {
            public string act { get; set; }
            public string a { get; set; }
            public string tkn { get; set; }
            public string email { get; set; }
            public string z { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string content { get; set; }
            public string service_mode { get; set; }
            public string ttl { get; set; }
        }

        public class Props
        {
            public int proxiable { get; set; }
            public int cloud_on { get; set; }
            public int cf_open { get; set; }
            public int vanity_lock { get; set; }
            public int ssl { get; set; }
            public int expired_ssl { get; set; }
            public int expiring_ssl { get; set; }
            public int pending_ssl { get; set; }
        }

        public class Mx
        {
            public bool auto { get; set; }
        }

        public class Obj
        {
            public string rec_id { get; set; }
            public string rec_hash { get; set; }
            public string zone_name { get; set; }
            public string name { get; set; }
            public string display_name { get; set; }
            public string type { get; set; }
            public string prio { get; set; }
            public string content { get; set; }
            public string display_content { get; set; }
            public string ttl { get; set; }
            public int ttl_ceil { get; set; }
            public string ssl_id { get; set; }
            public string ssl_status { get; set; }
            public object ssl_expires_on { get; set; }
            public int auto_ttl { get; set; }
            public string service_mode { get; set; }
            public Props props { get; set; }
            public Mx mx { get; set; }
        }

        public class Recs
        {
            public bool has_more { get; set; }
            public int count { get; set; }
            public List<Obj> objs { get; set; }
        }

        public class Response
        {
            public Recs recs { get; set; }
        }

        public class RootObject
        {
            public Request request { get; set; }
            public Response response { get; set; }
            public string result { get; set; }
            public object msg { get; set; }
        }
    }
}
