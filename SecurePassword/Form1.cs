using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fazel87.Security.AesLibrary;
using System.IO;

namespace SecurePassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reset_Form();
        }
        public void Reset_Form(object sender = null, EventArgs e = null)
        {
            Copy.Enabled = Generated_text.Text == "" ? false : true;
            SecureNum.Value = (int)SecureNumber.Value;
        }

        private void Maximum_SecureNum_ValueChanged(object sender, EventArgs e)
        {
            SecureNum.Maximum = (int)Maximum_SecureNum.Value;
            SecureNumber.Maximum = Maximum_SecureNum.Value;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Maximum_SecureNum.Value = 100;
            SecureNum.Maximum = 100;
            SecureNum.Value = 0;
            SecureNumber.Maximum = 100;
            SecureNumber.Value = 0;
            Generated_text.Text = "";
            account_name.Text = "";
            Reset_Form();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Generated_text.Text);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Generated_text.Text = account_name.Text.GenerateAsPassword(SecureNum.Value);
            Reset_Form();
        }

        private void SecureNum_Scroll(object sender, EventArgs e)
        {
            SecureNumber.Value = SecureNum.Value;
        }

        private void SecureNumber_ValueChanged(object sender, EventArgs e)
        {
            SecureNum.Value = (int)SecureNumber.Value;
        }

        private void Random_field_Click(object sender, EventArgs e)
        {
            account_name.Text = PasswordGenerate.RandomString(5);
            SecureNumber.Value = PasswordGenerate.Random(0, 5);
            Reset_Form();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
        }
        void LoadSecureBase(SecureBase secureBase)
        {
            Maximum_SecureNum.Value = secureBase.MaximumSecureNum;
            Reset_Form();
            SecureNumber.Value = secureBase.SecureNum;
            account_name.Text = secureBase.Name;
            Reset_Form();
        }
        SecureBase FormToSecureBase()
        {
            SecureBase secureBase = new SecureBase();

            secureBase.Name = account_name.Text;
            secureBase.SecureNum = (int)SecureNumber.Value;
            secureBase.MaximumSecureNum = (int)SecureNumber.Maximum;

            return secureBase;
        }
        IniFile FormToIni(bool with_maximum = true)
        {
            IniFile ini = new IniFile();

            ini["Account"]["Account"] = "Github";
            ini["Account"]["AcountName"] = account_name.Text;
            ini["Account"]["Password"] = Generated_text.Text;
            if (with_maximum)
            {
                ini["Account"]["Maximum"] = (int)Maximum_SecureNum.Value;
                ini["Account"]["SecureNum"] = (int)SecureNumber.Value;
            }
            return ini;
        }
        void IniToForm(IniFile ini)
        {
            account_name.Text = ini["Account"]["AccountName"].ToString();
            Generated_text.Text = ini["Account"]["Password"].ToString();
            Maximum_SecureNum.Value = ini["Account"]["AccountMaximumSecureNum"].ToInt();
            SecureNumber.Value = ini["Account"]["AccountSecureNum"].ToInt();

            Reset_Form();
        }

        private void Save_secure_Click(object sender, EventArgs e)
        {

            SAVE.Filter = "Secure File|*.secure";
            SAVE.Title = "Save Secure File";

            if (SAVE.ShowDialog() == DialogResult.OK)
            {
                FormToSecureBase().SaveSecure(SAVE.FileName);
            }
        }

        private void Open_secure_Click(object sender, EventArgs e)
        {
            OPEN.Filter = "Secure File|*.secure";
            OPEN.Title = "Open Secure File";

            if (OPEN.ShowDialog() == DialogResult.OK)
                LoadSecureBase(Secure.LoadSecure(OPEN.FileName));
        }

        private void Save_BSecure_Click(object sender, EventArgs e)
        {
            SAVE.Filter = "BSecure File|*.bsecure";
            SAVE.Title = "Save BSecure";

            if (SAVE.ShowDialog() == DialogResult.OK)
                FormToSecureBase().SaveBSecure(SAVE.FileName);
        }

        private void Open_BSecure_Click(object sender, EventArgs e)
        {
            OPEN.Filter = "BSecure File|*.bsecure";
            OPEN.Title = "Open BSecure";

            if (OPEN.ShowDialog() == DialogResult.OK)
                LoadSecureBase(Secure.LoadBSecure(OPEN.FileName));
        }

        private void Save_json_Click(object sender, EventArgs e)
        {
            SAVE.Filter = "javascript object notation|*.json";
            SAVE.Title = "Save Json";

            if (SAVE.ShowDialog() == DialogResult.OK)
                File.WriteAllText(SAVE.FileName,FormToSecureBase().ToJson());
        }

        private void Open_json_Click(object sender, EventArgs e)
        {
            OPEN.Filter = "javascript object notation (Json)|*.json";
            OPEN.Title = "Open Json";

            if (OPEN.ShowDialog() == DialogResult.OK)
                LoadSecureBase(File.ReadAllText(OPEN.FileName).ToSecureBase());
        }

        private void Save_text_Click(object sender, EventArgs e)
        {
            SaveText.ImportVars(account_name.Text,Generated_text.Text,(int)SecureNumber.Value,(int)Maximum_SecureNum.Value);
            new SaveText().ShowDialog();
        }

        private void Open_text_Click(object sender, EventArgs e)
        {
            OPEN.Filter = "Text File|*.txt";
            OPEN.Title = "Open Text File";

            if (OPEN.ShowDialog() == DialogResult.OK)
            {
                IniFile ini = new IniFile();
                ini.Load(OPEN.FileName);
                IniToForm(ini);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Seyyed Fazel Alavi\nSource: https://github.com/fazel87/SecurePassword\nLicense: MIT License", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
