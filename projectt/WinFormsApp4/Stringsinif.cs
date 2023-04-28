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
    public partial class Stringsinif : Form
    {
        public Stringsinif()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("String sınıfı, C# programlamada sıkça kullanılan bir veri tipidir ve birçok dilde olduğu gibi, karakter dizileri (string) ile ilgili işlemleri yapmak için kullanılır.\n\nÖrneğin: \n\n" +
                "Length: Bir string'in karakter sayısını verir.\r\nIndexOf: Belirli bir karakter veya alt dizenin pozisyonunu verir.\r\nSubstring: Belirtilen pozisyondan başlayarak bir alt dize alır.\r\nReplace: Bir karakter veya alt dizeyi başka bir karakter veya alt dizeyle değiştirir.\r\nToUpper ve ToLower: String'i büyük veya küçük harf yapar.\r\nConcat: İki veya daha fazla string'i birleştirir.");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            int length = metin.Length;
            MessageBox.Show(length.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string k_metin = metin.ToLower();
            MessageBox.Show(k_metin);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string metin2 = textBox2.Text;
            int index = metin.IndexOf(metin2);
            MessageBox.Show(index.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string metin2 = textBox2.Text;
           int harf = Convert.ToInt32(textBox2.Text);
            string substring = metin.Substring(harf);
            MessageBox.Show(substring);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string yeni_metin = metin.Replace(textBox2.Text, textBox3.Text);
            MessageBox.Show(yeni_metin);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string b_metin = metin.ToUpper();
            MessageBox.Show(b_metin);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string metin2 = textBox2.Text;
            string yeni_metin = String.Concat(metin, " ", metin2);
            MessageBox.Show(yeni_metin);
        }
    }
}
