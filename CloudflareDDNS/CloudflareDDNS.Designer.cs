namespace CloudflareDDNS
{
    partial class MainUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cf_list = new System.Windows.Forms.Button();
            this.btn_cf_setting = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_IPv6 = new System.Windows.Forms.Label();
            this.label_zone = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.label_IPv4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_facebook = new System.Windows.Forms.Button();
            this.chk_autoupdate = new System.Windows.Forms.CheckBox();
            this.chk_autopppoe = new System.Windows.Forms.CheckBox();
            this.chk_exitminimize = new System.Windows.Forms.CheckBox();
            this.chk_startminimize = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_pppoe_save = new System.Windows.Forms.Button();
            this.txt_pppoe_password = new System.Windows.Forms.TextBox();
            this.txt_pppoe_account = new System.Windows.Forms.TextBox();
            this.txt_pppoe_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer_IPSync = new System.Windows.Forms.Timer(this.components);
            this.bgWorker_IPSync = new System.ComponentModel.BackgroundWorker();
            this.bgWorker_doSync = new System.ComponentModel.BackgroundWorker();
            this.bgWorker_pppoe = new System.ComponentModel.BackgroundWorker();
            this.timer_autoSync = new System.Windows.Forms.Timer(this.components);
            this.status_countDown = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_countDown_icon = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Text = "CloudflareDDNS";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(122, 22);
            this.menu_exit.Text = "結束程式";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_countDown,
            this.status_countDown_icon});
            this.statusStrip.Location = new System.Drawing.Point(0, 297);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(664, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 282);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DDNS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cf_list);
            this.groupBox1.Controls.Add(this.btn_cf_setting);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_IPv6);
            this.groupBox1.Controls.Add(this.label_zone);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Controls.Add(this.label_key);
            this.groupBox1.Controls.Add(this.label_IPv4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(256, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cloudflare 資訊";
            // 
            // btn_cf_list
            // 
            this.btn_cf_list.BackgroundImage = global::CloudflareDDNS.Properties.Resources.list;
            this.btn_cf_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cf_list.FlatAppearance.BorderSize = 0;
            this.btn_cf_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cf_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cf_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cf_list.Location = new System.Drawing.Point(271, 19);
            this.btn_cf_list.Name = "btn_cf_list";
            this.btn_cf_list.Size = new System.Drawing.Size(30, 30);
            this.btn_cf_list.TabIndex = 11;
            this.btn_cf_list.Tag = "btn_list";
            this.btn_cf_list.UseVisualStyleBackColor = true;
            this.btn_cf_list.Click += new System.EventHandler(this.btn_Click);
            this.btn_cf_list.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_cf_list.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_cf_setting
            // 
            this.btn_cf_setting.BackgroundImage = global::CloudflareDDNS.Properties.Resources.setting;
            this.btn_cf_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cf_setting.FlatAppearance.BorderSize = 0;
            this.btn_cf_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cf_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cf_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cf_setting.Location = new System.Drawing.Point(313, 19);
            this.btn_cf_setting.Name = "btn_cf_setting";
            this.btn_cf_setting.Size = new System.Drawing.Size(30, 30);
            this.btn_cf_setting.TabIndex = 10;
            this.btn_cf_setting.Tag = "btn_setting";
            this.btn_cf_setting.UseVisualStyleBackColor = true;
            this.btn_cf_setting.Click += new System.EventHandler(this.btn_Click);
            this.btn_cf_setting.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_cf_setting.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zone:";
            // 
            // label_IPv6
            // 
            this.label_IPv6.AutoSize = true;
            this.label_IPv6.Location = new System.Drawing.Point(63, 70);
            this.label_IPv6.Name = "label_IPv6";
            this.label_IPv6.Size = new System.Drawing.Size(93, 17);
            this.label_IPv6.TabIndex = 8;
            this.label_IPv6.Text = "0:0:0:0:0:0:0:0";
            // 
            // label_zone
            // 
            this.label_zone.AutoSize = true;
            this.label_zone.Location = new System.Drawing.Point(63, 190);
            this.label_zone.Name = "label_zone";
            this.label_zone.Size = new System.Drawing.Size(0, 17);
            this.label_zone.TabIndex = 7;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(63, 150);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(0, 17);
            this.label_email.TabIndex = 6;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(63, 110);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(0, 17);
            this.label_key.TabIndex = 5;
            // 
            // label_IPv4
            // 
            this.label_IPv4.AutoSize = true;
            this.label_IPv4.Location = new System.Drawing.Point(63, 30);
            this.label_IPv4.Name = "label_IPv4";
            this.label_IPv4.Size = new System.Drawing.Size(49, 17);
            this.label_IPv4.TabIndex = 4;
            this.label_IPv4.Text = "0.0.0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IPv6:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPv4:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CloudflareDDNS.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(17, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_facebook);
            this.tabPage2.Controls.Add(this.chk_autoupdate);
            this.tabPage2.Controls.Add(this.chk_autopppoe);
            this.tabPage2.Controls.Add(this.chk_exitminimize);
            this.tabPage2.Controls.Add(this.chk_startminimize);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "設置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_facebook
            // 
            this.btn_facebook.BackgroundImage = global::CloudflareDDNS.Properties.Resources.fb;
            this.btn_facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_facebook.FlatAppearance.BorderSize = 0;
            this.btn_facebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_facebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facebook.Location = new System.Drawing.Point(533, 154);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.Size = new System.Drawing.Size(80, 80);
            this.btn_facebook.TabIndex = 5;
            this.btn_facebook.Tag = "btn_facebook";
            this.btn_facebook.UseVisualStyleBackColor = true;
            this.btn_facebook.Click += new System.EventHandler(this.btn_Click);
            this.btn_facebook.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_facebook.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // chk_autoupdate
            // 
            this.chk_autoupdate.AutoSize = true;
            this.chk_autoupdate.Location = new System.Drawing.Point(360, 175);
            this.chk_autoupdate.Name = "chk_autoupdate";
            this.chk_autoupdate.Size = new System.Drawing.Size(119, 21);
            this.chk_autoupdate.TabIndex = 4;
            this.chk_autoupdate.Tag = "chk_autoupdate";
            this.chk_autoupdate.Text = "自動更新 DDNS";
            this.chk_autoupdate.UseVisualStyleBackColor = true;
            this.chk_autoupdate.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_autopppoe
            // 
            this.chk_autopppoe.AutoSize = true;
            this.chk_autopppoe.Location = new System.Drawing.Point(360, 125);
            this.chk_autopppoe.Name = "chk_autopppoe";
            this.chk_autopppoe.Size = new System.Drawing.Size(121, 21);
            this.chk_autopppoe.TabIndex = 3;
            this.chk_autopppoe.Tag = "chk_autopppoe";
            this.chk_autopppoe.Text = "PPPoE 自動連線";
            this.chk_autopppoe.UseVisualStyleBackColor = true;
            this.chk_autopppoe.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_exitminimize
            // 
            this.chk_exitminimize.AutoSize = true;
            this.chk_exitminimize.Location = new System.Drawing.Point(360, 75);
            this.chk_exitminimize.Name = "chk_exitminimize";
            this.chk_exitminimize.Size = new System.Drawing.Size(118, 21);
            this.chk_exitminimize.TabIndex = 2;
            this.chk_exitminimize.Tag = "chk_exitminimize";
            this.chk_exitminimize.Text = "關閉程式最小化";
            this.chk_exitminimize.UseVisualStyleBackColor = true;
            this.chk_exitminimize.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_startminimize
            // 
            this.chk_startminimize.AutoSize = true;
            this.chk_startminimize.Location = new System.Drawing.Point(360, 25);
            this.chk_startminimize.Name = "chk_startminimize";
            this.chk_startminimize.Size = new System.Drawing.Size(105, 21);
            this.chk_startminimize.TabIndex = 1;
            this.chk_startminimize.Tag = "chk_startminimize";
            this.chk_startminimize.Text = "啟動時最小化";
            this.chk_startminimize.UseVisualStyleBackColor = true;
            this.chk_startminimize.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_pppoe_save);
            this.groupBox2.Controls.Add(this.txt_pppoe_password);
            this.groupBox2.Controls.Add(this.txt_pppoe_account);
            this.groupBox2.Controls.Add(this.txt_pppoe_name);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(18, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 221);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自動 PPPoE";
            // 
            // btn_pppoe_save
            // 
            this.btn_pppoe_save.Location = new System.Drawing.Point(210, 47);
            this.btn_pppoe_save.Name = "btn_pppoe_save";
            this.btn_pppoe_save.Size = new System.Drawing.Size(68, 28);
            this.btn_pppoe_save.TabIndex = 6;
            this.btn_pppoe_save.Tag = "btn_pppoe_save";
            this.btn_pppoe_save.Text = "儲存";
            this.btn_pppoe_save.UseVisualStyleBackColor = true;
            this.btn_pppoe_save.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_pppoe_password
            // 
            this.txt_pppoe_password.Location = new System.Drawing.Point(94, 158);
            this.txt_pppoe_password.Name = "txt_pppoe_password";
            this.txt_pppoe_password.Size = new System.Drawing.Size(184, 25);
            this.txt_pppoe_password.TabIndex = 5;
            // 
            // txt_pppoe_account
            // 
            this.txt_pppoe_account.Location = new System.Drawing.Point(94, 103);
            this.txt_pppoe_account.Name = "txt_pppoe_account";
            this.txt_pppoe_account.Size = new System.Drawing.Size(184, 25);
            this.txt_pppoe_account.TabIndex = 4;
            // 
            // txt_pppoe_name
            // 
            this.txt_pppoe_name.Location = new System.Drawing.Point(94, 48);
            this.txt_pppoe_name.Name = "txt_pppoe_name";
            this.txt_pppoe_name.Size = new System.Drawing.Size(94, 25);
            this.txt_pppoe_name.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "連線密碼:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "連線帳號:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "連線名稱:";
            // 
            // timer_IPSync
            // 
            this.timer_IPSync.Enabled = true;
            this.timer_IPSync.Interval = 3000;
            this.timer_IPSync.Tick += new System.EventHandler(this.timer_IPSync_Tick);
            // 
            // bgWorker_IPSync
            // 
            this.bgWorker_IPSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_IPSync_DoWork);
            this.bgWorker_IPSync.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_IPSync_RunWorkerCompleted);
            // 
            // bgWorker_doSync
            // 
            this.bgWorker_doSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_doSync_DoWork);
            this.bgWorker_doSync.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_doSync_RunWorkerCompleted);
            // 
            // bgWorker_pppoe
            // 
            this.bgWorker_pppoe.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_pppoe_DoWork);
            this.bgWorker_pppoe.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_pppoe_RunWorkerCompleted);
            // 
            // timer_autoSync
            // 
            this.timer_autoSync.Interval = 1000;
            this.timer_autoSync.Tick += new System.EventHandler(this.timer_autoSync_Tick);
            // 
            // status_countDown
            // 
            this.status_countDown.Name = "status_countDown";
            this.status_countDown.Size = new System.Drawing.Size(27, 17);
            this.status_countDown.Text = "null";
            this.status_countDown.Visible = false;
            // 
            // status_countDown_icon
            // 
            this.status_countDown_icon.Image = global::CloudflareDDNS.Properties.Resources.refresh;
            this.status_countDown_icon.Name = "status_countDown_icon";
            this.status_countDown_icon.Size = new System.Drawing.Size(16, 17);
            this.status_countDown_icon.Visible = false;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 319);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloudflareDDNS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.Shown += new System.EventHandler(this.MainUI_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_IPv4;
        private System.Windows.Forms.Label label_zone;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_IPv6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer_IPSync;
        private System.ComponentModel.BackgroundWorker bgWorker_IPSync;
        private System.Windows.Forms.Button btn_cf_setting;
        private System.Windows.Forms.Button btn_cf_list;
        private System.ComponentModel.BackgroundWorker bgWorker_doSync;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_pppoe_password;
        private System.Windows.Forms.TextBox txt_pppoe_account;
        private System.Windows.Forms.TextBox txt_pppoe_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_pppoe_save;
        private System.Windows.Forms.CheckBox chk_autoupdate;
        private System.Windows.Forms.CheckBox chk_autopppoe;
        private System.Windows.Forms.CheckBox chk_exitminimize;
        private System.Windows.Forms.CheckBox chk_startminimize;
        private System.Windows.Forms.Button btn_facebook;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.ComponentModel.BackgroundWorker bgWorker_pppoe;
        private System.Windows.Forms.Timer timer_autoSync;
        private System.Windows.Forms.ToolStripStatusLabel status_countDown;
        private System.Windows.Forms.ToolStripStatusLabel status_countDown_icon;
    }
}

