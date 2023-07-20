namespace PetStoreManagementApp.Pages
{
    partial class form_PetManager
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
            panel_Update = new Panel();
            panel_Delete = new Panel();
            panel_Add = new Panel();
            button_Change = new Button();
            button_Delete = new Button();
            button_Add = new Button();
            ownerID_Textbox = new TextBox();
            ID_Textbox = new TextBox();
            ID_ComboBox = new ComboBox();
            label4 = new Label();
            label_ID = new Label();
            phone_Textbox = new TextBox();
            type_Textbox = new TextBox();
            email_Textbox = new TextBox();
            age_Textbox = new TextBox();
            lastName_Textbox = new TextBox();
            firstName_Textbox = new TextBox();
            label3 = new Label();
            fullName_Textbox = new TextBox();
            label2 = new Label();
            label_Price = new Label();
            label1 = new Label();
            label_Quantity = new Label();
            label_Name = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            searchBar = new TextBox();
            label_All = new Label();
            label_Allproduct = new Label();
            label_Ware = new Label();
            pictureBox1 = new PictureBox();
            label_OverView = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel4.SuspendLayout();
            panel_Controls.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            dataGridView.Location = new Point(1, 49);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.ScrollBars = ScrollBars.Vertical;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(588, 265);
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
            panel_Controls.Controls.Add(panel_Update);
            panel_Controls.Controls.Add(panel_Delete);
            panel_Controls.Controls.Add(panel_Add);
            panel_Controls.Controls.Add(button_Change);
            panel_Controls.Controls.Add(button_Delete);
            panel_Controls.Controls.Add(button_Add);
            panel_Controls.Controls.Add(ownerID_Textbox);
            panel_Controls.Controls.Add(ID_Textbox);
            panel_Controls.Controls.Add(ID_ComboBox);
            panel_Controls.Controls.Add(label4);
            panel_Controls.Controls.Add(label_ID);
            panel_Controls.Controls.Add(phone_Textbox);
            panel_Controls.Controls.Add(type_Textbox);
            panel_Controls.Controls.Add(email_Textbox);
            panel_Controls.Controls.Add(age_Textbox);
            panel_Controls.Controls.Add(lastName_Textbox);
            panel_Controls.Controls.Add(firstName_Textbox);
            panel_Controls.Controls.Add(label3);
            panel_Controls.Controls.Add(fullName_Textbox);
            panel_Controls.Controls.Add(label2);
            panel_Controls.Controls.Add(label_Price);
            panel_Controls.Controls.Add(label1);
            panel_Controls.Controls.Add(label_Quantity);
            panel_Controls.Controls.Add(label_Name);
            panel_Controls.Location = new Point(0, 314);
            panel_Controls.Name = "panel_Controls";
            panel_Controls.Size = new Size(590, 227);
            panel_Controls.TabIndex = 1;
            // 
            // panel_Update
            // 
            panel_Update.BackColor = Color.DodgerBlue;
            panel_Update.Location = new Point(401, 209);
            panel_Update.Name = "panel_Update";
            panel_Update.Size = new Size(75, 2);
            panel_Update.TabIndex = 37;
            panel_Update.Visible = false;
            // 
            // panel_Delete
            // 
            panel_Delete.BackColor = Color.DodgerBlue;
            panel_Delete.Location = new Point(482, 209);
            panel_Delete.Name = "panel_Delete";
            panel_Delete.Size = new Size(68, 2);
            panel_Delete.TabIndex = 41;
            panel_Delete.Visible = false;
            // 
            // panel_Add
            // 
            panel_Add.BackColor = Color.DodgerBlue;
            panel_Add.Location = new Point(342, 209);
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
            button_Change.Location = new Point(401, 175);
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
            button_Delete.Location = new Point(482, 175);
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
            button_Add.Location = new Point(342, 175);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(53, 28);
            button_Add.TabIndex = 38;
            button_Add.Text = "ADD";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // ownerID_Textbox
            // 
            ownerID_Textbox.BackColor = Color.LightGray;
            ownerID_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ownerID_Textbox.Location = new Point(401, 31);
            ownerID_Textbox.Name = "ownerID_Textbox";
            ownerID_Textbox.Size = new Size(76, 23);
            ownerID_Textbox.TabIndex = 35;
            // 
            // ID_Textbox
            // 
            ID_Textbox.BackColor = Color.LightGray;
            ID_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ID_Textbox.Location = new Point(116, 28);
            ID_Textbox.Name = "ID_Textbox";
            ID_Textbox.Size = new Size(71, 23);
            ID_Textbox.TabIndex = 35;
            // 
            // ID_ComboBox
            // 
            ID_ComboBox.BackColor = Color.LightGray;
            ID_ComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ID_ComboBox.FormattingEnabled = true;
            ID_ComboBox.Location = new Point(193, 28);
            ID_ComboBox.Name = "ID_ComboBox";
            ID_ComboBox.Size = new Size(72, 23);
            ID_ComboBox.TabIndex = 34;
            ID_ComboBox.SelectedIndexChanged += ID_ComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(293, 31);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 33;
            label4.Text = "Owner ID:";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_ID.Location = new Point(35, 28);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(36, 25);
            label_ID.TabIndex = 33;
            label_ID.Text = "ID:";
            // 
            // phone_Textbox
            // 
            phone_Textbox.BackColor = Color.LightGray;
            phone_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phone_Textbox.Location = new Point(401, 89);
            phone_Textbox.Name = "phone_Textbox";
            phone_Textbox.ReadOnly = true;
            phone_Textbox.Size = new Size(158, 23);
            phone_Textbox.TabIndex = 32;
            // 
            // type_Textbox
            // 
            type_Textbox.BackColor = Color.LightGray;
            type_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            type_Textbox.Location = new Point(114, 86);
            type_Textbox.Name = "type_Textbox";
            type_Textbox.Size = new Size(151, 23);
            type_Textbox.TabIndex = 32;
            // 
            // email_Textbox
            // 
            email_Textbox.BackColor = Color.LightGray;
            email_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            email_Textbox.Location = new Point(401, 118);
            email_Textbox.Name = "email_Textbox";
            email_Textbox.ReadOnly = true;
            email_Textbox.Size = new Size(158, 23);
            email_Textbox.TabIndex = 31;
            // 
            // age_Textbox
            // 
            age_Textbox.BackColor = Color.LightGray;
            age_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            age_Textbox.Location = new Point(114, 115);
            age_Textbox.Name = "age_Textbox";
            age_Textbox.Size = new Size(151, 23);
            age_Textbox.TabIndex = 31;
            // 
            // lastName_Textbox
            // 
            lastName_Textbox.BackColor = Color.LightGray;
            lastName_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_Textbox.Location = new Point(483, 60);
            lastName_Textbox.Name = "lastName_Textbox";
            lastName_Textbox.ReadOnly = true;
            lastName_Textbox.Size = new Size(76, 23);
            lastName_Textbox.TabIndex = 30;
            // 
            // firstName_Textbox
            // 
            firstName_Textbox.BackColor = Color.LightGray;
            firstName_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            firstName_Textbox.Location = new Point(401, 60);
            firstName_Textbox.Name = "firstName_Textbox";
            firstName_Textbox.ReadOnly = true;
            firstName_Textbox.Size = new Size(76, 23);
            firstName_Textbox.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(314, 89);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 29;
            label3.Text = "Phone:";
            // 
            // fullName_Textbox
            // 
            fullName_Textbox.BackColor = Color.LightGray;
            fullName_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fullName_Textbox.Location = new Point(114, 57);
            fullName_Textbox.Name = "fullName_Textbox";
            fullName_Textbox.Size = new Size(151, 23);
            fullName_Textbox.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(327, 118);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 28;
            label2.Text = "Email:";
            // 
            // label_Price
            // 
            label_Price.AutoSize = true;
            label_Price.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_Price.Location = new Point(21, 86);
            label_Price.Name = "label_Price";
            label_Price.Size = new Size(58, 25);
            label_Price.TabIndex = 29;
            label_Price.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 60);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 27;
            label1.Text = "Full Name:";
            // 
            // label_Quantity
            // 
            label_Quantity.AutoSize = true;
            label_Quantity.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_Quantity.Location = new Point(28, 115);
            label_Quantity.Name = "label_Quantity";
            label_Quantity.Size = new Size(51, 25);
            label_Quantity.TabIndex = 28;
            label_Quantity.Text = "Age:";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_Name.Location = new Point(6, 57);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(102, 25);
            label_Name.TabIndex = 27;
            label_Name.Text = "Full Name:";
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
            pictureBox2.Location = new Point(515, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(284, 12);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(225, 23);
            searchBar.TabIndex = 6;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // label_All
            // 
            label_All.AutoSize = true;
            label_All.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label_All.ForeColor = Color.White;
            label_All.Location = new Point(76, 114);
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
            label_Allproduct.Location = new Point(35, 93);
            label_Allproduct.Name = "label_Allproduct";
            label_Allproduct.Size = new Size(84, 21);
            label_Allproduct.TabIndex = 7;
            label_Allproduct.Text = "Total Pets";
            // 
            // label_Ware
            // 
            label_Ware.AutoSize = true;
            label_Ware.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_Ware.ForeColor = Color.White;
            label_Ware.Location = new Point(32, 489);
            label_Ware.Name = "label_Ware";
            label_Ware.Size = new Size(122, 28);
            label_Ware.TabIndex = 1;
            label_Ware.Text = "Pet Manager";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(49, 444);
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
            // form_PetManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 541);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_PetManager";
            Text = "form_PetManager";
            Load += form_PetManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel4.ResumeLayout(false);
            panel_Controls.ResumeLayout(false);
            panel_Controls.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox type_Textbox;
        private TextBox age_Textbox;
        private TextBox fullName_Textbox;
        private Label label_Price;
        private Label label_Quantity;
        private Label label_Name;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox searchBar;
        private Label label_All;
        private Label label_Allproduct;
        private Label label_Ware;
        private PictureBox pictureBox1;
        private Label label_OverView;
        private Panel panel1;
        private TextBox ownerID_Textbox;
        private Label label4;
        private TextBox phone_Textbox;
        private TextBox email_Textbox;
        private TextBox lastName_Textbox;
        private TextBox firstName_Textbox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}