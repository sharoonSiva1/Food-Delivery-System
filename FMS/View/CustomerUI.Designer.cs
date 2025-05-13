namespace FMS.View
{
    partial class CustomerUI
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
            this.PlaceOrderBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewOrderBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlaceOrderBtn
            // 
            this.PlaceOrderBtn.Location = new System.Drawing.Point(268, 150);
            this.PlaceOrderBtn.Name = "PlaceOrderBtn";
            this.PlaceOrderBtn.Size = new System.Drawing.Size(210, 50);
            this.PlaceOrderBtn.TabIndex = 0;
            this.PlaceOrderBtn.Text = "Place Order";
            this.PlaceOrderBtn.UseVisualStyleBackColor = true;
            this.PlaceOrderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(272, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // ViewOrderBtn
            // 
            this.ViewOrderBtn.Location = new System.Drawing.Point(268, 206);
            this.ViewOrderBtn.Name = "ViewOrderBtn";
            this.ViewOrderBtn.Size = new System.Drawing.Size(210, 50);
            this.ViewOrderBtn.TabIndex = 3;
            this.ViewOrderBtn.Text = "View My orders";
            this.ViewOrderBtn.UseVisualStyleBackColor = true;
            this.ViewOrderBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(268, 262);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(210, 50);
            this.LogOutBtn.TabIndex = 4;
            this.LogOutBtn.Text = "Logout";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ViewOrderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlaceOrderBtn);
            this.Name = "CustomerUI";
            this.Text = "CustomerUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlaceOrderBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewOrderBtn;
        private System.Windows.Forms.Button LogOutBtn;
    }
}