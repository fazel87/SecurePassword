
namespace SecurePassword
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.account_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SecureNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Maximum_SecureNum = new System.Windows.Forms.NumericUpDown();
            this.SecureNum = new System.Windows.Forms.TrackBar();
            this.Generate = new System.Windows.Forms.Button();
            this.Generated_text = new System.Windows.Forms.TextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Random_field = new System.Windows.Forms.Button();
            this.OPEN = new System.Windows.Forms.OpenFileDialog();
            this.SAVE = new System.Windows.Forms.SaveFileDialog();
            this.File_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSecureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bSecureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecureNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximum_SecureNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecureNum)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.24299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generate Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.account_name);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account name / Your name";
            // 
            // account_name
            // 
            this.account_name.BackColor = System.Drawing.Color.DimGray;
            this.account_name.ForeColor = System.Drawing.Color.White;
            this.account_name.Location = new System.Drawing.Point(6, 31);
            this.account_name.Name = "account_name";
            this.account_name.Size = new System.Drawing.Size(763, 32);
            this.account_name.TabIndex = 0;
            this.account_name.TextChanged += new System.EventHandler(this.Reset_Form);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.SecureNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Maximum_SecureNum);
            this.groupBox2.Controls.Add(this.SecureNum);
            this.groupBox2.Font = new System.Drawing.Font("MV Boli", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Secure Number";
            // 
            // SecureNumber
            // 
            this.SecureNumber.BackColor = System.Drawing.Color.DimGray;
            this.SecureNumber.ForeColor = System.Drawing.Color.White;
            this.SecureNumber.Location = new System.Drawing.Point(649, 67);
            this.SecureNumber.Name = "SecureNumber";
            this.SecureNumber.Size = new System.Drawing.Size(120, 32);
            this.SecureNumber.TabIndex = 3;
            this.SecureNumber.ValueChanged += new System.EventHandler(this.SecureNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum:";
            // 
            // Maximum_SecureNum
            // 
            this.Maximum_SecureNum.BackColor = System.Drawing.Color.DimGray;
            this.Maximum_SecureNum.ForeColor = System.Drawing.Color.White;
            this.Maximum_SecureNum.Location = new System.Drawing.Point(120, 29);
            this.Maximum_SecureNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Maximum_SecureNum.Name = "Maximum_SecureNum";
            this.Maximum_SecureNum.Size = new System.Drawing.Size(649, 32);
            this.Maximum_SecureNum.TabIndex = 1;
            this.Maximum_SecureNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Maximum_SecureNum.ValueChanged += new System.EventHandler(this.Maximum_SecureNum_ValueChanged);
            // 
            // SecureNum
            // 
            this.SecureNum.Location = new System.Drawing.Point(6, 67);
            this.SecureNum.Maximum = 100;
            this.SecureNum.Name = "SecureNum";
            this.SecureNum.Size = new System.Drawing.Size(637, 50);
            this.SecureNum.TabIndex = 0;
            this.SecureNum.Scroll += new System.EventHandler(this.SecureNum_Scroll);
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.Gray;
            this.Generate.Font = new System.Drawing.Font("MV Boli", 14.13084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(12, 324);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(352, 114);
            this.Generate.TabIndex = 6;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Generated_text
            // 
            this.Generated_text.BackColor = System.Drawing.Color.DimGray;
            this.Generated_text.Font = new System.Drawing.Font("MV Boli", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generated_text.ForeColor = System.Drawing.Color.White;
            this.Generated_text.Location = new System.Drawing.Point(371, 325);
            this.Generated_text.Name = "Generated_text";
            this.Generated_text.ReadOnly = true;
            this.Generated_text.Size = new System.Drawing.Size(417, 32);
            this.Generated_text.TabIndex = 7;
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.Gray;
            this.Copy.Font = new System.Drawing.Font("MV Boli", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.ForeColor = System.Drawing.Color.White;
            this.Copy.Location = new System.Drawing.Point(371, 363);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(95, 74);
            this.Copy.TabIndex = 8;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Gray;
            this.Clear.Font = new System.Drawing.Font("MV Boli", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(693, 364);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(95, 74);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Random_field
            // 
            this.Random_field.BackColor = System.Drawing.Color.Gray;
            this.Random_field.Font = new System.Drawing.Font("MV Boli", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Random_field.ForeColor = System.Drawing.Color.White;
            this.Random_field.Location = new System.Drawing.Point(472, 364);
            this.Random_field.Name = "Random_field";
            this.Random_field.Size = new System.Drawing.Size(215, 74);
            this.Random_field.TabIndex = 10;
            this.Random_field.Text = "Random";
            this.Random_field.UseVisualStyleBackColor = false;
            this.Random_field.Click += new System.EventHandler(this.Random_field_Click);
            // 
            // File_ToolStrip
            // 
            this.File_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.File_ToolStrip.ForeColor = System.Drawing.Color.Black;
            this.File_ToolStrip.Name = "File_ToolStrip";
            this.File_ToolStrip.Size = new System.Drawing.Size(39, 21);
            this.File_ToolStrip.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secureToolStripMenuItem,
            this.bSecureToolStripMenuItem,
            this.jsonToolStripMenuItem,
            this.textToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // secureToolStripMenuItem
            // 
            this.secureToolStripMenuItem.Name = "secureToolStripMenuItem";
            this.secureToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.secureToolStripMenuItem.Text = "Secure";
            this.secureToolStripMenuItem.Click += new System.EventHandler(this.Open_secure_Click);
            // 
            // bSecureToolStripMenuItem
            // 
            this.bSecureToolStripMenuItem.Name = "bSecureToolStripMenuItem";
            this.bSecureToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.bSecureToolStripMenuItem.Text = "BSecure";
            this.bSecureToolStripMenuItem.Click += new System.EventHandler(this.Open_BSecure_Click);
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.jsonToolStripMenuItem.Text = "Json";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.Open_json_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.Open_text_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secureToolStripMenuItem1,
            this.bSecureToolStripMenuItem1,
            this.jsonToolStripMenuItem1,
            this.textToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // secureToolStripMenuItem1
            // 
            this.secureToolStripMenuItem1.Name = "secureToolStripMenuItem1";
            this.secureToolStripMenuItem1.Size = new System.Drawing.Size(201, 24);
            this.secureToolStripMenuItem1.Text = "Secure";
            this.secureToolStripMenuItem1.Click += new System.EventHandler(this.Save_secure_Click);
            // 
            // bSecureToolStripMenuItem1
            // 
            this.bSecureToolStripMenuItem1.Name = "bSecureToolStripMenuItem1";
            this.bSecureToolStripMenuItem1.Size = new System.Drawing.Size(201, 24);
            this.bSecureToolStripMenuItem1.Text = "BSecure";
            this.bSecureToolStripMenuItem1.Click += new System.EventHandler(this.Save_BSecure_Click);
            // 
            // jsonToolStripMenuItem1
            // 
            this.jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            this.jsonToolStripMenuItem1.Size = new System.Drawing.Size(201, 24);
            this.jsonToolStripMenuItem1.Text = "Json";
            this.jsonToolStripMenuItem1.Click += new System.EventHandler(this.Save_json_Click);
            // 
            // textToolStripMenuItem1
            // 
            this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            this.textToolStripMenuItem1.Size = new System.Drawing.Size(201, 24);
            this.textToolStripMenuItem1.Text = "Text";
            this.textToolStripMenuItem1.Click += new System.EventHandler(this.Save_text_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.Help.ForeColor = System.Drawing.Color.Black;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(47, 21);
            this.Help.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStrip,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Random_field);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Generated_text);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MV Boli", 6.728972F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SecurePassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecureNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximum_SecureNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecureNum)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox account_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Maximum_SecureNum;
        private System.Windows.Forms.TrackBar SecureNum;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Generated_text;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Random_field;
        private System.Windows.Forms.NumericUpDown SecureNumber;
        private System.Windows.Forms.OpenFileDialog OPEN;
        private System.Windows.Forms.SaveFileDialog SAVE;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSecureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bSecureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

