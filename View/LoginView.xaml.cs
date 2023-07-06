using PetStoreManagementApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;



namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //sqlite
        //SqlConnection conn = new SqlConnection("D:\Kì 3 năm 2\Lập trình window.exe\PetStoreManagementApp-moritaka_page\PetStoreManagementApp-moritaka_page\Properties\petstore.db");
        SQLiteConnection conn = new SQLiteConnection("Data Source=Source/storage.db; version = 3;");

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && textEmail.Text.Length > 0)
            {
                textEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
                textEmail.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }


        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Successfull login!");
            }
        }*/
        private void txtPassword_previewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login();
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            // Query the database to check if the entered email and password match
            string query = "SELECT ID FROM Employee_LoginData WHERE ID = @ID AND Password = @Password;";

            using (SQLiteCommand command = new SQLiteCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ID", email);
                command.Parameters.AddWithValue("@Password", password);

                conn.Open();

                object result = command.ExecuteScalar();

                if (result != null) // If a matching record is found
                {
                    MessageBox.Show("You have successfully logged in!", "Login Success");
                    txtPassword.Password = string.Empty;
                    txtEmail.Focus();
                    txtEmail.Text = string.Empty;
                    Main m = new Main();
                    m.Show();
                    this.Hide();
                }
                else // If no matching record is found
                {
                    MessageBox.Show("Login Failed");
                    txtPassword.Password = string.Empty;
                    txtEmail.Focus();
                    txtEmail.Text = string.Empty;
                }

                conn.Close();
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool success = signup();

            if (success)
            {
                MessageBox.Show("Account creation successful.");
                //Login();
            }
            else
            {
                MessageBox.Show("Account creation failed.");
            }
        }


        private bool signup()
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            using (SQLiteConnection connect = new SQLiteConnection(conn))
            {
                connect.Open();

                // Check if the account already exists
                string checkSql = "SELECT COUNT(*) FROM Employee_LoginData WHERE ID = @ID";
                using (SQLiteCommand checkCommand = new SQLiteCommand(checkSql, connect))
                {
                    checkCommand.Parameters.AddWithValue("@ID", email);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        // Account already exists
                        return false;
                    }
                }

                // Account does not exist, proceed with insertion
                string insertSql = "INSERT INTO Employee_LoginData (ID, Password) VALUES (@ID, @Password)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connect))
                {
                    insertCommand.Parameters.AddWithValue("@ID", email);
                    insertCommand.Parameters.AddWithValue("@Password", password);
                    insertCommand.ExecuteNonQuery();
                }
            }

            return true;
        }
    }
}