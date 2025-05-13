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
            this.AvailableRestaurantsBtn = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AvailableRestaurantsBtn
            // 
            this.AvailableRestaurantsBtn.FormattingEnabled = true;
            this.AvailableRestaurantsBtn.ItemHeight = 20;
            this.AvailableRestaurantsBtn.Location = new System.Drawing.Point(87, 97);
            this.AvailableRestaurantsBtn.Name = "AvailableRestaurantsBtn";
            this.AvailableRestaurantsBtn.Size = new System.Drawing.Size(218, 284);
            this.AvailableRestaurantsBtn.TabIndex = 0;
            this.AvailableRestaurantsBtn.SelectedIndexChanged += new System.EventHandler(this.AvailableRestaurantsBtn_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(69, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Restaurants";
            // 
            // ViewMenuBtn
            // 
            this.ViewMenuBtn.Location = new System.Drawing.Point(448, 207);
            this.ViewMenuBtn.Name = "ViewMenuBtn";
            this.ViewMenuBtn.Size = new System.Drawing.Size(125, 35);
            this.ViewMenuBtn.TabIndex = 4;
            this.ViewMenuBtn.Text = "View Menu";
            this.ViewMenuBtn.UseVisualStyleBackColor = true;
            this.ViewMenuBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pick_restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewMenuBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AvailableRestaurantsBtn);
            this.Name = "Pick_restaurant";
            this.Text = "Pick_restaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvailableRestaurantsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewMenuBtn;
    }
}