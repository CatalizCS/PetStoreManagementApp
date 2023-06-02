using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreManagementApp.DataAccess
{
    public class DataAccess
    {
        private string connectionString;
        DataAccess dataAccess = new DataAccess("Database/petstore.db");

        public DataAccess(string dbPath)
        {
            string absolutePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbPath);
            connectionString = $"Data Source={absolutePath}";
        }

        public void GetCustomers()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Mã để lấy dữ liệu khách hàng từ cơ sở dữ liệu
            }
        }

        public void InsertOrder()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Mã để thêm đơn hàng vào cơ sở dữ liệu
            }
        }

        // Các phương thức khác để thực hiện các hoạt động truy cập dữ liệu
    }
}
