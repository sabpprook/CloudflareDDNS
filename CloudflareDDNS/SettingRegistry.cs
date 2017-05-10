using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudflareDDNS
{
    public class SettingRegistry
    {
        public class CFSetting
        {
            public string key { get; set; }
            public string email { get; set; }
            public string zone { get; set; }
            public string sync { get; set; }
            public AutoPPPoE pppoe { get; set; }
            public Setting setting { get; set; }
        }

        public class AutoPPPoE
        {
            public string account { get; set; }
            public string name { get; set; }
            public string password { get; set; }
        }

        public class Setting
        {
            public bool autopppoe { get; set; }
            public bool autoupdate { get; set; }
            public bool exitminimize { get; set; }
            public bool startminimize { get; set; }
        }

        public CFSetting setting;
        RegistryKey rootReg;
        RegistryKey pppoeReg;
        RegistryKey settingReg;

        public SettingRegistry()
        {
            rootReg = Registry.CurrentUser.CreateSubKey(@"Software\Cloudflare");
            pppoeReg = rootReg.CreateSubKey("AutoPPPoE");
            settingReg = rootReg.CreateSubKey("Setting");
            setting = new CFSetting();
            setting.pppoe = new AutoPPPoE();
            setting.setting = new Setting();
            readSetting();
        }

        public void readSetting()
        {
            setting.key = (string)rootReg.GetValue("Key", "");
            setting.email = (string)rootReg.GetValue("Email", "");
            setting.zone = (string)rootReg.GetValue("Zone", "");
            setting.sync = (string)rootReg.GetValue("Sync", "");
            setting.pppoe.name = (string)pppoeReg.GetValue("Name", "");
            setting.pppoe.account = (string)pppoeReg.GetValue("Account", "");
            setting.pppoe.password = (string)pppoeReg.GetValue("Password", "");
            setting.setting.startminimize = (int)settingReg.GetValue("StartMinimize", 0) == 1 ? true : false;
            setting.setting.exitminimize = (int)settingReg.GetValue("ExitMinimize", 0) == 1 ? true : false;
            setting.setting.autopppoe = (int)settingReg.GetValue("AutoPPPoE", 0) == 1 ? true : false;
            setting.setting.autoupdate = (int)settingReg.GetValue("AutoUpdate", 0) == 1 ? true : false;
        }

        public void setSetting(int type)
        {
            if (type == 0)
            {
                rootReg.SetValue("Key", setting.key, RegistryValueKind.String);
                rootReg.SetValue("Email", setting.email, RegistryValueKind.String);
                rootReg.SetValue("Zone", setting.zone, RegistryValueKind.String);
            }
            if (type == 1)
                rootReg.SetValue("Sync", setting.sync, RegistryValueKind.String);
            if (type == 2)
            {
                pppoeReg.SetValue("Name", setting.pppoe.name, RegistryValueKind.String);
                pppoeReg.SetValue("Account", setting.pppoe.account, RegistryValueKind.String);
                pppoeReg.SetValue("Password", setting.pppoe.password, RegistryValueKind.String);
            }
            if (type == 3)
            {
                settingReg.SetValue("StartMinimize", setting.setting.startminimize, RegistryValueKind.DWord);
                settingReg.SetValue("ExitMinimize", setting.setting.exitminimize, RegistryValueKind.DWord);
                settingReg.SetValue("AutoPPPoE", setting.setting.autopppoe, RegistryValueKind.DWord);
                settingReg.SetValue("AutoUpdate", setting.setting.autoupdate, RegistryValueKind.DWord);
            }
        }
    }
}
