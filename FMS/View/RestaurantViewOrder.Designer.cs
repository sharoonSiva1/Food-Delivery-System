namespace FMS.View
{
    partial class RestaurantViewOrder
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
            this.OngoingOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.GoBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OngoingOrdersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(290, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ongoing Orders";
            // 
            // OngoingOrdersDataGrid
            // 
            this.OngoingOrdersDataGrid.AllowUserToAddRows = false;
            this.OngoingOrdersDataGrid.AllowUserToDeleteRows = false;
            this.OngoingOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OngoingOrdersDataGrid.Location = new System.Drawing.Point(68, 121);
            this.OngoingOrdersDataGrid.Name = "OngoingOrdersDataGrid";
            this.OngoingOrdersDataGrid.ReadOnly = true;
            this.OngoingOrdersDataGrid.RowHeadersWidth = 51;
            this.OngoingOrdersDataGrid.RowTemplate.Height = 24;
            this.OngoingOrdersDataGrid.Size = new System.Drawing.Size(675, 170);
            this.OngoingOrdersDataGrid.TabIndex = 1;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(355, 313);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(99, 33);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // RestaurantViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.OngoingOrdersDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "RestaurantViewOrder";
            this.Text = "RestaurantViewOrder";
            this.Load += new System.EventHandler(this.RestaurantViewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OngoingOrdersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OngoingOrdersDataGrid;
        private System.Windows.Forms.Button GoBackButton;
    }
}