namespace FMS.View
{
    partial class ChoosePayment
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
            this.CardPaymentBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CashOnDeliveryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CardPaymentBtn
            // 
            this.CardPaymentBtn.Location = new System.Drawing.Point(282, 235);
            this.CardPaymentBtn.Name = "CardPaymentBtn";
            this.CardPaymentBtn.Size = new System.Drawing.Size(165, 52);
            this.CardPaymentBtn.TabIndex = 9;
            this.CardPaymentBtn.Text = "Card payment";
            this.CardPaymentBtn.UseVisualStyleBackColor = true;
            this.CardPaymentBtn.Click += new System.EventHandler(this.CardPaymentBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(204, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payment method";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CashOnDeliveryBtn
            // 
            this.CashOnDeliveryBtn.Location = new System.Drawing.Point(282, 177);
            this.CashOnDeliveryBtn.Name = "CashOnDeliveryBtn";
            this.CashOnDeliveryBtn.Size = new System.Drawing.Size(165, 52);
            this.CashOnDeliveryBtn.TabIndex = 7;
            this.CashOnDeliveryBtn.Text = "Cash on Delivery";
            this.CashOnDeliveryBtn.UseVisualStyleBackColor = true;
            this.CashOnDeliveryBtn.Click += new System.EventHandler(this.CashOnDeliveryBtn_Click);
            // 
            // ChoosePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CardPaymentBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CashOnDeliveryBtn);
            this.Name = "ChoosePayment";
            this.Text = "ChoosePayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CardPaymentBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CashOnDeliveryBtn;
    }
}