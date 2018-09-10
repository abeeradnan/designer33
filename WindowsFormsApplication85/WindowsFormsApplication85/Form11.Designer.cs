namespace WindowsFormsApplication85
{
    partial class Form11
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
            this.userControl111 = new WindowsFormsApplication85.UserControl11();
            this.SuspendLayout();
            // 
            // userControl111
            // 
            this.userControl111.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl111.Location = new System.Drawing.Point(0, 0);
            this.userControl111.Name = "userControl111";
            this.userControl111.Size = new System.Drawing.Size(1059, 868);
            this.userControl111.TabIndex = 0;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 765);
            this.Controls.Add(this.userControl111);
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl11 userControl111;
    }
}