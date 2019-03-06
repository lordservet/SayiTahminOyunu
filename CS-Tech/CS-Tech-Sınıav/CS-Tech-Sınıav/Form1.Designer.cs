namespace CS_Tech_Sınıav
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tahminT = new System.Windows.Forms.TextBox();
            this.tahminB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bilTahminT = new System.Windows.Forms.Label();
            this.bilTahimB = new System.Windows.Forms.Button();
            this.kulTahminSonucT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.artiT = new System.Windows.Forms.TextBox();
            this.degerB = new System.Windows.Forms.Button();
            this.eksiT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Aklınızdan 4 basamaklı bir sayı tutun.\r\n2. Tuttuğunuz sayıyı söylemeyin.\r\n3. B" +
    "ilgisayarın tutuğu sayısı tahmin etmeye çalışın.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tahminiz : ";
            // 
            // tahminT
            // 
            this.tahminT.Location = new System.Drawing.Point(101, 82);
            this.tahminT.MaxLength = 4;
            this.tahminT.Name = "tahminT";
            this.tahminT.Size = new System.Drawing.Size(69, 20);
            this.tahminT.TabIndex = 2;
            // 
            // tahminB
            // 
            this.tahminB.Location = new System.Drawing.Point(200, 79);
            this.tahminB.Name = "tahminB";
            this.tahminB.Size = new System.Drawing.Size(75, 23);
            this.tahminB.TabIndex = 3;
            this.tahminB.Text = "Tahmin Et";
            this.tahminB.UseVisualStyleBackColor = true;
            this.tahminB.Click += new System.EventHandler(this.tahminB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tahmin Sonuçlarınız : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bilgisayarın Tahmini : ";
            // 
            // bilTahminT
            // 
            this.bilTahminT.AutoSize = true;
            this.bilTahminT.Location = new System.Drawing.Point(151, 231);
            this.bilTahminT.Name = "bilTahminT";
            this.bilTahminT.Size = new System.Drawing.Size(0, 13);
            this.bilTahminT.TabIndex = 6;
            // 
            // bilTahimB
            // 
            this.bilTahimB.Location = new System.Drawing.Point(40, 205);
            this.bilTahimB.Name = "bilTahimB";
            this.bilTahimB.Size = new System.Drawing.Size(130, 23);
            this.bilTahimB.TabIndex = 7;
            this.bilTahimB.Text = "Bilgisyar Tahmin Etsin";
            this.bilTahimB.UseVisualStyleBackColor = true;
            this.bilTahimB.Click += new System.EventHandler(this.bilTahimB_Click);
            // 
            // kulTahminSonucT
            // 
            this.kulTahminSonucT.AutoSize = true;
            this.kulTahminSonucT.Location = new System.Drawing.Point(151, 121);
            this.kulTahminSonucT.Name = "kulTahminSonucT";
            this.kulTahminSonucT.Size = new System.Drawing.Size(0, 13);
            this.kulTahminSonucT.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yeri doğru bilinen rakam adedi : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yeri yanlış bilinen rakam adedi : ";
            // 
            // artiT
            // 
            this.artiT.Location = new System.Drawing.Point(200, 250);
            this.artiT.MaxLength = 1;
            this.artiT.Name = "artiT";
            this.artiT.Size = new System.Drawing.Size(29, 20);
            this.artiT.TabIndex = 11;
            this.artiT.Text = "0";
            this.artiT.TextChanged += new System.EventHandler(this.artiT_TextChanged);
            this.artiT.Enter += new System.EventHandler(this.artiT_Enter);
            // 
            // degerB
            // 
            this.degerB.Location = new System.Drawing.Point(200, 302);
            this.degerB.Name = "degerB";
            this.degerB.Size = new System.Drawing.Size(75, 23);
            this.degerB.TabIndex = 12;
            this.degerB.Text = "Değerlendir";
            this.degerB.UseVisualStyleBackColor = true;
            this.degerB.Click += new System.EventHandler(this.degerB_Click);
            // 
            // eksiT
            // 
            this.eksiT.Location = new System.Drawing.Point(200, 276);
            this.eksiT.Name = "eksiT";
            this.eksiT.Size = new System.Drawing.Size(29, 20);
            this.eksiT.TabIndex = 13;
            this.eksiT.Text = "0";
            this.eksiT.TextChanged += new System.EventHandler(this.eksiT_TextChanged);
            this.eksiT.Enter += new System.EventHandler(this.eksiT_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(624, 354);
            this.Controls.Add(this.eksiT);
            this.Controls.Add(this.degerB);
            this.Controls.Add(this.artiT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kulTahminSonucT);
            this.Controls.Add(this.bilTahimB);
            this.Controls.Add(this.bilTahminT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tahminB);
            this.Controls.Add(this.tahminT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tahminT;
        private System.Windows.Forms.Button tahminB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bilTahminT;
        private System.Windows.Forms.Button bilTahimB;
        private System.Windows.Forms.Label kulTahminSonucT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox artiT;
        private System.Windows.Forms.Button degerB;
        private System.Windows.Forms.TextBox eksiT;
    }
}

