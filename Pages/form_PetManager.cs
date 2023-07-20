using PetStoreManagementApp.Libs;
using PetStoreManagementApp.Pages.Forms;
using System.Data;

namespace PetStoreManagementApp.Pages
{
    public partial class form_PetManager : Form
    {
        public form_PetManager()
        {
            InitializeComponent();
        }

        private void updateData()
        {
            DataTable PetData = DatabaseConnection.Instance.ReadToDataTable("SELECT * FROM Customer_PetData");
            dataGridView.DataSource = PetData;
            ID_ComboBox.Items.Clear();
            foreach (DataRow row in PetData.Rows)
            {
                ID_ComboBox.Items.Add(row["ID"]);
            }

            label_All.Text = dataGridView.Rows.Count.ToString();
        }

        private void form_PetManager_Load(object sender, EventArgs e)
        {
            updateData();
            dataGridView.Columns[0].HeaderText = "Mã thú cưng";
            dataGridView.Columns[1].HeaderText = "Tên thú cưng";
            dataGridView.Columns[2].HeaderText = "Tuổi";
            dataGridView.Columns[3].HeaderText = "Chủng Loại";
            dataGridView.Columns[4].HeaderText = "Mã chủ nhân";

            dataGridView.AutoGenerateColumns = false;
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
                return;

            ID_Textbox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            fullName_Textbox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[1].Value.ToString();
            age_Textbox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[2].Value.ToString();
            type_Textbox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[3].Value.ToString();

            // get owner data
            DataTable ownerData = DatabaseConnection.Instance.ReadToDataTable("SELECT * FROM Customer_InfoData WHERE ID = '" + dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[4].Value.ToString() + "'");
            if (ownerData.Rows.Count > 0)
            {
                ownerID_Textbox.Text = ownerData.Rows[0]["ID"].ToString();
                firstName_Textbox.Text = ownerData.Rows[0]["FirstName"].ToString() + " " + ownerData.Rows[0]["LastName"].ToString();
                lastName_Textbox.Text = ownerData.Rows[0]["LastName"].ToString();
                phone_Textbox.Text = ownerData.Rows[0]["PhoneNumber"].ToString();
                email_Textbox.Text = ownerData.Rows[0]["Email"].ToString();
            }
            else
            {
                ownerID_Textbox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[4].Value.ToString();
                firstName_Textbox.Text = "";
                lastName_Textbox.Text = "";
                phone_Textbox.Text = "";
                email_Textbox.Text = "";
                new CustomMessageBox("Không tìm thấy chủ nhân").ShowDialog();
                return;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (fullName_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tên thú cưng").ShowDialog();
                return;
            }
            if (age_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tuổi thú cưng").ShowDialog();
                return;
            }
            if (type_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập chủng loại thú cưng").ShowDialog();
                return;
            }
            if (ownerID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập mã chủ nhân").ShowDialog();
            }
            string query = "INSERT INTO Customer_PetData (FullName, Age, Type, OwnerID) VALUES ('" + fullName_Textbox.Text + "', '" + age_Textbox.Text + "', '" + type_Textbox.Text + "', '" + ownerID_Textbox.Text + "')";
            DatabaseConnection.Instance.ExecuteNonQuery(query);
            updateData();

            new CustomMessageBox("Thêm thú cưng thành công").ShowDialog();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            if (ID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng chọn thú cưng").ShowDialog();
                return;
            }

            if (fullName_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tên thú cưng").ShowDialog();
                return;
            }

            if (age_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tuổi thú cưng").ShowDialog();
                return;
            }

            if (type_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập chủng loại thú cưng").ShowDialog();
                return;
            }

            if (ownerID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập mã chủ nhân").ShowDialog();
            }

            string query = "UPDATE Customer_PetData SET FullName = '" + fullName_Textbox.Text + "', Age = '" + age_Textbox.Text + "', Type = '" + type_Textbox.Text + "', OwnerID = '" + ownerID_Textbox.Text + "' WHERE ID = '" + ID_Textbox.Text + "'";
            DatabaseConnection.Instance.ExecuteNonQuery(query);
            updateData();

            new CustomMessageBox("Chỉnh sửa thú cưng thành công").ShowDialog();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (ID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập mã thú cưng").ShowDialog();
                return;
            }

            string query = "DELETE FROM Customer_PetData WHERE ID = '" + ID_Textbox.Text + "'";
            DatabaseConnection.Instance.ExecuteNonQuery(query);
            updateData();

            new CustomMessageBox("Xóa thú cưng thành công").ShowDialog();
        }

        private void ID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_Textbox.Text = ID_ComboBox.Items[ID_ComboBox.SelectedIndex].ToString();
            dataGridView_Click(sender, e);
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            // search by ID, FullName, Type, OwnerID
            string query = "SELECT * FROM Customer_PetData WHERE ID LIKE '%" + searchBar.Text + "%' OR FullName LIKE '%" + searchBar.Text + "%' OR Type LIKE '%" + searchBar.Text + "%' OR OwnerID LIKE '%" + searchBar.Text + "%'";
            DataTable PetData = DatabaseConnection.Instance.ReadToDataTable(query);
            dataGridView.DataSource = PetData;
            label_All.Text = dataGridView.Rows.Count.ToString();
        }
    }
}
