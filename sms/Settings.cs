using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (isCB.Checked)
            {
                if(datasourceTxt.Text == "") { datasourceErrorLabel.Visible = true; } else { datasourceErrorLabel.Visible = false; }
                if(dbTxt.Text == "") { dbErrorLabel.Visible = true; } else { dbErrorLabel.Visible = false; }
                if(dbErrorLabel.Visible || datasourceErrorLabel.Visible)
                {
                    MessageBox.Show("Field with * are mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + datasourceTxt.Text + ";Initial Catlog" + dbTxt.Text + ";Integerated Security = true; MultipleActiveResultSets=true" );
                    File.WriteAllText(MainClass.path + "\\cnt", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved sucessfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this,MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (datasourceTxt.Text == "") { datasourceErrorLabel.Visible = true; } else { datasourceErrorLabel.Visible = false; }
                if (dbTxt.Text == "") { dbErrorLabel.Visible = true; } else { dbErrorLabel.Visible = false; }
                if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
                if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
                if (dbErrorLabel.Visible || datasourceErrorLabel.Visible || usernameErrorLabel.Visible || passErrorLabel.Visible)
                {
                    MessageBox.Show("Field with * are mandatory");
                }
            
            else
            {
                    sb.Append("Data Source=" + datasourceTxt.Text + ";Initial Catlog" + dbTxt.Text + "; User ID=" + usernameTxt.Text + "; Password=" + passTxt.Text + ";MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\cnt", sb.ToString());
                    File.WriteAllText(MainClass.path + "\\cnt", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void datasourceTxt_TextChanged(object sender, EventArgs e)
        {
            if (datasourceTxt.Text == "") { datasourceErrorLabel.Visible = true; } else { datasourceErrorLabel.Visible = false; }
        }

        private void dbTxt_TextChanged(object sender, EventArgs e)
        {
            if (dbTxt.Text == "") { dbErrorLabel.Visible = true; } else { dbErrorLabel.Visible = false; }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                usernameTxt.Text = "";
                usernameTxt.Enabled = false;
                usernameErrorLabel.Visible = false;

                passTxt.Text = "";
                passTxt.Enabled = false;
                passErrorLabel.Visible = false;
            }
            else
            {
                usernameTxt.Enabled = true;
                passTxt.Enabled = true;
            }
        }
    }
}
