using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
using PetStoreManagementApp.Libs.DTO;
using System.Drawing.Text;

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

        public bool SetData(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool CheckExist(string query)
        {
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
                    case Permission.customer:
                        command = new SQLiteCommand("SELECT * FROM Customer_InfoData WHERE ID = @ID", connection);
                        break;
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
                    Console.WriteLine("1" + row["ID"] + " | " + row["FirstName"] + " | " + row["LastName"] + " | " + row["Age"] + " | " + row["PhoneNumber"] + " | " + row["Email"] + " | " + row["AvatarURL"]);
                }

                if (dataTable.Rows.Count > 0)
                {
                    DTO_UserInfo.Instance.ID = dataTable.Rows[0]["ID"].ToString();
                    DTO_UserInfo.Instance.FirstName = dataTable.Rows[0]["FirstName"].ToString();
                    DTO_UserInfo.Instance.LastName = dataTable.Rows[0]["LastName"].ToString();
                    DTO_UserInfo.Instance.Age = int.Parse(dataTable.Rows[0]["Age"].ToString());
                    DTO_UserInfo.Instance.PhoneNumber = dataTable.Rows[0]["PhoneNumber"].ToString();
                    DTO_UserInfo.Instance.Email = dataTable.Rows[0]["Email"].ToString();
                    DTO_UserInfo.Instance.AvatarURL = dataTable.Rows[0]["AvatarURL"].ToString();
                }
                else throw new Exception("User not found"); // TODO: Add form for user input data
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

                // save username and password to DTO for later use
                if (dataTable.Rows.Count > 0)
                {
                    DTO_LoginData.Instance.username = username;
                    DTO_LoginData.Instance.password = password;

                    if (dataTable.Rows[0]["permission"].ToString() == "admin")
                    {
                        DTO_LoginData.Instance.permission = Permission.admin;
                    }
                    else if (dataTable.Rows[0]["permission"].ToString() == "employee")
                    {
                        DTO_LoginData.Instance.permission = Permission.employee;
                    }
                    else
                    {
                        DTO_LoginData.Instance.permission = Permission.customer;
                    }
                } else throw new Exception("Invalid username or password");
                return dataTable.Rows[0]["ID"].ToString();
            }
        }
    }
}
