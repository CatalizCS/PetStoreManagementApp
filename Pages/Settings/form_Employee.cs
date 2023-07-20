using PetStoreManagementApp.Dialogs;
using PetStoreManagementApp.Libs;
using PetStoreManagementApp.Libs.DTO;
using PetStoreManagementApp.Pages.Forms;

namespace PetStoreManagementApp.Pages
{
    public partial class form_Employee : Form
    {
        public form_Employee()
        {
            InitializeComponent();
        }

        private void form_Employee_Load(object sender, EventArgs e)
        {
            gender_TextBox.Text = DTO_UserInfo.Instance.Gender;
            firstName_TextBox.Text = DTO_UserInfo.Instance.FirstName;
            lastName_Textbox.Text = DTO_UserInfo.Instance.LastName;
            email_Textbox.Text = DTO_UserInfo.Instance.Email;
            age_Textbox.Text = DTO_UserInfo.Instance.Age.ToString();
            phoneNumber_Textbox.Text = DTO_UserInfo.Instance.PhoneNumber;
            notes_Textbox.Text = DTO_UserInfo.Instance.Notes;

            username_Textbox.Text = DTO_LoginData.Instance.username;
            permission_Textbox.Text = DTO_LoginData.Instance.permission.ToString();

            if (DTO_UserInfo.Instance.AvatarURL != "")
            {
                if (Form_Loader.avatarPath.findFile(Form_Loader.avatarPath.fullPath, DTO_UserInfo.Instance.AvatarURL) != null)
                    avatar_Image.Image = Image.FromFile(Path.Combine(Form_Loader.avatarPath.fullPath, DTO_UserInfo.Instance.AvatarURL));
            }
            else
            {
                avatar_Image.Image = Properties.Resources.user_24px;
            }
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            form_Employee_Load(sender, e);
            return;
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            DTO_UserInfo.Instance.Gender = gender_TextBox.Text == null ? DTO_UserInfo.Instance.Gender : gender_TextBox.Text;
            DTO_UserInfo.Instance.FirstName = firstName_TextBox.Text == null ? DTO_UserInfo.Instance.FirstName : firstName_TextBox.Text;
            DTO_UserInfo.Instance.LastName = lastName_Textbox.Text == null ? DTO_UserInfo.Instance.LastName : lastName_Textbox.Text;
            DTO_UserInfo.Instance.Email = email_Textbox.Text == null ? DTO_UserInfo.Instance.Email : email_Textbox.Text;
            DTO_UserInfo.Instance.Age = age_Textbox.Text == null ? DTO_UserInfo.Instance.Age : int.Parse(age_Textbox.Text);
            DTO_UserInfo.Instance.PhoneNumber = phoneNumber_Textbox.Text == null ? DTO_UserInfo.Instance.PhoneNumber : phoneNumber_Textbox.Text;
            DTO_UserInfo.Instance.Notes = notes_Textbox.Text == null ? DTO_UserInfo.Instance.Notes : notes_Textbox.Text;

            if (newPassword_Textbox.Text != "" || confirmPassword_Textbox.Text != "")
            {
                if (!RegexChecker.Instance.IsValidUsername(newPassword_Textbox.Text))
                {
                    new CustomMessageBox("Password must be at least 8 characters, including letters, numbers and special characters!").ShowDialog();
                    return;
                }

                if (newPassword_Textbox.Text != confirmPassword_Textbox.Text)
                {
                    new CustomMessageBox("Confirm password does not match!").ShowDialog();
                    return;
                }

                string updatePass = "UPDATE LoginData SET " +
                    "Password = '" + newPassword_Textbox.Text + "' WHERE Username = '" + DTO_LoginData.Instance.username + "'";

                if (DatabaseConnection.Instance.Execute(updatePass))
                {
                    new CustomMessageBox("Update password successfully!").ShowDialog();
                    return;
                }
                else
                {
                    new CustomMessageBox("Update password failed!").ShowDialog();
                    cancel_Button_Click(sender, e);
                    return;
                }
            }

            string query = "UPDATE Employee_InfoData SET " +
                "Gender = '" + DTO_UserInfo.Instance.Gender + "' , " +
                "FirstName = '" + DTO_UserInfo.Instance.FirstName + "', " +
                "LastName = '" + DTO_UserInfo.Instance.LastName + "', " +
                "Age = '" + DTO_UserInfo.Instance.Age + "', " +
                "PhoneNumber = '" + DTO_UserInfo.Instance.PhoneNumber + "', " +
                "Email = '" + DTO_UserInfo.Instance.Email + "', " +
                "Notes = '" + DTO_UserInfo.Instance.Notes + "', " +
                "AvatarURL = '" + DTO_UserInfo.Instance.AvatarURL + "' WHERE ID = '" + DTO_UserInfo.Instance.ID + "'";
            bool updated = DatabaseConnection.Instance.Execute(query);

            if (updated)
            {
                new CustomMessageBox("Update successfully!").ShowDialog();
                return;
            }
            else
            {
                new CustomMessageBox("Update failed!").ShowDialog();
                cancel_Button_Click(sender, e);
                return;
            }

        }

        private void changeAvater_Button_Click(object sender, EventArgs e)
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
                    DTO_UserInfo.Instance.AvatarURL = fileName + extension;
                    string query = "UPDATE Employee_InfoData SET AvatarURL = '" + fileName + extension + "' WHERE ID = '" + DTO_UserInfo.Instance.ID + "'";

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
    }
}