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

        public bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^[0-9]+$");
        }

        public bool IsValidAge(string age)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(age, @"^[0-9]+$");
        }

        public bool IsValidPrice(string price)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(price, @"^[0-9]+$");
        }

        public bool IsValidQuantity(string quantity)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(quantity, @"^[0-9]+$");
        }
    }
}
