using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CloudflareDDNS
{
    public class HttpUtils
    {
        public static string IPv4 { get; set; }
        public static string IPv6 { get; set; }

        private static string[] IPv4_API_URL = {
            "https://ipv4bot.whatismyipaddress.com",
            "https://v4.ident.me",
            "https://ip4.seeip.org"
        };

        private static string[] IPv6_API_URL = {
            "https://ipv6bot.whatismyipaddress.com",
            "https://v6.ident.me",
            "https://ip6.seeip.org"
        };

        public static bool isConnect()
        {
            try
            {
                var hostEntry = Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch (Exception e)
            {
                Logger.Write($"Error | HttpUtils::isConnect | {e.Message}");
                return false;
            }
        }

        public static void GetExternalIP()
        {
            using (var wc = new WebClient())
            {
                foreach (var url in IPv4_API_URL)
                {
                    try
                    {
                        IPv4 = wc.DownloadString(url);
                        break;
                    }
                    catch (Exception e)
                    {
                        IPv4 = "0.0.0.0";
                        Logger.Write($"Error | HttpUtils::GetExternalIP | IPv4 | {e.Message}");
                    }
                }
                foreach (var url in IPv6_API_URL)
                {
                    try
                    {
                        IPv6 = wc.DownloadString(url);
                        break;
                    }
                    catch (Exception e)
                    {
                        IPv6 = "0::0";
                        Logger.Write($"Error | HttpUtils::GetExternalIP | IPv6 | {e.Message}");
                    }
                }
            }
        }
    }
}
