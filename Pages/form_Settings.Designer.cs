namespace PetStoreManagementApp.Pages
{
    partial class form_Settings
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
            panel2 = new Panel();
            panel_Change = new Panel();
            panel_Profile = new Panel();
            button_Change = new Button();
            button_Profile = new Button();
            panel3 = new Panel();
            button_Change_Avatar = new Button();
            pictureBox_Avatar = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            button_Delete = new Button();
            button_Save = new Button();
            textBox_Pass_Confirm = new TextBox();
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
            label_Review = new Label();
            pictureBox_Close = new PictureBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Avatar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Close).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel_Change);
            panel2.Controls.Add(panel_Profile);
            panel2.Controls.Add(button_Change);
            panel2.Controls.Add(button_Profile);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 53);
            panel2.TabIndex = 1;
            // 
            // panel_Change
            // 
            panel_Change.BackColor = Color.DodgerBlue;
            panel_Change.Location = new Point(153, 6);
            panel_Change.Name = "panel_Change";
            panel_Change.Size = new Size(91, 2);
            panel_Change.TabIndex = 19;
            panel_Change.Visible = false;
            // 
            // panel_Profile
            // 
            panel_Profile.BackColor = Color.DodgerBlue;
            panel_Profile.Location = new Point(37, 6);
            panel_Profile.Name = "panel_Profile";
            panel_Profile.Size = new Size(85, 2);
            panel_Profile.TabIndex = 18;
            // 
            // button_Change
            // 
            button_Change.FlatAppearance.BorderSize = 0;
            button_Change.FlatStyle = FlatStyle.Flat;
            button_Change.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Change.ForeColor = Color.DodgerBlue;
            button_Change.Location = new Point(153, 12);
            button_Change.Name = "button_Change";
            button_Change.Size = new Size(91, 40);
            button_Change.TabIndex = 2;
            button_Change.Text = "CHANGE";
            button_Change.UseVisualStyleBackColor = true;
            button_Change.Click += button_Change_Click;
            button_Change.MouseMove += button_Change_MouseMove;
            // 
            // button_Profile
            // 
            button_Profile.FlatAppearance.BorderSize = 0;
            button_Profile.FlatStyle = FlatStyle.Flat;
            button_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Profile.ForeColor = Color.DodgerBlue;
            button_Profile.Location = new Point(39, 12);
            button_Profile.Name = "button_Profile";
            button_Profile.Size = new Size(85, 40);
            button_Profile.TabIndex = 0;
            button_Profile.Text = "PROFILE";
            button_Profile.UseVisualStyleBackColor = true;
            button_Profile.Click += button_Profile_Click;
            button_Profile.MouseMove += button_Profile_MouseMove;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button_Change_Avatar);
            panel3.Controls.Add(pictureBox_Avatar);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 382);
            panel3.TabIndex = 2;
            // 
            // button_Change_Avatar
            // 
            button_Change_Avatar.FlatAppearance.BorderSize = 0;
            button_Change_Avatar.FlatStyle = FlatStyle.Flat;
            button_Change_Avatar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Change_Avatar.ForeColor = Color.DodgerBlue;
            button_Change_Avatar.Location = new Point(102, 229);
            button_Change_Avatar.Name = "button_Change_Avatar";
            button_Change_Avatar.Size = new Size(90, 31);
            button_Change_Avatar.TabIndex = 3;
            button_Change_Avatar.Text = "CHANGE";
            button_Change_Avatar.UseVisualStyleBackColor = true;
            button_Change_Avatar.Click += button_Change_Avatar_Click;
            // 
            // pictureBox_Avatar
            // 
            pictureBox_Avatar.Location = new Point(64, 43);
            pictureBox_Avatar.Name = "pictureBox_Avatar";
            pictureBox_Avatar.Size = new Size(180, 157);
            pictureBox_Avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Avatar.TabIndex = 0;
            pictureBox_Avatar.TabStop = false;
            pictureBox_Avatar.Click += pictureBox_Avatar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(298, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(457, 382);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(button_Delete);
            panel5.Controls.Add(button_Save);
            panel5.Controls.Add(textBox_Pass_Confirm);
            panel5.Controls.Add(textBox_Pass);
            panel5.Controls.Add(textBox_Email);
            panel5.Controls.Add(textBox_Age);
            panel5.Controls.Add(textBox_Phone);
            panel5.Controls.Add(textBox_LName);
            panel5.Controls.Add(textBox_FName);
            panel5.Controls.Add(label_Pass);
            panel5.Controls.Add(label_Age);
            panel5.Controls.Add(label_Phone);
            panel5.Controls.Add(label_Email);
            panel5.Controls.Add(label_LastName);
            panel5.Controls.Add(label_FName);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(448, 373);
            panel5.TabIndex = 0;
            // 
            // button_Delete
            // 
            button_Delete.BackColor = Color.Gainsboro;
            button_Delete.FlatAppearance.BorderSize = 0;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button_Delete.ForeColor = Color.DodgerBlue;
            button_Delete.Location = new Point(69, 320);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(112, 37);
            button_Delete.TabIndex = 14;
            button_Delete.Text = "X";
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Visible = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Save
            // 
            button_Save.BackColor = Color.DodgerBlue;
            button_Save.FlatAppearance.BorderSize = 0;
            button_Save.FlatStyle = FlatStyle.Flat;
            button_Save.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Save.ForeColor = Color.White;
            button_Save.Location = new Point(204, 320);
            button_Save.MinimumSize = new Size(112, 37);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(210, 37);
            button_Save.TabIndex = 13;
            button_Save.Text = "SAVE";
            button_Save.UseVisualStyleBackColor = false;
            // 
            // textBox_Pass_Confirm
            // 
            textBox_Pass_Confirm.BackColor = Color.Gainsboro;
            textBox_Pass_Confirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Pass_Confirm.Location = new Point(144, 250);
            textBox_Pass_Confirm.Name = "textBox_Pass_Confirm";
            textBox_Pass_Confirm.Size = new Size(270, 29);
            textBox_Pass_Confirm.TabIndex = 12;
            // 
            // textBox_Pass
            // 
            textBox_Pass.BackColor = Color.Gainsboro;
            textBox_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Pass.Location = new Point(144, 211);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.Size = new Size(270, 29);
            textBox_Pass.TabIndex = 11;
            // 
            // textBox_Email
            // 
            textBox_Email.BackColor = Color.Gainsboro;
            textBox_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(144, 168);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(270, 29);
            textBox_Email.TabIndex = 10;
            // 
            // textBox_Age
            // 
            textBox_Age.BackColor = Color.Gainsboro;
            textBox_Age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Age.Location = new Point(144, 89);
            textBox_Age.Name = "textBox_Age";
            textBox_Age.Size = new Size(270, 29);
            textBox_Age.TabIndex = 9;
            // 
            // textBox_Phone
            // 
            textBox_Phone.BackColor = Color.Gainsboro;
            textBox_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Phone.Location = new Point(144, 130);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(270, 29);
            textBox_Phone.TabIndex = 8;
            // 
            // textBox_LName
            // 
            textBox_LName.BackColor = Color.Gainsboro;
            textBox_LName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_LName.Location = new Point(146, 54);
            textBox_LName.Name = "textBox_LName";
            textBox_LName.Size = new Size(270, 29);
            textBox_LName.TabIndex = 7;
            // 
            // textBox_FName
            // 
            textBox_FName.BackColor = Color.Gainsboro;
            textBox_FName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_FName.Location = new Point(144, 17);
            textBox_FName.Name = "textBox_FName";
            textBox_FName.Size = new Size(270, 29);
            textBox_FName.TabIndex = 6;
            // 
            // label_Pass
            // 
            label_Pass.AutoSize = true;
            label_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Pass.Location = new Point(15, 214);
            label_Pass.Name = "label_Pass";
            label_Pass.Size = new Size(94, 21);
            label_Pass.TabIndex = 5;
            label_Pass.Text = "PASSWORD";
            // 
            // label_Age
            // 
            label_Age.AutoSize = true;
            label_Age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Age.Location = new Point(19, 90);
            label_Age.Name = "label_Age";
            label_Age.Size = new Size(39, 21);
            label_Age.TabIndex = 4;
            label_Age.Text = "AGE";
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Phone.Location = new Point(15, 130);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(130, 21);
            label_Phone.TabIndex = 3;
            label_Phone.Text = "PHONE NUMBER";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Email.Location = new Point(19, 168);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(54, 21);
            label_Email.TabIndex = 2;
            label_Email.Text = "EMAIL";
            // 
            // label_LastName
            // 
            label_LastName.AutoSize = true;
            label_LastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_LastName.Location = new Point(19, 54);
            label_LastName.Name = "label_LastName";
            label_LastName.Size = new Size(93, 21);
            label_LastName.TabIndex = 1;
            label_LastName.Text = "LAST NAME";
            // 
            // label_FName
            // 
            label_FName.AutoSize = true;
            label_FName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_FName.Location = new Point(15, 20);
            label_FName.Name = "label_FName";
            label_FName.Size = new Size(97, 21);
            label_FName.TabIndex = 0;
            label_FName.Text = "FIRST NAME";
            // 
            // label_Review
            // 
            label_Review.AutoSize = true;
            label_Review.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_Review.Location = new Point(12, 19);
            label_Review.Name = "label_Review";
            label_Review.Size = new Size(166, 28);
            label_Review.TabIndex = 0;
            label_Review.Text = "Employee Setting";
            // 
            // pictureBox_Close
            // 
            pictureBox_Close.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_Close.Image = Properties.Resources.close;
            pictureBox_Close.Location = new Point(720, 3);
            pictureBox_Close.Name = "pictureBox_Close";
            pictureBox_Close.Size = new Size(29, 29);
            pictureBox_Close.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Close.TabIndex = 14;
            pictureBox_Close.TabStop = false;
            pictureBox_Close.Click += pictureBox_Close_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox_Close);
            panel1.Controls.Add(label_Review);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 67);
            panel1.TabIndex = 0;
            // 
            // form_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 502);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ImeMode = ImeMode.On;
            Name = "form_Settings";
            Text = "form_Settings";
            Load += form_Settings_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Avatar).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Close).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button_Profile;
        private Button button_Change;
        private Panel panel_Profile;
        private Panel panel_Change;
        private PictureBox pictureBox_Avatar;
        private Button button_Change_Avatar;
        private Panel panel5;
        private Label label_FName;
        private Label label_Age;
        private Label label_Phone;
        private Label label_Email;
        private Label label_LastName;
        private Label label_Pass;
        private TextBox textBox_FName;
        private TextBox textBox_Pass;
        private TextBox textBox_Email;
        private TextBox textBox_Age;
        private TextBox textBox_Phone;
        private TextBox textBox_LName;
        private TextBox textBox_Pass_Confirm;
        private Button button_Save;
        private Button button_Delete;
        private Label label_Review;
        private PictureBox pictureBox_Close;
        private Panel panel1;
    }
}