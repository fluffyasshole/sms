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
