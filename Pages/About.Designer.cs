namespace PetStoreManagementApp.Pages
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 222, 180);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 502);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 381);
            label6.Name = "label6";
            label6.Size = new Size(616, 90);
            label6.TabIndex = 4;
            label6.Text = "Trân trọng,\r\n\r\nNguyễn Tiến Dũng, Nguyễn Duy Dũng, và Vũ Nguyễn Thành Tâm\r\n[TNHH DDT]";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 307);
            label5.Name = "label5";
            label5.Size = new Size(712, 55);
            label5.TabIndex = 4;
            label5.Text = "Chúng tôi xin gửi lời cám ơn chân thành tới tất cả các bạn đã lựa chọn và sử dụng ứng dụng Quản lý PetStore của chúng tôi. Sự tin tưởng và ủng hộ của các bạn có ý nghĩa rất lớn với chúng tôi.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 104);
            label2.Name = "label2";
            label2.Size = new Size(712, 76);
            label2.TabIndex = 1;
            label2.Text = "PetStore Management cung cấp một giao diện người dùng trực quan và dễ sử dụng. Giao diện này cho phép người dùng tương tác với các tính năng và dữ liệu của ứng dụng.\r\n";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 74);
            label1.Name = "label1";
            label1.Size = new Size(350, 29);
            label1.TabIndex = 1;
            label1.Text = "Thanks you for using Our App";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(303, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 170);
            label3.Name = "label3";
            label3.Size = new Size(712, 137);
            label3.TabIndex = 5;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 502);
            Controls.Add(panel1);
            Name = "About";
            Text = "About";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label3;
    }
}