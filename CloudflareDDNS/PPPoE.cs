using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CloudflareDDNS
{
    public class PPPoE
    {
        public static void Dial(Setting.PPPoESetting setting)
        {
            using (var p = new Process())
            {
                p.StartInfo.FileName = "rasdial";
                p.StartInfo.Arguments = $"{setting.Name} {setting.User} {setting.Password}";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();
                Logger.Write($"Info | PPPoE::Dial | {p.StartInfo.Arguments} | {p.StandardOutput.ReadToEnd()}");
                Thread.Sleep(5000);
            }
        }
    }
}
