namespace FMS.View
{
    partial class RestaurantManageMenuUI
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
            this.menuItemsGrid = new System.Windows.Forms.DataGridView();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.UpdateItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemsGrid
            // 
            this.menuItemsGrid.AllowUserToOrderColumns = true;
            this.menuItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsGrid.Location = new System.Drawing.Point(64, 104);
            this.menuItemsGrid.Name = "menuItemsGrid";
            this.menuItemsGrid.RowHeadersWidth = 51;
            this.menuItemsGrid.RowTemplate.Height = 24;
            this.menuItemsGrid.Size = new System.Drawing.Size(686, 180);
            this.menuItemsGrid.TabIndex = 0;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(119, 299);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 29);
            this.AddItemButton.TabIndex = 1;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.Location = new System.Drawing.Point(285, 299);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(75, 29);
            this.UpdateItemButton.TabIndex = 2;
            this.UpdateItemButton.Text = "Update";
            this.UpdateItemButton.UseVisualStyleBackColor = true;
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(438, 299);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(75, 29);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(589, 299);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(82, 29);
            this.GoBackButton.TabIndex = 4;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.MenuLabel.Location = new System.Drawing.Point(68, 49);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(81, 31);
            this.MenuLabel.TabIndex = 5;
            this.MenuLabel.Text = "Menu";
            // 
            // RestaurantManageMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.UpdateItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.menuItemsGrid);
            this.Name = "RestaurantManageMenuUI";
            this.Text = "RestaurantManageMenuUI";
            this.Load += new System.EventHandler(this.RestaurantManageMenuUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menuItemsGrid;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button UpdateItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label MenuLabel;
    }
}