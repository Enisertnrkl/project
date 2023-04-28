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
    public partial class Exception : Form
    {
        public Exception()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exception, bir programın normal işleyişinin kesintiye uğradığı ve hata verdiği durumlarda atılan özel nesnelerdir. Bir hata oluştuğunda, program çalışması durdurulur ve bir hata mesajı görüntülenir. Bu nesneler, programcıların hataların nasıl yönetileceğini ve programın kurtarılacağını belirleyebilmesini sağlar.\n\n" +
                "DivideByZeroException: Bir sayı sıfıra bölündüğünde bu hatayı alırız.\n\n" +
                "IndexOutOfRangeException: Bir dizi veya liste için belirtilen sınırların dışına çıkıldığında bu hatayı alırız.\n\n" +
                "ArgumentNullException: Bir metodun parametresine null değer geçildiğinde bu hatayı alırız.\n\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = 5;
            int sayi2 = 0;
            try
            {
                int sonuc = sayi1 / sayi2;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show($" Bu exception ({ex.Message}) bir sayı sıfıra bölündüğü zaman ortaya çıkar.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[3];
            try
            {
                sayilar[4] = 5;
            }
            catch (IndexOutOfRangeException ex)
            {
               MessageBox.Show($"Bu exception ({ex.Message}) bir dizi ve ya  liste için belirtilen sınırların dışına çıkıldığında ortaya çıkar.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin = null;
            try
            {
                int uzunluk = metin.Length;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Bu exception ({ex.Message}) Bir methodun parametresine null değer geçildiğinde ortaya çıkar.");
            }

        }
    }
}
