using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudflareDDNS
{
    public partial class CloudflareRecords : Form
    {
        SettingRegistry.CFSetting setting;
        CloudflareAPI api = new CloudflareAPI();
        CloudflareJson.RootObject json;

        public CloudflareRecords(ref SettingRegistry.CFSetting _setting)
        {
            InitializeComponent();
            setting = _setting;
        }

        private void CloudflareRecords_Load(object sender, EventArgs e)
        {
            bgWorker_getRecs.RunWorkerAsync();
        }

        private void bgWorker_getRecs_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = api.readRecords(setting.key, setting.email, setting.zone);
        }

        private void bgWorker_getRecs_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            json = (CloudflareJson.RootObject)e.Result;
            if (json != null && json.result == "success")
            {
                button1.Enabled = true;
                dataGridView1.Rows.Clear();
                foreach (CloudflareJson.Obj rec in json.response.recs.objs)
                {
                    dataGridView1.Rows.Add(setting.sync.Contains(rec.rec_id) ? "True" : "False", rec.rec_id, rec.type, rec.name, rec.content);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = "";
            for (int i=0; i < dataGridView1.RowCount; i++)
            {
                if ((string)dataGridView1.Rows[i].Cells[0].Value == "True")
                    id += dataGridView1.Rows[i].Cells[1].Value + ";";
            }
            if (id.Length > 0) id = id.Substring(0, id.Length - 1);
            setting.sync = id;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
