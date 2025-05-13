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
<<<<<<< HEAD
            this.AvailableDriversLstbox = new System.Windows.Forms.ListBox();
            this.AssignDriverBtn = new System.Windows.Forms.Button();
=======
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
>>>>>>> c5019d217a9aabaad3ea5b91650c94a1de16a8d9
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
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
=======
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(94, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(606, 124);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Assign Driver";
            this.button1.UseVisualStyleBackColor = true;
>>>>>>> c5019d217a9aabaad3ea5b91650c94a1de16a8d9
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
<<<<<<< HEAD
            this.Controls.Add(this.AssignDriverBtn);
            this.Controls.Add(this.AvailableDriversLstbox);
=======
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
>>>>>>> c5019d217a9aabaad3ea5b91650c94a1de16a8d9
            this.Name = "PickaDriver";
            this.Text = "PickaDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.ListBox AvailableDriversLstbox;
        private System.Windows.Forms.Button AssignDriverBtn;
=======
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
>>>>>>> c5019d217a9aabaad3ea5b91650c94a1de16a8d9
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}