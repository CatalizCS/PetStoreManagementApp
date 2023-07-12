using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
