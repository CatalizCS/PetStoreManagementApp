namespace PetStoreManagementApp
{
    partial class form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            permission = new Label();
            username = new Label();
            avatar_Image = new CircularPictureBox();
            slideBar_Container = new FlowLayoutPanel();
            menu_container = new Panel();
            menu_Button = new Button();
            info_Container = new Panel();
            petManager_Button = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            service_Button = new Button();
            panel7 = new Panel();
            panel4 = new Panel();
            customer_Button = new Button();
            panel8 = new Panel();
            panel2 = new Panel();
            wareHouse_Button = new Button();
            panel10 = new Panel();
            panel11 = new Panel();
            about_Button = new Button();
            panel12 = new Panel();
            panel13 = new Panel();
            setting_Button = new Button();
            panel9 = new Panel();
            versionNumber = new Label();
            slideBarTimer = new System.Windows.Forms.Timer(components);
            headerBar = new Panel();
            containerName = new Label();
            closeApp_Button = new Button();
            logout_Button = new Button();
            mainInterface = new Panel();
            ((System.ComponentModel.ISupportInitialize)avatar_Image).BeginInit();
            slideBar_Container.SuspendLayout();
            menu_container.SuspendLayout();
            info_Container.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            panel13.SuspendLayout();
            panel9.SuspendLayout();
            headerBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(191, 191, 138);
            panel1.Location = new Point(3, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 2);
            panel1.TabIndex = 2;
            // 
            // permission
            // 
            permission.AutoSize = true;
            permission.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            permission.ForeColor = Color.FromArgb(95, 101, 96);
            permission.Location = new Point(69, 30);
            permission.Name = "permission";
            permission.Size = new Size(48, 15);
            permission.TabIndex = 1;
            permission.Text = "Admin";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            username.ForeColor = Color.FromArgb(88, 85, 78);
            username.Location = new Point(69, 11);
            username.Name = "username";
            username.Size = new Size(113, 19);
            username.TabIndex = 1;
            username.Text = "Tama Nguyen";
            // 
            // avatar_Image
            // 
            avatar_Image.Image = Properties.Resources.user_24px;
            avatar_Image.Location = new Point(3, 3);
            avatar_Image.MaximumSize = new Size(60, 60);
            avatar_Image.MinimumSize = new Size(35, 35);
            avatar_Image.Name = "avatar_Image";
            avatar_Image.Size = new Size(60, 60);
            avatar_Image.SizeMode = PictureBoxSizeMode.Zoom;
            avatar_Image.TabIndex = 0;
            avatar_Image.TabStop = false;
            // 
            // slideBar_Container
            // 
            slideBar_Container.BackColor = Color.FromArgb(255, 222, 180);
            slideBar_Container.Controls.Add(menu_container);
            slideBar_Container.Controls.Add(info_Container);
            slideBar_Container.Controls.Add(panel1);
            slideBar_Container.Controls.Add(petManager_Button);
            slideBar_Container.Controls.Add(panel6);
            slideBar_Container.Controls.Add(panel5);
            slideBar_Container.Controls.Add(panel7);
            slideBar_Container.Controls.Add(panel4);
            slideBar_Container.Controls.Add(panel8);
            slideBar_Container.Controls.Add(panel2);
            slideBar_Container.Controls.Add(panel10);
            slideBar_Container.Controls.Add(panel11);
            slideBar_Container.Controls.Add(panel12);
            slideBar_Container.Controls.Add(panel13);
            slideBar_Container.Controls.Add(panel9);
            slideBar_Container.Dock = DockStyle.Left;
            slideBar_Container.Location = new Point(0, 0);
            slideBar_Container.MaximumSize = new Size(249, 582);
            slideBar_Container.MinimumSize = new Size(42, 582);
            slideBar_Container.Name = "slideBar_Container";
            slideBar_Container.Size = new Size(249, 582);
            slideBar_Container.TabIndex = 3;
            // 
            // menu_container
            // 
            menu_container.Controls.Add(menu_Button);
            menu_container.Location = new Point(3, 3);
            menu_container.MaximumSize = new Size(243, 38);
            menu_container.MinimumSize = new Size(42, 38);
            menu_container.Name = "menu_container";
            menu_container.Size = new Size(243, 38);
            menu_container.TabIndex = 6;
            // 
            // menu_Button
            // 
            menu_Button.FlatStyle = FlatStyle.Flat;
            menu_Button.Font = new Font("Constantia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            menu_Button.ForeColor = Color.FromArgb(88, 85, 78);
            menu_Button.Location = new Point(0, 0);
            menu_Button.MaximumSize = new Size(243, 38);
            menu_Button.MinimumSize = new Size(38, 38);
            menu_Button.Name = "menu_Button";
            menu_Button.Size = new Size(243, 38);
            menu_Button.TabIndex = 1;
            menu_Button.Text = "☰       Menu";
            menu_Button.TextAlign = ContentAlignment.MiddleLeft;
            menu_Button.UseVisualStyleBackColor = false;
            menu_Button.Click += menu_Button_Click;
            // 
            // info_Container
            // 
            info_Container.Controls.Add(avatar_Image);
            info_Container.Controls.Add(username);
            info_Container.Controls.Add(permission);
            info_Container.Location = new Point(3, 47);
            info_Container.Name = "info_Container";
            info_Container.Size = new Size(243, 69);
            info_Container.TabIndex = 4;
            // 
            // petManager_Button
            // 
            petManager_Button.FlatStyle = FlatStyle.Flat;
            petManager_Button.Font = new Font("Constantia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            petManager_Button.ForeColor = Color.FromArgb(88, 85, 78);
            petManager_Button.Image = Properties.Resources.logo_24px;
            petManager_Button.ImageAlign = ContentAlignment.MiddleLeft;
            petManager_Button.Location = new Point(3, 130);
            petManager_Button.MaximumSize = new Size(243, 38);
            petManager_Button.MinimumSize = new Size(38, 38);
            petManager_Button.Name = "petManager_Button";
            petManager_Button.Size = new Size(243, 38);
            petManager_Button.TabIndex = 1;
            petManager_Button.Text = "      Pet Manager";
            petManager_Button.TextAlign = ContentAlignment.MiddleLeft;
            petManager_Button.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(124, 139, 114);
            panel6.Location = new Point(3, 174);
            panel6.Name = "panel6";
            panel6.Size = new Size(243, 2);
            panel6.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.Controls.Add(service_Button);
            panel5.Location = new Point(3, 182);
            panel5.MaximumSize = new Size(243, 38);
            panel5.MinimumSize = new Size(42, 38);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 38);
            panel5.TabIndex = 13;
            // 
            // service_Button
            // 
            service_Button.FlatStyle = FlatStyle.Flat;
            service_Button.Font = new Font("Constantia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            service_Button.ForeColor = Color.FromArgb(88, 85, 78);
            service_Button.Image = Properties.Resources.customer_service_24px;
            service_Button.ImageAlign = ContentAlignment.MiddleLeft;
            service_Button.Location = new Point(0, 0);
            service_Button.MaximumSize = new Size(243, 38);
            service_Button.MinimumSize = new Size(38, 38);
            service_Button.Name = "service_Button";
            service_Button.Size = new Size(243, 38);
            service_Button.TabIndex = 12;
            service_Button.Text = "      Service";
            service_Button.TextAlign = ContentAlignment.MiddleLeft;
            service_Button.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(124, 139, 114);
            panel7.Location = new Point(3, 226);
            panel7.Name = "panel7";
            panel7.Size = new Size(243, 2);
            panel7.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.Controls.Add(customer_Button);
            panel4.Location = new Point(3, 234);
            panel4.MaximumSize = new Size(243, 38);
            panel4.MinimumSize = new Size(42, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 38);
            panel4.TabIndex = 11;
            // 
            // customer_Button
            // 
            customer_Button.FlatStyle = FlatStyle.Flat;
            customer_Button.Font = new Font("Constantia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            customer_Button.ForeColor = Color.FromArgb(88, 85, 78);
            customer_Button.Image = Properties.Resources.customer_24px;
            customer_Button.ImageAlign = ContentAlignment.MiddleLeft;
            customer_Button.Location = new Point(0, 0);
            customer_Button.MaximumSize = new Size(243, 38);
            customer_Button.MinimumSize = new Size(38, 38);
            customer_Button.Name = "customer_Button";
            customer_Button.Size = new Size(243, 38);
            customer_Button.TabIndex = 10;
            customer_Button.Text = "      Customers";
            customer_Button.TextAlign = ContentAlignment.MiddleLeft;
            customer_Button.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(124, 139, 114);
            panel8.Location = new Point(3, 278);
            panel8.Name = "panel8";
            panel8.Size = new Size(243, 2);
            panel8.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(wareHouse_Button);
            panel2.Location = new Point(3, 286);
            panel2.MaximumSize = new Size(243, 38);
            panel2.MinimumSize = new Size(42, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 38);
            panel2.TabIndex = 13;
            // 
            // wareHouse_Button
            // 
            wareHouse_Button.FlatStyle = FlatStyle.Flat;
            wareHouse_Button.Font = new Font("Constantia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            wareHouse_Button.ForeColor = Color.FromArgb(88, 85, 78);
            wareHouse_Button.Image = Properties.Resources.warehouse_24px;
            wareHouse_Button.ImageAlign = ContentAlignment.MiddleLeft;
            wareHouse_Button.Location = new Point(0, 0);
            wareHouse_Button.MaximumSize = new Size(243, 38);
            wareHouse_Button.MinimumSize = new Size(38, 38);
            wareHouse_Button.Name = "wareHouse_Button";
            wareHouse_Button.Size = new Size(243, 38);
            wareHouse_Button.TabIndex = 12;
            wareHouse_Button.Text = "      Warehouse";
            wareHouse_Button.TextAlign = ContentAlignment.MiddleLeft;
            wareHouse_Button.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(124, 139, 114);
            panel10.Location = new Point(3, 330);
            panel10.Name = "panel10";
            panel10.Size = new Size(243, 2);
            panel10.TabIndex = 16;
            // 
            // panel11
            // 
            panel11.Controls.Add(about_Button);
            panel11.Location = new Point(3, 338);
            panel11.MaximumSize = new Size(243, 38);
            panel11.MinimumSize = new Size(42, 38);
            panel11.Name = "panel11";
            panel11.Size = new Size(243, 38);
            panel11.TabIndex = 16;
            // 
            // about_Button
            // 
            about_Button.FlatStyle = FlatStyle.Flat;
            about_Button.Font = new Font("Constantia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            about_Button.ForeColor = Color.FromArgb(88, 85, 78);
            about_Button.Image = Properties.Resources.info_24px;
            about_Button.ImageAlign = ContentAlignment.MiddleLeft;
            about_Button.Location = new Point(0, 0);
            about_Button.MaximumSize = new Size(243, 38);
            about_Button.MinimumSize = new Size(38, 38);
            about_Button.Name = "about_Button";
            about_Button.Size = new Size(243, 38);
            about_Button.TabIndex = 12;
            about_Button.Text = "      About";
            about_Button.TextAlign = ContentAlignment.MiddleLeft;
            about_Button.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.Location = new Point(3, 382);
            panel12.Name = "panel12";
            panel12.Size = new Size(243, 109);
            panel12.TabIndex = 17;
            // 
            // panel13
            // 
            panel13.Controls.Add(setting_Button);
            panel13.Location = new Point(3, 497);
            panel13.MaximumSize = new Size(243, 38);
            panel13.MinimumSize = new Size(42, 38);
            panel13.Name = "panel13";
            panel13.Size = new Size(243, 38);
            panel13.TabIndex = 19;
            // 
            // setting_Button
            // 
            setting_Button.FlatStyle = FlatStyle.Flat;
            setting_Button.Font = new Font("Constantia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            setting_Button.ForeColor = Color.FromArgb(88, 85, 78);
            setting_Button.Image = Properties.Resources.setting_24px;
            setting_Button.ImageAlign = ContentAlignment.MiddleLeft;
            setting_Button.Location = new Point(0, 0);
            setting_Button.MaximumSize = new Size(243, 38);
            setting_Button.MinimumSize = new Size(38, 38);
            setting_Button.Name = "setting_Button";
            setting_Button.Size = new Size(243, 38);
            setting_Button.TabIndex = 12;
            setting_Button.Text = "      Settings";
            setting_Button.TextAlign = ContentAlignment.MiddleLeft;
            setting_Button.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(versionNumber);
            panel9.Location = new Point(3, 541);
            panel9.MaximumSize = new Size(243, 38);
            panel9.MinimumSize = new Size(42, 38);
            panel9.Name = "panel9";
            panel9.Size = new Size(243, 38);
            panel9.TabIndex = 15;
            // 
            // versionNumber
            // 
            versionNumber.AutoSize = true;
            versionNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            versionNumber.Location = new Point(84, 16);
            versionNumber.Name = "versionNumber";
            versionNumber.Size = new Size(78, 15);
            versionNumber.TabIndex = 0;
            versionNumber.Text = "Version 0.0.1";
            // 
            // slideBarTimer
            // 
            slideBarTimer.Interval = 3;
            slideBarTimer.Tick += slideBarTimer_Tick;
            // 
            // headerBar
            // 
            headerBar.BackColor = Color.FromArgb(250, 240, 215);
            headerBar.Controls.Add(containerName);
            headerBar.Controls.Add(closeApp_Button);
            headerBar.Controls.Add(logout_Button);
            headerBar.Dock = DockStyle.Top;
            headerBar.Location = new Point(249, 0);
            headerBar.Name = "headerBar";
            headerBar.Size = new Size(771, 41);
            headerBar.TabIndex = 4;
            headerBar.MouseDown += headerBar_MouseDown;
            headerBar.MouseMove += headerBar_MouseMove;
            headerBar.MouseUp += headerBar_MouseUp;
            // 
            // containerName
            // 
            containerName.AutoSize = true;
            containerName.Font = new Font("Constantia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            containerName.ForeColor = Color.FromArgb(65, 67, 54);
            containerName.Location = new Point(6, 5);
            containerName.Name = "containerName";
            containerName.Size = new Size(250, 31);
            containerName.TabIndex = 0;
            containerName.Text = "CONTAINER_NAME";
            // 
            // closeApp_Button
            // 
            closeApp_Button.FlatAppearance.BorderSize = 0;
            closeApp_Button.FlatStyle = FlatStyle.Flat;
            closeApp_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeApp_Button.ImageAlign = ContentAlignment.MiddleRight;
            closeApp_Button.Location = new Point(735, 2);
            closeApp_Button.Name = "closeApp_Button";
            closeApp_Button.Size = new Size(33, 36);
            closeApp_Button.TabIndex = 5;
            closeApp_Button.Text = "X";
            closeApp_Button.UseVisualStyleBackColor = true;
            closeApp_Button.Click += closeApp_Button_Click;
            // 
            // logout_Button
            // 
            logout_Button.FlatAppearance.BorderSize = 0;
            logout_Button.FlatStyle = FlatStyle.Flat;
            logout_Button.Image = Properties.Resources.logout_24px;
            logout_Button.ImageAlign = ContentAlignment.MiddleRight;
            logout_Button.Location = new Point(641, 3);
            logout_Button.Name = "logout_Button";
            logout_Button.Size = new Size(78, 36);
            logout_Button.TabIndex = 5;
            logout_Button.Text = "Logout";
            logout_Button.TextAlign = ContentAlignment.MiddleLeft;
            logout_Button.UseVisualStyleBackColor = true;
            // 
            // mainInterface
            // 
            mainInterface.BackColor = Color.White;
            mainInterface.Dock = DockStyle.Fill;
            mainInterface.Location = new Point(249, 41);
            mainInterface.MaximumSize = new Size(1163, 543);
            mainInterface.MinimumSize = new Size(771, 541);
            mainInterface.Name = "mainInterface";
            mainInterface.Size = new Size(771, 541);
            mainInterface.TabIndex = 5;
            // 
            // form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 582);
            Controls.Add(mainInterface);
            Controls.Add(headerBar);
            Controls.Add(slideBar_Container);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Main";
            Text = "Form1";
            Load += form_Main_Load;
            ((System.ComponentModel.ISupportInitialize)avatar_Image).EndInit();
            slideBar_Container.ResumeLayout(false);
            menu_container.ResumeLayout(false);
            info_Container.ResumeLayout(false);
            info_Container.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            headerBar.ResumeLayout(false);
            headerBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CircularPictureBox avatar_Image;
        private Panel panel1;
        private Label permission;
        private Label username;
        private FlowLayoutPanel slideBar_Container;
        private Panel info_Container;
        private System.Windows.Forms.Timer slideBarTimer;
        private Panel menu_container;
        private Button menu_Button;
        private Button petManager_Button;
        private Button customer_Button;
        private Panel panel4;
        private Button service_Button;
        private Panel panel5;
        private Button wareHouse_Button;
        private Panel panel2;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private Panel panel11;
        private Button about_Button;
        private Panel panel9;
        private Panel panel12;
        private Label versionNumber;
        private Panel headerBar;
        private Button logout_Button;
        private Panel panel13;
        private Button setting_Button;
        private Button closeApp_Button;
        private Label containerName;
        private Panel mainInterface;
    }
}