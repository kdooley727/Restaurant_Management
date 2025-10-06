namespace RestaurantManagement
{
    partial class mainmenu
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Orders = new System.Windows.Forms.Button();
            this.btn_Reservation = new System.Windows.Forms.Button();
            this.btn_Feedback = new System.Windows.Forms.Button();
            this.btn_OrderTracking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(111, 96);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(245, 96);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(75, 23);
            this.btn_Registration.TabIndex = 1;
            this.btn_Registration.Text = "Registration";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(152, 217);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(128, 23);
            this.btn_Menu.TabIndex = 2;
            this.btn_Menu.Text = "Menu Management";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.Location = new System.Drawing.Point(245, 138);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Size = new System.Drawing.Size(75, 23);
            this.btn_Orders.TabIndex = 3;
            this.btn_Orders.Text = "Order";
            this.btn_Orders.UseVisualStyleBackColor = true;
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            // 
            // btn_Reservation
            // 
            this.btn_Reservation.Location = new System.Drawing.Point(111, 138);
            this.btn_Reservation.Name = "btn_Reservation";
            this.btn_Reservation.Size = new System.Drawing.Size(75, 23);
            this.btn_Reservation.TabIndex = 4;
            this.btn_Reservation.Text = "Reservations";
            this.btn_Reservation.UseVisualStyleBackColor = true;
            this.btn_Reservation.Click += new System.EventHandler(this.btn_Reservation_Click);
            // 
            // btn_Feedback
            // 
            this.btn_Feedback.Location = new System.Drawing.Point(245, 177);
            this.btn_Feedback.Name = "btn_Feedback";
            this.btn_Feedback.Size = new System.Drawing.Size(75, 23);
            this.btn_Feedback.TabIndex = 5;
            this.btn_Feedback.Text = "Feedback";
            this.btn_Feedback.UseVisualStyleBackColor = true;
            this.btn_Feedback.Click += new System.EventHandler(this.btn_Feedback_Click);
            // 
            // btn_OrderTracking
            // 
            this.btn_OrderTracking.Location = new System.Drawing.Point(111, 177);
            this.btn_OrderTracking.Name = "btn_OrderTracking";
            this.btn_OrderTracking.Size = new System.Drawing.Size(75, 23);
            this.btn_OrderTracking.TabIndex = 6;
            this.btn_OrderTracking.Text = "Track Order";
            this.btn_OrderTracking.UseVisualStyleBackColor = true;
            this.btn_OrderTracking.Click += new System.EventHandler(this.btn_OrderTracking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Restaurant Management System";
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OrderTracking);
            this.Controls.Add(this.btn_Feedback);
            this.Controls.Add(this.btn_Reservation);
            this.Controls.Add(this.btn_Orders);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.btn_Login);
            this.Name = "mainmenu";
            this.Text = "mainmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Orders;
        private System.Windows.Forms.Button btn_Reservation;
        private System.Windows.Forms.Button btn_Feedback;
        private System.Windows.Forms.Button btn_OrderTracking;
        private System.Windows.Forms.Label label1;
    }
}