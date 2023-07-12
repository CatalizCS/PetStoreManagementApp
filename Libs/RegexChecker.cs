using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreManagementApp.Libs
{
    public class RegexChecker
    {
        private static RegexChecker instance;

        public static RegexChecker Instance
        {
            get { if (instance == null) instance = new RegexChecker(); return RegexChecker.instance; }
            private set { RegexChecker.instance = value; }
        }

        private RegexChecker() { }

        public bool IsValidUsername(string username)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$");
        }

        public bool IsValidPassword(string password)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"^[a-zA-Z0-9_]+$");
        }
    }
}
