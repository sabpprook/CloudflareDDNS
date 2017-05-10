using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudflareDDNS
{
    public class PPPoE
    {
        public void pppoeConnect(SettingRegistry.AutoPPPoE ppp)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "rasdial";
                p.StartInfo.Arguments = ppp.name + " " + ppp.account + " " + ppp.password;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();
            }
        }

        public void pppoeDisconnect()
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "rasdial";
                p.StartInfo.Arguments = "/DISCONNECT";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();
            }
        }
    }
}
