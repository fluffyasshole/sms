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
    public partial class Sections : Sample2
    {
        public Sections()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (secnameTxt.Text == "") { secnameErrorLabel.Visible = true; } else { secnameErrorLabel.Visible = false; }
        }

        private void secstatusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secstatusDD.SelectedIndex == -1) { secstatusErrorLabel.Visible = true; } else { secstatusErrorLabel.Visible = false; }
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

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
    }
}
