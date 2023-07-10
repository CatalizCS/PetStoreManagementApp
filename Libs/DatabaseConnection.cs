using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;

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
                connectionString = String.Format("Data Source={0};Version=3", configReader.GetConfigValue("database.location"));
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
    }
}
