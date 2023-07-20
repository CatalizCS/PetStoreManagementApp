using PetStoreManagementApp.Dialogs;
using PetStoreManagementApp.Libs;
using PetStoreManagementApp.Libs.DTO;
using PetStoreManagementApp.Pages.Forms;
using System.Data;

namespace PetStoreManagementApp.Pages
{
    public partial class Form_Setting_Admin : Form
    {
        public Form_Setting_Admin()
        {
            InitializeComponent();
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Setting_Admin_Load(sender, e);
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            panel_Delete.Hide();
            panel_Update.Show();

            if (dataGridView_ListEm.Rows.Count == 0)
                return;

            if (comboBox_IDEmployee.Items[comboBox_IDEmployee.SelectedIndex].ToString() == "" || comboBox_NameEm.Items[comboBox_NameEm.SelectedIndex].ToString() == "")
            {
                if (comboBox_NameEm.Items.ToString() == "")
                {
                    new CustomMessageBox("Vui lòng chọn nhân viên cần thay đổi thông tin").ShowDialog();
                    return;
                }
            }

            if (newPassword_TextBox.Text != "" || confirmPassword_TextBox.Text != "")
            {
                if (newPassword_TextBox.Text != confirmPassword_TextBox.Text)
                {
                    new CustomMessageBox("Mật khẩu không khớp").ShowDialog();
                    return;
                }

                if (!RegexChecker.Instance.IsValidPassword(newPassword_TextBox.Text) || !RegexChecker.Instance.IsValidPassword(confirmPassword_TextBox.Text))
                {
                    new CustomMessageBox("Mật khẩu không hợp lệ").ShowDialog();
                    return;
                }

                DatabaseConnection.Instance.ExecuteQuery("UPDATE LoginData SET Password = '" + newPassword_TextBox.Text + "' WHERE ID = '" + comboBox_IDEmployee.Text + "'");

                new CustomMessageBox("Đổi mật khẩu thành công \ncho nhân viên: " + dataGridView_ListEm.CurrentRow.Cells[2].Value.ToString() + " " + dataGridView_ListEm.CurrentRow.Cells[3].Value.ToString()).ShowDialog();
                newPassword_TextBox.Clear();
                confirmPassword_TextBox.Clear();
                return;
            }


            string query = "UPDATE Employee_InfoData SET Gender = '" + (gender_ComboBox.Items[gender_ComboBox.SelectedIndex].ToString()).Split(".")[0] + "', FirstName = '" + firstName_TextBox.Text + "', LastName = '" + lastName_TextBox.Text + "', Age = '" + age_TextBox.Text + "', PhoneNumber = '" + phone_TextBox.Text + "', Email = '" + email_TextBox.Text + "', Notes = '" + notes_TextBox.Text + "' WHERE ";

            if (comboBox_IDEmployee.Text != "")
            {
                query += "ID = '" + comboBox_IDEmployee.Text + "'";

            }
            else if (comboBox_NameEm.Text != "")
            {
                query += "FirstName = '" + comboBox_NameEm.Text.Split(' ')[0] + "' AND LastName = '" + comboBox_NameEm.Text.Split(' ')[1] + "'";
            }

            DatabaseConnection.Instance.ExecuteQuery(query);
            DataTable allEmployeeData = DatabaseConnection.Instance.ReadToDataTable("SELECT ID, Gender, FirstName, LastName, Age, PhoneNumber, Email FROM Employee_InfoData");
            dataGridView_ListEm.DataSource = allEmployeeData;

            comboBox_IDEmployee.Items.Clear();
            comboBox_NameEm.Items.Clear();
            foreach (DataRow row in allEmployeeData.Rows)
            {
                comboBox_IDEmployee.Items.Add(row["ID"].ToString());
                comboBox_NameEm.Items.Add(row["FirstName"].ToString() + " " + row["LastName"].ToString());
            }

            new CustomMessageBox("Chỉnh sửa thông tin thành công cho\n nhân viên: " + dataGridView_ListEm.CurrentRow.Cells[2].Value.ToString() + " " + dataGridView_ListEm.CurrentRow.Cells[3].Value.ToString()).ShowDialog();
            return;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            panel_Delete.Show();
            panel_Update.Hide();

            if (dataGridView_ListEm.Rows.Count == 0)
                return;

            if (comboBox_IDEmployee.Items[comboBox_IDEmployee.SelectedIndex].ToString() == "" || comboBox_NameEm.Items[comboBox_NameEm.SelectedIndex].ToString() == "")
            {
                if (comboBox_NameEm.Items.ToString() == "")
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần Xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string query = "DELETE FROM Employee_InfoData WHERE ";
            if (comboBox_IDEmployee.Text != "")
            {
                query += "ID = '" + comboBox_IDEmployee.Text + "'";

            }
            else if (comboBox_NameEm.Text != "")
            {
                query += "FirstName = '" + comboBox_NameEm.Text.Split(' ')[0] + "' AND LastName = '" + comboBox_NameEm.Text.Split(' ')[1] + "'";
            }
            DatabaseConnection.Instance.ExecuteQuery(query);

            query = "DELETE FROM LoginData WHERE ";

            if (comboBox_IDEmployee.Text != "")
            {
                query += "ID = '" + comboBox_IDEmployee.Text + "'";

            }
            else if (comboBox_NameEm.Text != "")
            {
                query += "Username = '" + username.Text + "'";
            }
            DatabaseConnection.Instance.ExecuteQuery(query);

            DataTable allEmployeeData = DatabaseConnection.Instance.ReadToDataTable("SELECT ID, Gender, FirstName, LastName, Age, PhoneNumber, Email FROM Employee_InfoData");
            dataGridView_ListEm.DataSource = allEmployeeData;

            comboBox_IDEmployee.Items.Clear();
            comboBox_NameEm.Items.Clear();
            foreach (DataRow row in allEmployeeData.Rows)
            {
                comboBox_IDEmployee.Items.Add(row["ID"].ToString());
                comboBox_NameEm.Items.Add(row["FirstName"].ToString() + " " + row["LastName"].ToString());
            }

            new CustomMessageBox("Xóa nhân viên thành công").ShowDialog();
            return;
        }

        private void button_Change_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Delete.Hide();
            panel_Update.Show();
        }

        private void button_Delete_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Delete.Show();
            panel_Update.Hide();
        }

        private void Form_Setting_Admin_Load(object sender, EventArgs e)
        {
            DataTable allEmployeeData = DatabaseConnection.Instance.ReadToDataTable("SELECT ID, Gender, FirstName, LastName, Age, PhoneNumber, Email FROM Employee_InfoData");
            dataGridView_ListEm.DataSource = allEmployeeData;
            dataGridView_ListEm.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView_ListEm.Columns[1].HeaderText = "Giới tính";
            dataGridView_ListEm.Columns[2].HeaderText = "Tên";
            dataGridView_ListEm.Columns[3].HeaderText = "Họ";
            dataGridView_ListEm.Columns[4].HeaderText = "Tuổi";
            dataGridView_ListEm.Columns[5].HeaderText = "Số điện thoại";
            dataGridView_ListEm.Columns[6].HeaderText = "Email";

            dataGridView_ListEm.AutoGenerateColumns = false;

            foreach (DataRow row in allEmployeeData.Rows)
            {
                comboBox_IDEmployee.Items.Add(row["ID"].ToString());
                comboBox_NameEm.Items.Add(row["FirstName"].ToString() + " " + row["LastName"].ToString());
            }
        }

        private void dataGridView_ListEm_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListEm.Rows.Count == 0)
                return;

            // change index and show that gender in combobox
            Console.WriteLine("Index" + gender_ComboBox.FindStringExact(dataGridView_ListEm.CurrentRow.Cells[1].Value.ToString().Contains(".") ? dataGridView_ListEm.CurrentRow.Cells[1].Value.ToString() : dataGridView_ListEm.CurrentRow.Cells[1].Value.ToString() + "."));
            gender_ComboBox.SelectedIndex = gender_ComboBox.FindStringExact(dataGridView_ListEm.CurrentRow.Cells[1].Value.ToString().Contains(".") ? dataGridView_ListEm.CurrentRow.Cells[1].Value.ToString() : dataGridView_ListEm.CurrentRow.Cells[1].Value.ToString() + ".");
            comboBox_IDEmployee.SelectedIndex = comboBox_IDEmployee.FindStringExact(dataGridView_ListEm.CurrentRow.Cells[0].Value.ToString());
            comboBox_NameEm.SelectedIndex = comboBox_NameEm.FindStringExact(dataGridView_ListEm.CurrentRow.Cells[2].Value.ToString() + " " + dataGridView_ListEm.CurrentRow.Cells[3].Value.ToString());
            firstName_TextBox.Text = dataGridView_ListEm.CurrentRow.Cells[2].Value.ToString();
            lastName_TextBox.Text = dataGridView_ListEm.CurrentRow.Cells[3].Value.ToString();
            age_TextBox.Text = dataGridView_ListEm.CurrentRow.Cells[4].Value.ToString();
            phone_TextBox.Text = dataGridView_ListEm.CurrentRow.Cells[5].Value.ToString();
            email_TextBox.Text = dataGridView_ListEm.CurrentRow.Cells[6].Value.ToString();

            DataTable employeeData = DatabaseConnection.Instance.ReadToDataTable("SELECT Notes, AvatarURL FROM Employee_InfoData WHERE ID = '" + dataGridView_ListEm.CurrentRow.Cells[0].Value.ToString() + "'");
            if (employeeData.Rows.Count > 0)
            {
                notes_TextBox.Text = employeeData.Rows[0][0].ToString();
                if (employeeData.Rows[0]["AvatarURL"].ToString() != "")
                {
                    if (Form_Loader.avatarPath.findFile(Form_Loader.avatarPath.subName, employeeData.Rows[0]["AvatarURL"].ToString()) != null)
                        avatar_Image.Image = Image.FromFile(Path.Combine(Form_Loader.avatarPath.fullPath, employeeData.Rows[0]["AvatarURL"].ToString()));
                }
                else
                    avatar_Image.Image = Properties.Resources.user;
            }
            else
            {
                notes_TextBox.Text = "";
                avatar_Image.Image = Properties.Resources.user;
            }

            DataTable loginData = DatabaseConnection.Instance.ReadToDataTable("SELECT Username, Permission FROM LoginData WHERE ID = '" + dataGridView_ListEm.CurrentRow.Cells[0].Value.ToString() + "'");
            if (loginData.Rows.Count > 0)
            {
                username.Text = loginData.Rows[0][0].ToString();
                permission.Text = loginData.Rows[0][1].ToString();
            }
            else
            {
                username.Text = "";
                permission.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_Admin settings = new form_Admin();
            settings.TopLevel = false;
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();
            panel.Controls.Add(settings);
            settings.Show();
        }

        private void button_Seedetial_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListEm.Rows.Count == 0)
                return;

            if (comboBox_IDEmployee.SelectedIndex == -1 || comboBox_IDEmployee.Items[comboBox_IDEmployee.SelectedIndex].ToString() == "" || comboBox_NameEm.Items[comboBox_NameEm.SelectedIndex].ToString() == "")
            {
                if (comboBox_NameEm.Items.ToString() == "")
                {
                    new CustomMessageBox("Vui lòng chọn nhân viên cần thay đổi thông tin").ShowDialog();
                    return;
                }
            }

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
                    DTO_UserInfo.Instance.AvatarURL = fileName + extension;
                    string query = "UPDATE Employee_InfoData SET AvatarURL = '" + fileName + extension + "' WHERE ";

                    if (comboBox_IDEmployee.Text != "")
                    {
                        query += "ID = '" + comboBox_IDEmployee.Text + "'";

                    }
                    else if (comboBox_NameEm.Text != "")
                    {
                        query += "Username = '" + username.Text + "'";
                    }

                    DatabaseConnection.Instance.ExecuteQuery(query);

                    avatar_Image.Image = Image.FromFile(destinationPath);
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

        private void comboBox_NameEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_IDEmployee.SelectedIndex = comboBox_NameEm.SelectedIndex;
            dataGridView_ListEm.CurrentCell = dataGridView_ListEm.Rows[comboBox_NameEm.SelectedIndex].Cells[0];
            dataGridView_ListEm_Click(sender, e);
        }

        private void comboBox_IDEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_NameEm.SelectedIndex = comboBox_IDEmployee.SelectedIndex;
            dataGridView_ListEm.CurrentCell = dataGridView_ListEm.Rows[comboBox_IDEmployee.SelectedIndex].Cells[0];
            dataGridView_ListEm_Click(sender, e);
        }
    }
}
