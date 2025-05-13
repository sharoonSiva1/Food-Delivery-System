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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.PlaceOrderBtn = new System.Windows.Forms.Button();
            this.RemoveItemBtn = new System.Windows.Forms.Button();
            this.UpdateGridBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(43, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 244);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restaurant Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Available Food Items";
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.Location = new System.Drawing.Point(43, 358);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(119, 39);
            this.AddToCartBtn.TabIndex = 7;
            this.AddToCartBtn.Text = "Add to Cart";
            this.AddToCartBtn.UseVisualStyleBackColor = true;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(380, 131);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cart";
            // 
            // PlaceOrderBtn
            // 
            this.PlaceOrderBtn.Location = new System.Drawing.Point(340, 276);
            this.PlaceOrderBtn.Name = "PlaceOrderBtn";
            this.PlaceOrderBtn.Size = new System.Drawing.Size(119, 39);
            this.PlaceOrderBtn.TabIndex = 10;
            this.PlaceOrderBtn.Text = "Place Order";
            this.PlaceOrderBtn.UseVisualStyleBackColor = true;
            this.PlaceOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            // 
            // RemoveItemBtn
            // 
            this.RemoveItemBtn.Location = new System.Drawing.Point(465, 276);
            this.RemoveItemBtn.Name = "RemoveItemBtn";
            this.RemoveItemBtn.Size = new System.Drawing.Size(119, 39);
            this.RemoveItemBtn.TabIndex = 11;
            this.RemoveItemBtn.Text = "Remove Item";
            this.RemoveItemBtn.UseVisualStyleBackColor = true;
            this.RemoveItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // UpdateGridBtn
            // 
            this.UpdateGridBtn.Location = new System.Drawing.Point(590, 276);
            this.UpdateGridBtn.Name = "UpdateGridBtn";
            this.UpdateGridBtn.Size = new System.Drawing.Size(119, 39);
            this.UpdateGridBtn.TabIndex = 12;
            this.UpdateGridBtn.Text = "Update Grid";
            this.UpdateGridBtn.UseVisualStyleBackColor = true;
            this.UpdateGridBtn.Click += new System.EventHandler(this.UpdateGridBtn_Click);
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateGridBtn);
            this.Controls.Add(this.RemoveItemBtn);
            this.Controls.Add(this.PlaceOrderBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddToCartBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Name = "PlaceOrder";
            this.Text = "PlaceOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PlaceOrderBtn;
        private System.Windows.Forms.Button RemoveItemBtn;
        private System.Windows.Forms.Button UpdateGridBtn;
    }
}