using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class Sidenav : Form
    {
   
       
        public HomePage home;

        public Sidenav()
        {
            InitializeComponent();
        }

        public Sidenav(HomePage home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void allUserButton_Click(object sender, EventArgs e)
        {

            home.loadMainForm(new AdminPage("all"));
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            home.loadMainForm(new AdminPage("edit"));

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {


            home.loadMainForm(new AdminPage("add"));



        }
    }
}
