namespace PetStoreManagementApp.Pages
{
    partial class Form_Setting_Admin
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
            pictureBox_Close = new PictureBox();
            label_Review = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button_Seedetial = new Button();
            pictureBox_Avata_Em = new PictureBox();
            pictureBox1 = new PictureBox();
            comboBox_NameEm = new ComboBox();
            label_NameEm = new Label();
            comboBox_IDem = new ComboBox();
            label_IDEm = new Label();
            label1 = new Label();
            dataGridView_ListEm = new DataGridView();
            panel3 = new Panel();
            panel_Update = new Panel();
            panel_Delete = new Panel();
            panel_Add = new Panel();
            button_Change = new Button();
            button_Delete = new Button();
            button_Add = new Button();
            comboBox_ID_Employee = new ComboBox();
            label_ID = new Label();
            textBox_Pass = new TextBox();
            textBox_Email = new TextBox();
            textBox_Age = new TextBox();
            textBox_Phone = new TextBox();
            textBox_LName = new TextBox();
            textBox_FName = new TextBox();
            label_Pass = new Label();
            label_Age = new Label();
            label_Phone = new Label();
            label_Email = new Label();
            label_LastName = new Label();
            label_FName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Close).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Avata_Em).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ListEm).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_Close
            // 
            pictureBox_Close.Image = Properties.Resources.close;
            pictureBox_Close.Location = new Point(726, 3);
            pictureBox_Close.Name = "pictureBox_Close";
            pictureBox_Close.Size = new Size(29, 29);
            pictureBox_Close.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Close.TabIndex = 14;
            pictureBox_Close.TabStop = false;
            pictureBox_Close.Click += pictureBox_Close_Click;
            // 
            // label_Review
            // 
            label_Review.AutoSize = true;
            label_Review.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_Review.Location = new Point(11, 7);
            label_Review.Name = "label_Review";
            label_Review.Size = new Size(181, 28);
            label_Review.TabIndex = 0;
            label_Review.Text = "Employee Manager";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox_Close);
            panel1.Controls.Add(label_Review);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 38);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button_Seedetial);
            panel2.Controls.Add(pictureBox_Avata_Em);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(comboBox_NameEm);
            panel2.Controls.Add(label_NameEm);
            panel2.Controls.Add(comboBox_IDem);
            panel2.Controls.Add(label_IDEm);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView_ListEm);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 257);
            panel2.TabIndex = 5;
            // 
            // button_Seedetial
            // 
            button_Seedetial.BackColor = Color.DodgerBlue;
            button_Seedetial.FlatAppearance.BorderSize = 0;
            button_Seedetial.FlatStyle = FlatStyle.Flat;
            button_Seedetial.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_Seedetial.ForeColor = Color.White;
            button_Seedetial.Location = new Point(594, 153);
            button_Seedetial.Name = "button_Seedetial";
            button_Seedetial.Size = new Size(121, 36);
            button_Seedetial.TabIndex = 33;
            button_Seedetial.Text = "DETAIL";
            button_Seedetial.UseVisualStyleBackColor = false;
            // 
            // pictureBox_Avata_Em
            // 
            pictureBox_Avata_Em.Location = new Point(605, 20);
            pictureBox_Avata_Em.Name = "pictureBox_Avata_Em";
            pictureBox_Avata_Em.Size = new Size(100, 80);
            pictureBox_Avata_Em.TabIndex = 32;
            pictureBox_Avata_Em.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.refresh__1_;
            pictureBox1.Location = new Point(479, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox_NameEm
            // 
            comboBox_NameEm.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_NameEm.FormattingEnabled = true;
            comboBox_NameEm.Location = new Point(247, 42);
            comboBox_NameEm.Name = "comboBox_NameEm";
            comboBox_NameEm.Size = new Size(107, 25);
            comboBox_NameEm.TabIndex = 30;
            // 
            // label_NameEm
            // 
            label_NameEm.AutoSize = true;
            label_NameEm.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_NameEm.Location = new Point(199, 45);
            label_NameEm.Name = "label_NameEm";
            label_NameEm.Size = new Size(52, 19);
            label_NameEm.TabIndex = 29;
            label_NameEm.Text = "NAME ";
            // 
            // comboBox_IDem
            // 
            comboBox_IDem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_IDem.FormattingEnabled = true;
            comboBox_IDem.Location = new Point(66, 45);
            comboBox_IDem.Name = "comboBox_IDem";
            comboBox_IDem.Size = new Size(89, 25);
            comboBox_IDem.TabIndex = 28;
            // 
            // label_IDEm
            // 
            label_IDEm.AutoSize = true;
            label_IDEm.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_IDEm.Location = new Point(28, 42);
            label_IDEm.Name = "label_IDEm";
            label_IDEm.Size = new Size(23, 19);
            label_IDEm.TabIndex = 27;
            label_IDEm.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(11, 3);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 1;
            label1.Text = "Emloyee Record";
            // 
            // dataGridView_ListEm
            // 
            dataGridView_ListEm.BackgroundColor = Color.WhiteSmoke;
            dataGridView_ListEm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ListEm.Location = new Point(11, 80);
            dataGridView_ListEm.Name = "dataGridView_ListEm";
            dataGridView_ListEm.RowTemplate.Height = 25;
            dataGridView_ListEm.Size = new Size(496, 160);
            dataGridView_ListEm.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel_Update);
            panel3.Controls.Add(panel_Delete);
            panel3.Controls.Add(panel_Add);
            panel3.Controls.Add(button_Change);
            panel3.Controls.Add(button_Delete);
            panel3.Controls.Add(button_Add);
            panel3.Controls.Add(comboBox_ID_Employee);
            panel3.Controls.Add(label_ID);
            panel3.Controls.Add(textBox_Pass);
            panel3.Controls.Add(textBox_Email);
            panel3.Controls.Add(textBox_Age);
            panel3.Controls.Add(textBox_Phone);
            panel3.Controls.Add(textBox_LName);
            panel3.Controls.Add(textBox_FName);
            panel3.Controls.Add(label_Pass);
            panel3.Controls.Add(label_Age);
            panel3.Controls.Add(label_Phone);
            panel3.Controls.Add(label_Email);
            panel3.Controls.Add(label_LastName);
            panel3.Controls.Add(label_FName);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 284);
            panel3.Name = "panel3";
            panel3.Size = new Size(755, 218);
            panel3.TabIndex = 6;
            // 
            // panel_Update
            // 
            panel_Update.BackColor = Color.DodgerBlue;
            panel_Update.Location = new Point(468, 206);
            panel_Update.Name = "panel_Update";
            panel_Update.Size = new Size(141, 2);
            panel_Update.TabIndex = 20;
            panel_Update.Visible = false;
            // 
            // panel_Delete
            // 
            panel_Delete.BackColor = Color.DodgerBlue;
            panel_Delete.Location = new Point(616, 206);
            panel_Delete.Name = "panel_Delete";
            panel_Delete.Size = new Size(134, 2);
            panel_Delete.TabIndex = 30;
            panel_Delete.Visible = false;
            // 
            // panel_Add
            // 
            panel_Add.BackColor = Color.DodgerBlue;
            panel_Add.Location = new Point(343, 206);
            panel_Add.Name = "panel_Add";
            panel_Add.Size = new Size(119, 2);
            panel_Add.TabIndex = 19;
            // 
            // button_Change
            // 
            button_Change.FlatAppearance.BorderSize = 0;
            button_Change.FlatStyle = FlatStyle.Flat;
            button_Change.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_Change.ForeColor = Color.DodgerBlue;
            button_Change.Location = new Point(468, 160);
            button_Change.Name = "button_Change";
            button_Change.Size = new Size(141, 40);
            button_Change.TabIndex = 29;
            button_Change.Text = "UPDATE EMPLOYEE";
            button_Change.TextAlign = ContentAlignment.MiddleLeft;
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
            button_Delete.Location = new Point(616, 160);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(134, 40);
            button_Delete.TabIndex = 28;
            button_Delete.Text = "DELETE EMPLOYEE";
            button_Delete.TextAlign = ContentAlignment.MiddleLeft;
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
            button_Add.Location = new Point(343, 160);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(119, 40);
            button_Add.TabIndex = 27;
            button_Add.Text = "ADD EMPLOYEE";
            button_Add.TextAlign = ContentAlignment.MiddleLeft;
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            button_Add.MouseMove += button_Add_MouseMove;
            // 
            // comboBox_ID_Employee
            // 
            comboBox_ID_Employee.BackColor = Color.LightGray;
            comboBox_ID_Employee.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_ID_Employee.FormattingEnabled = true;
            comboBox_ID_Employee.Location = new Point(129, 124);
            comboBox_ID_Employee.Name = "comboBox_ID_Employee";
            comboBox_ID_Employee.Size = new Size(204, 25);
            comboBox_ID_Employee.TabIndex = 26;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_ID.Location = new Point(19, 127);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(95, 19);
            label_ID.TabIndex = 25;
            label_ID.Text = "ID EMPLOYEE";
            // 
            // textBox_Pass
            // 
            textBox_Pass.BackColor = Color.LightGray;
            textBox_Pass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Pass.Location = new Point(560, 95);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.Size = new Size(131, 25);
            textBox_Pass.TabIndex = 24;
            // 
            // textBox_Email
            // 
            textBox_Email.BackColor = Color.LightGray;
            textBox_Email.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(560, 56);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(131, 25);
            textBox_Email.TabIndex = 23;
            // 
            // textBox_Age
            // 
            textBox_Age.BackColor = Color.LightGray;
            textBox_Age.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Age.Location = new Point(129, 85);
            textBox_Age.Name = "textBox_Age";
            textBox_Age.Size = new Size(204, 25);
            textBox_Age.TabIndex = 22;
            // 
            // textBox_Phone
            // 
            textBox_Phone.BackColor = Color.LightGray;
            textBox_Phone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Phone.Location = new Point(560, 23);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(131, 25);
            textBox_Phone.TabIndex = 21;
            // 
            // textBox_LName
            // 
            textBox_LName.BackColor = Color.LightGray;
            textBox_LName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_LName.Location = new Point(130, 50);
            textBox_LName.Name = "textBox_LName";
            textBox_LName.Size = new Size(204, 25);
            textBox_LName.TabIndex = 20;
            // 
            // textBox_FName
            // 
            textBox_FName.BackColor = Color.LightGray;
            textBox_FName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_FName.Location = new Point(130, 17);
            textBox_FName.Name = "textBox_FName";
            textBox_FName.Size = new Size(204, 25);
            textBox_FName.TabIndex = 19;
            // 
            // label_Pass
            // 
            label_Pass.AutoSize = true;
            label_Pass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_Pass.Location = new Point(442, 95);
            label_Pass.Name = "label_Pass";
            label_Pass.Size = new Size(81, 19);
            label_Pass.TabIndex = 18;
            label_Pass.Text = "PASSWORD";
            // 
            // label_Age
            // 
            label_Age.AutoSize = true;
            label_Age.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_Age.Location = new Point(27, 83);
            label_Age.Name = "label_Age";
            label_Age.Size = new Size(35, 19);
            label_Age.TabIndex = 17;
            label_Age.Text = "AGE";
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_Phone.Location = new Point(439, 23);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(115, 19);
            label_Phone.TabIndex = 16;
            label_Phone.Text = "PHONE NUMBER";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_Email.Location = new Point(443, 56);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(49, 19);
            label_Email.TabIndex = 15;
            label_Email.Text = "EMAIL";
            // 
            // label_LastName
            // 
            label_LastName.AutoSize = true;
            label_LastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_LastName.Location = new Point(24, 47);
            label_LastName.Name = "label_LastName";
            label_LastName.Size = new Size(82, 19);
            label_LastName.TabIndex = 14;
            label_LastName.Text = "LAST NAME";
            // 
            // label_FName
            // 
            label_FName.AutoSize = true;
            label_FName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_FName.Location = new Point(24, 17);
            label_FName.Name = "label_FName";
            label_FName.Size = new Size(85, 19);
            label_FName.TabIndex = 13;
            label_FName.Text = "FIRST NAME";
            // 
            // Form_Setting_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 502);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_Setting_Admin";
            Text = "Form_Setting_Admin";
            Load += Form_Setting_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Close).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Avata_Em).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ListEm).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox_Close;
        private Label label_Review;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView_ListEm;
        private Panel panel3;
        private TextBox textBox_Pass;
        private TextBox textBox_Email;
        private TextBox textBox_Age;
        private TextBox textBox_Phone;
        private TextBox textBox_LName;
        private TextBox textBox_FName;
        private Label label_Pass;
        private Label label_Age;
        private Label label_Phone;
        private Label label_Email;
        private Label label_LastName;
        private Label label_FName;
        private Label label1;
        private Label label_ID;
        private ComboBox comboBox_ID_Employee;
        private Button button_Add;
        private Button button_Change;
        private Button button_Delete;
        private Panel panel_Add;
        private Panel panel_Update;
        private Panel panel_Delete;
        private ComboBox comboBox_IDem;
        private Label label_IDEm;
        private ComboBox comboBox_NameEm;
        private Label label_NameEm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox_Avata_Em;
        private Button button_Seedetial;
    }
}