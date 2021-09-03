
namespace SecurePassword
{
    partial class SaveText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveText));
            this.S_AccountName = new System.Windows.Forms.CheckBox();
            this.S_Account = new System.Windows.Forms.CheckBox();
            this.S_Maximum = new System.Windows.Forms.CheckBox();
            this.S_SecureNum = new System.Windows.Forms.CheckBox();
            this.S_Account_Site = new System.Windows.Forms.ComboBox();
            this.S_AccountPassword = new System.Windows.Forms.CheckBox();
            this.SAVE = new System.Windows.Forms.SaveFileDialog();
            this.Save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // S_AccountName
            // 
            this.S_AccountName.AutoSize = true;
            this.S_AccountName.Checked = true;
            this.S_AccountName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.S_AccountName.Font = new System.Drawing.Font("MV Boli", 10F);
            this.S_AccountName.Location = new System.Drawing.Point(13, 13);
            this.S_AccountName.Name = "S_AccountName";
            this.S_AccountName.Size = new System.Drawing.Size(165, 24);
            this.S_AccountName.TabIndex = 0;
            this.S_AccountName.Text = "Save Account Name";
            this.S_AccountName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.S_AccountName.UseVisualStyleBackColor = true;
            // 
            // S_Account
            // 
            this.S_Account.AutoSize = true;
            this.S_Account.Checked = true;
            this.S_Account.CheckState = System.Windows.Forms.CheckState.Checked;
            this.S_Account.Font = new System.Drawing.Font("MV Boli", 10F);
            this.S_Account.Location = new System.Drawing.Point(13, 73);
            this.S_Account.Name = "S_Account";
            this.S_Account.Size = new System.Drawing.Size(119, 24);
            this.S_Account.TabIndex = 1;
            this.S_Account.Text = "Save Account";
            this.S_Account.UseVisualStyleBackColor = true;
            this.S_Account.CheckedChanged += new System.EventHandler(this.Reset_Form);
            // 
            // S_Maximum
            // 
            this.S_Maximum.AutoSize = true;
            this.S_Maximum.Font = new System.Drawing.Font("MV Boli", 10F);
            this.S_Maximum.Location = new System.Drawing.Point(14, 103);
            this.S_Maximum.Name = "S_Maximum";
            this.S_Maximum.Size = new System.Drawing.Size(242, 24);
            this.S_Maximum.TabIndex = 2;
            this.S_Maximum.Text = "Save Maximum Secure Number";
            this.S_Maximum.UseVisualStyleBackColor = true;
            this.S_Maximum.CheckedChanged += new System.EventHandler(this.Reset_Form);
            // 
            // S_SecureNum
            // 
            this.S_SecureNum.AutoSize = true;
            this.S_SecureNum.Font = new System.Drawing.Font("MV Boli", 10F);
            this.S_SecureNum.Location = new System.Drawing.Point(13, 133);
            this.S_SecureNum.Name = "S_SecureNum";
            this.S_SecureNum.Size = new System.Drawing.Size(169, 24);
            this.S_SecureNum.TabIndex = 3;
            this.S_SecureNum.Text = "Save Secure Number";
            this.S_SecureNum.UseVisualStyleBackColor = true;
            // 
            // S_Account_Site
            // 
            this.S_Account_Site.BackColor = System.Drawing.Color.DimGray;
            this.S_Account_Site.Font = new System.Drawing.Font("MV Boli", 10F);
            this.S_Account_Site.ForeColor = System.Drawing.Color.White;
            this.S_Account_Site.FormattingEnabled = true;
            this.S_Account_Site.Items.AddRange(new object[] {
            "Github",
            "Stackowerflow",
            "Codeproject",
            "Microsoft",
            "Outlook",
            "Gmail",
            "Yahoo!",
            "Godot",
            "Unity",
            "MSN",
            "HotMail"});
            this.S_Account_Site.Location = new System.Drawing.Point(139, 73);
            this.S_Account_Site.Name = "S_Account_Site";
            this.S_Account_Site.Size = new System.Drawing.Size(130, 28);
            this.S_Account_Site.TabIndex = 4;
            this.S_Account_Site.Text = "Github";
            // 
            // S_AccountPassword
            // 
            this.S_AccountPassword.AutoSize = true;
            this.S_AccountPassword.Checked = true;
            this.S_AccountPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.S_AccountPassword.Font = new System.Drawing.Font("MV Boli", 10F);
            this.S_AccountPassword.Location = new System.Drawing.Point(12, 43);
            this.S_AccountPassword.Name = "S_AccountPassword";
            this.S_AccountPassword.Size = new System.Drawing.Size(188, 24);
            this.S_AccountPassword.TabIndex = 5;
            this.S_AccountPassword.Text = "Save Account Password";
            this.S_AccountPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.S_AccountPassword.UseVisualStyleBackColor = true;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.Gray;
            this.Save_btn.Font = new System.Drawing.Font("MV Boli", 12F);
            this.Save_btn.Location = new System.Drawing.Point(14, 163);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(255, 45);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // SaveText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(279, 220);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.S_AccountPassword);
            this.Controls.Add(this.S_Account_Site);
            this.Controls.Add(this.S_SecureNum);
            this.Controls.Add(this.S_Maximum);
            this.Controls.Add(this.S_Account);
            this.Controls.Add(this.S_AccountName);
            this.Font = new System.Drawing.Font("MV Boli", 6.728972F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaveText";
            this.Text = "Save Text File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox S_AccountName;
        private System.Windows.Forms.CheckBox S_Account;
        private System.Windows.Forms.CheckBox S_Maximum;
        private System.Windows.Forms.CheckBox S_SecureNum;
        private System.Windows.Forms.ComboBox S_Account_Site;
        private System.Windows.Forms.CheckBox S_AccountPassword;
        private System.Windows.Forms.SaveFileDialog SAVE;
        private System.Windows.Forms.Button Save_btn;
    }
}