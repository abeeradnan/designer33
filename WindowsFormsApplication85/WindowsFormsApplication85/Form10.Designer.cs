namespace WindowsFormsApplication85
{
    partial class Form10
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
            this.userControl101 = new WindowsFormsApplication85.UserControl10();
            this.SuspendLayout();
            // 
            // userControl101
            // 
            this.userControl101.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl101.Location = new System.Drawing.Point(0, 0);
            this.userControl101.Name = "userControl101";
            this.userControl101.Size = new System.Drawing.Size(1059, 868);
            this.userControl101.TabIndex = 0;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 765);
            this.Controls.Add(this.userControl101);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl10 userControl101;
    }
}