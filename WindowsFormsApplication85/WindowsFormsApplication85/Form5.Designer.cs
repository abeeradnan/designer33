namespace WindowsFormsApplication85
{
    partial class Form5
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
            this.slide5panel1 = new System.Windows.Forms.Panel();
            this.userControl51 = new WindowsFormsApplication85.UserControl5();
            this.SuspendLayout();
            // 
            // slide5panel1
            // 
            this.slide5panel1.Location = new System.Drawing.Point(8, 8);
            this.slide5panel1.Name = "slide5panel1";
            this.slide5panel1.Size = new System.Drawing.Size(10, 14);
            this.slide5panel1.TabIndex = 1;
            // 
            // userControl51
            // 
            this.userControl51.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl51.Location = new System.Drawing.Point(-1, 0);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(1059, 868);
            this.userControl51.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 765);
            this.Controls.Add(this.slide5panel1);
            this.Controls.Add(this.userControl51);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl5 userControl51;
        private System.Windows.Forms.Panel slide5panel1;
    }
}