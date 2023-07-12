namespace PetStoreManagementApp.Pages
{
    partial class form_PetManager
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
            dataGridView_petmanager = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            species = new DataGridViewTextBoxColumn();
            pet_owner = new DataGridViewTextBoxColumn();
            services = new DataGridViewTextBoxColumn();
            get_vaccinated = new DataGridViewTextBoxColumn();
            get_examined = new DataGridViewTextBoxColumn();
            good_health = new DataGridViewTextBoxColumn();
            txt_search = new TextBox();
            lab_search = new Label();
            lab_name = new Label();
            txt_name = new TextBox();
            lab_age = new Label();
            lab_species = new Label();
            lab_petowner = new Label();
            txt_age = new TextBox();
            txt_petowner = new TextBox();
            txt_species = new TextBox();
            lab_services = new Label();
            comboBox_services = new ComboBox();
            lab_vaccinated = new Label();
            lab_health = new Label();
            lab_examined = new Label();
            checkBox_vaccinated = new CheckBox();
            checkBox_examined = new CheckBox();
            checkBox_goodhealth = new CheckBox();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_uwu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_petmanager).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_petmanager
            // 
            dataGridView_petmanager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_petmanager.Columns.AddRange(new DataGridViewColumn[] { name, age, species, pet_owner, services, get_vaccinated, get_examined, good_health });
            dataGridView_petmanager.Location = new Point(12, 162);
            dataGridView_petmanager.Name = "dataGridView_petmanager";
            dataGridView_petmanager.RowTemplate.Height = 25;
            dataGridView_petmanager.Size = new Size(776, 276);
            dataGridView_petmanager.TabIndex = 0;
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
            // txt_search
            // 
            txt_search.BorderStyle = BorderStyle.None;
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(97, 14);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(465, 22);
            txt_search.TabIndex = 1;
            // 
            // lab_search
            // 
            lab_search.AutoSize = true;
            lab_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_search.Location = new Point(34, 14);
            lab_search.Name = "lab_search";
            lab_search.Size = new Size(57, 21);
            lab_search.TabIndex = 2;
            lab_search.Text = "Search";
            // 
            // lab_name
            // 
            lab_name.AutoSize = true;
            lab_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_name.Location = new Point(39, 58);
            lab_name.Name = "lab_name";
            lab_name.Size = new Size(55, 21);
            lab_name.TabIndex = 3;
            lab_name.Text = "Name:";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(132, 61);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(144, 18);
            txt_name.TabIndex = 4;
            // 
            // lab_age
            // 
            lab_age.AutoSize = true;
            lab_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_age.Location = new Point(39, 79);
            lab_age.Name = "lab_age";
            lab_age.Size = new Size(40, 21);
            lab_age.TabIndex = 5;
            lab_age.Text = "Age:";
            // 
            // lab_species
            // 
            lab_species.AutoSize = true;
            lab_species.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_species.Location = new Point(39, 100);
            lab_species.Name = "lab_species";
            lab_species.Size = new Size(65, 21);
            lab_species.TabIndex = 6;
            lab_species.Text = "Species:";
            // 
            // lab_petowner
            // 
            lab_petowner.AutoSize = true;
            lab_petowner.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_petowner.Location = new Point(39, 121);
            lab_petowner.Name = "lab_petowner";
            lab_petowner.Size = new Size(85, 21);
            lab_petowner.TabIndex = 7;
            lab_petowner.Text = "Pet Owner:";
            // 
            // txt_age
            // 
            txt_age.BorderStyle = BorderStyle.None;
            txt_age.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_age.Location = new Point(132, 82);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(144, 18);
            txt_age.TabIndex = 8;
            // 
            // txt_petowner
            // 
            txt_petowner.BorderStyle = BorderStyle.None;
            txt_petowner.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_petowner.Location = new Point(132, 124);
            txt_petowner.Name = "txt_petowner";
            txt_petowner.Size = new Size(144, 18);
            txt_petowner.TabIndex = 9;
            // 
            // txt_species
            // 
            txt_species.BorderStyle = BorderStyle.None;
            txt_species.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_species.Location = new Point(132, 103);
            txt_species.Name = "txt_species";
            txt_species.Size = new Size(144, 18);
            txt_species.TabIndex = 10;
            // 
            // lab_services
            // 
            lab_services.AutoSize = true;
            lab_services.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_services.Location = new Point(297, 58);
            lab_services.Name = "lab_services";
            lab_services.Size = new Size(115, 21);
            lab_services.TabIndex = 11;
            lab_services.Text = "Services in use:";
            // 
            // comboBox_services
            // 
            comboBox_services.FlatStyle = FlatStyle.Flat;
            comboBox_services.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_services.FormattingEnabled = true;
            comboBox_services.Location = new Point(418, 59);
            comboBox_services.Name = "comboBox_services";
            comboBox_services.Size = new Size(144, 20);
            comboBox_services.TabIndex = 12;
            // 
            // lab_vaccinated
            // 
            lab_vaccinated.AutoSize = true;
            lab_vaccinated.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_vaccinated.Location = new Point(298, 79);
            lab_vaccinated.Name = "lab_vaccinated";
            lab_vaccinated.Size = new Size(114, 21);
            lab_vaccinated.TabIndex = 13;
            lab_vaccinated.Text = "Get vaccinated:";
            // 
            // lab_health
            // 
            lab_health.AutoSize = true;
            lab_health.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_health.Location = new Point(298, 121);
            lab_health.Name = "lab_health";
            lab_health.Size = new Size(98, 21);
            lab_health.TabIndex = 14;
            lab_health.Text = "Good health:";
            // 
            // lab_examined
            // 
            lab_examined.AutoSize = true;
            lab_examined.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_examined.Location = new Point(298, 100);
            lab_examined.Name = "lab_examined";
            lab_examined.Size = new Size(108, 21);
            lab_examined.TabIndex = 15;
            lab_examined.Text = "Get examined:";
            // 
            // checkBox_vaccinated
            // 
            checkBox_vaccinated.AutoSize = true;
            checkBox_vaccinated.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_vaccinated.Location = new Point(418, 86);
            checkBox_vaccinated.Name = "checkBox_vaccinated";
            checkBox_vaccinated.Size = new Size(15, 14);
            checkBox_vaccinated.TabIndex = 16;
            checkBox_vaccinated.UseVisualStyleBackColor = true;
            // 
            // checkBox_examined
            // 
            checkBox_examined.AutoSize = true;
            checkBox_examined.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_examined.Location = new Point(418, 107);
            checkBox_examined.Name = "checkBox_examined";
            checkBox_examined.Size = new Size(15, 14);
            checkBox_examined.TabIndex = 17;
            checkBox_examined.UseVisualStyleBackColor = true;
            // 
            // checkBox_goodhealth
            // 
            checkBox_goodhealth.AutoSize = true;
            checkBox_goodhealth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_goodhealth.Location = new Point(418, 128);
            checkBox_goodhealth.Name = "checkBox_goodhealth";
            checkBox_goodhealth.Size = new Size(15, 14);
            checkBox_goodhealth.TabIndex = 18;
            checkBox_goodhealth.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(582, 58);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(64, 37);
            btn_add.TabIndex = 19;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(582, 105);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(64, 37);
            btn_edit.TabIndex = 20;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(652, 58);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(64, 37);
            btn_delete.TabIndex = 21;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_uwu
            // 
            btn_uwu.Location = new Point(652, 105);
            btn_uwu.Name = "btn_uwu";
            btn_uwu.Size = new Size(64, 37);
            btn_uwu.TabIndex = 22;
            btn_uwu.Text = "UwU";
            btn_uwu.UseVisualStyleBackColor = true;
            // 
            // form_PetManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_uwu);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(checkBox_goodhealth);
            Controls.Add(checkBox_examined);
            Controls.Add(checkBox_vaccinated);
            Controls.Add(lab_examined);
            Controls.Add(lab_health);
            Controls.Add(lab_vaccinated);
            Controls.Add(comboBox_services);
            Controls.Add(lab_services);
            Controls.Add(txt_species);
            Controls.Add(txt_petowner);
            Controls.Add(txt_age);
            Controls.Add(lab_petowner);
            Controls.Add(lab_species);
            Controls.Add(lab_age);
            Controls.Add(txt_name);
            Controls.Add(lab_name);
            Controls.Add(lab_search);
            Controls.Add(txt_search);
            Controls.Add(dataGridView_petmanager);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_PetManager";
            Text = "form_PetManager";
            ((System.ComponentModel.ISupportInitialize)dataGridView_petmanager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_petmanager;
        private TextBox txt_search;
        private Label lab_search;
        private Label lab_name;
        private TextBox txt_name;
        private Label lab_age;
        private Label lab_species;
        private Label lab_petowner;
        private TextBox txt_age;
        private TextBox txt_petowner;
        private TextBox txt_species;
        private Label lab_services;
        private ComboBox comboBox_services;
        private Label lab_vaccinated;
        private Label lab_health;
        private Label lab_examined;
        private CheckBox checkBox_vaccinated;
        private CheckBox checkBox_examined;
        private CheckBox checkBox_goodhealth;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn species;
        private DataGridViewTextBoxColumn pet_owner;
        private DataGridViewTextBoxColumn services;
        private DataGridViewTextBoxColumn get_vaccinated;
        private DataGridViewTextBoxColumn get_examined;
        private DataGridViewTextBoxColumn good_health;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_uwu;
    }
}