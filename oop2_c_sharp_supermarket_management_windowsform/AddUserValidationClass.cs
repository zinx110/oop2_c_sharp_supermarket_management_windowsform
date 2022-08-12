using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    class AddUserValidationClass 
    {
        Form AddUserPanel;
        
        public AddUserValidationClass(Form form)
        {
            AddUserPanel = form;

            useValidation();
        }

        private void  useValidation()
        {


        }


        public void usernameValidate()
        {


        }





































































































        public static string IsValidPassword(string password)
        {

            if (password == "" || password == null || password.Length == 0)
            {
                return "Password is required";
            }
            if (password.Length < 8)
            {
                return "Password should be at least 8 characters";
            }
            if (!password.Any(char.IsUpper))
            {
                return "Password should have at least 1 upper case character";
            }
            if (!password.Any(char.IsDigit))
            {
                return "Password should have at least 1 number";
            }


            return "";

        }



        public static string IsValidUsername(string name, string nameType)
        {

            if (name == "" || name == null || name.Length == 0)
            {
                return nameType + " is required";
            }
            if (name.Length < 3)
            {
                return nameType + " cannot be so short";
            }
            if (name.Any(char.IsSymbol))
            {
                return nameType + " cannot have a symbol in it";
            }
            if (name.Any(char.IsDigit))
            {
                return nameType + " cannot contain number";
            }
            if (name.Any(char.IsPunctuation))
            {
                return nameType + " cannot have a symbol in it";
            }

            return "";

        }

        public static string IsValidSalary(string salary)
        {

            if (salary == "" || salary == null || salary.Length == 0)
            {
                return "Salary is required";
            }


            if (!salary.Any(char.IsDigit))
            {
                return "Invalid Salary. Salary must be a number";
            }

            try
            {

                double sal = Convert.ToDouble(salary);
                return "";

            }
            catch (FormatException)
            {
                return "Invalid Salary. Salary must be a number";
            }




        }

        public static string IsValidPhone(string phone)
        {

            if (phone == "" || phone == null || phone.Length == 0)
            {
                return "Phone number is required";
            }


            if (!phone.Any(char.IsDigit))
            {
                return "Invalid phone number. Phone number must be a number";
            }

            try
            {

                double sal = Convert.ToInt32(phone);
                return "";

            }
            catch (FormatException)
            {
                return "Invalid phone number. Phone number must be a number";
            }




        }
    }
}
