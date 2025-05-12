namespace FMS.View
{
    partial class SignUp
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
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.AccTypeLabel = new System.Windows.Forms.Label();
            this.RestaurantButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.DeliveryDriverButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SignUpLabel.Location = new System.Drawing.Point(245, 29);
            this.SignUpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(110, 31);
            this.SignUpLabel.TabIndex = 0;
            this.SignUpLabel.Text = "Sign Up";
            // 
            // AccTypeLabel
            // 
            this.AccTypeLabel.AutoSize = true;
            this.AccTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccTypeLabel.Location = new System.Drawing.Point(224, 80);
            this.AccTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccTypeLabel.Name = "AccTypeLabel";
            this.AccTypeLabel.Size = new System.Drawing.Size(155, 20);
            this.AccTypeLabel.TabIndex = 1;
            this.AccTypeLabel.Text = "Select Account Type";
            // 
            // RestaurantButton
            // 
            this.RestaurantButton.Location = new System.Drawing.Point(250, 124);
            this.RestaurantButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RestaurantButton.Name = "RestaurantButton";
            this.RestaurantButton.Size = new System.Drawing.Size(99, 35);
            this.RestaurantButton.TabIndex = 2;
            this.RestaurantButton.Text = "Restaurant";
            this.RestaurantButton.UseVisualStyleBackColor = true;
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(250, 179);
            this.CustomerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(99, 35);
            this.CustomerButton.TabIndex = 3;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // DeliveryDriverButton
            // 
            this.DeliveryDriverButton.Location = new System.Drawing.Point(250, 233);
            this.DeliveryDriverButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeliveryDriverButton.Name = "DeliveryDriverButton";
            this.DeliveryDriverButton.Size = new System.Drawing.Size(99, 35);
            this.DeliveryDriverButton.TabIndex = 4;
            this.DeliveryDriverButton.Text = "Delivery Driver";
            this.DeliveryDriverButton.UseVisualStyleBackColor = true;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(272, 290);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(56, 22);
            this.GoBackButton.TabIndex = 5;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.DeliveryDriverButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.RestaurantButton);
            this.Controls.Add(this.AccTypeLabel);
            this.Controls.Add(this.SignUpLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Label AccTypeLabel;
        private System.Windows.Forms.Button RestaurantButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button DeliveryDriverButton;
        private System.Windows.Forms.Button GoBackButton;
    }
}