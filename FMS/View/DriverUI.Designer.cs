namespace FMS.View
{
    partial class DriverUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDriverOrders = new System.Windows.Forms.DataGridView();
            this.MarkDeliveredBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriverOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(233, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assigned Order";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewDriverOrders
            // 
            this.dataGridViewDriverOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDriverOrders.Location = new System.Drawing.Point(110, 129);
            this.dataGridViewDriverOrders.Name = "dataGridViewDriverOrders";
            this.dataGridViewDriverOrders.RowHeadersWidth = 62;
            this.dataGridViewDriverOrders.RowTemplate.Height = 28;
            this.dataGridViewDriverOrders.Size = new System.Drawing.Size(577, 209);
            this.dataGridViewDriverOrders.TabIndex = 7;
            this.dataGridViewDriverOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDriverOrders_CellContentClick);
            // 
            // MarkDeliveredBtn
            // 
            this.MarkDeliveredBtn.Location = new System.Drawing.Point(199, 363);
            this.MarkDeliveredBtn.Name = "MarkDeliveredBtn";
            this.MarkDeliveredBtn.Size = new System.Drawing.Size(180, 47);
            this.MarkDeliveredBtn.TabIndex = 8;
            this.MarkDeliveredBtn.Text = "Mark Delivered ";
            this.MarkDeliveredBtn.UseVisualStyleBackColor = true;
            this.MarkDeliveredBtn.Click += new System.EventHandler(this.MarkDeliveredBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(405, 363);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(180, 47);
            this.LogOutBtn.TabIndex = 9;
            this.LogOutBtn.Text = "Log Out ";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // DriverUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.MarkDeliveredBtn);
            this.Controls.Add(this.dataGridViewDriverOrders);
            this.Controls.Add(this.label2);
            this.Name = "DriverUI";
            this.Text = "D";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriverOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDriverOrders;
        private System.Windows.Forms.Button MarkDeliveredBtn;
        private System.Windows.Forms.Button LogOutBtn;
    }
}