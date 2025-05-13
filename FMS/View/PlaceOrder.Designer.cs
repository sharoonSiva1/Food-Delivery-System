namespace FMS.View
{
    partial class PlaceOrder
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
            this.label3 = new System.Windows.Forms.Label();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.CartGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.PlaceOrderBtn = new System.Windows.Forms.Button();
            this.RemoveItemBtn = new System.Windows.Forms.Button();
            this.UpdateGridBtn = new System.Windows.Forms.Button();
            this.AvailableFoodItemGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableFoodItemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(206, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restaurant Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Available Food Items";
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.Location = new System.Drawing.Point(543, 225);
            this.AddToCartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(106, 31);
            this.AddToCartBtn.TabIndex = 7;
            this.AddToCartBtn.Text = "Add to Cart";
            this.AddToCartBtn.UseVisualStyleBackColor = true;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // CartGrid
            // 
            this.CartGrid.AllowUserToAddRows = false;
            this.CartGrid.AllowUserToDeleteRows = false;
            this.CartGrid.AllowUserToResizeColumns = false;
            this.CartGrid.AllowUserToResizeRows = false;
            this.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGrid.Location = new System.Drawing.Point(141, 339);
            this.CartGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CartGrid.MultiSelect = false;
            this.CartGrid.Name = "CartGrid";
            this.CartGrid.RowHeadersWidth = 62;
            this.CartGrid.RowTemplate.Height = 28;
            this.CartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartGrid.Size = new System.Drawing.Size(508, 105);
            this.CartGrid.TabIndex = 8;
            this.CartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cart";
            // 
            // PlaceOrderBtn
            // 
            this.PlaceOrderBtn.Location = new System.Drawing.Point(168, 458);
            this.PlaceOrderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlaceOrderBtn.Name = "PlaceOrderBtn";
            this.PlaceOrderBtn.Size = new System.Drawing.Size(106, 31);
            this.PlaceOrderBtn.TabIndex = 10;
            this.PlaceOrderBtn.Text = "Place Order";
            this.PlaceOrderBtn.UseVisualStyleBackColor = true;
            this.PlaceOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            // 
            // RemoveItemBtn
            // 
            this.RemoveItemBtn.Location = new System.Drawing.Point(329, 458);
            this.RemoveItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveItemBtn.Name = "RemoveItemBtn";
            this.RemoveItemBtn.Size = new System.Drawing.Size(106, 31);
            this.RemoveItemBtn.TabIndex = 11;
            this.RemoveItemBtn.Text = "Remove Item";
            this.RemoveItemBtn.UseVisualStyleBackColor = true;
            this.RemoveItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // UpdateGridBtn
            // 
            this.UpdateGridBtn.Location = new System.Drawing.Point(489, 458);
            this.UpdateGridBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateGridBtn.Name = "UpdateGridBtn";
            this.UpdateGridBtn.Size = new System.Drawing.Size(106, 31);
            this.UpdateGridBtn.TabIndex = 12;
            this.UpdateGridBtn.Text = "Go Back";
            this.UpdateGridBtn.UseVisualStyleBackColor = true;
            this.UpdateGridBtn.Click += new System.EventHandler(this.UpdateGridBtn_Click);
            // 
            // AvailableFoodItemGrid
            // 
            this.AvailableFoodItemGrid.AllowUserToAddRows = false;
            this.AvailableFoodItemGrid.AllowUserToDeleteRows = false;
            this.AvailableFoodItemGrid.AllowUserToResizeColumns = false;
            this.AvailableFoodItemGrid.AllowUserToResizeRows = false;
            this.AvailableFoodItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableFoodItemGrid.Location = new System.Drawing.Point(141, 103);
            this.AvailableFoodItemGrid.MultiSelect = false;
            this.AvailableFoodItemGrid.Name = "AvailableFoodItemGrid";
            this.AvailableFoodItemGrid.RowHeadersWidth = 51;
            this.AvailableFoodItemGrid.RowTemplate.Height = 24;
            this.AvailableFoodItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AvailableFoodItemGrid.Size = new System.Drawing.Size(508, 117);
            this.AvailableFoodItemGrid.TabIndex = 13;
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 575);
            this.Controls.Add(this.AvailableFoodItemGrid);
            this.Controls.Add(this.UpdateGridBtn);
            this.Controls.Add(this.RemoveItemBtn);
            this.Controls.Add(this.PlaceOrderBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CartGrid);
            this.Controls.Add(this.AddToCartBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlaceOrder";
            this.Text = "PlaceOrder";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableFoodItemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.DataGridView CartGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PlaceOrderBtn;
        private System.Windows.Forms.Button RemoveItemBtn;
        private System.Windows.Forms.Button UpdateGridBtn;
        private System.Windows.Forms.DataGridView AvailableFoodItemGrid;
    }
}