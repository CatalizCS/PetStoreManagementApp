namespace PetStoreManagementApp.Pages.Forms
{
    partial class CustomMessageBox
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
            Message = new Label();
            close_Button = new Libs.BetterButton();
            betterButton1 = new Libs.BetterButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Message
            // 
            Message.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Message.Location = new Point(3, 11);
            Message.Name = "Message";
            Message.Size = new Size(289, 40);
            Message.TabIndex = 0;
            Message.Text = "label1";
            Message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // close_Button
            // 
            close_Button.BackColor = Color.FromArgb(128, 128, 255);
            close_Button.BackgroundColor = Color.FromArgb(128, 128, 255);
            close_Button.BorderColor = Color.PaleVioletRed;
            close_Button.BorderRadius = 10;
            close_Button.BorderSize = 0;
            close_Button.FlatAppearance.BorderSize = 0;
            close_Button.FlatStyle = FlatStyle.Flat;
            close_Button.ForeColor = Color.White;
            close_Button.Location = new Point(190, 87);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(117, 40);
            close_Button.TabIndex = 1;
            close_Button.Text = "Xác Nhận";
            close_Button.TextColor = Color.White;
            close_Button.UseVisualStyleBackColor = false;
            close_Button.Click += close_Button_Click;
            // 
            // betterButton1
            // 
            betterButton1.BackColor = Color.Red;
            betterButton1.BackgroundColor = Color.Red;
            betterButton1.BorderColor = Color.PaleVioletRed;
            betterButton1.BorderRadius = 10;
            betterButton1.BorderSize = 0;
            betterButton1.FlatAppearance.BorderSize = 0;
            betterButton1.FlatStyle = FlatStyle.Flat;
            betterButton1.ForeColor = Color.White;
            betterButton1.Location = new Point(12, 87);
            betterButton1.Name = "betterButton1";
            betterButton1.Size = new Size(117, 40);
            betterButton1.TabIndex = 1;
            betterButton1.Text = "Đóng";
            betterButton1.TextColor = Color.White;
            betterButton1.UseVisualStyleBackColor = false;
            betterButton1.Click += betterButton1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Message);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 69);
            panel1.TabIndex = 2;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 222, 180);
            ClientSize = new Size(319, 139);
            Controls.Add(panel1);
            Controls.Add(betterButton1);
            Controls.Add(close_Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomMessageBox";
            Load += CustomMessageBox_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Message;
        private Libs.BetterButton close_Button;
        private Libs.BetterButton betterButton1;
        private Panel panel1;
    }
}