namespace WindowsFormsApplication85
{
    partial class Form8
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
            this.userControl81 = new WindowsFormsApplication85.UserControl8();
            this.SuspendLayout();
            // 
            // userControl81
            // 
            this.userControl81.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl81.Location = new System.Drawing.Point(0, 0);
            this.userControl81.Name = "userControl81";
            this.userControl81.Size = new System.Drawing.Size(1059, 868);
            this.userControl81.TabIndex = 0;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 765);
            this.Controls.Add(this.userControl81);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl8 userControl81;
    }
}