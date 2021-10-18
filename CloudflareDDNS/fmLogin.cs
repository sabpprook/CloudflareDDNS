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
    public partial class fmLogin : MetroFramework.Forms.MetroForm
    {
        API.Object dns = null;
        string key = null;
        string email = null;

        public fmLogin()
        {
            InitializeComponent();
        }

        private async void buttonGetZones_Click(object sender, EventArgs e)
        {
            key = textBoxAPIKey.Text;
            email = textBoxEmail.Text;
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(email))
            {
                comboBoxZones.Items.Clear();
                dataGridView.Rows.Clear();
                var zones = await Task.Run(() => API.GetZones(key, email));
                if (!zones.success)
                {
                    key = email = null;
                    MessageBox.Show("Cannot get Cloudflare zones");
                    return;
                }
                foreach (var result in zones.result)
                {
                    comboBoxZones.Items.Add(result);
                }
                if (comboBoxZones.Items.Count > 0)
                {
                    comboBoxZones.SelectedIndex = 0;
                }
            }
        }

        private async void comboBoxZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            key = textBoxAPIKey.Text;
            email = textBoxEmail.Text;
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(email))
            {
                dataGridView.Rows.Clear();
                var zone = (API.Result)comboBoxZones.SelectedItem;
                dns = await Task.Run(() => API.GetDNSRecords(key, email, zone));
                if (!dns.success)
                {
                    key = email = null;
                    MessageBox.Show("Cannot Get Cloudflare DNS Records");
                    return;
                }
                if (dns.result.Count > 0)
                {
                    var syncList = ((fmGUI)this.Owner).setting.syncList.result;
                    foreach (var rec in dns.result)
                    {
                        if (rec.type == "A" || rec.type == "AAAA")
                        {
                            var obj = syncList.FirstOrDefault(x => x.id == rec.id);
                            dataGridView.Rows.Add(obj != null ? "1" : "0", rec.id, rec.type, rec.name, rec);
                        }
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var syncList = ((fmGUI)this.Owner).setting.syncList.result;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var row = dataGridView.Rows[i];
                var rec = (API.Result)row.Cells[4].Value;

                var obj = syncList.FirstOrDefault(x => x.id == rec.id);
                if (obj != null)
                {
                    syncList.Remove(obj);
                }

                if (row.Cells[0].Value.ToString() == "1")
                {
                    rec.key = key;
                    rec.email = email;
                    syncList.Add(rec);
                }
            }
        }
    }
}
