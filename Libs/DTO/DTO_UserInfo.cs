using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AvatarURL { get; set; }
    }

}
