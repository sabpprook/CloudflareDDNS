namespace CloudflareDDNS
{
    partial class fmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxAPIKey = new MetroFramework.Controls.MetroTextBox();
            this.textBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxZones = new System.Windows.Forms.ComboBox();
            this.buttonGetZones = new MetroFramework.Controls.MetroButton();
            this.dataGridView = new MetroFramework.Controls.MetroGrid();
            this.isRecordSync = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAPIKey
            // 
            // 
            // 
            // 
            this.textBoxAPIKey.CustomButton.Image = null;
            this.textBoxAPIKey.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.textBoxAPIKey.CustomButton.Name = "";
            this.textBoxAPIKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxAPIKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxAPIKey.CustomButton.TabIndex = 1;
            this.textBoxAPIKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxAPIKey.CustomButton.UseSelectable = true;
            this.textBoxAPIKey.CustomButton.Visible = false;
            this.textBoxAPIKey.Lines = new string[0];
            this.textBoxAPIKey.Location = new System.Drawing.Point(101, 85);
            this.textBoxAPIKey.MaxLength = 32767;
            this.textBoxAPIKey.Name = "textBoxAPIKey";
            this.textBoxAPIKey.PasswordChar = '\0';
            this.textBoxAPIKey.WaterMark = "Cloudflare API Key";
            this.textBoxAPIKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAPIKey.SelectedText = "";
            this.textBoxAPIKey.SelectionLength = 0;
            this.textBoxAPIKey.SelectionStart = 0;
            this.textBoxAPIKey.ShortcutsEnabled = true;
            this.textBoxAPIKey.Size = new System.Drawing.Size(350, 23);
            this.textBoxAPIKey.Style = MetroFramework.MetroColorStyle.Orange;
            this.textBoxAPIKey.TabIndex = 0;
            this.textBoxAPIKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAPIKey.UseSelectable = true;
            this.textBoxAPIKey.WaterMark = "Cloudflare API Key";
            this.textBoxAPIKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxAPIKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxEmail
            // 
            // 
            // 
            // 
            this.textBoxEmail.CustomButton.Image = null;
            this.textBoxEmail.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.textBoxEmail.CustomButton.Name = "";
            this.textBoxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxEmail.CustomButton.TabIndex = 1;
            this.textBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxEmail.CustomButton.UseSelectable = true;
            this.textBoxEmail.CustomButton.Visible = false;
            this.textBoxEmail.Lines = new string[0];
            this.textBoxEmail.Location = new System.Drawing.Point(101, 126);
            this.textBoxEmail.MaxLength = 32767;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.WaterMark = "Cloudflare Email";
            this.textBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.ShortcutsEnabled = true;
            this.textBoxEmail.Size = new System.Drawing.Size(350, 23);
            this.textBoxEmail.Style = MetroFramework.MetroColorStyle.Orange;
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.UseSelectable = true;
            this.textBoxEmail.WaterMark = "Cloudflare Email";
            this.textBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(32, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Key:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Email:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Zone:";
            // 
            // comboBoxZones
            // 
            this.comboBoxZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZones.FormattingEnabled = true;
            this.comboBoxZones.Location = new System.Drawing.Point(101, 168);
            this.comboBoxZones.Name = "comboBoxZones";
            this.comboBoxZones.Size = new System.Drawing.Size(220, 25);
            this.comboBoxZones.TabIndex = 0;
            this.comboBoxZones.TabStop = false;
            this.comboBoxZones.SelectedIndexChanged += new System.EventHandler(this.comboBoxZones_SelectedIndexChanged);
            // 
            // buttonGetZones
            // 
            this.buttonGetZones.Location = new System.Drawing.Point(351, 168);
            this.buttonGetZones.Name = "buttonGetZones";
            this.buttonGetZones.Size = new System.Drawing.Size(100, 25);
            this.buttonGetZones.Style = MetroFramework.MetroColorStyle.Orange;
            this.buttonGetZones.TabIndex = 2;
            this.buttonGetZones.TabStop = false;
            this.buttonGetZones.Text = "Get Zones";
            this.buttonGetZones.UseSelectable = true;
            this.buttonGetZones.UseStyleColors = true;
            this.buttonGetZones.Click += new System.EventHandler(this.buttonGetZones_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isRecordSync,
            this.RecordID,
            this.RecordType,
            this.RecordName,
            this.Object});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(28, 219);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(448, 230);
            this.dataGridView.StandardTab = true;
            this.dataGridView.Style = MetroFramework.MetroColorStyle.Orange;
            this.dataGridView.TabIndex = 6;
            this.dataGridView.TabStop = false;
            this.dataGridView.UseStyleColors = true;
            // 
            // isRecordSync
            // 
            this.isRecordSync.FalseValue = "0";
            this.isRecordSync.HeaderText = "Sync";
            this.isRecordSync.Name = "isRecordSync";
            this.isRecordSync.TrueValue = "1";
            this.isRecordSync.Width = 40;
            // 
            // RecordID
            // 
            this.RecordID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RecordID.HeaderText = "ID";
            this.RecordID.Name = "RecordID";
            this.RecordID.ReadOnly = true;
            // 
            // RecordType
            // 
            this.RecordType.HeaderText = "Type";
            this.RecordType.Name = "RecordType";
            this.RecordType.ReadOnly = true;
            this.RecordType.Width = 60;
            // 
            // RecordName
            // 
            this.RecordName.HeaderText = "Name";
            this.RecordName.Name = "RecordName";
            this.RecordName.ReadOnly = true;
            this.RecordName.Width = 180;
            // 
            // Object
            // 
            this.Object.HeaderText = "ResultObject";
            this.Object.Name = "Object";
            this.Object.Visible = false;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataSource = typeof(CloudflareDDNS.API.Result);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 483);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 36);
            this.buttonSave.Style = MetroFramework.MetroColorStyle.Orange;
            this.buttonSave.TabIndex = 7;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseSelectable = true;
            this.buttonSave.UseStyleColors = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonGetZones);
            this.Controls.Add(this.comboBoxZones);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAPIKey);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmLogin";
            this.Padding = new System.Windows.Forms.Padding(23, 85, 23, 28);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBoxAPIKey;
        private MetroFramework.Controls.MetroTextBox textBoxEmail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox comboBoxZones;
        private MetroFramework.Controls.MetroButton buttonGetZones;
        private MetroFramework.Controls.MetroGrid dataGridView;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private MetroFramework.Controls.MetroButton buttonSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRecordSync;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object;
    }
}