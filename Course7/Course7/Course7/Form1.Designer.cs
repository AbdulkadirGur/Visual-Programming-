namespace Course7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vade = new System.Windows.Forms.ListBox();
            this.Faiz = new System.Windows.Forms.ListBox();
            this.Ana = new System.Windows.Forms.TextBox();
            this.Hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vade
            // 
            this.Vade.FormattingEnabled = true;
            this.Vade.ItemHeight = 20;
            this.Vade.Items.AddRange(new object[] {
            "1 Aylik - 3 Aylik",
            "4 Aylik - 6 Aylik",
            "7 Aylik - 9 Aylik",
            "10 Aylik - 12 Aylik"});
            this.Vade.Location = new System.Drawing.Point(146, 113);
            this.Vade.Name = "Vade";
            this.Vade.Size = new System.Drawing.Size(203, 184);
            this.Vade.TabIndex = 0;
            this.Vade.SelectedIndexChanged += new System.EventHandler(this.Vade_SelectedIndexChanged);
            // 
            // Faiz
            // 
            this.Faiz.FormattingEnabled = true;
            this.Faiz.ItemHeight = 20;
            this.Faiz.Items.AddRange(new object[] {
            "1% - 3%",
            "4% - 7%",
            "7% - 10%",
            "10% - 20%"});
            this.Faiz.Location = new System.Drawing.Point(390, 113);
            this.Faiz.Name = "Faiz";
            this.Faiz.Size = new System.Drawing.Size(203, 184);
            this.Faiz.TabIndex = 1;
            this.Faiz.SelectedIndexChanged += new System.EventHandler(this.Faiz_SelectedIndexChanged);
            // 
            // Ana
            // 
            this.Ana.Location = new System.Drawing.Point(146, 33);
            this.Ana.Multiline = true;
            this.Ana.Name = "Ana";
            this.Ana.Size = new System.Drawing.Size(301, 34);
            this.Ana.TabIndex = 2;
            this.Ana.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(146, 345);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(189, 58);
            this.Hesapla.TabIndex = 3;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vade";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(473, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Faiz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(269, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ana";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.Ana);
            this.Controls.Add(this.Faiz);
            this.Controls.Add(this.Vade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Vade;
        private ListBox Faiz;
        private TextBox Ana;
        private Button Hesapla;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}