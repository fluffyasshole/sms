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
    public partial class Subjects : Sample2
    {
        public Subjects()
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
            if (subjectTxt.Text == "") { subjectErrorLabel.Visible = true; } else { subjectErrorLabel.Visible = false; }
            if (subjectErrorLabel.Visible)
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

        private void subjectTxt_TextChanged(object sender, EventArgs e)
        {
            if (subjectTxt.Text == "") { subjectErrorLabel.Visible = true; } else { subjectErrorLabel.Visible = false; }
        }
    }
}
