using PetStoreManagementApp.Dialogs;
using PetStoreManagementApp.Libs;
using PetStoreManagementApp.Pages.Forms;
using System.Data;

namespace PetStoreManagementApp.Pages
{
    public partial class form_Customer : Form
    {
        public form_Customer()
        {
            InitializeComponent();
        }

        private void form_Customer_Load(object sender, EventArgs e)
        {
            DataTable customerData = DatabaseConnection.Instance.ReadToDataTable("SELECT ID, FirstName, LastName, PhoneNumber, Email FROM Customer_InfoData");
            dataGridView.DataSource = customerData;
            dataGridView.Columns[0].HeaderText = "Mã khách hàng";
            dataGridView.Columns[1].HeaderText = "Họ";
            dataGridView.Columns[2].HeaderText = "Tên";
            dataGridView.Columns[3].HeaderText = "Số điện thoại";
            dataGridView.Columns[4].HeaderText = "Email";

            dataGridView.AutoGenerateColumns = false;
            foreach (DataRow row in customerData.Rows)
            {
                ID_ComboBox.Items.Add(row["ID"]);
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
                return;

            ID_Textbox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            firstName_TextBox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[1].Value.ToString();
            lastName_TextBox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[2].Value.ToString();
            phone_TextBox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[3].Value.ToString();
            email_TextBox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[4].Value.ToString();

            // get AvatarURL data
            DataTable avatarURLData = DatabaseConnection.Instance.ReadToDataTable("SELECT AvatarURL FROM Customer_InfoData WHERE ID = '" + dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString() + "'");
            if (avatarURLData.Rows.Count > 0 && avatarURLData.Rows[0]["AvatarURL"].ToString() != "")
            {
                if (Form_Loader.avatarPath.findFile(Form_Loader.avatarPath.subName, avatarURLData.Rows[0]["AvatarURL"].ToString()) != null)
                    avatar.Image = Image.FromFile(Path.Combine(Form_Loader.avatarPath.fullPath, avatarURLData.Rows[0]["AvatarURL"].ToString()));
            }
            else
            {
                avatar.Image = Properties.Resources.user;
            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (firstName_TextBox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tên khách hàng").ShowDialog();
            }

            if (lastName_TextBox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập họ khách hàng").ShowDialog();
            }

            // checking first name and last name is exist
            string query = "SELECT FirstName, LastName FROM Customer_InfoData";
            DataTable customerData = DatabaseConnection.Instance.ReadToDataTable(query);
            foreach (DataRow row in customerData.Rows)
            {
                if (row["FirstName"].ToString() == firstName_TextBox.Text && row["LastName"].ToString() == lastName_TextBox.Text)
                {
                    new CustomMessageBox("Khách hàng đã tồn tại").ShowDialog();
                    return;
                }
            }

            if (firstName_TextBox.Text != "" && lastName_TextBox.Text != "")
            {
                query = "INSERT INTO Customer_InfoData (FirstName, LastName, PhoneNumber, Email) VALUES ('" + firstName_TextBox.Text + "', '" + lastName_TextBox.Text + "', '" + phone_TextBox.Text + "', '" + email_TextBox.Text + "')";
                DatabaseConnection.Instance.ExecuteQuery(query);

                query = "SELECT ID, FirstName, LastName, PhoneNumber, Email FROM Customer_InfoData";
                customerData = DatabaseConnection.Instance.ReadToDataTable(query);
                dataGridView.DataSource = customerData;

                ID_ComboBox.Items.Clear();
                foreach (DataRow row in customerData.Rows)
                {
                    ID_ComboBox.Items.Add(row["ID"]);
                }

                new CustomMessageBox("Thêm khách hàng thành công").ShowDialog();
                form_Customer_Load(sender, e);
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            if (ID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập hoặc chọn ID khách hàng cần chỉnh sửa").ShowDialog();
                return;
            }

            if (firstName_TextBox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tên khách hàng").ShowDialog();
            }

            if (lastName_TextBox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập họ khách hàng").ShowDialog();
            }

            string query = "UPDATE Customer_InfoData SET FirstName = '" + firstName_TextBox.Text + "', LastName = '" + lastName_TextBox.Text + "', PhoneNumber = '" + phone_TextBox.Text + "', Email = '" + email_TextBox.Text + "' WHERE ID = '" + ID_Textbox.Text + "'";
            DatabaseConnection.Instance.ExecuteQuery(query);

            query = "SELECT ID, FirstName, LastName, PhoneNumber, Email FROM Customer_InfoData";
            DataTable customerData = DatabaseConnection.Instance.ReadToDataTable(query);
            dataGridView.DataSource = customerData;

            ID_ComboBox.Items.Clear();
            foreach (DataRow row in customerData.Rows)
            {
                ID_ComboBox.Items.Add(row["ID"]);
            }

            new CustomMessageBox("Chỉnh sửa khách hàng thành công").ShowDialog();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (ID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập hoặc chọn ID khách hàng cần xóa").ShowDialog();
                return;
            }

            string query = "DELETE FROM Customer_InfoData WHERE ID = '" + ID_Textbox.Text + "'";
            DatabaseConnection.Instance.ExecuteQuery(query);

            query = "SELECT ID, FirstName, LastName, PhoneNumber, Email FROM Customer_InfoData";
            DataTable customerData = DatabaseConnection.Instance.ReadToDataTable(query);
            dataGridView.DataSource = customerData;
            ID_ComboBox.Items.Clear();

            foreach (DataRow row in customerData.Rows)
            {
                ID_ComboBox.Items.Add(row["ID"]);
            }

            new CustomMessageBox("Xóa khách hàng thành công").ShowDialog();
        }

        private void ID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_Textbox.Text = ID_ComboBox.Items[ID_ComboBox.SelectedIndex].ToString();
            dataGridView_Click(sender, e);
        }

        private void avatar_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string sourcePath = openFileDialog.FileName;
                string extension = Path.GetExtension(sourcePath);
                string fileName = Path.GetRandomFileName();
                fileName = fileName.Split('.')[0];

                try
                {
                    string destinationPath = Path.Combine(Form_Loader.avatarPath.fullPath, fileName + extension);
                    Console.WriteLine(destinationPath.ToString());
                    File.Copy(sourcePath, destinationPath, true);

                    string query = "UPDATE Customer_InfoData SET AvatarURL = '" + fileName + extension + "' WHERE ID = '" + ID_Textbox.Text + "'";
                    DatabaseConnection.Instance.ExecuteQuery(query);

                    avatar.Image = Image.FromFile(destinationPath);
                    new CustomMessageBox("Cập nhật ảnh đại diện thành công").ShowDialog();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    new CustomMessageBox("Cập nhật ảnh đại diện thất bại").ShowDialog();
                    return;
                }
            }

        }
    }
}
