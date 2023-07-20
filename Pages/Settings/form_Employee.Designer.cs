﻿namespace PetStoreManagementApp.Pages
{
    partial class form_Employee
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
            changeAvater_Button = new Libs.BetterButton();
            avatar_Image = new CircularPictureBox();
            panel3 = new Panel();
            email_Textbox = new TextBox();
            phoneNumber_Textbox = new TextBox();
            lastName_Textbox = new TextBox();
            firstName_TextBox = new TextBox();
            notes_Textbox = new TextBox();
            age_Textbox = new TextBox();
            gender_TextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            permission_Textbox = new TextBox();
            username_Textbox = new TextBox();
            cancel_Button = new Libs.BetterButton();
            save_Button = new Libs.BetterButton();
            newPassword_Textbox = new TextBox();
            confirmPassword_Textbox = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar_Image).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(changeAvater_Button);
            panel2.Controls.Add(avatar_Image);
            panel2.Location = new Point(528, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 178);
            panel2.TabIndex = 1;
            // 
            // changeAvater_Button
            // 
            changeAvater_Button.BackColor = Color.MediumSlateBlue;
            changeAvater_Button.BackgroundColor = Color.MediumSlateBlue;
            changeAvater_Button.BorderColor = Color.PaleVioletRed;
            changeAvater_Button.BorderRadius = 10;
            changeAvater_Button.BorderSize = 0;
            changeAvater_Button.FlatAppearance.BorderSize = 0;
            changeAvater_Button.FlatStyle = FlatStyle.Flat;
            changeAvater_Button.ForeColor = Color.White;
            changeAvater_Button.Location = new Point(74, 119);
            changeAvater_Button.Name = "changeAvater_Button";
            changeAvater_Button.Size = new Size(100, 40);
            changeAvater_Button.TabIndex = 2;
            changeAvater_Button.Text = "Change";
            changeAvater_Button.TextColor = Color.White;
            changeAvater_Button.UseVisualStyleBackColor = false;
            changeAvater_Button.Click += changeAvater_Button_Click;
            // 
            // avatar_Image
            // 
            avatar_Image.Image = Properties.Resources.user_24px;
            avatar_Image.Location = new Point(74, 13);
            avatar_Image.Name = "avatar_Image";
            avatar_Image.Size = new Size(100, 100);
            avatar_Image.SizeMode = PictureBoxSizeMode.Zoom;
            avatar_Image.TabIndex = 1;
            avatar_Image.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(email_Textbox);
            panel3.Controls.Add(phoneNumber_Textbox);
            panel3.Controls.Add(lastName_Textbox);
            panel3.Controls.Add(firstName_TextBox);
            panel3.Controls.Add(notes_Textbox);
            panel3.Controls.Add(age_Textbox);
            panel3.Controls.Add(gender_TextBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 272);
            panel3.TabIndex = 2;
            // 
            // email_Textbox
            // 
            email_Textbox.Location = new Point(150, 140);
            email_Textbox.Name = "email_Textbox";
            email_Textbox.Size = new Size(159, 23);
            email_Textbox.TabIndex = 2;
            // 
            // phoneNumber_Textbox
            // 
            phoneNumber_Textbox.Location = new Point(149, 94);
            phoneNumber_Textbox.Name = "phoneNumber_Textbox";
            phoneNumber_Textbox.Size = new Size(159, 23);
            phoneNumber_Textbox.TabIndex = 2;
            // 
            // lastName_Textbox
            // 
            lastName_Textbox.Location = new Point(226, 45);
            lastName_Textbox.Name = "lastName_Textbox";
            lastName_Textbox.Size = new Size(82, 23);
            lastName_Textbox.TabIndex = 2;
            // 
            // firstName_TextBox
            // 
            firstName_TextBox.Location = new Point(138, 45);
            firstName_TextBox.Name = "firstName_TextBox";
            firstName_TextBox.Size = new Size(82, 23);
            firstName_TextBox.TabIndex = 2;
            // 
            // notes_Textbox
            // 
            notes_Textbox.Location = new Point(77, 182);
            notes_Textbox.Multiline = true;
            notes_Textbox.Name = "notes_Textbox";
            notes_Textbox.Size = new Size(388, 82);
            notes_Textbox.TabIndex = 2;
            // 
            // age_Textbox
            // 
            age_Textbox.Location = new Point(391, 47);
            age_Textbox.Name = "age_Textbox";
            age_Textbox.Size = new Size(74, 23);
            age_Textbox.TabIndex = 2;
            // 
            // gender_TextBox
            // 
            gender_TextBox.Location = new Point(78, 45);
            gender_TextBox.Name = "gender_TextBox";
            gender_TextBox.Size = new Size(54, 23);
            gender_TextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(341, 47);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 1;
            label3.Text = "Age: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 214);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 1;
            label4.Text = "Notes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 138);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 1;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 92);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 1;
            label5.Text = "Phone Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.Controls.Add(label1);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(528, 28);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, -2);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 1;
            label1.Text = "Personal Info";
            // 
            // panel4
            // 
            panel4.Controls.Add(confirmPassword_Textbox);
            panel4.Controls.Add(newPassword_Textbox);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(permission_Textbox);
            panel4.Controls.Add(username_Textbox);
            panel4.Location = new Point(0, 271);
            panel4.Name = "panel4";
            panel4.Size = new Size(528, 165);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.RoyalBlue;
            panel6.Controls.Add(label7);
            panel6.Location = new Point(0, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(528, 28);
            panel6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, -2);
            label7.Name = "label7";
            label7.Size = new Size(142, 30);
            label7.TabIndex = 1;
            label7.Text = "Account Info";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(254, 44);
            label9.Name = "label9";
            label9.Size = new Size(98, 21);
            label9.TabIndex = 1;
            label9.Text = "Permission:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(13, 121);
            label11.Name = "label11";
            label11.Size = new Size(152, 21);
            label11.TabIndex = 1;
            label11.Text = "Confirm Password:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(13, 82);
            label10.Name = "label10";
            label10.Size = new Size(125, 21);
            label10.TabIndex = 1;
            label10.Text = "New password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 44);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 1;
            label8.Text = "Username: ";
            // 
            // permission_Textbox
            // 
            permission_Textbox.Location = new Point(358, 46);
            permission_Textbox.Name = "permission_Textbox";
            permission_Textbox.ReadOnly = true;
            permission_Textbox.Size = new Size(107, 23);
            permission_Textbox.TabIndex = 2;
            // 
            // username_Textbox
            // 
            username_Textbox.Location = new Point(114, 44);
            username_Textbox.Name = "username_Textbox";
            username_Textbox.ReadOnly = true;
            username_Textbox.Size = new Size(107, 23);
            username_Textbox.TabIndex = 2;
            // 
            // cancel_Button
            // 
            cancel_Button.BackColor = Color.Red;
            cancel_Button.BackgroundColor = Color.Red;
            cancel_Button.BorderColor = Color.PaleVioletRed;
            cancel_Button.BorderRadius = 10;
            cancel_Button.BorderSize = 0;
            cancel_Button.FlatAppearance.BorderSize = 0;
            cancel_Button.FlatStyle = FlatStyle.Flat;
            cancel_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_Button.ForeColor = Color.White;
            cancel_Button.Location = new Point(535, 354);
            cancel_Button.Name = "cancel_Button";
            cancel_Button.Size = new Size(112, 40);
            cancel_Button.TabIndex = 4;
            cancel_Button.Text = "CANCEL";
            cancel_Button.TextColor = Color.White;
            cancel_Button.UseVisualStyleBackColor = false;
            cancel_Button.Click += cancel_Button_Click;
            // 
            // save_Button
            // 
            save_Button.BackColor = Color.Blue;
            save_Button.BackgroundColor = Color.Blue;
            save_Button.BorderColor = Color.PaleVioletRed;
            save_Button.BorderRadius = 10;
            save_Button.BorderSize = 0;
            save_Button.FlatAppearance.BorderSize = 0;
            save_Button.FlatStyle = FlatStyle.Flat;
            save_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            save_Button.ForeColor = Color.White;
            save_Button.Location = new Point(653, 354);
            save_Button.Name = "save_Button";
            save_Button.Size = new Size(112, 40);
            save_Button.TabIndex = 4;
            save_Button.Text = "SAVE";
            save_Button.TextColor = Color.White;
            save_Button.UseVisualStyleBackColor = false;
            save_Button.Click += save_Button_Click;
            // 
            // newPassword_Textbox
            // 
            newPassword_Textbox.BackColor = Color.LightGray;
            newPassword_Textbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newPassword_Textbox.Location = new Point(144, 82);
            newPassword_Textbox.Name = "newPassword_Textbox";
            newPassword_Textbox.PasswordChar = '*';
            newPassword_Textbox.Size = new Size(197, 25);
            newPassword_Textbox.TabIndex = 25;
            // 
            // confirmPassword_Textbox
            // 
            confirmPassword_Textbox.BackColor = Color.LightGray;
            confirmPassword_Textbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPassword_Textbox.Location = new Point(171, 121);
            confirmPassword_Textbox.Name = "confirmPassword_Textbox";
            confirmPassword_Textbox.PasswordChar = '*';
            confirmPassword_Textbox.Size = new Size(170, 25);
            confirmPassword_Textbox.TabIndex = 26;
            // 
            // form_Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(771, 439);
            Controls.Add(save_Button);
            Controls.Add(cancel_Button);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            Name = "form_Employee";
            Text = "form_Settings";
            Load += form_Employee_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avatar_Image).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private CircularPictureBox avatar_Image;
        private Libs.BetterButton changeAvater_Button;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private TextBox phoneNumber_Textbox;
        private TextBox lastName_Textbox;
        private TextBox firstName_TextBox;
        private TextBox notes_Textbox;
        private TextBox gender_TextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox age_Textbox;
        private TextBox email_Textbox;
        private Label label6;
        private Panel panel6;
        private Label label7;
        private Label label9;
        private Label label8;
        private TextBox username_Textbox;
        private Label label11;
        private Label label10;
        private TextBox permission_Textbox;
        private Libs.BetterButton cancel_Button;
        private Libs.BetterButton save_Button;
        private TextBox newPassword_Textbox;
        private TextBox confirmPassword_Textbox;
    }
}