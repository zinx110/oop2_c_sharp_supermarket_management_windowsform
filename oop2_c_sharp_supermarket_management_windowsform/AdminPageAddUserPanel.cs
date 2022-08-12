using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class AdminPageAddUserPanel : Form
    {
        string role;
        string gender;
        string username;
        string password;
        string confirmPassword;
        string address;
        double salary;
        int phone;
        



        public AdminPageAddUserPanel()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            role = roleComboBox.SelectedItem.ToString();
           
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = genderComboBox.SelectedItem.ToString();
           
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {


            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                password = passwordTextBox.Text;
                MessageBox.Show(password, "Password!");
            }


















        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)

        {
            string passwordValid = FormValidateFunctions.IsValidPassword(passwordTextBox.Text);
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || passwordValid != "")
            {

                e.Cancel = true;
                passwordTextBox.Focus();
                errorProvider1.SetError(passwordTextBox, "Name should not be left blank!");
                if(passwordValid!="")
                {
                    passwordTextBoxError.Text = passwordValid;
                }
                else passwordTextBoxError.Text = "Name should not be left blank!";

            }
           
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(passwordTextBox, "");
            }
        }



    }
}
