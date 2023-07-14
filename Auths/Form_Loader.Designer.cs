namespace PetStoreManagementApp.Dialogs
{
    partial class Form_Loader
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Loader));
            pictureBox1 = new PictureBox();
            loadingBar = new CircularProgressBar.CircularProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loading_timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loadingBar
            // 
            loadingBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            loadingBar.AnimationSpeed = 500;
            loadingBar.BackColor = Color.Transparent;
            loadingBar.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            loadingBar.ForeColor = Color.FromArgb(124, 139, 114);
            loadingBar.InnerColor = Color.FromArgb(255, 217, 192);
            loadingBar.InnerMargin = 2;
            loadingBar.InnerWidth = -1;
            loadingBar.Location = new Point(91, 146);
            loadingBar.MarqueeAnimationSpeed = 2000;
            loadingBar.Name = "loadingBar";
            loadingBar.OuterColor = Color.Gray;
            loadingBar.OuterMargin = -25;
            loadingBar.OuterWidth = 26;
            loadingBar.ProgressColor = Color.FromArgb(255, 128, 0);
            loadingBar.ProgressWidth = 6;
            loadingBar.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            loadingBar.Size = new Size(107, 107);
            loadingBar.StartAngle = 270;
            loadingBar.Style = ProgressBarStyle.Continuous;
            loadingBar.SubscriptColor = Color.FromArgb(166, 166, 166);
            loadingBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            loadingBar.SubscriptText = "";
            loadingBar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            loadingBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            loadingBar.SuperscriptText = "°C";
            loadingBar.TabIndex = 1;
            loadingBar.TextMargin = new Padding(8, 8, 0, 0);
            loadingBar.Value = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(273, 30);
            label1.TabIndex = 2;
            label1.Text = "PetStore Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(109, 256);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 2;
            label2.Text = "Loading....";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 299);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 3;
            label3.Text = "Made By CatalizCS";
            // 
            // Form_Loader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 222, 180);
            ClientSize = new Size(293, 319);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loadingBar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Loader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetStoreManagement - Loading";
            Load += Form_Loader_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar loadingBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer loading_timer;
    }
}