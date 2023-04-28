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
    public partial class Operatorler : Form
    {
        public Operatorler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operatörler, programlama dillerinde değişkenler, sabitler veya ifadeler üzerinde matematiksel, karşılaştırmalı veya mantıksal işlemler yapmak için kullanılan sembollerdir. Operatörler, bir veya daha fazla değişkeni alarak belirli bir işlemi gerçekleştirirler ve sonuç olarak bir değer döndürürler.\n" +
                "Programlama dillerinde birçok farklı türde operatör vardır. Bazı örnekler şunlardır:\r\n\r\nMatematiksel operatörler: toplama (+), çıkarma (-), çarpma (*), bölme (/), mod alma (%), arttırma (++) ve azaltma (--)\r\n\nKarşılaştırmalı operatörler: eşitlik (==), eşit değil (!=), büyüktür (>), küçüktür (<), büyük veya eşit (>=), küçük veya eşit (<=)\r\n\nMantıksal operatörler: VE (&&), VEYA (||), DEĞİL (!)\r\n\nAtama operatörleri: eşitleme (=), toplama eşitleme (+=), çıkarma eşitleme (-=), çarpma eşitleme (*=), bölme eşitleme (/=) gibi.");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToInt32(textBox1.Text);
            double sayi2 = Convert.ToInt32(textBox2.Text);
            double sonuc = sayi + sayi2;
            sonuc = Math.Round(sonuc, 2);
            textBox3.Text = sonuc.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToInt32(textBox1.Text);
            double sayi2 = Convert.ToInt32(textBox2.Text);
            double sonuc = sayi - sayi2;
            sonuc = Math.Round(sonuc, 2);
            textBox3.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToInt32(textBox1.Text);
            double sayi2 = Convert.ToInt32(textBox2.Text);
            double sonuc = sayi * sayi2;
            sonuc = Math.Round(sonuc, 2);
            textBox3.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToInt32(textBox1.Text);
            double sayi2 = Convert.ToInt32(textBox2.Text);
            double sonuc = sayi / sayi2;
            sonuc = Math.Round(sonuc,2);
            textBox3.Text = sonuc.ToString();
        }

        private void Operatorler_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        { 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToInt32(textBox1.Text);
            double sayi2 = Convert.ToInt32(textBox2.Text);
            double sonuc = sayi % sayi2;
            sonuc = Math.Round(sonuc, 2);
            textBox3.Text = sonuc.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'&&' operatörü, iki mantıksal ifadeyi birleştiren bir operatördür.\n\n" +
                "Bu operatör, sol ve sağ tarafındaki ifadelerin her ikisi de true olduğunda true sonucunu döndürür; aksi takdirde false sonucunu döndürür. && operatörü, \"ve\" bağlacı olarak da bilinir.\n\n" +
                "bool a = true;\r\nbool b = false;\r\nbool c = (a && b); // c = false\n\n" +
                "Yukarıdaki örnekte, a değişkeni true olduğu için sol taraf true olarak değerlendirilir. Ancak, b değişkeni false olduğu için sağ taraf false olarak değerlendirilir. && operatörü, sol ve sağ taraftaki ifadelerin her ikisi de true olduğunda true sonucunu döndürdüğünden, sonuç false olur.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("|| (veya) operatörü, iki veya daha fazla koşuldan en az birinin doğru (true) olması durumunda sonucu doğru (true) olarak döndürür. Aksi takdirde sonuç yanlış (false) olacaktır.\n\n" +
                "Örneğin, aşağıdaki ifade x değeri 5 veya 7 ise doğru (true) döndürür, diğer durumlarda yanlış (false) döndürür:\n\n" +
                "if (x == 5 || x == 7)\r\n{\r\n    // kod bloğu\r\n}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"!\" operatörü, bir ifadeyi tersine çevirir. Örneğin, bir bool değişkeni \"true\" ise, \"!\" operatörü kullanılarak bu ifade \"false\" haline getirilebilir. Aynı şekilde, bir bool değişkeni \"false\" ise, \"!\" operatörü kullanılarak bu ifade \"true\" haline getirilebilir.\n\n" +
                "bool isLoggedin = false;\r\nif (!isLoggedin)\r\n{\r\n    Console.WriteLine(\"Lütfen giriş yapın!\");\r\n}\n\nYukarıdaki örnekte, \"isLoggedin\" değişkeni \"false\" olduğu için \"!\" operatörü kullanılarak \"true\" haline getirilir. Bu şekilde, \"if\" bloğu içindeki kodlar çalıştırılır ve \"Lütfen giriş yapın!\" mesajı yazdırılır.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" < operatörü, sol tarafındaki değerin sağ tarafındaki değerden küçük olduğunu kontrol eder ve bir boolean değer döndürür.\n\n Örneğin, 3 < 5 ifadesi doğrudur çünkü 3, 5'ten küçüktür ve bu ifade true değerini döndürür. Ancak 5 < 3 ifadesi yanlıştır çünkü 5, 3'ten büyüktür ve bu ifade false değerini döndürür.");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("> operatörü, sol tarafındaki ifadenin sağ tarafındaki ifadeden büyük olup olmadığını kontrol eder. Eğer sol tarafındaki ifade sağ tarafındakinden büyükse, sonuç true olarak değerlendirilir. Aksi takdirde sonuç false olarak değerlendirilir. \n\nÖrneğin: \n\n" +
                "int a = 5;\r\nint b = 3;\r\nbool result = a > b;\n\nYukarıdaki örnekte, a değişkeni b değişkeninden büyük olduğu için result değişkeni true değerini alır.");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<= operatoru, bir sayının başka bir sayıdan küçük veya eşit olduğunu kontrol etmek için kullanılır. \n\nÖrneğin:\n\n" +
                "int x = 5;\r\nint y = 10;\r\nif (x <= y)\r\n{\r\n    Console.WriteLine(\"x, y'den küçük veya eşittir.\");\r\n}");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(">= operatoru ise bir sayının başka bir sayıdan büyük veya eşit olduğunu kontrol etmek için kullanılır.\n\n Örneğin:\n\n" +
                "int x = 5;\r\nint y = 10;\r\nif (y >= x)\r\n{\r\n    Console.WriteLine(\"y, x'den büyük veya eşittir.\");\r\n}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("== operatörü, iki değerin birbirine eşit olup olmadığını kontrol etmek için kullanılır. Eğer iki değer birbirine eşitse true döndürür, değilse false döndürür.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!= operatörü  == operatörünün tersidir. Eğer iki değer birbirine eşit değilse true döndürür, değilse false döndürür.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("++ ve -- operatörleri, bir değişkenin değerini 1 artırmak veya 1 azaltmak için kullanılır. ++ operatörü, değişkenin değerini 1 artırırken, -- operatörü, değişkenin değerini 1 azaltır.\r\n\r\nÖrneğin:\n\n" +
                "int sayi = 5;\r\nsayi++;  // sayi şimdi 6 oldu\r\nsayi--;  // sayi tekrar 5 oldu\n\n" +
                "++ ve -- operatörleri, değişkenin önünde veya arkasında kullanılabilir. Eğer değişkenin önünde kullanılırsa, önce artırma veya azaltma işlemi yapılır, sonra değişkenin değeri kullanılır. Eğer değişkenin arkasında kullanılırsa, önce değişkenin değeri kullanılır, sonra artırma veya azaltma işlemi yapılır.\r\n\r\nÖrneğin:\n\n" +
                "int sayi1 = 5;\r\nint sayi2 = ++sayi1;  // sayi1 artırıldıktan sonra sayi2'ye atanır, sayi1=6, sayi2=6\r\nint sayi3 = sayi1--;  // sayi1 sayi3'ye atanıktan sonra azaltılır, sayi1=5, sayi3=6");
        }
    }
}
