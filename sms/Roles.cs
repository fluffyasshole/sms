using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class Roles : Sample2
    {
        public Roles()
        {
            InitializeComponent();
        }
        int edit = 0;
        private void roleTxt_TextChanged(object sender, EventArgs e)
        {
            if (roleTxt.Text == "") { roleErrorLabel.Visible = true;  } else { roleErrorLabel.Visible = false; }
        }

        private void roleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleDropDown.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false;  }
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel6);
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (roleTxt.Text == "") { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
            if (roleDropDown.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (roleErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are madatory", "Stop", "Error");
            }
            else
            {
                if (edit == 0) //Code for SAVE OPERATION
                {
                    myDBDataContext obj = new myDBDataContext();
                    role r = new role();
                    r.r_name = roleTxt.Text;
                    if (roleDropDown.SelectedIndex == 0)
                    {
                        r.r_status = 1;
                    }
                    else
                    {
                        r.r_status = 0;
                    }
                    obj.roles.InsertOnSubmit(r);
                    obj.SubmitChanges();
                }
                else if (edit == 1)  //Code for UPDATE operation
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

        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
    }

}
