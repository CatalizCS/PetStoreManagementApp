namespace PetStoreManagementApp.Libs.DTO
{
    // DTO for Nhanvien table with instance variables mapping to columns of table
    public class DTO_UserInfo
    {
        private static DTO_UserInfo instance;
        public static DTO_UserInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DTO_UserInfo();
                }
                return instance;
            }
        }

        public string ID { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string AvatarURL { get; set; }

        public void logout()
        {
            ID = null;
            FirstName = null;
            LastName = null;
            Age = 0;
            PhoneNumber = null;
            Email = null;
            AvatarURL = null;
        }
    }

}
