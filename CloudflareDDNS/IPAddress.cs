using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CloudflareDDNS
{
    public class IPAddress
    {
        string[] IPv4ApiUrl = 
        {
            "http://ipv4bot.whatismyipaddress.com",
            "http://v4.ident.me",
            "http://v4.ipv6-test.com/api/myip.php"
        };

        string[] IPv6ApiUrl =
        {
            "http://ipv6bot.whatismyipaddress.com",
            "http://v6.ident.me",
            "http://v6.ipv6-test.com/api/myip.php"
        };

        public string GetIPv4()
        {
            for (int i=0; i< IPv4ApiUrl.Length; i++)
            {
                string tmp = GetIP(IPv4ApiUrl[i], true);
                if (tmp != null) return tmp;
            }
            return "0.0.0.0";
        }

        public string GetIPv6()
        {
            for (int i = 0; i < IPv4ApiUrl.Length; i++)
            {
                string tmp = GetIP(IPv6ApiUrl[i], true);
                if (tmp != null) return tmp;
            }
            return "0:0:0:0:0:0:0:0";
        }

        string GetIP(string URL, bool isIPv4 = true)
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    return web.DownloadString(URL);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
