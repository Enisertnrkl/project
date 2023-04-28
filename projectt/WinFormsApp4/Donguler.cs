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
    public partial class Donguler : Form
    {
        public Donguler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Döngüler, programlama dillerinde tekrarlayan işlemleri yapmak için kullanılan yapıdır. Döngüler sayesinde belirli bir işlemi birden çok kez tekrarlayarak kod tekrarı azaltılabilir ve programın daha modüler ve kolay okunur hale gelmesi sağlanılabilir.\n" +
                "C# programlama dilinde kullanılan döngüler şunlardır:\r\n\r\nfor döngüsü: Belirli sayıda tekrarlanması gereken durumlarda kullanılır. Örneğin, bir dizi içindeki tüm elemanları tek tek işlemek için for döngüsü kullanılabilir.\r\n\r\nwhile döngüsü: Bir koşul doğru olduğu sürece tekrarlanması gereken durumlarda kullanılır. Örneğin, bir kullanıcının girdiği sayılarla toplama işlemini gerçekleştirmek için while döngüsü kullanılabilir.\r\n\r\ndo-while döngüsü: while döngüsüne benzer, ancak önce işlem yapılır, sonra koşul kontrol edilir. Bu nedenle, do-while döngüsü en az bir kez çalıştırılır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int[] sayilar = new int[bitis - baslangic  + 1];
            int index = 0;
            for (int i = baslangic; i <= bitis; i++)
            {
                sayilar[index] = i;
                index++;
            }
            string sayilarstr = string.Join(",", sayilar);
            MessageBox.Show($"Sonuç : {sayilarstr} \n\n Çalışan kod :   int baslangic = Convert.ToInt32(textBox1.Text);\r\n            int bitis = Convert.ToInt32(textBox2.Text);\r\n            int[] sayilar = new int[bitis - baslangic  + 1];\r\n            int sayac = 0;\r\n            for (int i = baslangic; i <= bitis; i++)\r\n            {{\r\n                sayilar[sayac] = i;\r\n                sayac++;\r\n            }}\r\n            string sayilarstr = string.Join(\",\", sayilar);");

        }
    }
}
