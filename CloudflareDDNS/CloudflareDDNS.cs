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
    public partial class MainUI : Form
    {
        const int COUNT_DOWN = 300;
        int countDown;
        SettingRegistry regKey;
        IPAddress ipAddress = new IPAddress();
        CloudflareJson.RootObject json = null;
        CloudflareAPI api = new CloudflareAPI();
        PPPoE ppp = new PPPoE();

        public MainUI()
        {
            InitializeComponent();
            this.notifyIcon.Icon = this.Icon = Properties.Resources.ICON;
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            regKey = new SettingRegistry();
            updateCloudflareInfo();
            updatePPPoESetting();
            updateSetting();
        }

        void updateCloudflareInfo()
        {
            label_key.Text = regKey.setting.key;
            label_email.Text = regKey.setting.email;
            label_zone.Text = regKey.setting.zone;
        }

        void updatePPPoESetting()
        {
            txt_pppoe_name.Text = regKey.setting.pppoe.name;
            txt_pppoe_account.Text = regKey.setting.pppoe.account;
            txt_pppoe_password.Text = regKey.setting.pppoe.password;
        }

        void updateSetting()
        {
            chk_startminimize.Checked = regKey.setting.setting.startminimize;
            chk_exitminimize.Checked = regKey.setting.setting.exitminimize;
            chk_autopppoe.Checked = regKey.setting.setting.autopppoe;
            chk_autoupdate.Checked = regKey.setting.setting.autoupdate;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((string)btn.Tag == "btn_list")
            {
                using (CloudflareRecords tmp = new CloudflareRecords(ref regKey.setting))
                {
                    if (tmp.ShowDialog() == DialogResult.OK)
                    {
                        regKey.setSetting(1);
                        if (bgWorker_doSync.IsBusy) bgWorker_doSync.CancelAsync();
                        bgWorker_doSync.RunWorkerAsync();
                    }
                }
            }
            if ((string)btn.Tag == "btn_setting")
            {
                using (CloudflareSetting tmp = new CloudflareSetting(ref regKey.setting))
                {
                    if (tmp.ShowDialog() == DialogResult.OK)
                    {
                        regKey.setSetting(0);
                        updateCloudflareInfo();
                    }
                }
            }
            if ((string)btn.Tag == "btn_pppoe_save")
            {
                regKey.setting.pppoe.name = txt_pppoe_name.Text;
                regKey.setting.pppoe.account = txt_pppoe_account.Text;
                regKey.setting.pppoe.password = txt_pppoe_password.Text;
                regKey.setSetting(2);
            }
            if ((string)btn.Tag == "btn_facebook")
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100005653172695");
            }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if ((string)chk.Tag == "chk_startminimize") regKey.setting.setting.startminimize = chk_startminimize.Checked;
            if ((string)chk.Tag == "chk_exitminimize") regKey.setting.setting.exitminimize = chk_exitminimize.Checked;
            if ((string)chk.Tag == "chk_autopppoe") regKey.setting.setting.autopppoe = chk_autopppoe.Checked;
            if ((string)chk.Tag == "chk_autoupdate")
            {
                regKey.setting.setting.autoupdate = chk_autoupdate.Checked;
                status_countDown.Visible = status_countDown_icon.Visible = chk_autoupdate.Checked;
                if (chk_autoupdate.Checked)
                {
                    status_countDown.Text = "下次更新 " + (countDown = COUNT_DOWN) + " 秒";
                    timer_autoSync.Start();
                }
                else
                {
                    timer_autoSync.Stop();
                }
            }
            regKey.setSetting(3);
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((string)btn.Tag == "btn_list") btn.BackgroundImage = Properties.Resources.list2;
            if ((string)btn.Tag == "btn_setting") btn.BackgroundImage = Properties.Resources.setting2;
            if ((string)btn.Tag == "btn_facebook") btn.BackgroundImage = Properties.Resources.fb2;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((string)btn.Tag == "btn_list") btn.BackgroundImage = Properties.Resources.list;
            if ((string)btn.Tag == "btn_setting") btn.BackgroundImage = Properties.Resources.setting;
            if ((string)btn.Tag == "btn_facebook") btn.BackgroundImage = Properties.Resources.fb;
        }

        private void timer_IPSync_Tick(object sender, EventArgs e)
        {
            if (!bgWorker_IPSync.IsBusy) bgWorker_IPSync.RunWorkerAsync();
            GC.Collect();
        }

        private void bgWorker_IPSync_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = ipAddress.GetIPv4() + "|" + ipAddress.GetIPv6();
        }

        private void bgWorker_IPSync_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool doSync = false;
            string[] ip = ((string)e.Result).Split('|');
            if (label_IPv4.Text == "0.0.0.0" && ip[0] != "0.0.0.0") doSync = true; 
            label_IPv4.Text = ip[0];
            label_IPv6.Text = ip[1];
            if (label_IPv4.Text == "0.0.0.0" && chk_autopppoe.Checked && !bgWorker_pppoe.IsBusy) bgWorker_pppoe.RunWorkerAsync();
            if (doSync) bgWorker_doSync.RunWorkerAsync();
        }

        private void bgWorker_pppoe_DoWork(object sender, DoWorkEventArgs e)
        {
            ppp.pppoeConnect(regKey.setting.pppoe);
            System.Threading.Thread.Sleep(10000);
        }

        private void bgWorker_pppoe_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ipAddress.GetIPv4() == "0.0.0.0") ppp.pppoeDisconnect();
            System.Threading.Thread.Sleep(2000);
        }

        private void bgWorker_doSync_DoWork(object sender, DoWorkEventArgs e)
        {
            json = api.readRecords(regKey.setting.key, regKey.setting.email, regKey.setting.zone);
            if (json == null || json.result != "success") e.Cancel = true;
            else
            {
                foreach (CloudflareJson.Obj rec in json.response.recs.objs)
                {
                    if (regKey.setting.sync.Contains(rec.rec_id) && rec.type == "A" || rec.type == "AAAA")
                    {
                        api.editRecord(regKey.setting.key, regKey.setting.email, regKey.setting.zone, rec.rec_id, rec.type, rec.name, rec.type == "A" ? label_IPv4.Text : label_IPv6.Text);
                    }
                }
            }
        }

        private void bgWorker_doSync_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (!e.Cancelled) System.Media.SystemSounds.Asterisk.Play();
        }

        private void timer_autoSync_Tick(object sender, EventArgs e)
        {
            if (countDown != 0) status_countDown.Text = "下次更新 " + (--countDown) + " 秒";
            else
            {
                countDown = COUNT_DOWN;
                bgWorker_doSync.RunWorkerAsync();
            }
        }

        private void MainUI_Shown(object sender, EventArgs e)
        {
            if (chk_startminimize.Checked) Hide();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!this.Visible)
                    this.Show();
                else
                    this.Hide();
            }
        }

        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && chk_exitminimize.Checked)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                notifyIcon.Visible = false;
            }
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
