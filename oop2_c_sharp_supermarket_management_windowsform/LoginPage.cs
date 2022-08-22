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
    public partial class LoginPage : Form
    {






        string path = $@"Data Source={EnvironmentProvider.server};Initial Catalog={EnvironmentProvider.database};User Id={EnvironmentProvider.userId};Password={EnvironmentProvider.Password};Integrated Security={EnvironmentProvider.security}";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        AdminPage parent;





        public LoginPage()
        {
            InitializeComponent();

            con = new SqlConnection(path);
           
        }










        // import user to edit 

        private void loginFunction()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                string sqlcommand = $@"
IF OBJECT_ID('Employees', 'U') IS NOT NULL 
BEGIN 
select * from Employees where Username = '{usernameTextBox.Text.Trim()}' 
END 
";

                adapter = new SqlDataAdapter(sqlcommand, con);
                adapter.Fill(dt);


                con.Close();


                if(dt.Rows.Count>0)
                {
                    if (dt.Rows[0].Field<string>("Password").Trim() == passwordTextBox.Text.Trim())
                    {
                        string role = dt.Rows[0].Field<string>("Role").Trim();
                        login(role);
                        storeuser(dt);


                    }
                    else
                    {
                        MessageBox.Show("User Matched but Password is wrong!", "Invalid Login");
                        passwordTextBox.Focus();
                        passwordError.Text="Password is wrong!";
                    }
                }
                else
                {
                    MessageBox.Show("User not found", "Invalid Login");
                    usernameTextBox.Focus();
                    usernameError.Text = "User not found";
                }

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Import Error");
            }

        }



       public void  storeuser(DataTable dt)
        {
            try
            {
                UserProvider.username = dt.Rows[0].Field<string>("Username").Trim();
                UserProvider.role = dt.Rows[0].Field<string>("Role").Trim();
                UserProvider.id = int.Parse(dt.Rows[0].Field<int>("Id").ToString().Trim());
                UserProvider.gender = dt.Rows[0].Field<string>("Gender").Trim();
                UserProvider.salary = Double.Parse(dt.Rows[0].Field<double>("Salary").ToString().Trim());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading user, please try again!");
            }
            
        }
        


        public void login(string mode)
        {

            HomePage homepage = new HomePage(mode);
            homepage.Show();
            this.Hide();
        }



 

        private void exitButton_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                loginFunction();
            }
        }













        private void username_Validating(object sender, CancelEventArgs e)
        {
            string error = "";

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {



                error = "Enter Username!";


            }

            else
            {
                if (usernameTextBox.Text == "" || usernameTextBox.Text == null || usernameTextBox.Text.Length == 0)
                {

                    error = "Enter Username!";
                }


            }




            if (error != "")
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, error);
                usernameError.Text = error;
                


            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(usernameTextBox, "");
                usernameError.Text = "";
            }


        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            string error = "";

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {



                error = "Enter Username!";


            }

            else
            {
                if (passwordTextBox.Text == "" || passwordTextBox.Text == null || passwordTextBox.Text.Length == 0)
                {

                    error = "Enter Username!";
                }


            }
            if (error != "")
            {
                e.Cancel = true;
                passwordTextBox.Focus();
                errorProvider1.SetError(passwordTextBox, error);
                passwordError.Text = error;


            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(passwordTextBox, "");
                passwordError.Text = "";
            }
            
     

        }

    }
}






















