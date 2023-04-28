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
    public partial class Dictionaryfrm : Form
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        public Dictionaryfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dictionary sınıfı, key-value (anahtar-değer) çiftlerini kullanarak veri depolamak için kullanılan bir koleksiyon sınıfıdır. Key-value çiftlerinin özelliği, bir key (anahtar) ile ilişkili bir değer (value) olmasıdır. Key-value çiftleri birbirleriyle bağlantılıdır ve bu çiftlerin düzeni önemli değildir.\r\n\r\nDictionary sınıfının kullanımı oldukça basittir. Sınıfın temel özellikleri şunlardır:\r\n\r\nAdd(): Belirtilen anahtar ve değeri Dictionary nesnesine ekler.\r\n\nClear(): Dictionary nesnesini temizler.\r\n\nContainsKey(): Belirtilen anahtarın Dictionary nesnesinde bulunup bulunmadığını kontrol eder.\r\n\nContainsValue(): Belirtilen değerin Dictionary nesnesinde bulunup bulunmadığını kontrol eder.\r\n\nCount(): Dictionary nesnesindeki key-value çiftlerinin sayısını verir.\r\n\nRemove(): Belirtilen anahtar ve değeri Dictionary nesnesinden kaldırır.\r\n\nTryGetValue(): Belirtilen anahtarın değerini döndürür. Eğer anahtar Dictionary nesnesinde yoksa default(TValue) değerini döndürür.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox2.Text);
            if(dict.ContainsKey(textBox1.Text))
            {
                MessageBox.Show("bu anahtar zaten var !");
                return;
            }
            dict.Add(textBox1.Text, num);
            label2.Text = "";
         foreach(var item in dict)
            {
                label2.Text += item.Key + ": " + item.Value + "\n";
            }

        }

        private void Dictionaryfrm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Dictionary nesnesinde {dict.Count} adet key-value çifti bulunmaktadır");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dict.Remove(textBox1.Text);
            label2.Text = "";
            foreach (var item in dict)
            {
                label2.Text += item.Key + ": " + item.Value + "\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dict.ContainsKey(textBox1.Text)) 
            {
                int deger = dict[textBox1.Text];
                MessageBox.Show($"Dictionary nesnesi ({textBox1.Text}) anahtarını içermektedir ve değeri ({deger}) 'dir");
            }
            else
            {
                MessageBox.Show("Böyle bir anahtar bulunmamaktadır.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);
            if(dict.ContainsValue(sayi))
            {
                var anahtar = dict.FirstOrDefault(x => x.Value == sayi).Key;
                MessageBox.Show($"Dictionary nesnesi ({sayi}) değerini içermektedir ve anahtarı ({anahtar}) 'dir");
            }
            else
            {
                MessageBox.Show("Böyle bir değer bulunmamaktadır.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int deger;
            if(dict.TryGetValue(textBox1.Text,out deger))
            {
                MessageBox.Show($"Dictionary nesnesinin ({textBox1.Text}) anahtarının değeri : {deger} 'dir");
            }
            else
            {
                MessageBox.Show("Böyle bir anahtar bulunmamaktadır.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dict.Clear();
            label2.Text = "";
        }
    }
}
