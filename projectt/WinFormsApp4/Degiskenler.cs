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
    public partial class Degiskenler : Form
    {
        public Degiskenler()
        {
            InitializeComponent();
        }

        private void Degiskenler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Değişkenler, bir değerin geçici olarak saklanması için kullanılan isimlendirilmiş bellek alanlarıdır.Değişkenler, programcıların belirli bir değeri saklamalarına ve programın farklı bölümlerinde bu değere erişmelerine izin verir.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("* bool: Mantıksal bir değeri (doğru veya yanlış) tutmak için kullanılır.\n" +
                "* byte: 8 bitlik bir tam sayı (0-255) tutmak için kullanılır.\n" +
                "* sbyte: 8 bitlik bir tam sayı (-128 ila 127) tutmak için kullanılır.\n" +
                "* short: 16 bitlik bir tam sayı (-32,768 ila 32,767) tutmak için kullanılır.\n" +
                "* ushort: 16 bitlik bir tam sayı (0 ila 65,535) tutmak için kullanılır.\n" +
                "* int: 32 bitlik bir tam sayı (-2,147,483,648 ila 2,147,483,647) tutmak için kullanılır.\n" +
                "* uint: 32 bitlik bir tam sayı (0 ila 4,294,967,295) tutmak için kullanılır.\n" +
                "* long: 64 bitlik bir tam sayı (-9,223,372,036,854,775,808 ila 9,223,372,036,854,775,807) tutmak için kullanılır.\n" +
                "* ulong: 64 bitlik bir tam sayı (0 ila 18,446,744,073,709,551,615) tutmak için kullanılır.\n" +
                "* float: Tek hassasiyetli kayan noktalı bir sayı (-3.402823e38 ila 3.402823e38) tutmak için kullanılır.\n" +
                "* double: Çift hassasiyetli kayan noktalı bir sayı (-1.79769313486232e308 ila 1.79769313486232e308) tutmak için kullanılır.\n" +
                "* decimal: Hassas bir ondalık sayı (-79228162514264337593543950335 ila 79228162514264337593543950335) tutmak için kullanılır.\n" +
                "* char: Tek bir karakteri (Unicode karakter kodu) tutmak için kullanılır.\n" +
                "* string: Bir dizi karakteri (metin) tutmak için kullanılır.");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "int")
            {
                MessageBox.Show("Değişken tanımlama : int sayi = 5;\n" +
                    "Değer değiştirme : sayi = 8\n" +
                    "Birden fazla değişken tanımlama : int x = 5, y = 10, z = 15;\n" +
                    "Değişkenlerin değerlerini birbiriyle değiştirme :\nint temp = x;\n" +
                    "x = y;\n" +
                    "y = temp;");
            }
            if (textBox1.Text == "string")
            {
                MessageBox.Show("Değişken tanımlama : string metin = \"Merhaba Dünya\";\n" +
                    "Değer değiştirme : metin = \"Merhaba\";\n");
            }
            if (textBox1.Text == "bool")
            {
                MessageBox.Show("Değişken tanımlama : bool değer = true;\n" +
                    "Değer değiştirme : değer = false;");
            }
            if(textBox1.Text == "char")
            {
                MessageBox.Show("Değişken tanımlama : char değer = 'a';\n" +
                    "Değer değiştirme : değer = 'z';");
            }
        }
    }
}
