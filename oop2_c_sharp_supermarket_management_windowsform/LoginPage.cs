using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        public void loginFunction(string mode)
        {
            HomePage homepage = new HomePage(mode);
            homepage.Show();
            this.Hide();
        }



        private void WelcomeTextPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginFunction("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginFunction("admin");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginFunction("inventorymanager");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginFunction("supervisor");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loginFunction("checkout");
        }
    }
}
