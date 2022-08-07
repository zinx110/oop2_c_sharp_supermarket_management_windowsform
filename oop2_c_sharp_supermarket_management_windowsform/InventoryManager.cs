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
        public InventoryManager()
        {
            InitializeComponent();
            loadMainPanel("all");
        }
        public InventoryManager(string page)
        {
            InitializeComponent();
            loadMainPanel(page);
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
    }
}
