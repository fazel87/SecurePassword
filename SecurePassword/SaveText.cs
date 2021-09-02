using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePassword
{
    public partial class SaveText : Form
    {
        static string AccountName;
        static string AccountPassword;
        static int SecureNum;
        static int Maximum_SecureNum;

        public static void ImportVars(string Account_Name, string Account_Password, int Secure_Num, int Maximum_Secure_Num)
        {
            AccountName = Account_Name;
            AccountPassword = Account_Password;
            SecureNum = Secure_Num;
            Maximum_SecureNum = Maximum_Secure_Num;
            MessageBox.Show(Account_Name);
            MessageBox.Show(Account_Password);
            MessageBox.Show(Secure_Num.ToString());
            MessageBox.Show(Maximum_Secure_Num.ToString());
        }
        public SaveText()
        {
            InitializeComponent();
            Reset_Form();
        }

        private void Reset_Form(object sender = null, EventArgs e = null)
        {
            S_SecureNum.Enabled = S_Maximum.Checked;
            S_Account_Site.Enabled = S_Account.Checked;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            SAVE.Filter = "text file|*.txt";
            SAVE.Title = "Save Text";

            if(SAVE.ShowDialog() == DialogResult.OK)
            {
                IniFile ini = new IniFile();
                if(S_Account.Checked)
                    ini["Account"]["Account"] = S_Account_Site.Text;
                if (S_AccountName.Checked)
                    ini["Account"]["AccountName"] = AccountName;
                if (S_AccountPassword.Checked)
                    ini["Account"]["AccountPassword"] = AccountPassword;
                if (S_Maximum.Checked)
                {
                    ini["Account"]["AccountMaximumSecureNum"] = Maximum_SecureNum;
                    if (S_SecureNum.Checked)
                        ini["Account"]["AccountSecureNum"] = SecureNum;
                }
                ini.Save(SAVE.FileName);
            }
            this.Close();
        }
    }
}