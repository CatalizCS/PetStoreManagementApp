using PetStoreManagementApp.Libs;
using PetStoreManagementApp.Pages.Forms;
using System.Data;

namespace PetStoreManagementApp.Pages
{
    public partial class form_Service : Form
    {
        public form_Service()
        {
            InitializeComponent();
        }

        private void form_Service_Load(object sender, EventArgs e)
        {
            DataTable serviceData = DatabaseConnection.Instance.ReadToDataTable("SELECT ID, Name, price FROM Service_InfoData");
            dataGridView.DataSource = serviceData;
            dataGridView.Columns[0].HeaderText = "Mã dịch vụ";
            dataGridView.Columns[1].HeaderText = "Tên dịch vụ";
            dataGridView.Columns[2].HeaderText = "Tổng Giá";

            dataGridView.AutoGenerateColumns = false;
            foreach (DataRow row in serviceData.Rows)
            {
                ID_ComboBox.Items.Add(row["ID"]);
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
                return;

            ID_Depot.Items.Clear();
            ID_Textbox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            name_TextBox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[1].Value.ToString();
            if (dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[2].Value.ToString() == "")
                totalPrice_Textbox.Text = "0";
            else
                totalPrice_Textbox.Text = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[2].Value.ToString();

            string query = "SELECT DepotList FROM Service_InfoData WHERE ID = '" + dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString() + "'";
            DataTable depotListData = DatabaseConnection.Instance.ReadToDataTable(query);
            if (depotListData.Rows.Count > 0)
            {
                string[] depotList = depotListData.Rows[0]["DepotList"].ToString().Split(',');
                foreach (string depot in depotList)
                {
                    ID_Depot.Items.Add(depot);
                }
            }
        }

        private void depotID_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT NameProduct, Quantity, Price FROM Depot WHERE ID = '" + depotID.Text + "'";
            DataTable depotNameData = DatabaseConnection.Instance.ReadToDataTable(query);
            if (depotNameData.Rows.Count > 0)
            {
                depotName.Text = depotNameData.Rows[0]["NameProduct"].ToString();
                price.Text = depotNameData.Rows[0]["Price"].ToString();
                quantity_textbox.Text = depotNameData.Rows[0]["Quantity"].ToString();
            }
        }

        private void ID_Depot_SelectedIndexChanged(object sender, EventArgs e)
        {
            depotID.Text = ID_Depot.Items[ID_Depot.SelectedIndex].ToString();
            depotID_TextChanged(sender, e);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (name_TextBox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tên dịch vụ!").ShowDialog();
                return;
            }

            totalPrice_Textbox.Text = "0";
            string depotList = "";
            if (ID_Depot.Items.Count > 0)
            {
                depotList = string.Join(",", ID_Depot.Items.Cast<string>().ToArray());

                foreach (string item in ID_Depot.Items)
                {
                    // get price of each depot and add to total price
                    Console.WriteLine(item + "depot id");
                    string query = "SELECT Price FROM Depot WHERE ID = '" + item + "'";
                    DataTable depotPriceData = DatabaseConnection.Instance.ReadToDataTable(query);
                    if (depotPriceData.Rows.Count > 0)
                    {
                        totalPrice_Textbox.Text = (int.Parse(totalPrice_Textbox.Text) + int.Parse(depotPriceData.Rows[0]["Price"].ToString())).ToString();
                    }
                    else
                    {
                        new CustomMessageBox("Không tìm thấy giá của kho " + item).ShowDialog();
                    }
                }
            }

            string insertQuery = "INSERT INTO Service_InfoData (Name, DepotList, Price) VALUES ('" + name_TextBox.Text + "', '" + depotList + "', '" + totalPrice_Textbox.Text + "')";
            if (DatabaseConnection.Instance.ExecuteNonQuery(insertQuery) > 0)
            {
                new CustomMessageBox("Thêm dịch vụ thành công!").ShowDialog();
                form_Service_Load(sender, e);
            }
            else
            {
                new CustomMessageBox("Thêm dịch vụ thất bại!").ShowDialog();
            }

            DataTable serviceData = DatabaseConnection.Instance.ReadToDataTable("SELECT ID, Name, price FROM Service_InfoData");
            dataGridView.DataSource = serviceData;

            ID_ComboBox.Items.Clear();
            foreach (DataRow row in serviceData.Rows)
            {
                ID_ComboBox.Items.Add(row["ID"]);
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            if (ID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng chọn dịch vụ!").ShowDialog();
                return;
            }

            if (name_TextBox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tên dịch vụ!").ShowDialog();
                return;
            }

            string depotList = "";
            totalPrice_Textbox.Text = "0";

            if (ID_Depot.Items.Count > 0)
            {
                depotList = string.Join(",", ID_Depot.Items.Cast<string>().ToArray());

                foreach (string item in ID_Depot.Items)
                {
                    // get price of each depot and add to total price
                    Console.WriteLine(item + "depot id");
                    string query = "SELECT Price FROM Depot WHERE ID = '" + item + "'";
                    DataTable depotPriceData = DatabaseConnection.Instance.ReadToDataTable(query);
                    if (depotPriceData.Rows.Count > 0)
                    {
                        totalPrice_Textbox.Text = (long.Parse(totalPrice_Textbox.Text) + long.Parse(depotPriceData.Rows[0]["Price"].ToString())).ToString();
                    }
                    else
                    {
                        new CustomMessageBox("Không tìm thấy giá của kho " + item).ShowDialog();
                    }
                }
            }

            string updateQuery = "UPDATE Service_InfoData SET Name = '" + name_TextBox.Text + "', DepotList = '" + depotList + "', Price = '" + totalPrice_Textbox.Text + "' WHERE ID = '" + ID_Textbox.Text + "'";
            if (DatabaseConnection.Instance.ExecuteNonQuery(updateQuery) > 0)
            {
                new CustomMessageBox("Sửa dịch vụ thành công!").ShowDialog();
                form_Service_Load(sender, e);
            }
            else
            {
                new CustomMessageBox("Sửa dịch vụ thất bại!").ShowDialog();
            }

            DataTable serviceData = DatabaseConnection.Instance.ReadToDataTable("SELECT ID, Name, price FROM Service_InfoData");
            dataGridView.DataSource = serviceData;

            ID_ComboBox.Items.Clear();
            foreach (DataRow row in serviceData.Rows)
            {
                ID_ComboBox.Items.Add(row["ID"]);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (ID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng chọn dịch vụ!").ShowDialog();
                return;
            }

            string deleteQuery = "DELETE FROM Service_InfoData WHERE ID = '" + ID_Textbox.Text + "'";
            if (DatabaseConnection.Instance.ExecuteNonQuery(deleteQuery) > 0)
            {
                new CustomMessageBox("Xóa dịch vụ thành công!").ShowDialog();
                form_Service_Load(sender, e);
            }
            else
            {
                new CustomMessageBox("Xóa dịch vụ thất bại!").ShowDialog();
            }

            DataTable serviceData = DatabaseConnection.Instance.ReadToDataTable("SELECT ID, Name, price FROM Service_InfoData");
            dataGridView.DataSource = serviceData;

            ID_ComboBox.Items.Clear();
            foreach (DataRow row in serviceData.Rows)
            {
                ID_ComboBox.Items.Add(row["ID"]);
            }
        }

        private void depotAdd_Click(object sender, EventArgs e)
        {
            if (depotID.Text == "")
            {
                new CustomMessageBox("Vui lòng chọn kho!").ShowDialog();
                return;
            }

            if (ID_Depot.Items.Contains(depotID.Text))
            {
                new CustomMessageBox("Kho đã tồn tại!").ShowDialog();
                return;
            }

            ID_Depot.Items.Add(depotID.Text);
            ID_Depot.Refresh();
            depotID.Text = "";
        }

        private void depotDelete_Click(object sender, EventArgs e)
        {
            if (depotID.Text == "")
            {
                new CustomMessageBox("Vui lòng chọn kho!").ShowDialog();
                return;
            }

            if (!ID_Depot.Items.Contains(depotID.Text))
            {
                new CustomMessageBox("Kho không tồn tại!").ShowDialog();
                return;
            }

            ID_Depot.Items.Remove(depotID.Text);
            ID_Depot.Refresh();
            depotID.Text = "";
        }
    }
}
