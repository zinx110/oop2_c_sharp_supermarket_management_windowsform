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
        string firstname;
        string lastname;
        string password;
        string confirmPassword;
        string address;
        double salary;
        int phone;
        



        public AdminPageAddUserPanel()
        {
            InitializeComponent();
        }



 

        private void addUserButton_Click(object sender, EventArgs e)
        {

            assignVariables();
            MessageBox.Show("done");







        }

        private void assignVariables()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {


                username = usernameTextBox.Text;
                firstname = firstnameTextBox.Text;
                lastname = lastnameTextBox.Text;
                password = passwordTextBox.Text;
                address = addressTextBox.Text;
                role = roleComboBox.Text;
                gender = genderComboBox.Text;


                try
                {

                    salary = Convert.ToDouble(salaryTextBox.Text);
                }
                catch (FormatException)
                {
                    salaryTextBox.Focus();
                    usernameErrorProvider.SetError(salaryTextBox, "Invalid salary!");
                    salaryTextBoxError.Text = "Invalid salary!";
                }
                try
                {

                    salary = Convert.ToInt32(salaryTextBox.Text);
                }
                catch (FormatException)
                {
                    salaryTextBox.Focus();
                    usernameErrorProvider.SetError(salaryTextBox, "Invalid salary!");
                    salaryTextBoxError.Text = "Invalid salary!";
                }



            }
        }


        private void usernameTextBox_Validating(object sender, CancelEventArgs e)

        {
            string usernameInValid = AddUserValidationClass.IsValidUsername(usernameTextBox.Text, "Username");

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || usernameInValid != "")
            {

                e.Cancel = true;
                usernameTextBox.Focus();
                usernameErrorProvider.SetError(usernameTextBox, "username is required!");
                if (usernameInValid != "")
                {
                    usernameTextBoxError.Text = usernameInValid;
                }
                else usernameTextBoxError.Text = "username is required!";

            }

            else
            {
                e.Cancel = false;
                usernameErrorProvider.SetError(usernameTextBox, "");
                usernameTextBoxError.Text = "";
            }
        }

        private void firstnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string usernameInValid = AddUserValidationClass.IsValidUsername(firstnameTextBox.Text, "First name");

            if (string.IsNullOrWhiteSpace(firstnameTextBox.Text) || usernameInValid != "")
            {

                e.Cancel = true;
                firstnameTextBox.Focus();
                usernameErrorProvider.SetError(firstnameTextBox, "First name is required!");

                if (usernameInValid != "")
                {
                    firstnameTextBoxError.Text = usernameInValid;
                }
                else firstnameTextBoxError.Text = "First name is required!";

            }

            else
            {
                e.Cancel = false;
                usernameErrorProvider.SetError(firstnameTextBox, "");
                firstnameTextBoxError.Text = "";

            }
        }

        private void lastnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string usernameInValid = AddUserValidationClass.IsValidUsername(lastnameTextBox.Text, "First name");

            if (string.IsNullOrWhiteSpace(lastnameTextBox.Text) || usernameInValid != "")
            {

                e.Cancel = true;
                lastnameTextBox.Focus();
                usernameErrorProvider.SetError(lastnameTextBox, "First name is required!");

                if (usernameInValid != "")
                {
                    lastnameTextBoxError.Text = usernameInValid;
                }
                else lastnameTextBoxError.Text = "First name is required!";

            }

            else
            {
                e.Cancel = false;
                usernameErrorProvider.SetError(lastnameTextBox, "");
                lastnameTextBoxError.Text = "";

            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)

        {
            string passwordInValid = AddUserValidationClass.IsValidPassword(passwordTextBox.Text);

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || passwordInValid != "")
            {

                e.Cancel = true;
                passwordTextBox.Focus();
                usernameErrorProvider.SetError(passwordTextBox, "Password is required!");
                if(passwordInValid != "")
                {
                    passwordTextBoxError.Text = passwordInValid;
                }
                else passwordTextBoxError.Text = "Password is required!";

            }
           
            else
            {
                e.Cancel = false;
                usernameErrorProvider.SetError(passwordTextBox, "");
                passwordTextBoxError.Text = "";
            }
        }

        private void confirmPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {

                e.Cancel = true;
                confirmPasswordTextBox.Focus();
                usernameErrorProvider.SetError(confirmPasswordTextBox, "Confirm the password");
                confirmPasswordTextBoxError.Text = "Confirm the password!";


            }
            else if (passwordTextBox.Text !=confirmPasswordTextBox.Text)
            {
                e.Cancel = true;
                confirmPasswordTextBox.Focus();
                usernameErrorProvider.SetError(confirmPasswordTextBox, "Password did not match");
                confirmPasswordTextBoxError.Text = "Password did not match";
            }

            else
            {


                e.Cancel = false;
                usernameErrorProvider.SetError(confirmPasswordTextBox, "");
                confirmPasswordTextBoxError.Text = "";
            }

        }

        private void roleComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roleComboBox.Text))
            {
                e.Cancel = true;
                roleComboBox.Focus();
                usernameErrorProvider.SetError(roleComboBox, "Select a role");
                roleComboBoxError.Text = "Select a role";
            }

            else
            {


                e.Cancel = false;
                usernameErrorProvider.SetError(roleComboBox, "");
                roleComboBoxError.Text = "";
            }

        }

        private void genderComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(genderComboBox.Text))
            {
                e.Cancel = true;
                genderComboBox.Focus();
                usernameErrorProvider.SetError(genderComboBox, "Select a gender");
                genderComboBoxError.Text = "Select a gender";
            }

            else
            {


                e.Cancel = false;
                usernameErrorProvider.SetError(genderComboBox, "");
                genderComboBoxError.Text = "";
            }

        }

        private void salaryTextBox_Validating(object sender, CancelEventArgs e)
        {
            string salaryInvalid = AddUserValidationClass.IsValidSalary(salaryTextBox.Text);

            if (string.IsNullOrWhiteSpace(salaryTextBox.Text) || salaryInvalid != "")
            {

                e.Cancel = true;
                salaryTextBox.Focus();
                usernameErrorProvider.SetError(salaryTextBox, "Salary is required!");

                if (salaryInvalid != "")
                {
                    salaryTextBoxError.Text = salaryInvalid;
                }
                else salaryTextBoxError.Text = "Salary is required!";

            }

            else
            {
                try
                {

                    double sal = Convert.ToDouble(salaryTextBox.Text);
                    e.Cancel = false;
                    usernameErrorProvider.SetError(salaryTextBox, "");
                    salaryTextBoxError.Text = "";


                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    salaryTextBox.Focus();
                    usernameErrorProvider.SetError(salaryTextBox, "Invalid salary!");
                    salaryTextBoxError.Text = "Invalid salary!";

                }


            }
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            string phoneInvalid = AddUserValidationClass.IsValidPhone(phoneTextBox.Text);

            if (string.IsNullOrWhiteSpace(phoneTextBox.Text) || phoneInvalid != "")
            {

                e.Cancel = true;
                phoneTextBox.Focus();
                usernameErrorProvider.SetError(phoneTextBox, "Salary is required!");

                if (phoneInvalid != "")
                {
                    phoneTextBoxError.Text = phoneInvalid;
                }
                else phoneTextBoxError.Text = "Salary is required!";

            }

            else
            {
                try
                {

                    double phn = Convert.ToInt32(phoneTextBox.Text);
                    e.Cancel = false;
                    usernameErrorProvider.SetError(phoneTextBox, "");
                    phoneTextBoxError.Text = "";


                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    phoneTextBox.Focus();
                    usernameErrorProvider.SetError(phoneTextBox, "Invalid phone number!");
                    phoneTextBoxError.Text = "Invalid phone number!";

                }


            }

        }

        private void addressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                e.Cancel = true;
                addressTextBox.Focus();
                usernameErrorProvider.SetError(addressTextBox, "Address is required");
                addressTextBoxError.Text = "Address is required";
            }

            else
            {


                e.Cancel = false;
                usernameErrorProvider.SetError(addressTextBox, "");
                addressTextBoxError.Text = "";
            }
        }
    }
}
