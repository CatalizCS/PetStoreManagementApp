using PetStoreManagementApp.Libs.DTO;
using System.Data;
using System.Data.SQLite;

namespace PetStoreManagementApp.Libs
{
    public class DatabaseConnection
    {
        private string connectionString;
        private static DatabaseConnection instance;
        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }

        private DatabaseConnection()
        {
            ConfigReader configReader = new ConfigReader("config.cfg");
            if (!configReader.validateConfig())
            {
                throw new Exception("Config file is not valid");
            }
            configReader.ReadConfig();

            if (configReader.GetConfigValue("database.local") == "true")
            {
                PathManagement databasePath = new PathManagement(configReader.GetConfigValue("database.location"));
                connectionString = String.Format("Data Source={0};Version=3", databasePath.fullPath);
            }
            else
            {
                string server = configReader.GetConfigValue("database.server");
                string database = configReader.GetConfigValue("database.database");
                string username = configReader.GetConfigValue("database.username");
                string password = configReader.GetConfigValue("database.password");

                connectionString = String.Format("Server={0};Database={1};User Id={2};Password={3};", server, database, username, password);
            }
        }

        public bool IsConnected()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                return command.ExecuteNonQuery();
            }
        }

        public bool Execute(string query)
        {
            Console.WriteLine(query);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ReadToDataTable(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                return dataTable;
            }
        }

        public bool CheckExist(string query)
        {
            Console.WriteLine(query);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable.Rows.Count > 0;
            }
        }

        public void test()
        {
            Console.WriteLine(connectionString);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table'", connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine(row["name"]);
                }
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Depot", connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Console.WriteLine(dataTable.Rows);

                foreach (DataColumn row in dataTable.Columns)
                {
                    Console.WriteLine(row.ColumnName);
                }
            }

        }

        // USER PART
        public void GetUserInfo(string ID, Permission userType)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command;
                connection.Open();
                switch (userType)
                {
                    case Permission.employee:
                    case Permission.admin:
                        command = new SQLiteCommand("SELECT * FROM Employee_InfoData WHERE ID = @ID", connection);
                        break;

                    default:
                        throw new Exception("Invalid user type");
                }

                command.Parameters.AddWithValue("@ID", ID);
                DataTable dataTable = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine(row["ID"] + " - " + row["FirstName"] + " - " + row["LastName"] + " - " + row["Gender"] + " - " + row["Age"] + " - " + row["PhoneNumber"] + " - " + row["Email"] + " - " + row["Notes"] + " - " + row["AvatarURL"]);
                }

                if (dataTable.Rows.Count > 0)
                {
                    DTO_UserInfo.Instance.ID = dataTable.Rows[0]["ID"].ToString();
                    DTO_UserInfo.Instance.Gender = dataTable.Rows[0]["Gender"].ToString();
                    DTO_UserInfo.Instance.FirstName = dataTable.Rows[0]["FirstName"].ToString();
                    DTO_UserInfo.Instance.LastName = dataTable.Rows[0]["LastName"].ToString();
                    DTO_UserInfo.Instance.Age = int.Parse(dataTable.Rows[0]["Age"].ToString());
                    DTO_UserInfo.Instance.PhoneNumber = dataTable.Rows[0]["PhoneNumber"].ToString();
                    DTO_UserInfo.Instance.Email = dataTable.Rows[0]["Email"].ToString();
                    DTO_UserInfo.Instance.Notes = dataTable.Rows[0]["Notes"].ToString();
                    DTO_UserInfo.Instance.AvatarURL = dataTable.Rows[0]["AvatarURL"].ToString();

                    return;
                }
                else throw new Exception("User not found");
            }
        }

        // LOGIN PART
        public string CheckLogin(string username, string password)
        {

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM LoginData WHERE Username = @username AND Password = @password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Console.WriteLine(dataTable.Rows.Count);

                // save username and password to DTO for later use
                if (dataTable.Rows.Count > 0)
                {
                    DTO_LoginData.Instance.username = username;
                    DTO_LoginData.Instance.password = password;

                    if (dataTable.Rows[0]["permission"].ToString() == "admin")
                    {
                        DTO_LoginData.Instance.permission = Permission.admin;
                    }
                    else
                    {
                        DTO_LoginData.Instance.permission = Permission.employee;
                    }
                }
                else throw new Exception("Invalid username or password");
                return dataTable.Rows[0]["ID"].ToString();
            }
        }
    }
}
