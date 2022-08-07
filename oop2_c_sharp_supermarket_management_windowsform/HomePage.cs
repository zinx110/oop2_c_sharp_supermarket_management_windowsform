using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class HomePage : Form
    {

        
        

        public Form sidenav ;
        public Form mainpage;

        public HomePage(string mode)
        {
            InitializeComponent();

          
            loadMainPanel(mode);
            loadNavbar(new Sidenav(this));
           


        }




        private void label1_Click(object sender, EventArgs e)
        {


        }
        public void loadMainPanel(string mode)
        {
            switch (mode)
            {
                case "admin":
                    pageRoleName.Text = "Admin";
                    loadMainForm(new AdminPage("all"));
                    break;

                case "supervisor":
                    pageRoleName.Text = "Supervisor";
                    loadMainForm(new SupervisorPage("all"));
                    break;
                case "inventorymanager":
                    pageRoleName.Text = "Inventory";
                    loadMainForm(new InventoryManager("all"));
                    break;
                case "checkout":
                    pageRoleName.Text = "Checkout";
                    loadMainForm(new CheckoutPage("all"));
                    break;
                default:
                    MessageBox.Show("Invalid User Role", "Error");
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                    this.Hide();
                    break;



            }
        }



        public void loadMainForm(object Form)
        {
            if (this.mainPanel.Controls.Count>0)
            { this.mainPanel.Controls.RemoveAt(0); }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;

            f.Show();

        }



        public void loadNavbar(object Form)
        {
            if (this.SidenavContainer.Controls.Count > 0)
            { this.SidenavContainer.Controls.RemoveAt(0); }

           sidenav = Form as Form;
            sidenav.TopLevel = false;
            sidenav.Dock = DockStyle.Fill;
            this.SidenavContainer.Controls.Add(sidenav);
            this.SidenavContainer.Tag = sidenav;
            
            sidenav.Show();

        }


        







        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
