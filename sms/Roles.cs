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
        myDBDataContext obj = new myDBDataContext();
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
            MainClass.enable(panel6);
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
                    //obj.roles.InsertOnSubmit(r);
                    obj.st_insertRoles(roleTxt.Text, r.r_status);
                    obj.SubmitChanges();
                    MainClass.showMSG(roleTxt.Text + " added successfully,", "Success", "Success");
                    MainClass.disable_reset(panel6);
                    loadData(); 
                }
                else if (edit == 1)  //Code for UPDATE operation
                {
                    byte stat;
                    if (roleDropDown.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else
                    {
                        stat  = 0;
                    }
                    obj.st_updateRoles(roleTxt.Text, stat, roleID);
                   /* var data = obj.roles.Single(x => x.r_id == roleID);
                    data.r_name = roleTxt.Text;
                    if (roleDropDown.SelectedIndex == 0)
                    {
                        data.r_status = 1;
                    }
                    else
                    {
                        data.r_status = 0;
                    }
                    obj.SubmitChanges(); */
                    MainClass.showMSG(roleTxt.Text + " updated successfully,", "Success", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + roleTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.st_deleteRoles(roleID);
                    MainClass.showMSG(roleTxt.Text + " deleted successfully,", "Success", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }
        private void loadData()
        {
            var abc = obj.st_getRoles();
            rolesIDGV.DataPropertyName = "ID";
            roleGV.DataPropertyName = "Role";
            statusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
        }

        private void searchData()
        {
            //Code for serial number is yet remaining
            var abc = obj.st_searcHRoles(searchTxt.Text);
            rolesIDGV.DataPropertyName = "ID";
            roleGV.DataPropertyName = "Role";
            statusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
        }
        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            
        }
        int roleID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["rolesIDGV"].Value.ToString()); 
                roleTxt.Text = row.Cells["roleGV"].Value.ToString();
                roleDropDown.SelectedItem = row.Cells["statusGV"].Value.ToString();

            }
        }
    }

}
