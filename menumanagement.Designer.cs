namespace RestaurantManagement
{
    partial class menumanagement
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_Description = new System.Windows.Forms.TextBox();
            this.txtbox_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combox_Category = new System.Windows.Forms.ComboBox();
            this.dgv_Menu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_ItemId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(343, 116);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(343, 156);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(343, 195);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(200, 90);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Name.TabIndex = 3;
            // 
            // txtbox_Description
            // 
            this.txtbox_Description.Location = new System.Drawing.Point(200, 136);
            this.txtbox_Description.Name = "txtbox_Description";
            this.txtbox_Description.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Description.TabIndex = 4;
            // 
            // txtbox_Price
            // 
            this.txtbox_Price.Location = new System.Drawing.Point(200, 181);
            this.txtbox_Price.Name = "txtbox_Price";
            this.txtbox_Price.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Price.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            // 
            // combox_Category
            // 
            this.combox_Category.FormattingEnabled = true;
            this.combox_Category.Items.AddRange(new object[] {
            "Appetizer",
            "Main Course",
            "Dessert"});
            this.combox_Category.Location = new System.Drawing.Point(200, 229);
            this.combox_Category.Name = "combox_Category";
            this.combox_Category.Size = new System.Drawing.Size(121, 21);
            this.combox_Category.TabIndex = 11;
            // 
            // dgv_Menu
            // 
            this.dgv_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Menu.Location = new System.Drawing.Point(137, 279);
            this.dgv_Menu.Name = "dgv_Menu";
            this.dgv_Menu.Size = new System.Drawing.Size(443, 150);
            this.dgv_Menu.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ItemID";
            // 
            // txtbox_ItemId
            // 
            this.txtbox_ItemId.Location = new System.Drawing.Point(200, 43);
            this.txtbox_ItemId.Name = "txtbox_ItemId";
            this.txtbox_ItemId.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ItemId.TabIndex = 14;
            // 
            // menumanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.txtbox_ItemId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_Menu);
            this.Controls.Add(this.combox_Category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_Price);
            this.Controls.Add(this.txtbox_Description);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Name = "menumanagement";
            this.Text = "menumanagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_Description;
        private System.Windows.Forms.TextBox txtbox_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combox_Category;
        private System.Windows.Forms.DataGridView dgv_Menu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_ItemId;
    }
}