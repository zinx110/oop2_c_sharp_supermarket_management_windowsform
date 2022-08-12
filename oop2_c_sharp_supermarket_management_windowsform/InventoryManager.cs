using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class InventoryManager : Form
    {
        public Form sidenav;


        public InventoryManager()
        {
            InitializeComponent();
            loadMainPanel("all");
        }














        public void loadMainPanel(string page)
        {
            switch (page)
            {
                case "all":

                    loadMainForm(new InventoryManagerAllProduct());
                    break;

                case "edit":

                    loadMainForm(new InventoryManagerEditProduct());
                    break;
                case "add":

                    loadMainForm(new InventoryManagerAddProduct());
                    break;
                case "message":

                    loadMainForm(new MessagingPage());
                    break;

                default:
                    loadMainForm(new InventoryManagerAllProduct());
                    break;



            }
        }

        public void loadMainForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            { this.mainPanel.Controls.RemoveAt(0); }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }






        private void label1_Click(object sender, EventArgs e)
        {


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






        private void allUserButton_Click_1(object sender, EventArgs e)
        {
            this.loadMainPanel("all");
        }

        private void editUserButton_Click_1(object sender, EventArgs e)
        {
            this.loadMainPanel("edit");
        }

        private void addUserButton_Click_1(object sender, EventArgs e)
        {
            this.loadMainPanel("add");
        }

        private void MessagesButton_Click(object sender, EventArgs e)
        {
            this.loadMainPanel("message");
        }

    }
}
