namespace FMS.View
{
    partial class Pick_restaurant
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
            this.ViewMenuBtn = new System.Windows.Forms.Button();
            this.AvailableRestaurantsBtn = new System.Windows.Forms.DataGridView();
            this.GoBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableRestaurantsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(61, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Restaurants";
            // 
            // ViewMenuBtn
            // 
            this.ViewMenuBtn.Location = new System.Drawing.Point(219, 280);
            this.ViewMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewMenuBtn.Name = "ViewMenuBtn";
            this.ViewMenuBtn.Size = new System.Drawing.Size(111, 28);
            this.ViewMenuBtn.TabIndex = 4;
            this.ViewMenuBtn.Text = "View Menu";
            this.ViewMenuBtn.UseVisualStyleBackColor = true;
            this.ViewMenuBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AvailableRestaurantsBtn
            // 
            this.AvailableRestaurantsBtn.AllowUserToAddRows = false;
            this.AvailableRestaurantsBtn.AllowUserToDeleteRows = false;
            this.AvailableRestaurantsBtn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableRestaurantsBtn.Location = new System.Drawing.Point(68, 104);
            this.AvailableRestaurantsBtn.Name = "AvailableRestaurantsBtn";
            this.AvailableRestaurantsBtn.ReadOnly = true;
            this.AvailableRestaurantsBtn.RowHeadersWidth = 51;
            this.AvailableRestaurantsBtn.RowTemplate.Height = 24;
            this.AvailableRestaurantsBtn.Size = new System.Drawing.Size(549, 150);
            this.AvailableRestaurantsBtn.TabIndex = 5;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(360, 280);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(111, 28);
            this.GoBackButton.TabIndex = 6;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // Pick_restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.AvailableRestaurantsBtn);
            this.Controls.Add(this.ViewMenuBtn);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pick_restaurant";
            this.Text = "Pick_restaurant";
            this.Load += new System.EventHandler(this.Pick_restaurant_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableRestaurantsBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewMenuBtn;
        private System.Windows.Forms.DataGridView AvailableRestaurantsBtn;
        private System.Windows.Forms.Button GoBackButton;
    }
}