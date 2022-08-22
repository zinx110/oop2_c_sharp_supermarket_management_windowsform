using System;
using System.Collections.Generic;
using System.Text;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    class EnvironmentProvider
    {
        public static string server = $@"DESKTOP-1S3SUP7\SQLEXPRESS";
        public static string database = $@"MainDatabase";
        public static string userId = $@"one";
        public static string Password = $@"1234";
        public static bool security = false;


    }
}
