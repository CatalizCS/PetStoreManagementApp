namespace PetStoreManagementApp.Pages
{
    partial class form_Service
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
            txt_search = new TextBox();
            lab_search = new Label();
            dataGridView_service = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            species = new DataGridViewTextBoxColumn();
            pet_owner = new DataGridViewTextBoxColumn();
            services = new DataGridViewTextBoxColumn();
            get_vaccinated = new DataGridViewTextBoxColumn();
            get_examined = new DataGridViewTextBoxColumn();
            good_health = new DataGridViewTextBoxColumn();
            lab_servicename = new Label();
            lab_unitprice = new Label();
            lab_describe = new Label();
            txt_servicename = new TextBox();
            txt_describe = new TextBox();
            txt_unitprice = new TextBox();
            btn_uwu = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_service).BeginInit();
            SuspendLayout();
            // 
            // txt_search
            // 
            txt_search.BorderStyle = BorderStyle.None;
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(97, 14);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(465, 22);
            txt_search.TabIndex = 2;
            // 
            // lab_search
            // 
            lab_search.AutoSize = true;
            lab_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_search.Location = new Point(34, 14);
            lab_search.Name = "lab_search";
            lab_search.Size = new Size(57, 21);
            lab_search.TabIndex = 3;
            lab_search.Text = "Search";
            // 
            // dataGridView_service
            // 
            dataGridView_service.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_service.Columns.AddRange(new DataGridViewColumn[] { name, age, species, pet_owner, services, get_vaccinated, get_examined, good_health });
            dataGridView_service.Location = new Point(12, 162);
            dataGridView_service.Name = "dataGridView_service";
            dataGridView_service.RowTemplate.Height = 25;
            dataGridView_service.Size = new Size(776, 276);
            dataGridView_service.TabIndex = 4;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            // 
            // age
            // 
            age.HeaderText = "Age";
            age.Name = "age";
            // 
            // species
            // 
            species.HeaderText = "Species";
            species.Name = "species";
            // 
            // pet_owner
            // 
            pet_owner.HeaderText = "Pet Owner";
            pet_owner.Name = "pet_owner";
            // 
            // services
            // 
            services.HeaderText = "Services in Use";
            services.Name = "services";
            // 
            // get_vaccinated
            // 
            get_vaccinated.HeaderText = "Get vaccinated";
            get_vaccinated.Name = "get_vaccinated";
            // 
            // get_examined
            // 
            get_examined.HeaderText = "Get examined";
            get_examined.Name = "get_examined";
            // 
            // good_health
            // 
            good_health.HeaderText = "Good health";
            good_health.Name = "good_health";
            // 
            // lab_servicename
            // 
            lab_servicename.AutoSize = true;
            lab_servicename.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_servicename.Location = new Point(39, 58);
            lab_servicename.Name = "lab_servicename";
            lab_servicename.Size = new Size(109, 21);
            lab_servicename.TabIndex = 5;
            lab_servicename.Text = "Service Name:";
            // 
            // lab_unitprice
            // 
            lab_unitprice.AutoSize = true;
            lab_unitprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_unitprice.Location = new Point(39, 79);
            lab_unitprice.Name = "lab_unitprice";
            lab_unitprice.Size = new Size(80, 21);
            lab_unitprice.TabIndex = 6;
            lab_unitprice.Text = "Unit Price:";
            // 
            // lab_describe
            // 
            lab_describe.AutoSize = true;
            lab_describe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_describe.Location = new Point(39, 100);
            lab_describe.Name = "lab_describe";
            lab_describe.Size = new Size(73, 21);
            lab_describe.TabIndex = 7;
            lab_describe.Text = "Describe:";
            // 
            // txt_servicename
            // 
            txt_servicename.BorderStyle = BorderStyle.None;
            txt_servicename.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_servicename.Location = new Point(154, 61);
            txt_servicename.Name = "txt_servicename";
            txt_servicename.Size = new Size(144, 18);
            txt_servicename.TabIndex = 8;
            // 
            // txt_describe
            // 
            txt_describe.BorderStyle = BorderStyle.None;
            txt_describe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_describe.Location = new Point(154, 103);
            txt_describe.Multiline = true;
            txt_describe.Name = "txt_describe";
            txt_describe.Size = new Size(312, 39);
            txt_describe.TabIndex = 9;
            // 
            // txt_unitprice
            // 
            txt_unitprice.BorderStyle = BorderStyle.None;
            txt_unitprice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_unitprice.Location = new Point(154, 82);
            txt_unitprice.Name = "txt_unitprice";
            txt_unitprice.Size = new Size(144, 18);
            txt_unitprice.TabIndex = 10;
            // 
            // btn_uwu
            // 
            btn_uwu.Location = new Point(568, 105);
            btn_uwu.Name = "btn_uwu";
            btn_uwu.Size = new Size(64, 37);
            btn_uwu.TabIndex = 26;
            btn_uwu.Text = "UwU";
            btn_uwu.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(568, 58);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(64, 37);
            btn_delete.TabIndex = 25;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(498, 105);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(64, 37);
            btn_edit.TabIndex = 24;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(498, 58);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(64, 37);
            btn_add.TabIndex = 23;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // form_Service
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_uwu);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(txt_unitprice);
            Controls.Add(txt_describe);
            Controls.Add(txt_servicename);
            Controls.Add(lab_describe);
            Controls.Add(lab_unitprice);
            Controls.Add(lab_servicename);
            Controls.Add(dataGridView_service);
            Controls.Add(lab_search);
            Controls.Add(txt_search);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Service";
            Text = "form_Service";
            ((System.ComponentModel.ISupportInitialize)dataGridView_service).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_search;
        private Label lab_search;
        private DataGridView dataGridView_service;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn species;
        private DataGridViewTextBoxColumn pet_owner;
        private DataGridViewTextBoxColumn services;
        private DataGridViewTextBoxColumn get_vaccinated;
        private DataGridViewTextBoxColumn get_examined;
        private DataGridViewTextBoxColumn good_health;
        private Label lab_servicename;
        private Label lab_unitprice;
        private Label lab_describe;
        private TextBox txt_servicename;
        private TextBox txt_describe;
        private TextBox txt_unitprice;
        private Button btn_uwu;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
    }
}