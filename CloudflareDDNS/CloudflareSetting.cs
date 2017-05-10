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
    public partial class CloudflareSetting : Form
    {
        SettingRegistry.CFSetting setting;
        CloudflareAPI api = new CloudflareAPI();

        public CloudflareSetting(ref SettingRegistry.CFSetting _setting)
        {
            InitializeComponent();
            setting = _setting;
            txt_key.Text = setting.key;
            txt_email.Text = setting.email;
            txt_zone.Text = setting.zone;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (txt_key.Text.Length > 0 && txt_email.Text.Length > 0 && txt_zone.Text.Length > 0)
            {
                CloudflareJson.RootObject json = api.readRecords(txt_key.Text, txt_email.Text, txt_zone.Text);
                if (json.result == "success")
                {
                    DialogResult = DialogResult.OK;
                    setting.key = txt_key.Text;
                    setting.email = txt_email.Text;
                    setting.zone = txt_zone.Text;
                }
                else
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show((string)json.msg);
                }
            }
            else
                System.Media.SystemSounds.Asterisk.Play();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
