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
    public partial class TryCatch : Form
    {
        public TryCatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try-Catch-Finally, bir hata durumunda bir programın düzgün çalışmasını sağlamak için kullanılan bir programlama yapısıdır. Try bloğu, hata olasılığı olan kodları içerir. Catch bloğu, programın hata durumunda çalışacak kodları içerir ve hatanın türüne göre farklı Catch blokları kullanılabilir. Finally bloğu, Try-Catch bloklarının sonunda her zaman çalışacak olan kodları içerir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            try
            {
                int sonuc = a / b;
            }
            catch(DivideByZeroException ex ) 
            {
                MessageBox.Show($"{ex.Message}------Sayı sıfıra bölündüğü için DivideByZeroException hatası alındı ve catch bloğu çalıştı.");
            }
            finally
            {
                MessageBox.Show("try ve catch blokları çalıştıktan sonra finally bloğu çalıştı.");
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] metin = textBox3.Text.Split(' ');
                int[] sayilar = new int[4];
                for(int i = 0; i< metin.Length; i++)
                {
                    sayilar[i] = Convert.ToInt32(metin[i]);
                }
             
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show($"{ex.Message} dizi sınırı aşıldığı için catch bloğunda bu hata mesajı çalıştı.");
            }
            finally
            {
                MessageBox.Show("Derleme sonlandı.(finally bloğu)");
            }
        


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
