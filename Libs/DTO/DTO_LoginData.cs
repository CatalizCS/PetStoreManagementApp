namespace PetStoreManagementApp.Libs.DTO
{
    // instance variables mapping to columns of table
    public enum Permission { admin, employee, customer };
    public class DTO_LoginData
    {
        private static DTO_LoginData instance;

        public static DTO_LoginData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DTO_LoginData();
                }
                return instance;
            }
        }

        public string username { get; set; }
        public string password { get; set; }
        public Permission permission { get; set; }

        public void logout()
        {
            username = null;
            password = null;
            permission = Permission.customer;
        }
    }

}
