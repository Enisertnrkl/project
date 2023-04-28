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
    public partial class Listfrm : Form
    {
        List<int> sayilar = new List<int>();
        public Listfrm()
        {
    
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List sınıfı, dinamik bir dizi yapısıdır. Bu sınıf, dizilerin aksine boyutu önceden belirtilmediğinden, istenilen boyutta veri depolama imkanı sağlar. List sınıfı, System.Collections.Generic ad alanı altında yer almaktadır.\r\n\r\nList sınıfının bazı temel metodları ve kullanımları şu şekildedir:\n\n" +
                "Add(): Listenin sonuna belirtilen öğeyi ekler.\n\n" +
                "Insert(): Belirtilen konuma belirtilen öğeyi ekler.\n\n" +
                "Remove(): Belirtilen öğeyi listeden kaldırır.\n\n" +
                "RemoveAt(): Belirtilen konumdaki öğeyi listeden kaldırır.\n\n" +
                "Count: Listenin eleman sayısını verir.\n\n" +
                "Contains(): Belirtilen öğenin listede olup olmadığını kontrol eder.\n\n" +
                "Sort(): Listeyi sıralar.\n\n" +
                "Clear(): Listenin tüm öğelerini kaldırır.\n\n" +
                "IndexOf(): Belirtilen öğenin indeksini verir.\n\n" +
                "Reverse(): Listeyi tersine çevirir.\n\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
            int sayi = Convert.ToInt32(textBox1.Text);
            sayilar.Add(sayi);
            label2.Text = "";
            foreach (int item in sayilar)
            {
                label2.Text +=  item.ToString() +"\n" ;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            int sayi = Convert.ToInt32(textBox1.Text);
            int i = Convert.ToInt32(textBox2.Text);
            sayilar.Insert(i,sayi);
            label2.Text = "";
            foreach (int item in sayilar)
            {
                label2.Text += item.ToString() + "\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            sayilar.Remove(sayi);
            label2.Text = "";
            foreach (int item in sayilar)
            {
                label2.Text += item.ToString() + "\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            sayilar.RemoveAt(sayi);
            label2.Text = "";
            foreach (int item in sayilar)
            {
                label2.Text += item.ToString() + "\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = sayilar.Count();
            MessageBox.Show(a.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            bool a = sayilar.Contains(sayi);
            MessageBox.Show(a.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayilar.Sort();
            label2.Text = "";
            foreach (int item in sayilar)
            {
                label2.Text += item.ToString() + "\n";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayilar.Clear();
            label2.Text = "";
            foreach (int item in sayilar)
            {
                label2.Text += item.ToString() + "\n";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
           int a = sayilar.IndexOf(sayi);
            MessageBox.Show(a.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayilar.Reverse();
            label2.Text = "";
            foreach (int item in sayilar)
            {
                label2.Text += item.ToString() + "\n";
            }
        }
    }
}
