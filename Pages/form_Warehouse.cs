using PetStoreManagementApp.Libs;
using PetStoreManagementApp.Libs.DTO;
using PetStoreManagementApp.Pages.Forms;
using System.Data;

namespace PetStoreManagementApp.Pages
{
    public partial class form_WareHouse : Form
    {
        public static DTO_LoginData loginData = new DTO_LoginData();
        public form_WareHouse()
        {
            InitializeComponent();
        }
        private void Ware_House_Load(object sender, EventArgs e)
        {
            DataTable wareHouseData = DatabaseConnection.Instance.ReadToDataTable("SELECT * FROM Depot");
            dataGridView_Product.DataSource = wareHouseData;
            dataGridView_Product.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView_Product.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView_Product.Columns[2].HeaderText = "Số lượng";
            dataGridView_Product.Columns[3].HeaderText = "Giá";

            dataGridView_Product.AutoGenerateColumns = false;
            foreach (DataRow row in wareHouseData.Rows)
            {
                Console.WriteLine(dataGridView_Product.Rows.Count);
                comboBox_ID.Items.Add(row["ID"]);
            }

            label_All.Text = wareHouseData.Rows.Count.ToString();
        }

        private void panel_NewOrder_Paint(object sender, PaintEventArgs e)
        {
            button_NewOrder_Click(sender, e);
        }

        private void button_NewOrder_Click(object sender, EventArgs e)
        {
            dataGridView_Product.Size = dataGridView_Product.MinimumSize;
            panel_Controls.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            panel_Delete.Hide();
            panel_Update.Hide();
            panel_Add.Show();
            button_Add.ForeColor = Color.White;
            button_Add.BackColor = Color.DodgerBlue;
            button_Change.ForeColor = Color.DodgerBlue;
            button_Change.BackColor = Color.White;
            button_Delete.ForeColor = Color.DodgerBlue;
            button_Delete.BackColor = Color.White;

            if (name_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tên sản phẩm").ShowDialog();
                return;
            }

            // Check if name is already exist
            string query = "SELECT * FROM Depot WHERE NameProduct = '" + name_Textbox.Text + "'";
            if (DatabaseConnection.Instance.CheckExist(query))
            {
                new CustomMessageBox("Sản phẩm đã tồn tại").ShowDialog();
                return;
            }

            if (quantity_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập số lượng sản phẩm").ShowDialog();
                return;
            }

            if (price_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập giá sản phẩm").ShowDialog();
                return;
            }

            query = "INSERT INTO Depot (NameProduct, Quantity, Price) VALUES ('" + name_Textbox.Text + "', '" + quantity_Textbox.Text + "', '" + price_Textbox.Text + "')";

            DatabaseConnection.Instance.ExecuteNonQuery(query);
            DataTable wareHouseData = DatabaseConnection.Instance.ReadToDataTable("SELECT * FROM Depot");
            dataGridView_Product.DataSource = wareHouseData;
            label_All.Text = wareHouseData.Rows.Count.ToString();
            comboBox_ID.Items.Clear();
            foreach (DataRow row in wareHouseData.Rows)
            {
                comboBox_ID.Items.Add(row["ID"]);
            }

            new CustomMessageBox("Thêm sản phẩm thành công").ShowDialog();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Hide();
            panel_Update.Show();
            button_Add.ForeColor = Color.DodgerBlue;
            button_Add.BackColor = Color.White;
            button_Change.ForeColor = Color.White;
            button_Change.BackColor = Color.DodgerBlue;
            button_Delete.ForeColor = Color.DodgerBlue;
            button_Delete.BackColor = Color.White;

            if (ID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập ID sản phẩm hoặc chọn ID sản phẩm").ShowDialog();
                return;
            }

            if (name_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập tên sản phẩm").ShowDialog();
                return;
            }

            // Check if name is already exist
            string query = "SELECT * FROM Depot WHERE NameProduct = '" + name_Textbox.Text + "'";
            if (!DatabaseConnection.Instance.CheckExist(query))
            {
                new CustomMessageBox("Sản phẩm không tồn tại").ShowDialog();
                return;
            }

            if (quantity_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập số lượng sản phẩm").ShowDialog();
                return;
            }

            if (price_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập giá sản phẩm").ShowDialog();
                return;
            }

            // update thông qua ID
            query = "UPDATE Depot SET Quantity = '" + quantity_Textbox.Text + "', Price = '" + price_Textbox.Text + "' WHERE ID = '" + ID_Textbox.Text + "'";
            DatabaseConnection.Instance.ExecuteNonQuery(query);

            DataTable wareHouseData = DatabaseConnection.Instance.ReadToDataTable("SELECT * FROM Depot");
            dataGridView_Product.DataSource = wareHouseData;
            label_All.Text = wareHouseData.Rows.Count.ToString();
            comboBox_ID.Items.Clear();
            foreach (DataRow row in wareHouseData.Rows)
            {
                comboBox_ID.Items.Add(row["ID"]);
            }

            new CustomMessageBox("Cập nhật sản phẩm thành công").ShowDialog();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Show();
            panel_Update.Hide();
            button_Add.ForeColor = Color.DodgerBlue;
            button_Add.BackColor = Color.White;
            button_Change.ForeColor = Color.DodgerBlue;
            button_Change.BackColor = Color.White;
            button_Delete.ForeColor = Color.White;
            button_Delete.BackColor = Color.DodgerBlue;

            if (ID_Textbox.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập ID sản phẩm hoặc chọn ID sản phẩm").ShowDialog();
                return;
            }

            // Check if name is already exist
            string query = "SELECT * FROM Depot WHERE ID = '" + ID_Textbox.Text + "'";
            if (!DatabaseConnection.Instance.CheckExist(query))
            {
                new CustomMessageBox("Sản phẩm không tồn tại").ShowDialog();
                return;
            }

            // delete thông qua ID
            query = "DELETE FROM Depot WHERE ID = '" + ID_Textbox.Text + "'";

            DatabaseConnection.Instance.ExecuteNonQuery(query);

            DataTable wareHouseData = DatabaseConnection.Instance.ReadToDataTable("SELECT * FROM Depot");

            // reset the auto increment ID
            query = "UPDATE sqlite_sequence SET seq = " + (wareHouseData.Rows.Count) + " WHERE name = 'Depot'";
            DatabaseConnection.Instance.ExecuteNonQuery(query);

            // update lại ID
            query = "UPDATE Depot SET ID = ID - 1 WHERE ID > " + ID_Textbox.Text;
            DatabaseConnection.Instance.ExecuteNonQuery(query);

            dataGridView_Product.DataSource = wareHouseData;
            label_All.Text = wareHouseData.Rows.Count.ToString();
            comboBox_ID.Items.Clear();
            foreach (DataRow row in wareHouseData.Rows)
            {
                comboBox_ID.Items.Add(row["ID"]);
            }

            new CustomMessageBox("Xóa sản phẩm thành công").ShowDialog();
        }

        private void button_Add_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Delete.Hide();
            panel_Update.Hide();
            panel_Add.Show();
        }

        private void button_Change_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Hide();
            panel_Update.Show();
        }

        private void button_Delete_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Show();
            panel_Update.Hide();
        }

        private void panel_Controls_Click(object sender, EventArgs e)
        {
            button_Delete.ForeColor = Color.White;
            button_Delete.BackColor = Color.DodgerBlue;
            button_Change.ForeColor = Color.White;
            button_Change.BackColor = Color.DodgerBlue;
            button_Add.ForeColor = Color.White;
            button_Add.BackColor = Color.DodgerBlue;
        }

        private void dataGridView_Product_Click(object sender, EventArgs e)
        {

            if (dataGridView_Product.Rows.Count == 0)
                return;

            Console.WriteLine(dataGridView_Product.Rows[dataGridView_Product.CurrentCell.RowIndex].Cells[0].Value.ToString());
            ID_Textbox.Text = dataGridView_Product.Rows[dataGridView_Product.CurrentCell.RowIndex].Cells[0].Value.ToString();
            name_Textbox.Text = dataGridView_Product.Rows[dataGridView_Product.CurrentCell.RowIndex].Cells[1].Value.ToString();
            quantity_Textbox.Text = dataGridView_Product.Rows[dataGridView_Product.CurrentCell.RowIndex].Cells[2].Value.ToString();
            price_Textbox.Text = dataGridView_Product.Rows[dataGridView_Product.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            // search by name or ID
            string query = "SELECT * FROM Depot WHERE NameProduct LIKE '%" + searchBar.Text + "%' OR ID LIKE '%" + searchBar.Text + "%'";
            DataTable wareHouseData = DatabaseConnection.Instance.ReadToDataTable(query);
            dataGridView_Product.DataSource = wareHouseData;
            label_All.Text = wareHouseData.Rows.Count.ToString();
        }
    }
}
