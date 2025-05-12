namespace FMS.View
{
    partial class RestaurantUI
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
            this.ManageProfileButton = new System.Windows.Forms.Button();
            this.ManageMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(302, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant";
            // 
            // ManageProfileButton
            // 
            this.ManageProfileButton.Location = new System.Drawing.Point(309, 107);
            this.ManageProfileButton.Name = "ManageProfileButton";
            this.ManageProfileButton.Size = new System.Drawing.Size(176, 41);
            this.ManageProfileButton.TabIndex = 1;
            this.ManageProfileButton.Text = "Manage Profile";
            this.ManageProfileButton.UseVisualStyleBackColor = true;
            // 
            // ManageMenuButton
            // 
            this.ManageMenuButton.Location = new System.Drawing.Point(309, 169);
            this.ManageMenuButton.Name = "ManageMenuButton";
            this.ManageMenuButton.Size = new System.Drawing.Size(176, 41);
            this.ManageMenuButton.TabIndex = 2;
            this.ManageMenuButton.Text = "Manage Menu";
            this.ManageMenuButton.UseVisualStyleBackColor = true;
            // 
            // RestaurantUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ManageMenuButton);
            this.Controls.Add(this.ManageProfileButton);
            this.Controls.Add(this.label1);
            this.Name = "RestaurantUI";
            this.Text = "RestaurantUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageProfileButton;
        private System.Windows.Forms.Button ManageMenuButton;
    }
}