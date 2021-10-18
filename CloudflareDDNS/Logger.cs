using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudflareDDNS
{
    public class Logger
    {
        public static bool Enable { get; set; }
        private static string LogFile = $"{Program.StartupPath}\\cloudflare_ddns.log";

        public static void Write(string text)
        {
            var dateString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            text = $"{dateString}\t{text}\r\n";
            Console.Write(text);
            if (Enable)
            {
                File.AppendAllText(LogFile, text, Encoding.UTF8);
                if (new FileInfo(LogFile).Length > 1 * 1024 * 1024)
                {
                    File.Delete(LogFile);
                }
            }
        }
    }
}
