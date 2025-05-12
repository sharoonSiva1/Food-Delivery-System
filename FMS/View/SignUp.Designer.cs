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
            this.SignUpLabel.Location = new System.Drawing.Point(327, 36);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(139, 39);
            this.SignUpLabel.TabIndex = 0;
            this.SignUpLabel.Text = "Sign Up";
            // 
            // AccTypeLabel
            // 
            this.AccTypeLabel.AutoSize = true;
            this.AccTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccTypeLabel.Location = new System.Drawing.Point(299, 98);
            this.AccTypeLabel.Name = "AccTypeLabel";
            this.AccTypeLabel.Size = new System.Drawing.Size(194, 25);
            this.AccTypeLabel.TabIndex = 1;
            this.AccTypeLabel.Text = "Select Account Type";
            // 
            // RestaurantButton
            // 
            this.RestaurantButton.Location = new System.Drawing.Point(333, 153);
            this.RestaurantButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestaurantButton.Name = "RestaurantButton";
            this.RestaurantButton.Size = new System.Drawing.Size(132, 43);
            this.RestaurantButton.TabIndex = 2;
            this.RestaurantButton.Text = "Restaurant";
            this.RestaurantButton.UseVisualStyleBackColor = true;
            this.RestaurantButton.Click += new System.EventHandler(this.RestaurantButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(333, 220);
            this.CustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(132, 43);
            this.CustomerButton.TabIndex = 3;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // DeliveryDriverButton
            // 
            this.DeliveryDriverButton.Location = new System.Drawing.Point(333, 287);
            this.DeliveryDriverButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeliveryDriverButton.Name = "DeliveryDriverButton";
            this.DeliveryDriverButton.Size = new System.Drawing.Size(132, 43);
            this.DeliveryDriverButton.TabIndex = 4;
            this.DeliveryDriverButton.Text = "Delivery Driver";
            this.DeliveryDriverButton.UseVisualStyleBackColor = true;
            this.DeliveryDriverButton.Click += new System.EventHandler(this.DeliveryDriverButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(349, 348);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(99, 36);
            this.GoBackButton.TabIndex = 5;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.DeliveryDriverButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.RestaurantButton);
            this.Controls.Add(this.AccTypeLabel);
            this.Controls.Add(this.SignUpLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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