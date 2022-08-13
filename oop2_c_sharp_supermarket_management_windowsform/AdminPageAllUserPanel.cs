using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;


namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class AdminPageAllUserPanel : Form
    {

        AdminPage parent;

        string path = @"Data Source=DESKTOP-1S3SUP7\SQLEXPRESS;Initial Catalog=MainDatabase;User Id=one;Password=1234;Integrated Security=False";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;



        string queryString = "";
        int operationEmployeeId;

        public AdminPageAllUserPanel()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            loadAll();
        }

        public AdminPageAllUserPanel(AdminPage parent)
        {
            InitializeComponent();
            this.parent = parent;
            con = new SqlConnection(path);
            loadAll();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(queryTextBox.Text=="")
            {
                loadAll();
            }
            else
            {
                loadQuery();
            }
        }



        private void showAllButton_Click(object sender, EventArgs e)
        {
            loadAll();

        }


        private void loadAll()
        {
            clearQueries();
            try
            {

                dt = new DataTable();
                con.Open();
                adapter = new SqlDataAdapter("select * from Employees", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                con.Close();

                

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Import Error");
            }

        }

        private void clearQueries()
        {
            queryTextBox.Text = "";
            queryString = "";
        }

        private void loadQuery()
        {
            try
            {
                queryString = queryTextBox.Text;
                int id = 0;

                if(queryString.All(c=>char.IsDigit(c)))
                {
                    id = Convert.ToInt32(queryString);
                }

                dt = new DataTable();
                con.Open();


                adapter = new SqlDataAdapter($"select* from Employees where Id = {id} OR CONVERT(varchar(20),Salary) LIKE '%{queryString}%' OR  Salary = {id} OR Username LIKE '%{queryString}%' OR Lastname LIKE '%{queryString}%' OR Firstname LIKE '%{queryString}%' OR Role = '{queryString}' OR Gender = '{queryString}' OR Phone LIKE '{queryString}%' OR Address LIKE '%{queryString}%'", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Import Error");
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                operationEmployeeId = Convert.ToInt32(row.Cells["Id"].Value);

                parent.loadEditPageWithData(operationEmployeeId);




            }
        }
    }
}
