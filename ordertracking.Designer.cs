namespace RestaurantManagement
{
    partial class ordertracking
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
            this.dgv_OrderTracking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_OrderTracking
            // 
            this.dgv_OrderTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderTracking.Location = new System.Drawing.Point(32, 35);
            this.dgv_OrderTracking.Name = "dgv_OrderTracking";
            this.dgv_OrderTracking.Size = new System.Drawing.Size(623, 296);
            this.dgv_OrderTracking.TabIndex = 0;
            // 
            // ordertracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 361);
            this.Controls.Add(this.dgv_OrderTracking);
            this.Name = "ordertracking";
            this.Text = "ordertracking";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderTracking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_OrderTracking;
    }
}