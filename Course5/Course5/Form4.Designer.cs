namespace Course5
{
    partial class Form4
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
            this.girdi = new System.Windows.Forms.TextBox();
            this.dugme = new System.Windows.Forms.Button();
            this.katsayi = new System.Windows.Forms.ListBox();
            this.us = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // girdi
            // 
            this.girdi.Location = new System.Drawing.Point(109, 31);
            this.girdi.Multiline = true;
            this.girdi.Name = "girdi";
            this.girdi.Size = new System.Drawing.Size(309, 71);
            this.girdi.TabIndex = 0;
            this.girdi.Text = "5x^2 + 4x^3 +3x^4 = 125";
            // 
            // dugme
            // 
            this.dugme.Location = new System.Drawing.Point(223, 179);
            this.dugme.Name = "dugme";
            this.dugme.Size = new System.Drawing.Size(120, 63);
            this.dugme.TabIndex = 1;
            this.dugme.Text = "button1";
            this.dugme.UseVisualStyleBackColor = true;
            this.dugme.Click += new System.EventHandler(this.dugme_Click);
            // 
            // katsayi
            // 
            this.katsayi.FormattingEnabled = true;
            this.katsayi.ItemHeight = 16;
            this.katsayi.Items.AddRange(new object[] {
            ""});
            this.katsayi.Location = new System.Drawing.Point(464, 158);
            this.katsayi.Name = "katsayi";
            this.katsayi.Size = new System.Drawing.Size(120, 84);
            this.katsayi.TabIndex = 2;
            this.katsayi.SelectedIndexChanged += new System.EventHandler(this.katsayi_SelectedIndexChanged);
            // 
            // us
            // 
            this.us.FormattingEnabled = true;
            this.us.ItemHeight = 16;
            this.us.Location = new System.Drawing.Point(464, 40);
            this.us.Name = "us";
            this.us.Size = new System.Drawing.Size(120, 84);
            this.us.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.us);
            this.Controls.Add(this.katsayi);
            this.Controls.Add(this.dugme);
            this.Controls.Add(this.girdi);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox girdi;
        private System.Windows.Forms.Button dugme;
        private System.Windows.Forms.ListBox katsayi;
        private System.Windows.Forms.ListBox us;
    }
}