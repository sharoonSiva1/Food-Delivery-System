namespace FMS.View
{
    partial class PickaDriver
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
            this.AvailableDriversLstbox = new System.Windows.Forms.ListBox();
            this.AssignDriverBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvailableDriversLstbox
            // 
            this.AvailableDriversLstbox.FormattingEnabled = true;
            this.AvailableDriversLstbox.ItemHeight = 20;
            this.AvailableDriversLstbox.Location = new System.Drawing.Point(94, 168);
            this.AvailableDriversLstbox.Name = "AvailableDriversLstbox";
            this.AvailableDriversLstbox.Size = new System.Drawing.Size(606, 124);
            this.AvailableDriversLstbox.TabIndex = 0;            // 
            // AssignDriverBtn
            // 
            this.AssignDriverBtn.Location = new System.Drawing.Point(329, 311);
            this.AssignDriverBtn.Name = "AssignDriverBtn";
            this.AssignDriverBtn.Size = new System.Drawing.Size(134, 46);
            this.AssignDriverBtn.TabIndex = 1;
            this.AssignDriverBtn.Text = "Assign Driver";
            this.AssignDriverBtn.UseVisualStyleBackColor = true;
            this.AssignDriverBtn.Click += new System.EventHandler(this.AssignDriverBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(178, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assign Delivery Driver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Available drivers";
            // 
            // PickaDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AssignDriverBtn);
            this.Controls.Add(this.AvailableDriversLstbox);
            this.Name = "PickaDriver";
            this.Text = "PickaDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvailableDriversLstbox;
        private System.Windows.Forms.Button AssignDriverBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}