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
    public partial class Diziler : Form
    {
        public Diziler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diziler, aynı türdeki birden fazla veriyi tek bir değişkende tutmamızı sağlayan veri yapılarıdır. Dizi içindeki elemanlar birbirinden farklı indeks numaraları ile ayrılır ve bu indeks numaraları, dizinin başlangıç noktasından itibaren sırayla atanır.\r\n\r\nDiziler, programlamada çok sık kullanılan ve oldukça yararlı olan veri yapılarıdır. Örneğin, bir dizide saklanan verileri döngü yardımıyla tek tek işleyebilir ve bir sonuca ulaşabilirsiniz. Diziler, programlama dillerinde bulunan pek çok algoritmanın temelinde kullanılan bir veri yapısıdır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string[] ayikla = metin.Split(',');
            int[] sayilar = new int[ayikla.Length];
            for (int i = 0; i < ayikla.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(ayikla[i]);
            }
            Array.Reverse(sayilar);
            MessageBox.Show(string.Join(" ", sayilar));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string[] ayikla = metin.Split(',');
            int[] sayilar = new int[ayikla.Length];
            for (int i = 0; i < ayikla.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(ayikla[i]);
            }
            Array.Sort(sayilar);
            MessageBox.Show(string.Join(" ", sayilar));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string[] ayikla = metin.Split(',');
            int[] sayilar = new int[ayikla.Length];
            for (int i = 0; i < ayikla.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(ayikla[i]);
            }
            if(String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Bir değer giriniz!");
                return;
            }
            int sayi = Convert.ToInt32(textBox2.Text);
            int index = Array.IndexOf(sayilar,sayi);
            MessageBox.Show(string.Join("",index));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string[] ayikla = metin.Split(',');
            int[] kaynakdizi = new int[ayikla.Length];
            for (int i = 0; i < ayikla.Length; i++)
            {
               kaynakdizi[i] = Convert.ToInt32(ayikla[i]);
            }
            int sayi = Convert.ToInt32(textBox2.Text);
            int[] hedefdizi = new int[sayi];
            Array.Copy(kaynakdizi, 0, hedefdizi, 0,sayi);
            MessageBox.Show(string.Join(", ", hedefdizi));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Diziler_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iki boyutlu diziler iki boyutlu bir matris şeklinde verileri saklar. Matris, satır ve sütunlardan oluşur ve bu nedenle iki boyutlu bir dizi iki endeksle (indekslerle erişilebilen elemanların yer aldığı) bir yapıdır.\n\n" +
                "Örneğin : int[,] matris = new int[3,3];\n\n" +
                "   Bu matrisin 3 satır ve 3 sütunu vardır ve tüm elemanları varsayılan olarak 0 olarak atanır. Matrisin her bir elemanına erişmek için, satır ve sütun numaralarını kullanarak bir indeksleme işlemi gerçekleştirirsiniz:\n\n" +
                "int eleman = matris[1,2]; \n\n// matrisin ikinci satırının üçüncü sütunundaki elemanı alır\r\n\nmatris[0,1] = 5; \n\n// matrisin ilk satırının ikinci sütunundaki elemanı 5 yapar");
        }
    }
}
