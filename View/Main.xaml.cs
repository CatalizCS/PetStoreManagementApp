using Login;
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
using System.Windows.Shapes;

namespace PetStoreManagementApp.View
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Lấy nút Button đã được bấm
            Button clickedButton = (Button)sender;

            // Đặt nền của nút Button đã được bấm là không hiển thị (Collapsed)
            clickedButton.Background = Brushes.Transparent;

            // Lặp qua tất cả các nút Button
            foreach (Button button in FindVisualChildren<Button>(this))
            {
                // Kiểm tra nếu nút Button không phải là nút đã được bấm
                if (button != clickedButton)
                {
                    // Đặt nền của các nút còn lại là không hiển thị (Collapsed)
                    button.Background = Brushes.Transparent;
                }
            }
        }

        // Phương thức hỗ trợ để tìm các phần tử con kiểu T trong một phần tử chính
        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject dependencyObject) where T : DependencyObject
        {
            if (dependencyObject != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(dependencyObject); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(dependencyObject, i);

                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow(); // Create an instance of the Login window
            var result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                this.Close(); // Close the current Main window
                mw.Show();
            }
            else
            {
                this.Show();
            }
            
        }

    }
}
