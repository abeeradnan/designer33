namespace WindowsFormsApplication85
{
    partial class Form9
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
            this.userControl91 = new WindowsFormsApplication85.UserControl9();
            this.SuspendLayout();
            // 
            // userControl91
            // 
            this.userControl91.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl91.Location = new System.Drawing.Point(0, 0);
            this.userControl91.Name = "userControl91";
            this.userControl91.Size = new System.Drawing.Size(1059, 868);
            this.userControl91.TabIndex = 0;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 765);
            this.Controls.Add(this.userControl91);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl9 userControl91;
    }
}