namespace CloudflareDDNS
{
    partial class CloudflareSetting
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
            this.label_api = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_zone = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_zone = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_api
            // 
            this.label_api.AutoSize = true;
            this.label_api.Location = new System.Drawing.Point(22, 31);
            this.label_api.Name = "label_api";
            this.label_api.Size = new System.Drawing.Size(57, 17);
            this.label_api.TabIndex = 0;
            this.label_api.Text = "API Key:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(22, 91);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(43, 17);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email:";
            // 
            // label_zone
            // 
            this.label_zone.AutoSize = true;
            this.label_zone.Location = new System.Drawing.Point(22, 151);
            this.label_zone.Name = "label_zone";
            this.label_zone.Size = new System.Drawing.Size(42, 17);
            this.label_zone.TabIndex = 2;
            this.label_zone.Text = "Zone:";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(93, 27);
            this.txt_key.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(337, 25);
            this.txt_key.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(93, 86);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(337, 25);
            this.txt_email.TabIndex = 4;
            // 
            // txt_zone
            // 
            this.txt_zone.Location = new System.Drawing.Point(93, 148);
            this.txt_zone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_zone.Name = "txt_zone";
            this.txt_zone.Size = new System.Drawing.Size(337, 25);
            this.txt_zone.TabIndex = 5;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(103, 203);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(106, 33);
            this.btn_apply.TabIndex = 6;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(255, 203);
            this.btn_cancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(106, 33);
            this.btn_cancle.TabIndex = 7;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // CloudflareSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.txt_zone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.label_zone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_api);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CloudflareSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cloudflare Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_api;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_zone;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_zone;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cancle;
    }
}