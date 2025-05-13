namespace FMS.View
{
    partial class CardPayment
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
            this.CardNumbertxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CardHoldertxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cvvtxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpireDatetxtbox = new System.Windows.Forms.TextBox();
            this.ConfirmPaymentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CardNumbertxtbox
            // 
            this.CardNumbertxtbox.Location = new System.Drawing.Point(83, 162);
            this.CardNumbertxtbox.Name = "CardNumbertxtbox";
            this.CardNumbertxtbox.Size = new System.Drawing.Size(225, 26);
            this.CardNumbertxtbox.TabIndex = 0;
            this.CardNumbertxtbox.TextChanged += new System.EventHandler(this.CardNumbertxtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(251, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Card Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cardholder Name";
            // 
            // CardHoldertxtbox
            // 
            this.CardHoldertxtbox.Location = new System.Drawing.Point(83, 219);
            this.CardHoldertxtbox.Name = "CardHoldertxtbox";
            this.CardHoldertxtbox.Size = new System.Drawing.Size(225, 26);
            this.CardHoldertxtbox.TabIndex = 7;
            this.CardHoldertxtbox.TextChanged += new System.EventHandler(this.CardHoldertxtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "CVV";
            // 
            // Cvvtxtbox
            // 
            this.Cvvtxtbox.Location = new System.Drawing.Point(451, 219);
            this.Cvvtxtbox.Name = "Cvvtxtbox";
            this.Cvvtxtbox.Size = new System.Drawing.Size(225, 26);
            this.Cvvtxtbox.TabIndex = 11;
            this.Cvvtxtbox.TextChanged += new System.EventHandler(this.Cvvtxtbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expiry Date (MM/YY)";
            // 
            // ExpireDatetxtbox
            // 
            this.ExpireDatetxtbox.Location = new System.Drawing.Point(451, 162);
            this.ExpireDatetxtbox.Name = "ExpireDatetxtbox";
            this.ExpireDatetxtbox.Size = new System.Drawing.Size(225, 26);
            this.ExpireDatetxtbox.TabIndex = 9;
            this.ExpireDatetxtbox.TextChanged += new System.EventHandler(this.ExpireDatetxtbox_TextChanged);
            // 
            // ConfirmPaymentBtn
            // 
            this.ConfirmPaymentBtn.Location = new System.Drawing.Point(285, 304);
            this.ConfirmPaymentBtn.Name = "ConfirmPaymentBtn";
            this.ConfirmPaymentBtn.Size = new System.Drawing.Size(167, 41);
            this.ConfirmPaymentBtn.TabIndex = 13;
            this.ConfirmPaymentBtn.Text = "Confirm Payment";
            this.ConfirmPaymentBtn.UseVisualStyleBackColor = true;
            this.ConfirmPaymentBtn.Click += new System.EventHandler(this.ConfirmPaymentBtn_Click);
            // 
            // CardPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmPaymentBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cvvtxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExpireDatetxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CardHoldertxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardNumbertxtbox);
            this.Name = "CardPayment";
            this.Text = "CardPayment";
            this.Load += new System.EventHandler(this.CardPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardNumbertxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardHoldertxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cvvtxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExpireDatetxtbox;
        private System.Windows.Forms.Button ConfirmPaymentBtn;
    }
}