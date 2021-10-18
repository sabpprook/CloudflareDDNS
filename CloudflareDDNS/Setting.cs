using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CloudflareDDNS
{
    [Serializable]
    public class Setting
    {
        public bool isAutoPPPoE { get; set; }
        public bool isDebugOutput { get; set; }
        public bool isStartMinimize { get; set; }

        [Serializable]
        public class SyncList
        {
            public List<API.Result> result { get; set; } = new List<API.Result>();
        }

        public SyncList syncList { get; set; } = new SyncList();

        [Serializable]
        public class PPPoESetting
        {
            public string Name { get; set; }
            public string User { get; set; }
            public string Password { get; set; }
        }

        public PPPoESetting PPPoE { get; set; } = new PPPoESetting();

        public static string SaveFile = $"{Program.StartupPath}\\CloudflareDDNS.db";

        public static Setting Load()
        {
            Setting setting = new Setting();
            if (File.Exists(SaveFile))
            {
                var bf = new BinaryFormatter();
                using (var fs = new FileStream(SaveFile, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        setting = (Setting)bf.Deserialize(fs);
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"Error | Setting::Load | {e.Message}");
                    }
                }
            }
            return setting;
        }

        public static void Save(Setting setting)
        {
            var bf = new BinaryFormatter();
            using (var fs = new FileStream(SaveFile, FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(fs, setting);
            }
        }
    }
}
