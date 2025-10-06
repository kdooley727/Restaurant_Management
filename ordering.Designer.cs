namespace RestaurantManagement
{
    partial class ordering
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
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.btn_Order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.AllowUserToOrderColumns = true;
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Location = new System.Drawing.Point(12, 12);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.Size = new System.Drawing.Size(776, 214);
            this.dgv_Orders.TabIndex = 0;
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(308, 298);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(75, 23);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.dgv_Orders);
            this.Name = "ordering";
            this.Text = "Ordering";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.Button btn_Order;
    }
}