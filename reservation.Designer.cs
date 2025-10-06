namespace RestaurantManagement
{
    partial class reservation
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
            this.components = new System.ComponentModel.Container();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txtbox_Table = new System.Windows.Forms.TextBox();
            this.txtbox_PartySize = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combox_Time = new System.Windows.Forms.ComboBox();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_ResNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Book
            // 
            this.btn_Book.Location = new System.Drawing.Point(328, 100);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(75, 23);
            this.btn_Book.TabIndex = 0;
            this.btn_Book.Text = "Book";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(328, 149);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txtbox_Table
            // 
            this.txtbox_Table.Location = new System.Drawing.Point(190, 100);
            this.txtbox_Table.Name = "txtbox_Table";
            this.txtbox_Table.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Table.TabIndex = 2;
            // 
            // txtbox_PartySize
            // 
            this.txtbox_PartySize.Location = new System.Drawing.Point(190, 152);
            this.txtbox_PartySize.Name = "txtbox_PartySize";
            this.txtbox_PartySize.Size = new System.Drawing.Size(100, 20);
            this.txtbox_PartySize.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // combox_Time
            // 
            this.combox_Time.DataSource = this.reservationBindingSource;
            this.combox_Time.FormattingEnabled = true;
            this.combox_Time.Location = new System.Drawing.Point(190, 250);
            this.combox_Time.Name = "combox_Time";
            this.combox_Time.Size = new System.Drawing.Size(121, 21);
            this.combox_Time.TabIndex = 5;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(RestaurantManagement.reservation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "# of People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reservation #";
            // 
            // txtbox_ResNum
            // 
            this.txtbox_ResNum.Location = new System.Drawing.Point(190, 49);
            this.txtbox_ResNum.Name = "txtbox_ResNum";
            this.txtbox_ResNum.Size = new System.Drawing.Size(141, 20);
            this.txtbox_ResNum.TabIndex = 11;
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 387);
            this.Controls.Add(this.txtbox_ResNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox_Time);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbox_PartySize);
            this.Controls.Add(this.txtbox_Table);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Book);
            this.Name = "reservation";
            this.Text = "reservation";
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txtbox_Table;
        private System.Windows.Forms.TextBox txtbox_PartySize;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combox_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_ResNum;
    }
}