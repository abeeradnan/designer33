namespace WindowsFormsApplication85
{
    partial class Form7
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
            this.userControl71 = new WindowsFormsApplication85.UserControl7();
            this.SuspendLayout();
            // 
            // userControl71
            // 
            this.userControl71.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl71.Location = new System.Drawing.Point(0, 0);
            this.userControl71.Name = "userControl71";
            this.userControl71.Size = new System.Drawing.Size(1059, 868);
            this.userControl71.TabIndex = 0;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 773);
            this.Controls.Add(this.userControl71);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl7 userControl71;
    }
}