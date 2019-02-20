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
    public partial class ClassTimings : Sample2
    {
        public ClassTimings()
        {
            InitializeComponent();
        }
        int edit = 0;
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (timeNameTxt.Text == "") { timeErrorLabel.Visible = true; } else { timeErrorLabel.Visible = false; }
            if (fromTxt.Text == "") { fromErrorLabel.Visible = true; } else { fromErrorLabel.Visible = false; }
            if (toTxt.Text == "") { toErrorLabel.Visible = true; } else { toErrorLabel.Visible = false; }
            if (dayDD.SelectedIndex == -1) { dayErrorLabel.Visible = true; } else { dayErrorLabel.Visible = false; }
            if (timeErrorLabel.Visible || fromErrorLabel.Visible || toErrorLabel.Visible || dayErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are manadatory", "Stop", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    //Code for SAVE
                }
                else
                {
                    //Code for save
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

        private void timeNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (timeNameTxt.Text == "") { timeErrorLabel.Visible = true; } else { timeErrorLabel.Visible = false; }
        }

        private void fromTxt_TextChanged(object sender, EventArgs e)
        {
            if (fromTxt.Text == "") { fromErrorLabel.Visible = true; } else { fromErrorLabel.Visible = false; }
        }

        private void toTxt_TextChanged(object sender, EventArgs e)
        {
            if (toTxt.Text == "") { toErrorLabel.Visible = true; } else { toErrorLabel.Visible = false; }
        }
    }
}
