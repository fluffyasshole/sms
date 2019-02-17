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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();

            MainClass.showWindow(hs, this, MDI.ActiveForm);
        }
    }
}
