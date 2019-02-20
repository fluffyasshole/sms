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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }
        private void staffBtn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            Classes st = new Classes();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void sectionBtn_Click(object sender, EventArgs e)
        {
            Sections st = new Sections();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {

        }

        private void voucherBtn_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void housesBtn_Click(object sender, EventArgs e)
        {

        }

        private void timetableBtn_Click(object sender, EventArgs e)
        {

        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {

        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {

        }

        private void resultsBtn_Click(object sender, EventArgs e)
        {

        }

        private void subjectBtn_Click(object sender, EventArgs e)
        {
            Subjects st = new Subjects();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            Roles st = new Roles();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void classTimeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
