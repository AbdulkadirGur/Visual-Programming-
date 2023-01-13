namespace Course8
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
            this.Ana = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.Liste = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // Ana
            // 
            this.Ana.FileName = "openFileDialog1";
            this.Ana.Filter = "\"Resim dosyalari |*.png;*.jpg\"";
            this.Ana.FileOk += new System.ComponentModel.CancelEventHandler(this.Ana_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "openFileDialog1";
            // 
            // Resim
            // 
            this.Resim.Location = new System.Drawing.Point(32, 74);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(260, 270);
            this.Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resim.TabIndex = 1;
            this.Resim.TabStop = false;
            // 
            // Liste
            // 
            this.Liste.FormattingEnabled = true;
            this.Liste.ItemHeight = 20;
            this.Liste.Location = new System.Drawing.Point(353, 74);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(260, 264);
            this.Liste.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "PictureBox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(413, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "ListBox";
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(225, 389);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(172, 87);
            this.Hesapla.TabIndex = 5;
            this.Hesapla.Text = "Ac";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 572);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.Resim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog Ana;
        private Label label1;
        private PictureBox Resim;
        private ListBox Liste;
        private Label label2;
        private Label label3;
        private Button Hesapla;
        private Label label4;
    }
}