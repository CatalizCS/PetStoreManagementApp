namespace PetStoreManagementApp.Pages
{
    partial class form_Customer
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
            dataGridView = new DataGridView();
            panel4 = new Panel();
            panel_Controls = new Panel();
            avatar = new CircularPictureBox();
            panel_Update = new Panel();
            panel_Delete = new Panel();
            panel_Add = new Panel();
            button_Change = new Button();
            button_Delete = new Button();
            button_Add = new Button();
            ID_Textbox = new TextBox();
            ID_ComboBox = new ComboBox();
            label_ID = new Label();
            age_textBox = new TextBox();
            lastName_TextBox = new TextBox();
            email_TextBox = new TextBox();
            phone_TextBox = new TextBox();
            firstName_TextBox = new TextBox();
            label1 = new Label();
            label_Price = new Label();
            label_Quantity = new Label();
            label_Name = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            searchBar = new TextBox();
            panel1 = new Panel();
            label_All = new Label();
            label_Allproduct = new Label();
            label_Ware = new Label();
            pictureBox1 = new PictureBox();
            label_OverView = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel4.SuspendLayout();
            panel_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(2, 49);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.ScrollBars = ScrollBars.Vertical;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(588, 288);
            dataGridView.TabIndex = 2;
            dataGridView.Click += dataGridView_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView);
            panel4.Controls.Add(panel_Controls);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(181, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(590, 536);
            panel4.TabIndex = 4;
            // 
            // panel_Controls
            // 
            panel_Controls.BackColor = Color.White;
            panel_Controls.Controls.Add(avatar);
            panel_Controls.Controls.Add(panel_Update);
            panel_Controls.Controls.Add(panel_Delete);
            panel_Controls.Controls.Add(panel_Add);
            panel_Controls.Controls.Add(button_Change);
            panel_Controls.Controls.Add(button_Delete);
            panel_Controls.Controls.Add(button_Add);
            panel_Controls.Controls.Add(ID_Textbox);
            panel_Controls.Controls.Add(ID_ComboBox);
            panel_Controls.Controls.Add(label_ID);
            panel_Controls.Controls.Add(age_textBox);
            panel_Controls.Controls.Add(lastName_TextBox);
            panel_Controls.Controls.Add(email_TextBox);
            panel_Controls.Controls.Add(phone_TextBox);
            panel_Controls.Controls.Add(firstName_TextBox);
            panel_Controls.Controls.Add(label1);
            panel_Controls.Controls.Add(label_Price);
            panel_Controls.Controls.Add(label_Quantity);
            panel_Controls.Controls.Add(label_Name);
            panel_Controls.Location = new Point(0, 337);
            panel_Controls.Name = "panel_Controls";
            panel_Controls.Size = new Size(590, 199);
            panel_Controls.TabIndex = 1;
            // 
            // avatar
            // 
            avatar.Image = Properties.Resources.user_24px;
            avatar.Location = new Point(427, 12);
            avatar.Name = "avatar";
            avatar.Size = new Size(110, 100);
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
            avatar.TabIndex = 42;
            avatar.TabStop = false;
            avatar.Click += avatar_Image_Click;
            // 
            // panel_Update
            // 
            panel_Update.BackColor = Color.DodgerBlue;
            panel_Update.Location = new Point(427, 186);
            panel_Update.Name = "panel_Update";
            panel_Update.Size = new Size(75, 2);
            panel_Update.TabIndex = 37;
            panel_Update.Visible = false;
            // 
            // panel_Delete
            // 
            panel_Delete.BackColor = Color.DodgerBlue;
            panel_Delete.Location = new Point(508, 186);
            panel_Delete.Name = "panel_Delete";
            panel_Delete.Size = new Size(68, 2);
            panel_Delete.TabIndex = 41;
            panel_Delete.Visible = false;
            // 
            // panel_Add
            // 
            panel_Add.BackColor = Color.DodgerBlue;
            panel_Add.Location = new Point(368, 186);
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
            button_Change.Location = new Point(427, 152);
            button_Change.Name = "button_Change";
            button_Change.Size = new Size(75, 28);
            button_Change.TabIndex = 40;
            button_Change.Text = "UPDATE";
            button_Change.UseVisualStyleBackColor = true;
            button_Change.Click += button_Change_Click;
            // 
            // button_Delete
            // 
            button_Delete.FlatAppearance.BorderSize = 0;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_Delete.ForeColor = Color.DodgerBlue;
            button_Delete.Location = new Point(508, 152);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(68, 28);
            button_Delete.TabIndex = 39;
            button_Delete.Text = "DELETE";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Add
            // 
            button_Add.FlatAppearance.BorderSize = 0;
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.ForeColor = Color.DodgerBlue;
            button_Add.Location = new Point(368, 152);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(53, 28);
            button_Add.TabIndex = 38;
            button_Add.Text = "ADD";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // ID_Textbox
            // 
            ID_Textbox.BackColor = Color.LightGray;
            ID_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ID_Textbox.Location = new Point(123, 12);
            ID_Textbox.Name = "ID_Textbox";
            ID_Textbox.Size = new Size(97, 23);
            ID_Textbox.TabIndex = 35;
            // 
            // ID_ComboBox
            // 
            ID_ComboBox.BackColor = Color.LightGray;
            ID_ComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ID_ComboBox.FormattingEnabled = true;
            ID_ComboBox.Location = new Point(226, 12);
            ID_ComboBox.Name = "ID_ComboBox";
            ID_ComboBox.Size = new Size(97, 23);
            ID_ComboBox.TabIndex = 34;
            ID_ComboBox.SelectedIndexChanged += ID_ComboBox_SelectedIndexChanged;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_ID.Location = new Point(72, 12);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(36, 25);
            label_ID.TabIndex = 33;
            label_ID.Text = "ID:";
            // 
            // age_textBox
            // 
            age_textBox.BackColor = Color.LightGray;
            age_textBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            age_textBox.Location = new Point(123, 126);
            age_textBox.Name = "age_textBox";
            age_textBox.Size = new Size(56, 23);
            age_textBox.TabIndex = 32;
            // 
            // lastName_TextBox
            // 
            lastName_TextBox.BackColor = Color.LightGray;
            lastName_TextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_TextBox.Location = new Point(226, 42);
            lastName_TextBox.Name = "lastName_TextBox";
            lastName_TextBox.Size = new Size(97, 23);
            lastName_TextBox.TabIndex = 30;
            // 
            // email_TextBox
            // 
            email_TextBox.BackColor = Color.LightGray;
            email_TextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            email_TextBox.Location = new Point(123, 99);
            email_TextBox.Name = "email_TextBox";
            email_TextBox.Size = new Size(200, 23);
            email_TextBox.TabIndex = 31;
            // 
            // phone_TextBox
            // 
            phone_TextBox.BackColor = Color.LightGray;
            phone_TextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phone_TextBox.Location = new Point(123, 70);
            phone_TextBox.Name = "phone_TextBox";
            phone_TextBox.Size = new Size(200, 23);
            phone_TextBox.TabIndex = 31;
            // 
            // firstName_TextBox
            // 
            firstName_TextBox.BackColor = Color.LightGray;
            firstName_TextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            firstName_TextBox.Location = new Point(123, 42);
            firstName_TextBox.Name = "firstName_TextBox";
            firstName_TextBox.Size = new Size(97, 23);
            firstName_TextBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 99);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 28;
            label1.Text = "Email:";
            // 
            // label_Price
            // 
            label_Price.AutoSize = true;
            label_Price.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_Price.Location = new Point(57, 126);
            label_Price.Name = "label_Price";
            label_Price.Size = new Size(51, 25);
            label_Price.TabIndex = 29;
            label_Price.Text = "Age:";
            // 
            // label_Quantity
            // 
            label_Quantity.AutoSize = true;
            label_Quantity.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_Quantity.Location = new Point(37, 70);
            label_Quantity.Name = "label_Quantity";
            label_Quantity.Size = new Size(71, 25);
            label_Quantity.TabIndex = 28;
            label_Quantity.Text = "Phone:";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_Name.Location = new Point(41, 42);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(67, 25);
            label_Name.TabIndex = 27;
            label_Name.Text = "Name:";
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
            pictureBox2.Location = new Point(517, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(286, 12);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(225, 23);
            searchBar.TabIndex = 6;
            searchBar.TextChanged += searchBar_TextChanged;
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
            panel1.TabIndex = 3;
            // 
            // label_All
            // 
            label_All.AutoSize = true;
            label_All.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label_All.ForeColor = Color.White;
            label_All.Location = new Point(76, 116);
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
            label_Allproduct.Location = new Point(21, 95);
            label_Allproduct.Name = "label_Allproduct";
            label_Allproduct.Size = new Size(132, 21);
            label_Allproduct.TabIndex = 7;
            label_Allproduct.Text = "Total Customers";
            // 
            // label_Ware
            // 
            label_Ware.AutoSize = true;
            label_Ware.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_Ware.ForeColor = Color.White;
            label_Ware.Location = new Point(31, 489);
            label_Ware.Name = "label_Ware";
            label_Ware.Size = new Size(96, 28);
            label_Ware.TabIndex = 1;
            label_Ware.Text = "Customer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(41, 444);
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
            label_OverView.Size = new Size(120, 29);
            label_OverView.TabIndex = 0;
            label_OverView.Text = "OverView";
            // 
            // form_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 541);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Customer";
            Text = "form_Customer";
            Load += form_Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel4.ResumeLayout(false);
            panel_Controls.ResumeLayout(false);
            panel_Controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Panel panel4;
        private Panel panel_Controls;
        private Panel panel_Update;
        private Panel panel_Delete;
        private Panel panel_Add;
        private Button button_Change;
        private Button button_Delete;
        private Button button_Add;
        private TextBox ID_Textbox;
        private ComboBox ID_ComboBox;
        private Label label_ID;
        private TextBox age_textBox;
        private TextBox phone_TextBox;
        private TextBox firstName_TextBox;
        private Label label_Price;
        private Label label_Quantity;
        private Label label_Name;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox searchBar;
        private Panel panel1;
        private Label label_All;
        private Label label_Allproduct;
        private Label label_Ware;
        private PictureBox pictureBox1;
        private Label label_OverView;
        private CircularPictureBox avatar;
        private TextBox lastName_TextBox;
        private TextBox email_TextBox;
        private Label label1;
    }
}