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
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            permission = new Label();
            dataGridView_ListEm = new DataGridView();
            avatar_Image = new CircularPictureBox();
            button_Seedetial = new Button();
            refresh = new PictureBox();
            comboBox_NameEm = new ComboBox();
            label_NameEm = new Label();
            comboBox_IDEmployee = new ComboBox();
            label_IDEm = new Label();
            label1 = new Label();
            panel3 = new Panel();
            gender_ComboBox = new ComboBox();
            notes_TextBox = new TextBox();
            label4 = new Label();
            panel_Update = new Panel();
            panel_Delete = new Panel();
            button_Change = new Button();
            button_Delete = new Button();
            confirmPassword_TextBox = new TextBox();
            username = new TextBox();
            newPassword_TextBox = new TextBox();
            email_TextBox = new TextBox();
            age_TextBox = new TextBox();
            phone_TextBox = new TextBox();
            lastName_TextBox = new TextBox();
            firstName_TextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label_Pass = new Label();
            label_Age = new Label();
            label_Phone = new Label();
            label_Email = new Label();
            label_FName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ListEm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 38);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Location = new Point(122, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(113, 2);
            panel4.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DodgerBlue;
            panel5.Location = new Point(3, 33);
            panel5.Name = "panel5";
            panel5.Size = new Size(113, 2);
            panel5.TabIndex = 31;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(122, 3);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 32;
            button1.Text = "Management";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 33;
            button2.Text = "Account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(permission);
            panel2.Controls.Add(dataGridView_ListEm);
            panel2.Controls.Add(avatar_Image);
            panel2.Controls.Add(button_Seedetial);
            panel2.Controls.Add(refresh);
            panel2.Controls.Add(comboBox_NameEm);
            panel2.Controls.Add(label_NameEm);
            panel2.Controls.Add(comboBox_IDEmployee);
            panel2.Controls.Add(label_IDEm);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 255);
            panel2.TabIndex = 5;
            // 
            // permission
            // 
            permission.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            permission.ForeColor = Color.FromArgb(95, 101, 96);
            permission.Location = new Point(600, 176);
            permission.Name = "permission";
            permission.Size = new Size(80, 27);
            permission.TabIndex = 36;
            permission.Text = "Employee";
            permission.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView_ListEm
            // 
            dataGridView_ListEm.AllowUserToAddRows = false;
            dataGridView_ListEm.AllowUserToDeleteRows = false;
            dataGridView_ListEm.AllowUserToResizeColumns = false;
            dataGridView_ListEm.AllowUserToResizeRows = false;
            dataGridView_ListEm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_ListEm.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView_ListEm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ListEm.Location = new Point(19, 73);
            dataGridView_ListEm.MultiSelect = false;
            dataGridView_ListEm.Name = "dataGridView_ListEm";
            dataGridView_ListEm.ReadOnly = true;
            dataGridView_ListEm.RowTemplate.Height = 25;
            dataGridView_ListEm.ScrollBars = ScrollBars.Vertical;
            dataGridView_ListEm.ShowEditingIcon = false;
            dataGridView_ListEm.Size = new Size(488, 167);
            dataGridView_ListEm.TabIndex = 35;
            dataGridView_ListEm.Click += dataGridView_ListEm_Click;
            // 
            // avatar_Image
            // 
            avatar_Image.Image = Properties.Resources.user_24px;
            avatar_Image.Location = new Point(590, 73);
            avatar_Image.Name = "avatar_Image";
            avatar_Image.Size = new Size(100, 100);
            avatar_Image.SizeMode = PictureBoxSizeMode.Zoom;
            avatar_Image.TabIndex = 34;
            avatar_Image.TabStop = false;
            // 
            // button_Seedetial
            // 
            button_Seedetial.BackColor = Color.DodgerBlue;
            button_Seedetial.FlatAppearance.BorderSize = 0;
            button_Seedetial.FlatStyle = FlatStyle.Flat;
            button_Seedetial.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_Seedetial.ForeColor = Color.White;
            button_Seedetial.Location = new Point(581, 206);
            button_Seedetial.Name = "button_Seedetial";
            button_Seedetial.Size = new Size(121, 36);
            button_Seedetial.TabIndex = 33;
            button_Seedetial.Text = "Change";
            button_Seedetial.UseVisualStyleBackColor = false;
            button_Seedetial.Click += button_Seedetial_Click;
            // 
            // refresh
            // 
            refresh.Image = Properties.Resources.refresh__1_;
            refresh.Location = new Point(479, 42);
            refresh.Name = "refresh";
            refresh.Size = new Size(28, 28);
            refresh.SizeMode = PictureBoxSizeMode.Zoom;
            refresh.TabIndex = 31;
            refresh.TabStop = false;
            refresh.Click += pictureBox1_Click;
            // 
            // comboBox_NameEm
            // 
            comboBox_NameEm.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_NameEm.FormattingEnabled = true;
            comboBox_NameEm.Location = new Point(268, 42);
            comboBox_NameEm.Name = "comboBox_NameEm";
            comboBox_NameEm.Size = new Size(152, 25);
            comboBox_NameEm.TabIndex = 30;
            comboBox_NameEm.SelectedIndexChanged += comboBox_NameEm_SelectedIndexChanged;
            // 
            // label_NameEm
            // 
            label_NameEm.AutoSize = true;
            label_NameEm.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_NameEm.Location = new Point(195, 41);
            label_NameEm.Name = "label_NameEm";
            label_NameEm.Size = new Size(67, 25);
            label_NameEm.TabIndex = 29;
            label_NameEm.Text = "Name:";
            // 
            // comboBox_IDEmployee
            // 
            comboBox_IDEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_IDEmployee.FormattingEnabled = true;
            comboBox_IDEmployee.Location = new Point(58, 42);
            comboBox_IDEmployee.Name = "comboBox_IDEmployee";
            comboBox_IDEmployee.Size = new Size(89, 25);
            comboBox_IDEmployee.TabIndex = 28;
            comboBox_IDEmployee.SelectedIndexChanged += comboBox_IDEmployee_SelectedIndexChanged;
            // 
            // label_IDEm
            // 
            label_IDEm.AutoSize = true;
            label_IDEm.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_IDEm.Location = new Point(19, 41);
            label_IDEm.Name = "label_IDEm";
            label_IDEm.Size = new Size(36, 25);
            label_IDEm.TabIndex = 27;
            label_IDEm.Text = "ID:";
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(gender_ComboBox);
            panel3.Controls.Add(notes_TextBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel_Update);
            panel3.Controls.Add(panel_Delete);
            panel3.Controls.Add(button_Change);
            panel3.Controls.Add(button_Delete);
            panel3.Controls.Add(confirmPassword_TextBox);
            panel3.Controls.Add(username);
            panel3.Controls.Add(newPassword_TextBox);
            panel3.Controls.Add(email_TextBox);
            panel3.Controls.Add(age_TextBox);
            panel3.Controls.Add(phone_TextBox);
            panel3.Controls.Add(lastName_TextBox);
            panel3.Controls.Add(firstName_TextBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label_Pass);
            panel3.Controls.Add(label_Age);
            panel3.Controls.Add(label_Phone);
            panel3.Controls.Add(label_Email);
            panel3.Controls.Add(label_FName);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 299);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 242);
            panel3.TabIndex = 6;
            // 
            // gender_ComboBox
            // 
            gender_ComboBox.FormattingEnabled = true;
            gender_ComboBox.Items.AddRange(new object[] { "Mr.", "Miss.", "Ms.", "Mrs." });
            gender_ComboBox.Location = new Point(107, 17);
            gender_ComboBox.Name = "gender_ComboBox";
            gender_ComboBox.Size = new Size(58, 23);
            gender_ComboBox.TabIndex = 33;
            // 
            // notes_TextBox
            // 
            notes_TextBox.Location = new Point(496, 47);
            notes_TextBox.Multiline = true;
            notes_TextBox.Name = "notes_TextBox";
            notes_TextBox.Size = new Size(248, 82);
            notes_TextBox.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(590, 15);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 31;
            label4.Text = "Notes";
            // 
            // panel_Update
            // 
            panel_Update.BackColor = Color.DodgerBlue;
            panel_Update.Location = new Point(479, 214);
            panel_Update.Name = "panel_Update";
            panel_Update.Size = new Size(141, 2);
            panel_Update.TabIndex = 20;
            panel_Update.Visible = false;
            // 
            // panel_Delete
            // 
            panel_Delete.BackColor = Color.DodgerBlue;
            panel_Delete.Location = new Point(627, 214);
            panel_Delete.Name = "panel_Delete";
            panel_Delete.Size = new Size(134, 2);
            panel_Delete.TabIndex = 30;
            panel_Delete.Visible = false;
            // 
            // button_Change
            // 
            button_Change.FlatAppearance.BorderSize = 0;
            button_Change.FlatStyle = FlatStyle.Flat;
            button_Change.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_Change.ForeColor = Color.DodgerBlue;
            button_Change.Location = new Point(479, 168);
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
            button_Delete.Location = new Point(627, 168);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(134, 40);
            button_Delete.TabIndex = 28;
            button_Delete.Text = "DELETE EMPLOYEE";
            button_Delete.TextAlign = ContentAlignment.MiddleLeft;
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            button_Delete.MouseMove += button_Delete_MouseMove;
            // 
            // confirmPassword_TextBox
            // 
            confirmPassword_TextBox.BackColor = Color.LightGray;
            confirmPassword_TextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPassword_TextBox.Location = new Point(159, 206);
            confirmPassword_TextBox.Name = "confirmPassword_TextBox";
            confirmPassword_TextBox.PasswordChar = '*';
            confirmPassword_TextBox.Size = new Size(150, 25);
            confirmPassword_TextBox.TabIndex = 24;
            // 
            // username
            // 
            username.BackColor = Color.LightGray;
            username.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(159, 149);
            username.Name = "username";
            username.ReadOnly = true;
            username.Size = new Size(150, 25);
            username.TabIndex = 24;
            // 
            // newPassword_TextBox
            // 
            newPassword_TextBox.BackColor = Color.LightGray;
            newPassword_TextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newPassword_TextBox.Location = new Point(159, 178);
            newPassword_TextBox.Name = "newPassword_TextBox";
            newPassword_TextBox.PasswordChar = '*';
            newPassword_TextBox.Size = new Size(150, 25);
            newPassword_TextBox.TabIndex = 24;
            // 
            // email_TextBox
            // 
            email_TextBox.BackColor = Color.LightGray;
            email_TextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            email_TextBox.Location = new Point(107, 46);
            email_TextBox.Name = "email_TextBox";
            email_TextBox.Size = new Size(177, 25);
            email_TextBox.TabIndex = 23;
            // 
            // age_TextBox
            // 
            age_TextBox.BackColor = Color.LightGray;
            age_TextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            age_TextBox.Location = new Point(107, 108);
            age_TextBox.Name = "age_TextBox";
            age_TextBox.Size = new Size(58, 25);
            age_TextBox.TabIndex = 22;
            // 
            // phone_TextBox
            // 
            phone_TextBox.BackColor = Color.LightGray;
            phone_TextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phone_TextBox.Location = new Point(107, 77);
            phone_TextBox.Name = "phone_TextBox";
            phone_TextBox.Size = new Size(177, 25);
            phone_TextBox.TabIndex = 21;
            // 
            // lastName_TextBox
            // 
            lastName_TextBox.BackColor = Color.LightGray;
            lastName_TextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_TextBox.Location = new Point(290, 15);
            lastName_TextBox.Name = "lastName_TextBox";
            lastName_TextBox.Size = new Size(113, 25);
            lastName_TextBox.TabIndex = 20;
            // 
            // firstName_TextBox
            // 
            firstName_TextBox.BackColor = Color.LightGray;
            firstName_TextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            firstName_TextBox.Location = new Point(171, 15);
            firstName_TextBox.Name = "firstName_TextBox";
            firstName_TextBox.Size = new Size(113, 25);
            firstName_TextBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 207);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 18;
            label2.Text = "Confirm Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 149);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 18;
            label3.Text = "Username:";
            // 
            // label_Pass
            // 
            label_Pass.AutoSize = true;
            label_Pass.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Pass.Location = new Point(31, 178);
            label_Pass.Name = "label_Pass";
            label_Pass.Size = new Size(116, 20);
            label_Pass.TabIndex = 18;
            label_Pass.Text = "New Password:";
            // 
            // label_Age
            // 
            label_Age.AutoSize = true;
            label_Age.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Age.Location = new Point(55, 109);
            label_Age.Name = "label_Age";
            label_Age.Size = new Size(41, 20);
            label_Age.TabIndex = 17;
            label_Age.Text = "Age:";
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Phone.Location = new Point(39, 78);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(57, 20);
            label_Phone.TabIndex = 16;
            label_Phone.Text = "Phone:";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Email.Location = new Point(45, 47);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(51, 20);
            label_Email.TabIndex = 15;
            label_Email.Text = "Email:";
            // 
            // label_FName
            // 
            label_FName.AutoSize = true;
            label_FName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_FName.Location = new Point(12, 16);
            label_FName.Name = "label_FName";
            label_FName.Size = new Size(84, 20);
            label_FName.TabIndex = 13;
            label_FName.Text = "Full Name:";
            // 
            // Form_Setting_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 541);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Setting_Admin";
            Text = "Form_Setting_Admin";
            Load += Form_Setting_Admin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ListEm).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatar_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox newPassword_TextBox;
        private TextBox email_TextBox;
        private TextBox age_TextBox;
        private TextBox phone_TextBox;
        private TextBox lastName_TextBox;
        private Label label_Pass;
        private Label label_Age;
        private Label label_Phone;
        private Label label_Email;
        private Label label_FName;
        private Label label1;
        private Button button_Change;
        private Button button_Delete;
        private Panel panel_Update;
        private Panel panel_Delete;
        private ComboBox comboBox_IDEmployee;
        private Label label_IDEm;
        private ComboBox comboBox_NameEm;
        private Label label_NameEm;
        private PictureBox refresh;
        private Button button_Seedetial;
        private Panel panel4;
        private Panel panel5;
        private Button button1;
        private Button button2;
        private TextBox firstName_TextBox;
        private TextBox notes_TextBox;
        private Label label4;
        private TextBox confirmPassword_TextBox;
        private Label label2;
        private CircularPictureBox avatar_Image;
        private ComboBox gender_ComboBox;
        private DataGridView dataGridView_ListEm;
        private TextBox username;
        private Label label3;
        private Label permission;
    }
}