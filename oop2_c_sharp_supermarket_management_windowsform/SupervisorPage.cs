using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class SupervisorPage : Form
    {
       

        public SupervisorPage(string page)
        {
            InitializeComponent();
            loadMainPanel(page);
        }
        public SupervisorPage()
        {
            InitializeComponent();
            loadMainPanel("all");
        }



        public void loadMainPanel(string page)
        {
            switch (page)
            {
                case "all":

                    loadMainForm(new AdminPageAllUserPanel());
                    break;

                case "salary":

                    loadMainForm(new AdminPageAllUserPanel());
                    break;
               

                default:
                    loadMainForm(new AdminPageAllUserPanel());
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




















    }
}
