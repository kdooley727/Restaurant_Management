namespace RestaurantManagement
{
    partial class feedback
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Feedback = new System.Windows.Forms.DataGridView();
            this.combox_Rating = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txtbox_OrderId = new System.Windows.Forms.TextBox();
            this.rtxbx_Comment = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Feedback)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment";
            // 
            // dgv_Feedback
            // 
            this.dgv_Feedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Feedback.Location = new System.Drawing.Point(39, 261);
            this.dgv_Feedback.Name = "dgv_Feedback";
            this.dgv_Feedback.Size = new System.Drawing.Size(699, 155);
            this.dgv_Feedback.TabIndex = 3;
            // 
            // combox_Rating
            // 
            this.combox_Rating.FormattingEnabled = true;
            this.combox_Rating.Items.AddRange(new object[] {
            "1",
            "2 ",
            "3 ",
            "4 ",
            "5 "});
            this.combox_Rating.Location = new System.Drawing.Point(102, 136);
            this.combox_Rating.Name = "combox_Rating";
            this.combox_Rating.Size = new System.Drawing.Size(121, 21);
            this.combox_Rating.TabIndex = 4;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(525, 216);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txtbox_OrderId
            // 
            this.txtbox_OrderId.Location = new System.Drawing.Point(102, 94);
            this.txtbox_OrderId.Name = "txtbox_OrderId";
            this.txtbox_OrderId.Size = new System.Drawing.Size(100, 20);
            this.txtbox_OrderId.TabIndex = 6;
            // 
            // rtxbx_Comment
            // 
            this.rtxbx_Comment.Location = new System.Drawing.Point(102, 185);
            this.rtxbx_Comment.Name = "rtxbx_Comment";
            this.rtxbx_Comment.Size = new System.Drawing.Size(385, 70);
            this.rtxbx_Comment.TabIndex = 7;
            this.rtxbx_Comment.Text = "";
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxbx_Comment);
            this.Controls.Add(this.txtbox_OrderId);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.combox_Rating);
            this.Controls.Add(this.dgv_Feedback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "feedback";
            this.Text = "feedback";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Feedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Feedback;
        private System.Windows.Forms.ComboBox combox_Rating;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txtbox_OrderId;
        private System.Windows.Forms.RichTextBox rtxbx_Comment;
    }
}