namespace PetStoreManagementApp.Pages
{
    partial class form_WareHouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label_All = new Label();
            label_Allproduct = new Label();
            label_Ware = new Label();
            pictureBox1 = new PictureBox();
            label_OverView = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            searchBar = new TextBox();
            panel_Controls = new Panel();
            panel_Update = new Panel();
            panel_Delete = new Panel();
            panel_Add = new Panel();
            button_Change = new Button();
            button_Delete = new Button();
            button_Add = new Button();
            ID_Textbox = new TextBox();
            comboBox_ID = new ComboBox();
            label_ID = new Label();
            price_Textbox = new TextBox();
            quantity_Textbox = new TextBox();
            name_Textbox = new TextBox();
            label_Price = new Label();
            label_Quantity = new Label();
            label_Name = new Label();
            panel4 = new Panel();
            dataGridView_Product = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_Controls.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Product).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label_All);
            panel1.Controls.Add(label_Allproduct);
            panel1.Controls.Add(label_Ware);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_OverView);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 541);
            panel1.TabIndex = 0;
            // 
            // label_All
            // 
            label_All.AutoSize = true;
            label_All.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label_All.ForeColor = Color.White;
            label_All.Location = new Point(70, 114);
            label_All.Name = "label_All";
            label_All.Size = new Size(65, 37);
            label_All.TabIndex = 8;
            label_All.Text = "488";
            // 
            // label_Allproduct
            // 
            label_Allproduct.AutoSize = true;
            label_Allproduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Allproduct.ForeColor = Color.White;
            label_Allproduct.Location = new Point(26, 93);
            label_Allproduct.Name = "label_Allproduct";
            label_Allproduct.Size = new Size(100, 21);
            label_Allproduct.TabIndex = 7;
            label_Allproduct.Text = "all products";
            // 
            // label_Ware
            // 
            label_Ware.AutoSize = true;
            label_Ware.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_Ware.ForeColor = Color.White;
            label_Ware.Location = new Point(27, 489);
            label_Ware.Name = "label_Ware";
            label_Ware.Size = new Size(109, 28);
            label_Ware.TabIndex = 1;
            label_Ware.Text = "Warehouse";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(42, 444);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label_OverView
            // 
            label_OverView.AutoSize = true;
            label_OverView.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_OverView.ForeColor = Color.White;
            label_OverView.Location = new Point(21, 49);
            label_OverView.Name = "label_OverView";
            label_OverView.Size = new Size(127, 29);
            label_OverView.TabIndex = 0;
            label_OverView.Text = "Over View";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(searchBar);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 52);
            panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(514, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(283, 12);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(225, 23);
            searchBar.TabIndex = 6;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // panel_Controls
            // 
            panel_Controls.BackColor = Color.White;
            panel_Controls.Controls.Add(panel_Update);
            panel_Controls.Controls.Add(panel_Delete);
            panel_Controls.Controls.Add(panel_Add);
            panel_Controls.Controls.Add(button_Change);
            panel_Controls.Controls.Add(button_Delete);
            panel_Controls.Controls.Add(button_Add);
            panel_Controls.Controls.Add(ID_Textbox);
            panel_Controls.Controls.Add(comboBox_ID);
            panel_Controls.Controls.Add(label_ID);
            panel_Controls.Controls.Add(price_Textbox);
            panel_Controls.Controls.Add(quantity_Textbox);
            panel_Controls.Controls.Add(name_Textbox);
            panel_Controls.Controls.Add(label_Price);
            panel_Controls.Controls.Add(label_Quantity);
            panel_Controls.Controls.Add(label_Name);
            panel_Controls.Location = new Point(0, 404);
            panel_Controls.Name = "panel_Controls";
            panel_Controls.Size = new Size(590, 132);
            panel_Controls.TabIndex = 1;
            panel_Controls.Click += panel_Controls_Click;
            // 
            // panel_Update
            // 
            panel_Update.BackColor = Color.DodgerBlue;
            panel_Update.Location = new Point(433, 119);
            panel_Update.Name = "panel_Update";
            panel_Update.Size = new Size(75, 2);
            panel_Update.TabIndex = 37;
            panel_Update.Visible = false;
            // 
            // panel_Delete
            // 
            panel_Delete.BackColor = Color.DodgerBlue;
            panel_Delete.Location = new Point(514, 119);
            panel_Delete.Name = "panel_Delete";
            panel_Delete.Size = new Size(68, 2);
            panel_Delete.TabIndex = 41;
            panel_Delete.Visible = false;
            // 
            // panel_Add
            // 
            panel_Add.BackColor = Color.DodgerBlue;
            panel_Add.Location = new Point(374, 119);
            panel_Add.Name = "panel_Add";
            panel_Add.Size = new Size(53, 2);
            panel_Add.TabIndex = 36;
            // 
            // button_Change
            // 
            button_Change.FlatAppearance.BorderSize = 0;
            button_Change.FlatStyle = FlatStyle.Flat;
            button_Change.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_Change.ForeColor = Color.DodgerBlue;
            button_Change.Location = new Point(433, 85);
            button_Change.Name = "button_Change";
            button_Change.Size = new Size(75, 28);
            button_Change.TabIndex = 40;
            button_Change.Text = "UPDATE";
            button_Change.UseVisualStyleBackColor = true;
            button_Change.Click += button_Change_Click;
            button_Change.MouseMove += button_Change_MouseMove;
            // 
            // button_Delete
            // 
            button_Delete.FlatAppearance.BorderSize = 0;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_Delete.ForeColor = Color.DodgerBlue;
            button_Delete.Location = new Point(514, 85);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(68, 28);
            button_Delete.TabIndex = 39;
            button_Delete.Text = "DELETE";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            button_Delete.MouseMove += button_Delete_MouseMove;
            // 
            // button_Add
            // 
            button_Add.FlatAppearance.BorderSize = 0;
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.ForeColor = Color.DodgerBlue;
            button_Add.Location = new Point(374, 85);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(53, 28);
            button_Add.TabIndex = 38;
            button_Add.Text = "ADD";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            button_Add.MouseMove += button_Add_MouseMove;
            // 
            // ID_Textbox
            // 
            ID_Textbox.BackColor = Color.LightGray;
            ID_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ID_Textbox.Location = new Point(137, 12);
            ID_Textbox.Name = "ID_Textbox";
            ID_Textbox.Size = new Size(69, 23);
            ID_Textbox.TabIndex = 35;
            // 
            // comboBox_ID
            // 
            comboBox_ID.BackColor = Color.LightGray;
            comboBox_ID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_ID.FormattingEnabled = true;
            comboBox_ID.Location = new Point(238, 12);
            comboBox_ID.Name = "comboBox_ID";
            comboBox_ID.Size = new Size(81, 23);
            comboBox_ID.TabIndex = 34;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_ID.Location = new Point(86, 9);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(36, 25);
            label_ID.TabIndex = 33;
            label_ID.Text = "ID:";
            // 
            // price_Textbox
            // 
            price_Textbox.BackColor = Color.LightGray;
            price_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            price_Textbox.Location = new Point(137, 93);
            price_Textbox.Name = "price_Textbox";
            price_Textbox.Size = new Size(182, 23);
            price_Textbox.TabIndex = 32;
            // 
            // quantity_Textbox
            // 
            quantity_Textbox.BackColor = Color.LightGray;
            quantity_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            quantity_Textbox.Location = new Point(137, 64);
            quantity_Textbox.Name = "quantity_Textbox";
            quantity_Textbox.Size = new Size(182, 23);
            quantity_Textbox.TabIndex = 31;
            // 
            // name_Textbox
            // 
            name_Textbox.BackColor = Color.LightGray;
            name_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            name_Textbox.Location = new Point(137, 35);
            name_Textbox.Name = "name_Textbox";
            name_Textbox.Size = new Size(182, 23);
            name_Textbox.TabIndex = 30;
            // 
            // label_Price
            // 
            label_Price.AutoSize = true;
            label_Price.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_Price.Location = new Point(55, 90);
            label_Price.Name = "label_Price";
            label_Price.Size = new Size(59, 25);
            label_Price.TabIndex = 29;
            label_Price.Text = "Price:";
            // 
            // label_Quantity
            // 
            label_Quantity.AutoSize = true;
            label_Quantity.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_Quantity.Location = new Point(30, 61);
            label_Quantity.Name = "label_Quantity";
            label_Quantity.Size = new Size(92, 25);
            label_Quantity.TabIndex = 28;
            label_Quantity.Text = "Quantity:";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_Name.Location = new Point(55, 32);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(67, 25);
            label_Name.TabIndex = 27;
            label_Name.Text = "Name:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView_Product);
            panel4.Controls.Add(panel_Controls);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(181, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(590, 536);
            panel4.TabIndex = 2;
            // 
            // dataGridView_Product
            // 
            dataGridView_Product.AllowUserToAddRows = false;
            dataGridView_Product.AllowUserToDeleteRows = false;
            dataGridView_Product.AllowUserToResizeColumns = false;
            dataGridView_Product.AllowUserToResizeRows = false;
            dataGridView_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Product.Location = new Point(2, 49);
            dataGridView_Product.MultiSelect = false;
            dataGridView_Product.Name = "dataGridView_Product";
            dataGridView_Product.ReadOnly = true;
            dataGridView_Product.RowTemplate.Height = 25;
            dataGridView_Product.ScrollBars = ScrollBars.Vertical;
            dataGridView_Product.ShowEditingIcon = false;
            dataGridView_Product.Size = new Size(588, 358);
            dataGridView_Product.TabIndex = 2;
            dataGridView_Product.Click += dataGridView_Product_Click;
            // 
            // form_WareHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 541);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_WareHouse";
            Text = "Ware_House";
            Load += Ware_House_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_Controls.ResumeLayout(false);
            panel_Controls.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Product).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_OverView;
        private PictureBox pictureBox1;
        private Label label_All;
        private Label label_Allproduct;
        private Label label_Ware;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox searchBar;
        private Panel panel_Controls;
        private Panel panel_Update;
        private Panel panel_Delete;
        private Panel panel_Add;
        private Button button_Change;
        private Button button_Delete;
        private Button button_Add;
        private TextBox ID_Textbox;
        private ComboBox comboBox_ID;
        private Label label_ID;
        private TextBox price_Textbox;
        private TextBox quantity_Textbox;
        private TextBox name_Textbox;
        private Label label_Price;
        private Label label_Quantity;
        private Label label_Name;
        private Panel panel4;
        private DataGridView dataGridView_Product;
    }
}