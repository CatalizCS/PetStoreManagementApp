namespace PetStoreManagementApp.Pages
{
    partial class form_Warehouse
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
            dataGridView_warehouse = new DataGridView();
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
            btn_uwu = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            txt_unit = new TextBox();
            txt_price = new TextBox();
            txt_quantity = new TextBox();
            lab_price = new Label();
            lab_unit = new Label();
            lab_quantity = new Label();
            txt_nameitems = new TextBox();
            lab_nameitems = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_warehouse).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_warehouse
            // 
            dataGridView_warehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_warehouse.Columns.AddRange(new DataGridViewColumn[] { name, age, species, pet_owner, services, get_vaccinated, get_examined, good_health });
            dataGridView_warehouse.Location = new Point(12, 162);
            dataGridView_warehouse.Name = "dataGridView_warehouse";
            dataGridView_warehouse.RowTemplate.Height = 25;
            dataGridView_warehouse.Size = new Size(776, 276);
            dataGridView_warehouse.TabIndex = 2;
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
            lab_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_search.Location = new Point(34, 14);
            lab_search.Name = "lab_search";
            lab_search.Size = new Size(57, 21);
            lab_search.TabIndex = 5;
            lab_search.Text = "Search";
            // 
            // txt_search
            // 
            txt_search.BorderStyle = BorderStyle.None;
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(97, 14);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(465, 22);
            txt_search.TabIndex = 6;
            // 
            // btn_uwu
            // 
            btn_uwu.Location = new Point(414, 99);
            btn_uwu.Name = "btn_uwu";
            btn_uwu.Size = new Size(64, 37);
            btn_uwu.TabIndex = 39;
            btn_uwu.Text = "UwU";
            btn_uwu.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(414, 52);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(64, 37);
            btn_delete.TabIndex = 38;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(344, 99);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(64, 37);
            btn_edit.TabIndex = 37;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(344, 52);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(64, 37);
            btn_add.TabIndex = 36;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // txt_unit
            // 
            txt_unit.BorderStyle = BorderStyle.None;
            txt_unit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_unit.Location = new Point(167, 97);
            txt_unit.Name = "txt_unit";
            txt_unit.Size = new Size(144, 18);
            txt_unit.TabIndex = 35;
            // 
            // txt_price
            // 
            txt_price.BorderStyle = BorderStyle.None;
            txt_price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_price.Location = new Point(167, 118);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(144, 18);
            txt_price.TabIndex = 34;
            // 
            // txt_quantity
            // 
            txt_quantity.BorderStyle = BorderStyle.None;
            txt_quantity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(167, 76);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(144, 18);
            txt_quantity.TabIndex = 33;
            // 
            // lab_price
            // 
            lab_price.AutoSize = true;
            lab_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_price.Location = new Point(34, 115);
            lab_price.Name = "lab_price";
            lab_price.Size = new Size(47, 21);
            lab_price.TabIndex = 32;
            lab_price.Text = "Price:";
            // 
            // lab_unit
            // 
            lab_unit.AutoSize = true;
            lab_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_unit.Location = new Point(34, 94);
            lab_unit.Name = "lab_unit";
            lab_unit.Size = new Size(42, 21);
            lab_unit.TabIndex = 31;
            lab_unit.Text = "Unit:";
            // 
            // lab_quantity
            // 
            lab_quantity.AutoSize = true;
            lab_quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_quantity.Location = new Point(34, 73);
            lab_quantity.Name = "lab_quantity";
            lab_quantity.Size = new Size(73, 21);
            lab_quantity.TabIndex = 30;
            lab_quantity.Text = "Quantity:";
            // 
            // txt_nameitems
            // 
            txt_nameitems.BorderStyle = BorderStyle.None;
            txt_nameitems.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nameitems.Location = new Point(167, 55);
            txt_nameitems.Name = "txt_nameitems";
            txt_nameitems.Size = new Size(144, 18);
            txt_nameitems.TabIndex = 29;
            // 
            // lab_nameitems
            // 
            lab_nameitems.AutoSize = true;
            lab_nameitems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_nameitems.Location = new Point(34, 52);
            lab_nameitems.Name = "lab_nameitems";
            lab_nameitems.Size = new Size(97, 21);
            lab_nameitems.TabIndex = 28;
            lab_nameitems.Text = "Name Items:";
            // 
            // form_Warehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_uwu);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(txt_unit);
            Controls.Add(txt_price);
            Controls.Add(txt_quantity);
            Controls.Add(lab_price);
            Controls.Add(lab_unit);
            Controls.Add(lab_quantity);
            Controls.Add(txt_nameitems);
            Controls.Add(lab_nameitems);
            Controls.Add(txt_search);
            Controls.Add(lab_search);
            Controls.Add(dataGridView_warehouse);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Warehouse";
            Text = "form_Warehouse";
            ((System.ComponentModel.ISupportInitialize)dataGridView_warehouse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_warehouse;
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
        private Button btn_uwu;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private TextBox txt_unit;
        private TextBox txt_price;
        private TextBox txt_quantity;
        private Label lab_price;
        private Label lab_unit;
        private Label lab_quantity;
        private TextBox txt_nameitems;
        private Label lab_nameitems;
    }
}