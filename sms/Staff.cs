using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class Staff : Sample2
    {
        public Staff()
        {
            InitializeComponent();
        }
        myDBDataContext obj = new myDBDataContext();
        int edit = 0;

        private void backBtn_Click(object sender, EventArgs e)
        {
            
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
            imagePathTxt.Enabled = false;
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
            imagePathTxt.Enabled = false;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (PasswordTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
            if (cpassTxt.Text == "") { cpassErrorLabel.Visible = true; } else { cpassErrorLabel.Visible = false; }
            //For Password Not Matching Confirm Password
            if (PasswordTxt.Text != cpassTxt.Text) { mismatchedErrorLabel.Visible = true; } else { mismatchedErrorLabel.Visible = false; }
            if (phoneTxt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
            if (roleCBTxt.SelectedIndex == -1) { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passErrorLabel.Visible || cpassErrorLabel.Visible || mismatchedErrorLabel.Visible || phone1ErrorLabel.Visible ||roleErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory.", "Stop", "Error");
            }
            else
            {
                //Code for SAVE Operation
                if (edit == 0)
                {
                    if (imagePathTxt.Text == "")
                    {
                        byte stat = statusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                        obj.st_insertStaffWithOutImage(nameTxt.Text, usernameTxt.Text, usernameTxt.Text, phoneTxt.Text, phone2Txt.Text,Convert.ToByte(roleCBTxt.SelectedValue.ToString()),stat);
                        MainClass.showMSG(nameTxt.Text + " added successfully to the system", "Success", "Success");
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        i.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        byte stat = statusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                        obj.st_insertStaff(nameTxt.Text, usernameTxt.Text, usernameTxt.Text, phoneTxt.Text, phone2Txt.Text, Convert.ToInt32(roleCBTxt.SelectedValue.ToString()), stat, arr);
                        MainClass.showMSG(nameTxt.Text + " added successfully to the system", "Success", "Success");
                    }
                }
                //Code for UPDATE Operation
                else if (edit == 1)
                {

                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
        }

        private void cpassTxt_TextChanged(object sender, EventArgs e)
        {
            if (cpassTxt.Text == "") { cpassErrorLabel.Visible = true; } else { cpassErrorLabel.Visible = false; }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
        }

        private void roleCBTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleCBTxt.SelectedIndex == -1) { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
        }

        private void statusCBTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
        }

        private void cpassTxt_Validating(object sender, CancelEventArgs e)
        {
            if (PasswordTxt.Text != cpassTxt.Text) { mismatchedErrorLabel.Visible = true; } else { mismatchedErrorLabel.Visible = false; }
        }
        Image i;
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Image i = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = i;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                imagePathTxt.Text = openFileDialog1.FileName;
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
    }
}
