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
    public partial class fmGUI : MetroFramework.Forms.MetroForm
    {
        public Setting setting { get; set; }
        public bool isConnect { get; set; }
        public bool isNeedUpdate { get; set; }

        public fmGUI()
        {
            InitializeComponent();
        }

        private void fmGUI_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
            notifyIcon.Icon = Properties.Resources.icon;

            setting = Setting.Load();
            toggleMinimize.Checked = setting.isStartMinimize;
            toggleAutoPPPoE.Checked = setting.isAutoPPPoE;
            toggleDebugOutput.Checked = setting.isDebugOutput;
        }

        private void fmGUI_Shown(object sender, EventArgs e)
        {
            if (setting.isStartMinimize)
            {
                this.Hide();
            }
        }

        private void fmGUI_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
            this.WindowState = FormWindowState.Normal;
        }

        private async void timerConnect_Tick(object sender, EventArgs e)
        {
            var _conn = await Task.Run(() => HttpUtils.isConnect());
            if (!_conn)
            {
                labelIPv4.Text = "0.0.0.0";
                labelIPv6.Text = "0::0";
            }
            else if (!isConnect)
            {
                isConnect = _conn;
                timerCheckIP_Tick(sender, e);
            }
            if (toggleAutoPPPoE.Checked)
            {
                await Task.Run(() => PPPoE.Dial(setting.PPPoE));
            }
            isConnect = _conn;
        }

        private async void timerCheckIP_Tick(object sender, EventArgs e)
        {
            if (!isConnect)
                return;
            await Task.Run(() => HttpUtils.GetExternalIP());
            if (labelIPv4.Text != HttpUtils.IPv4 || labelIPv6.Text != HttpUtils.IPv6)
            {
                labelIPv4.Text = HttpUtils.IPv4;
                labelIPv6.Text = HttpUtils.IPv6;
                isNeedUpdate = true;
            }
        }

        private async void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (isConnect && isNeedUpdate)
            {
                isNeedUpdate = false;
                await Task.Run(() => API.UpdateDNSRecord(setting.syncList.result, HttpUtils.IPv4, HttpUtils.IPv6));
            }
        }

        private void toggleMinimize_CheckedChanged(object sender, EventArgs e)
        {
            setting.isStartMinimize = toggleMinimize.Checked;
            Setting.Save(setting);
        }

        private void toggleAutoPPPoE_CheckedChanged(object sender, EventArgs e)
        {
            setting.isAutoPPPoE = toggleAutoPPPoE.Checked;
            Setting.Save(setting);
        }

        private void toggleDebugOutput_CheckedChanged(object sender, EventArgs e)
        {
            Logger.Enable = setting.isDebugOutput = toggleDebugOutput.Checked;
            Setting.Save(setting);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            using (var fm = new fmLogin())
            {
                fm.Owner = this;
                fm.ShowDialog();
                Setting.Save(setting);
                isNeedUpdate = true;
            }
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            using (var fm = new fmSyncList())
            {
                fm.Owner = this;
                fm.ShowDialog();
            }
        }

        private void buttonPPPSave_Click(object sender, EventArgs e)
        {
            setting.PPPoE.Name = textBoxPPPName.Text;
            setting.PPPoE.User = textBoxPPPUser.Text;
            setting.PPPoE.Password = textBoxPPPPassword.Text;
            Setting.Save(setting);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            setting = new Setting();
            Setting.Save(setting);
        }
    }
}
