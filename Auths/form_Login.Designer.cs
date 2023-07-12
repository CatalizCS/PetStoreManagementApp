﻿namespace PetStoreManagementApp.Auths
{
    partial class form_Login
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            cancel_Button = new Button();
            login_Button = new Button();
            password = new TextBox();
            username = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 222, 180);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 378);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 359);
            label3.Name = "label3";
            label3.Size = new Size(241, 19);
            label3.TabIndex = 2;
            label3.Text = "version 0.0.1";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 175);
            label2.Name = "label2";
            label2.Size = new Size(241, 45);
            label2.TabIndex = 1;
            label2.Text = "Welcome back to the best. We're\r\nalways here, waiting for you!\r\n\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 116);
            label1.Name = "label1";
            label1.Size = new Size(185, 29);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(108, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(169, 134, 115);
            label4.Location = new Point(38, 69);
            label4.Name = "label4";
            label4.Size = new Size(204, 29);
            label4.TabIndex = 2;
            label4.Text = "Login to Account";
            // 
            // panel2
            // 
            panel2.Controls.Add(cancel_Button);
            panel2.Controls.Add(login_Button);
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(286, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 376);
            panel2.TabIndex = 3;
            // 
            // cancel_Button
            // 
            cancel_Button.BackColor = Color.Gray;
            cancel_Button.FlatStyle = FlatStyle.Flat;
            cancel_Button.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_Button.ForeColor = Color.White;
            cancel_Button.Location = new Point(38, 284);
            cancel_Button.Name = "cancel_Button";
            cancel_Button.Size = new Size(204, 46);
            cancel_Button.TabIndex = 3;
            cancel_Button.Text = "Cancel";
            cancel_Button.UseVisualStyleBackColor = false;
            cancel_Button.Click += cancel_Button_Click;
            // 
            // login_Button
            // 
            login_Button.BackColor = Color.FromArgb(255, 222, 180);
            login_Button.FlatStyle = FlatStyle.Flat;
            login_Button.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            login_Button.ForeColor = Color.Black;
            login_Button.Location = new Point(38, 232);
            login_Button.Name = "login_Button";
            login_Button.Size = new Size(204, 46);
            login_Button.TabIndex = 2;
            login_Button.Text = "Login";
            login_Button.UseVisualStyleBackColor = false;
            login_Button.Click += login_Button_Click;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            password.ForeColor = Color.FromArgb(169, 134, 115);
            password.Location = new Point(33, 198);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(237, 25);
            password.TabIndex = 1;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            username.ForeColor = Color.FromArgb(169, 134, 115);
            username.Location = new Point(33, 136);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(237, 25);
            username.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock_24px;
            pictureBox3.Location = new Point(3, 195);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_24px;
            pictureBox2.Location = new Point(3, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(124, 139, 114);
            panel3.Location = new Point(0, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 2);
            panel3.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(124, 139, 114);
            panel6.Location = new Point(1, 162);
            panel6.Name = "panel6";
            panel6.Size = new Size(281, 2);
            panel6.TabIndex = 17;
            // 
            // form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(558, 376);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel2;
        private TextBox username;
        private Panel panel6;
        private Panel panel3;
        private TextBox password;
        private Button login_Button;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button cancel_Button;
    }
}