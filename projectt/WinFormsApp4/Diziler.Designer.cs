﻿namespace WinFormsApp4
{
    partial class Diziler
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(186, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diziler nedir ve ne işe yarar ?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bilgi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Array.Reverse()";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aralarında virgül bırakarak bir Integer dizisi giriniz";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Array.Sort()";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Diziyi ters çevirir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diziyi küçükten büyüğe sıralar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 23);
            this.textBox2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Array.IndexOf()";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Array.IndexOf() ve Array.Copy() için değer giriniz";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bir dizide belirli bir elemanın bulunduğu indeksi döndürür. Eğer eleman bulunamaz" +
    "sa -1 döndürür.";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Array.Copy()";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Array.Copy: Bir dizinin belirli bir bölümünü, başka bir diziye kopyalar.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(26, 308);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10);
            this.label8.Size = new System.Drawing.Size(246, 35);
            this.label8.TabIndex = 14;
            this.label8.Text = "İki boyutlu diziler nedir ve ne işe yarar ?";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(275, 308);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 35);
            this.button6.TabIndex = 15;
            this.button6.Text = "Bilgi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Diziler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Diziler";
            this.Text = "Diziler";
            this.Load += new System.EventHandler(this.Diziler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button button4;
        private Label label5;
        private Label label6;
        private Button button5;
        private Label label7;
        private Label label8;
        private Button button6;
    }
}