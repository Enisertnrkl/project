using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Formozfrm : Form
    {
        int originalWidth;
        int originalHeight;
        Color originalBackColor;
        Color originalForeColor;
        string originalText;
        Point originalLocation;

        public Formozfrm()
        {
           
            InitializeComponent();
        }
        private void Formozfrm_Load(object sender, EventArgs e)
        {
            originalWidth = this.Width;
            originalHeight = this.Height;
            originalBackColor = this.BackColor;
            originalForeColor= this.ForeColor;
            originalText = this.Text;
            originalLocation= this.Location;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Windows Forms, kullanıcı arayüzü oluşturmak için .NET Framework içinde yer alan bir teknolojidir. Windows Forms uygulamaları, bir veya birden çok form (pencere) içerir. Form, bir uygulamanın kullanıcı arayüzünün temel yapı taşıdır ve kullanıcı arayüzü öğelerini (örneğin, düğmeler, metin kutuları, listeler vb.) içerebilir.\r\n\r\nWindows Forms uygulamalarında form, \"Form\" sınıfından türetilir ve çeşitli özelliklerini ayarlamak için bir dizi özellik sağlar. Bazı form özellikleri şunlardır:\r\n\r\nText: Formun başlığı (pencere çerçevesinde görüntülenir).\r\nBackColor: Formun arka plan rengi.\r\nForeColor: Formdaki yazıların ve diğer öğelerin renkleri.\r\nWidth: Formun genişliği.\r\nHeight: Formun yüksekliği.\r\nLocation: Formun ekran üzerindeki konumu (x ve y koordinatları).\r\nFormBorderStyle: Formun çerçeve tarzı (örneğin, FixedSingle, Sizable, None).\r\nIcon: Formun simgesi (pencere çerçevesinde görüntülenir).");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int genislik = Convert.ToInt32(textBox4.Text);
            int yukseklik = Convert.ToInt32(textBox5.Text);
                if (genislik > Screen.PrimaryScreen.Bounds.Width || yukseklik > Screen.PrimaryScreen.Bounds.Height)
                {
                    MessageBox.Show("genişlik veya yükseklik ekranın kendisinden fazla olamaz!");
                    return;
                }
                this.Width = genislik;
                this.Height = yukseklik;
                MessageBox.Show($"Bu kod formun genişliğini ve yüksekliğini ayarlar. \n\nÖrnek : this.Width = {textBox4.Text};  this.Height : {textBox5.Text};");
                this.Width = originalWidth;
                this.Height = originalHeight;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.BackColor == originalBackColor && this.ForeColor == originalForeColor)
            {
                this.BackColor = Color.Yellow;
                this.ForeColor =Color.Violet;
            }
            else
            {
                this.BackColor = originalBackColor;
                this.ForeColor = originalForeColor;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 10)
            {
                MessageBox.Show("Harf sınırını aştınız!");
                return;
            }
                this.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int count = 0;
            int deger = Convert.ToInt32(textBox2.Text);
            int sleep = Convert.ToInt32(textBox3.Text);

            while (true)
            {
                int x = rnd.Next(0, Screen.PrimaryScreen.Bounds.Width - this.Width);
                int y = rnd.Next(0, Screen.PrimaryScreen.Bounds.Height - this.Height);
                if (count == deger)
                {
                    break;
                }
                    this.Location = new Point(x, y);
                Thread.Sleep(sleep);
                    count++;
                
            }
                this.Location = originalLocation;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
