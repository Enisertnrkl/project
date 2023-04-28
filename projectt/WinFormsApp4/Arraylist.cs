using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Arraylist : Form
    {
        private ArrayList liste;
        public Arraylist()
        {
            InitializeComponent();
            liste = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ArrayList, .NET Framework'ün eski sürümlerinde kullanılan bir koleksiyon sınıfıdır ve dinamik boyutlarda nesneleri depolamak için kullanılır. ArrayList sınıfı, herhangi bir türde nesne depolamak için kullanılabilir, ancak tip kontrolü yapılmaz ve bu nedenle performans açısından bazı dezavantajları vardır. Daha yeni .NET sürümlerinde List<T> sınıfı, ArrayList yerine tercih edilir.\r\n\r\nArrayList sınıfının bazı önemli özellikleri şunlardır:\r\n\r\nDinamik boyutlandırma: ArrayList sınıfı, elemanları eklemek ve çıkarmak için dinamik olarak boyutlandırılabilir. Bu, belirli bir boyuta sahip olmayan verileri depolamak için kullanışlıdır.\r\n\nNesne depolama: ArrayList sınıfı, herhangi bir türde nesneyi depolayabilir. Bu, farklı tipte nesneleri aynı koleksiyonda depolamak için kullanışlıdır.\r\n\nIndeksleme: ArrayList sınıfı, elemanlarını indekslemek için kullanılabilir. Elemanların dizin numarası, 0'dan başlar.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            liste.Add(textBox1.Text);
            string listem = string.Join("\n", liste.ToArray());
            label4.Text = listem;

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            liste.Clear();
            label4.Text = string.Empty;
            MessageBox.Show("liste temizlendi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool contains = liste.Contains(textBox1.Text);
            MessageBox.Show(contains.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = liste.Count;
            MessageBox.Show(count.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);
            liste.Insert(sayi, textBox1.Text);
            string listem = string.Join("\n", liste.ToArray());
            label4.Text = listem;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            liste.Remove(textBox1.Text);
            MessageBox.Show($"{textBox1.Text} silindi.");
            string listem = string.Join("\n", liste.ToArray());
            label4.Text = listem;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            liste.Sort();
            string listem = string.Join("\n", liste.ToArray());
            label4.Text = listem;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
