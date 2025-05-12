namespace FMS.View
{
    partial class RestaurantManageProfileUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateProfileButton = new System.Windows.Forms.Button();
            this.DeleteProfileButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.OpeningTimeBox = new System.Windows.Forms.DateTimePicker();
            this.ClosingTimeBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(351, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opening Time : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Closing Time : ";
            // 
            // UpdateProfileButton
            // 
            this.UpdateProfileButton.Location = new System.Drawing.Point(541, 124);
            this.UpdateProfileButton.Name = "UpdateProfileButton";
            this.UpdateProfileButton.Size = new System.Drawing.Size(133, 29);
            this.UpdateProfileButton.TabIndex = 6;
            this.UpdateProfileButton.Text = "Update Profile";
            this.UpdateProfileButton.UseVisualStyleBackColor = true;
            this.UpdateProfileButton.Click += new System.EventHandler(this.UpdateProfileButton_Click);
            // 
            // DeleteProfileButton
            // 
            this.DeleteProfileButton.Location = new System.Drawing.Point(541, 175);
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.Size = new System.Drawing.Size(133, 29);
            this.DeleteProfileButton.TabIndex = 7;
            this.DeleteProfileButton.Text = "Delete Profile";
            this.DeleteProfileButton.UseVisualStyleBackColor = true;
            this.DeleteProfileButton.Click += new System.EventHandler(this.DeleteProfileButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(541, 227);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(133, 29);
            this.GoBackButton.TabIndex = 8;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(293, 112);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 22);
            this.NameTextBox.TabIndex = 9;
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(293, 143);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(200, 22);
            this.DescTextBox.TabIndex = 10;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(293, 181);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(200, 22);
            this.AddressTextBox.TabIndex = 11;
            // 
            // OpeningTimeBox
            // 
            this.OpeningTimeBox.CustomFormat = "hh:mm tt";
            this.OpeningTimeBox.Location = new System.Drawing.Point(293, 218);
            this.OpeningTimeBox.MaxDate = new System.DateTime(2025, 5, 20, 0, 0, 0, 0);
            this.OpeningTimeBox.MinDate = new System.DateTime(2025, 5, 12, 0, 0, 0, 0);
            this.OpeningTimeBox.Name = "OpeningTimeBox";
            this.OpeningTimeBox.ShowUpDown = true;
            this.OpeningTimeBox.Size = new System.Drawing.Size(200, 22);
            this.OpeningTimeBox.TabIndex = 12;
            this.OpeningTimeBox.Value = new System.DateTime(2025, 5, 12, 19, 29, 0, 0);
            // 
            // ClosingTimeBox
            // 
            this.ClosingTimeBox.CustomFormat = "hh:mm tt";
            this.ClosingTimeBox.Location = new System.Drawing.Point(293, 248);
            this.ClosingTimeBox.Name = "ClosingTimeBox";
            this.ClosingTimeBox.ShowUpDown = true;
            this.ClosingTimeBox.Size = new System.Drawing.Size(200, 22);
            this.ClosingTimeBox.TabIndex = 13;
            // 
            // RestaurantManageProfileUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClosingTimeBox);
            this.Controls.Add(this.OpeningTimeBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.DeleteProfileButton);
            this.Controls.Add(this.UpdateProfileButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RestaurantManageProfileUI";
            this.Text = "RestaurantManageProfileUI";
            this.Load += new System.EventHandler(this.RestaurantManageProfileUI_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpdateProfileButton;
        private System.Windows.Forms.Button DeleteProfileButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.DateTimePicker OpeningTimeBox;
        private System.Windows.Forms.DateTimePicker ClosingTimeBox;
    }
}