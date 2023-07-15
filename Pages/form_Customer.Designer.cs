namespace PetStoreManagementApp.Pages
{
    partial class form_Customer
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
            dataGridView_customer = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            species = new DataGridViewTextBoxColumn();
            pet_owner = new DataGridViewTextBoxColumn();
            services = new DataGridViewTextBoxColumn();
            get_vaccinated = new DataGridViewTextBoxColumn();
            get_examined = new DataGridViewTextBoxColumn();
            good_health = new DataGridViewTextBoxColumn();
            lab_search = new Label();
            txt_search = new TextBox();
            txt_day = new TextBox();
            txt_phonenumber = new TextBox();
            txt_petname = new TextBox();
            lab_phonenumber = new Label();
            lab_day = new Label();
            lab_petname = new Label();
            txt_customername = new TextBox();
            lab_customername = new Label();
            btn_uwu = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_customer).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_customer
            // 
            dataGridView_customer.BackgroundColor = Color.White;
            dataGridView_customer.BorderStyle = BorderStyle.None;
            dataGridView_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_customer.Columns.AddRange(new DataGridViewColumn[] { name, age, species, pet_owner, services, get_vaccinated, get_examined, good_health });
            dataGridView_customer.Location = new Point(12, 162);
            dataGridView_customer.Name = "dataGridView_customer";
            dataGridView_customer.RowTemplate.Height = 25;
            dataGridView_customer.Size = new Size(776, 276);
            dataGridView_customer.TabIndex = 1;
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
            // lab_search
            // 
            lab_search.AutoSize = true;
            lab_search.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lab_search.Location = new Point(34, 14);
            lab_search.Name = "lab_search";
            lab_search.Size = new Size(59, 19);
            lab_search.TabIndex = 4;
            lab_search.Text = "Search";
            // 
            // txt_search
            // 
            txt_search.BorderStyle = BorderStyle.None;
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(97, 14);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(465, 22);
            txt_search.TabIndex = 3;
            // 
            // txt_day
            // 
            txt_day.BorderStyle = BorderStyle.None;
            txt_day.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_day.Location = new Point(167, 97);
            txt_day.Name = "txt_day";
            txt_day.Size = new Size(144, 18);
            txt_day.TabIndex = 18;
            // 
            // txt_phonenumber
            // 
            txt_phonenumber.BorderStyle = BorderStyle.None;
            txt_phonenumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phonenumber.Location = new Point(167, 118);
            txt_phonenumber.Name = "txt_phonenumber";
            txt_phonenumber.Size = new Size(144, 18);
            txt_phonenumber.TabIndex = 17;
            // 
            // txt_petname
            // 
            txt_petname.BorderStyle = BorderStyle.None;
            txt_petname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_petname.Location = new Point(167, 76);
            txt_petname.Name = "txt_petname";
            txt_petname.Size = new Size(144, 18);
            txt_petname.TabIndex = 16;
            // 
            // lab_phonenumber
            // 
            lab_phonenumber.AutoSize = true;
            lab_phonenumber.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lab_phonenumber.Location = new Point(34, 115);
            lab_phonenumber.Name = "lab_phonenumber";
            lab_phonenumber.Size = new Size(121, 19);
            lab_phonenumber.TabIndex = 15;
            lab_phonenumber.Text = "Phone Number:";
            // 
            // lab_day
            // 
            lab_day.AutoSize = true;
            lab_day.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lab_day.Location = new Point(34, 94);
            lab_day.Name = "lab_day";
            lab_day.Size = new Size(42, 19);
            lab_day.TabIndex = 14;
            lab_day.Text = "Day:";
            // 
            // lab_petname
            // 
            lab_petname.AutoSize = true;
            lab_petname.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lab_petname.Location = new Point(34, 73);
            lab_petname.Name = "lab_petname";
            lab_petname.Size = new Size(83, 19);
            lab_petname.TabIndex = 13;
            lab_petname.Text = "Pet Name:";
            // 
            // txt_customername
            // 
            txt_customername.BorderStyle = BorderStyle.None;
            txt_customername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_customername.Location = new Point(167, 55);
            txt_customername.Name = "txt_customername";
            txt_customername.Size = new Size(144, 18);
            txt_customername.TabIndex = 12;
            // 
            // lab_customername
            // 
            lab_customername.AutoSize = true;
            lab_customername.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lab_customername.Location = new Point(34, 52);
            lab_customername.Name = "lab_customername";
            lab_customername.Size = new Size(129, 19);
            lab_customername.TabIndex = 11;
            lab_customername.Text = "Customer Name:";
            // 
            // btn_uwu
            // 
            btn_uwu.BackColor = Color.White;
            btn_uwu.FlatAppearance.BorderSize = 0;
            btn_uwu.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btn_uwu.FlatStyle = FlatStyle.Flat;
            btn_uwu.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_uwu.Location = new Point(414, 99);
            btn_uwu.Name = "btn_uwu";
            btn_uwu.Size = new Size(64, 37);
            btn_uwu.TabIndex = 26;
            btn_uwu.Text = "UwU";
            btn_uwu.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.White;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(414, 52);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(64, 37);
            btn_delete.TabIndex = 25;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.White;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.Location = new Point(344, 99);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(64, 37);
            btn_edit.TabIndex = 24;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.White;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.Location = new Point(344, 52);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(64, 37);
            btn_add.TabIndex = 23;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // form_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_uwu);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(txt_day);
            Controls.Add(txt_phonenumber);
            Controls.Add(txt_petname);
            Controls.Add(lab_phonenumber);
            Controls.Add(lab_day);
            Controls.Add(lab_petname);
            Controls.Add(txt_customername);
            Controls.Add(lab_customername);
            Controls.Add(lab_search);
            Controls.Add(txt_search);
            Controls.Add(dataGridView_customer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Customer";
            Text = "form_Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridView_customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_customer;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn species;
        private DataGridViewTextBoxColumn pet_owner;
        private DataGridViewTextBoxColumn services;
        private DataGridViewTextBoxColumn get_vaccinated;
        private DataGridViewTextBoxColumn get_examined;
        private DataGridViewTextBoxColumn good_health;
        private Label lab_search;
        private TextBox txt_search;
        private TextBox txt_day;
        private TextBox txt_phonenumber;
        private TextBox txt_petname;
        private Label lab_phonenumber;
        private Label lab_day;
        private Label lab_petname;
        private TextBox txt_customername;
        private Label lab_customername;
        private Button btn_uwu;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
    }
}