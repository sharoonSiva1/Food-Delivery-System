namespace FMS.View
{
    partial class ViewMyOrders
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
            this.DataGridViewMyOrders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.CancelOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMyOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewMyOrders
            // 
            this.DataGridViewMyOrders.AllowUserToAddRows = false;
            this.DataGridViewMyOrders.AllowUserToDeleteRows = false;
            this.DataGridViewMyOrders.AllowUserToResizeColumns = false;
            this.DataGridViewMyOrders.AllowUserToResizeRows = false;
            this.DataGridViewMyOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewMyOrders.ColumnHeadersHeight = 29;
            this.DataGridViewMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewMyOrders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridViewMyOrders.Location = new System.Drawing.Point(139, 95);
            this.DataGridViewMyOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewMyOrders.MultiSelect = false;
            this.DataGridViewMyOrders.Name = "DataGridViewMyOrders";
            this.DataGridViewMyOrders.ReadOnly = true;
            this.DataGridViewMyOrders.RowHeadersWidth = 62;
            this.DataGridViewMyOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewMyOrders.RowTemplate.Height = 28;
            this.DataGridViewMyOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMyOrders.ShowEditingIcon = false;
            this.DataGridViewMyOrders.Size = new System.Drawing.Size(668, 258);
            this.DataGridViewMyOrders.TabIndex = 0;
            this.DataGridViewMyOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMyOrders_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(382, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "My Orders";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(12, 193);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(109, 28);
            this.RefreshBtn.TabIndex = 7;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Location = new System.Drawing.Point(12, 244);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(109, 28);
            this.GoBackBtn.TabIndex = 8;
            this.GoBackBtn.Text = "Go back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // CancelOrderBtn
            // 
            this.CancelOrderBtn.Location = new System.Drawing.Point(12, 142);
            this.CancelOrderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelOrderBtn.Name = "CancelOrderBtn";
            this.CancelOrderBtn.Size = new System.Drawing.Size(109, 28);
            this.CancelOrderBtn.TabIndex = 10;
            this.CancelOrderBtn.Text = "Cancel Order";
            this.CancelOrderBtn.UseVisualStyleBackColor = true;
            this.CancelOrderBtn.Click += new System.EventHandler(this.CancelOrderBtn_Click);
            // 
            // ViewMyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 418);
            this.Controls.Add(this.CancelOrderBtn);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewMyOrders);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewMyOrders";
            this.Text = "ViewMyOrders";
            this.Load += new System.EventHandler(this.ViewMyOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMyOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewMyOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Button CancelOrderBtn;
    }
}