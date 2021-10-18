namespace CloudflareDDNS
{
    partial class fmGUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.toggleDebugOutput = new MetroFramework.Controls.MetroToggle();
            this.toggleAutoPPPoE = new MetroFramework.Controls.MetroToggle();
            this.toggleMinimize = new MetroFramework.Controls.MetroToggle();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.labelIPv6 = new MetroFramework.Controls.MetroLabel();
            this.labelIPv4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.buttonReset = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPPPSave = new MetroFramework.Controls.MetroButton();
            this.textBoxPPPPassword = new MetroFramework.Controls.MetroTextBox();
            this.textBoxPPPUser = new MetroFramework.Controls.MetroTextBox();
            this.textBoxPPPName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.timerConnect = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerCheckIP = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "CloudflareDDNS";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 85);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(604, 267);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.toggleDebugOutput);
            this.metroTabPage1.Controls.Add(this.toggleAutoPPPoE);
            this.metroTabPage1.Controls.Add(this.toggleMinimize);
            this.metroTabPage1.Controls.Add(this.buttonSetting);
            this.metroTabPage1.Controls.Add(this.buttonRecord);
            this.metroTabPage1.Controls.Add(this.labelIPv6);
            this.metroTabPage1.Controls.Add(this.labelIPv4);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.pictureBox);
            this.metroTabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(596, 225);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Information";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 4;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(335, 183);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Debug output";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(335, 146);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "PPPoE Re-connect";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(335, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Startup minimize";
            // 
            // toggleDebugOutput
            // 
            this.toggleDebugOutput.AutoSize = true;
            this.toggleDebugOutput.DisplayStatus = false;
            this.toggleDebugOutput.Location = new System.Drawing.Point(279, 182);
            this.toggleDebugOutput.Name = "toggleDebugOutput";
            this.toggleDebugOutput.Size = new System.Drawing.Size(50, 21);
            this.toggleDebugOutput.Style = MetroFramework.MetroColorStyle.Orange;
            this.toggleDebugOutput.TabIndex = 12;
            this.toggleDebugOutput.TabStop = false;
            this.toggleDebugOutput.Text = "Off";
            this.toggleDebugOutput.UseSelectable = true;
            this.toggleDebugOutput.UseStyleColors = true;
            this.toggleDebugOutput.CheckedChanged += new System.EventHandler(this.toggleDebugOutput_CheckedChanged);
            // 
            // toggleAutoPPPoE
            // 
            this.toggleAutoPPPoE.AutoSize = true;
            this.toggleAutoPPPoE.DisplayStatus = false;
            this.toggleAutoPPPoE.Location = new System.Drawing.Point(279, 145);
            this.toggleAutoPPPoE.Name = "toggleAutoPPPoE";
            this.toggleAutoPPPoE.Size = new System.Drawing.Size(50, 21);
            this.toggleAutoPPPoE.Style = MetroFramework.MetroColorStyle.Orange;
            this.toggleAutoPPPoE.TabIndex = 11;
            this.toggleAutoPPPoE.TabStop = false;
            this.toggleAutoPPPoE.Text = "Off";
            this.toggleAutoPPPoE.UseSelectable = true;
            this.toggleAutoPPPoE.UseStyleColors = true;
            this.toggleAutoPPPoE.CheckedChanged += new System.EventHandler(this.toggleAutoPPPoE_CheckedChanged);
            // 
            // toggleMinimize
            // 
            this.toggleMinimize.AutoSize = true;
            this.toggleMinimize.DisplayStatus = false;
            this.toggleMinimize.Location = new System.Drawing.Point(279, 108);
            this.toggleMinimize.Name = "toggleMinimize";
            this.toggleMinimize.Size = new System.Drawing.Size(50, 21);
            this.toggleMinimize.Style = MetroFramework.MetroColorStyle.Orange;
            this.toggleMinimize.TabIndex = 10;
            this.toggleMinimize.TabStop = false;
            this.toggleMinimize.Text = "Off";
            this.toggleMinimize.UseSelectable = true;
            this.toggleMinimize.UseStyleColors = true;
            this.toggleMinimize.CheckedChanged += new System.EventHandler(this.toggleMinimize_CheckedChanged);
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.Transparent;
            this.buttonSetting.BackgroundImage = global::CloudflareDDNS.Properties.Resources.setup;
            this.buttonSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Location = new System.Drawing.Point(553, 173);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(40, 40);
            this.buttonSetting.TabIndex = 9;
            this.buttonSetting.TabStop = false;
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackColor = System.Drawing.Color.Transparent;
            this.buttonRecord.BackgroundImage = global::CloudflareDDNS.Properties.Resources.list;
            this.buttonRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecord.FlatAppearance.BorderSize = 0;
            this.buttonRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecord.Location = new System.Drawing.Point(507, 173);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(40, 40);
            this.buttonRecord.TabIndex = 8;
            this.buttonRecord.TabStop = false;
            this.buttonRecord.UseVisualStyleBackColor = false;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // labelIPv6
            // 
            this.labelIPv6.AutoSize = true;
            this.labelIPv6.Location = new System.Drawing.Point(321, 57);
            this.labelIPv6.Name = "labelIPv6";
            this.labelIPv6.Size = new System.Drawing.Size(29, 19);
            this.labelIPv6.TabIndex = 7;
            this.labelIPv6.Text = "0::0";
            // 
            // labelIPv4
            // 
            this.labelIPv4.AutoSize = true;
            this.labelIPv4.Location = new System.Drawing.Point(321, 28);
            this.labelIPv4.Name = "labelIPv4";
            this.labelIPv4.Size = new System.Drawing.Size(46, 19);
            this.labelIPv4.TabIndex = 6;
            this.labelIPv4.Text = "0.0.0.0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(279, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "IPv6:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(279, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "IPv4:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = global::CloudflareDDNS.Properties.Resources.logo;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(3, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 200);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.buttonReset);
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(596, 225);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Misc";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 4;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(348, 18);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(200, 30);
            this.buttonReset.Style = MetroFramework.MetroColorStyle.Orange;
            this.buttonReset.TabIndex = 24;
            this.buttonReset.TabStop = false;
            this.buttonReset.Text = "Reset Config";
            this.buttonReset.UseSelectable = true;
            this.buttonReset.UseStyleColors = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonPPPSave);
            this.groupBox1.Controls.Add(this.textBoxPPPPassword);
            this.groupBox1.Controls.Add(this.textBoxPPPUser);
            this.groupBox1.Controls.Add(this.textBoxPPPName);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 204);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PPPoE Setting";
            // 
            // buttonPPPSave
            // 
            this.buttonPPPSave.Location = new System.Drawing.Point(75, 160);
            this.buttonPPPSave.Name = "buttonPPPSave";
            this.buttonPPPSave.Size = new System.Drawing.Size(150, 30);
            this.buttonPPPSave.Style = MetroFramework.MetroColorStyle.Orange;
            this.buttonPPPSave.TabIndex = 23;
            this.buttonPPPSave.TabStop = false;
            this.buttonPPPSave.Text = "Save";
            this.buttonPPPSave.UseSelectable = true;
            this.buttonPPPSave.UseStyleColors = true;
            this.buttonPPPSave.Click += new System.EventHandler(this.buttonPPPSave_Click);
            // 
            // textBoxPPPPassword
            // 
            // 
            // 
            // 
            this.textBoxPPPPassword.CustomButton.Image = null;
            this.textBoxPPPPassword.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.textBoxPPPPassword.CustomButton.Name = "";
            this.textBoxPPPPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPPPPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPPPPassword.CustomButton.TabIndex = 1;
            this.textBoxPPPPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPPPPassword.CustomButton.UseSelectable = true;
            this.textBoxPPPPassword.CustomButton.Visible = false;
            this.textBoxPPPPassword.Lines = new string[0];
            this.textBoxPPPPassword.Location = new System.Drawing.Point(83, 119);
            this.textBoxPPPPassword.MaxLength = 32767;
            this.textBoxPPPPassword.Name = "textBoxPPPPassword";
            this.textBoxPPPPassword.PasswordChar = '\0';
            this.textBoxPPPPassword.PromptText = "PPPoE password";
            this.textBoxPPPPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPPPPassword.SelectedText = "";
            this.textBoxPPPPassword.SelectionLength = 0;
            this.textBoxPPPPassword.SelectionStart = 0;
            this.textBoxPPPPassword.ShortcutsEnabled = true;
            this.textBoxPPPPassword.Size = new System.Drawing.Size(205, 23);
            this.textBoxPPPPassword.Style = MetroFramework.MetroColorStyle.Orange;
            this.textBoxPPPPassword.TabIndex = 22;
            this.textBoxPPPPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPPPPassword.UseSelectable = true;
            this.textBoxPPPPassword.WaterMark = "PPPoE password";
            this.textBoxPPPPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPPPPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxPPPUser
            // 
            // 
            // 
            // 
            this.textBoxPPPUser.CustomButton.Image = null;
            this.textBoxPPPUser.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.textBoxPPPUser.CustomButton.Name = "";
            this.textBoxPPPUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPPPUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPPPUser.CustomButton.TabIndex = 1;
            this.textBoxPPPUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPPPUser.CustomButton.UseSelectable = true;
            this.textBoxPPPUser.CustomButton.Visible = false;
            this.textBoxPPPUser.Lines = new string[0];
            this.textBoxPPPUser.Location = new System.Drawing.Point(83, 80);
            this.textBoxPPPUser.MaxLength = 32767;
            this.textBoxPPPUser.Name = "textBoxPPPUser";
            this.textBoxPPPUser.PasswordChar = '\0';
            this.textBoxPPPUser.PromptText = "PPPoE username";
            this.textBoxPPPUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPPPUser.SelectedText = "";
            this.textBoxPPPUser.SelectionLength = 0;
            this.textBoxPPPUser.SelectionStart = 0;
            this.textBoxPPPUser.ShortcutsEnabled = true;
            this.textBoxPPPUser.Size = new System.Drawing.Size(205, 23);
            this.textBoxPPPUser.Style = MetroFramework.MetroColorStyle.Orange;
            this.textBoxPPPUser.TabIndex = 21;
            this.textBoxPPPUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPPPUser.UseSelectable = true;
            this.textBoxPPPUser.WaterMark = "PPPoE username";
            this.textBoxPPPUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPPPUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxPPPName
            // 
            // 
            // 
            // 
            this.textBoxPPPName.CustomButton.Image = null;
            this.textBoxPPPName.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.textBoxPPPName.CustomButton.Name = "";
            this.textBoxPPPName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPPPName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPPPName.CustomButton.TabIndex = 1;
            this.textBoxPPPName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPPPName.CustomButton.UseSelectable = true;
            this.textBoxPPPName.CustomButton.Visible = false;
            this.textBoxPPPName.Lines = new string[0];
            this.textBoxPPPName.Location = new System.Drawing.Point(83, 41);
            this.textBoxPPPName.MaxLength = 32767;
            this.textBoxPPPName.Name = "textBoxPPPName";
            this.textBoxPPPName.PasswordChar = '\0';
            this.textBoxPPPName.PromptText = "PPPoE entry name";
            this.textBoxPPPName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPPPName.SelectedText = "";
            this.textBoxPPPName.SelectionLength = 0;
            this.textBoxPPPName.SelectionStart = 0;
            this.textBoxPPPName.ShortcutsEnabled = true;
            this.textBoxPPPName.Size = new System.Drawing.Size(205, 23);
            this.textBoxPPPName.Style = MetroFramework.MetroColorStyle.Orange;
            this.textBoxPPPName.TabIndex = 20;
            this.textBoxPPPName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPPPName.UseSelectable = true;
            this.textBoxPPPName.WaterMark = "PPPoE entry name";
            this.textBoxPPPName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPPPName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 119);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(66, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Password:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 80);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Username:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 41);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Name:";
            // 
            // timerConnect
            // 
            this.timerConnect.Enabled = true;
            this.timerConnect.Interval = 5000;
            this.timerConnect.Tick += new System.EventHandler(this.timerConnect_Tick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 300000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // timerCheckIP
            // 
            this.timerCheckIP.Enabled = true;
            this.timerCheckIP.Interval = 30000;
            this.timerCheckIP.Tick += new System.EventHandler(this.timerCheckIP_Tick);
            // 
            // fmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "fmGUI";
            this.Padding = new System.Windows.Forms.Padding(23, 85, 23, 28);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Cloudflare DDNS";
            this.Load += new System.EventHandler(this.fmGUI_Load);
            this.Shown += new System.EventHandler(this.fmGUI_Shown);
            this.Resize += new System.EventHandler(this.fmGUI_Resize);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Timer timerConnect;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel labelIPv6;
        private MetroFramework.Controls.MetroLabel labelIPv4;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonSetting;
        private MetroFramework.Controls.MetroToggle toggleMinimize;
        private MetroFramework.Controls.MetroToggle toggleDebugOutput;
        private MetroFramework.Controls.MetroToggle toggleAutoPPPoE;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox textBoxPPPPassword;
        private MetroFramework.Controls.MetroTextBox textBoxPPPUser;
        private MetroFramework.Controls.MetroTextBox textBoxPPPName;
        private MetroFramework.Controls.MetroButton buttonPPPSave;
        private MetroFramework.Controls.MetroButton buttonReset;
        private System.Windows.Forms.Timer timerCheckIP;
    }
}

