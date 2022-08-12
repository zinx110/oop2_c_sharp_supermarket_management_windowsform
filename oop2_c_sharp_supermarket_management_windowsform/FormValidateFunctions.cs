using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    class FormValidateFunctions
    {

        public static string IsValidPassword(string password)
        {

            if (password =="" || password == null || password.Length == 0)
            {
                return "Password is required";
            }
            if (password.Length<8)
            {
                return "Password should be at least 8 characters";
            }
            if (!password.Any(char.IsUpper) )
            {
                return "Password should have at least 1 upper case character";
            }
            if (!password.Any(char.IsSymbol))
            {
                return "Password should have at least 1 upper case character";
            }
            


            else
            {
                return "";
            }
        }



    }
}
