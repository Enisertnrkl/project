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
    public partial class Throwfrm : Form
    {
        public Throwfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"throw\" anahtar kelimesi bir hata fırlatmak için kullanılır. Bu, bir hatanın oluştuğunu ve işleyicisi tarafından ele alınması gerektiğini belirtir.\r\n\r\nBir hata fırlatmak için, öncelikle bir hata nesnesi oluşturmanız gerekmektedir. Bu nesne, hatanın ayrıntılarını içerir ve hatanın türüne göre bir alt sınıfı olabilir. Daha sonra, \"throw\" anahtar kelimesini kullanarak hatayı fırlatırsınız.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if(sayi < 0)
            {
                throw new ArgumentException("Sayı negatif olamaz \nBu örnekte, \"sayi\" adlı bir parametre vardır. Eğer bu parametre negatif bir sayı ise, bir \"ArgumentException\" nesnesi oluşturulur ve \"throw\" anahtar kelimesiyle fırlatılır. Oluşturulan hata nesnesi, birinci parametre olarak hata mesajını ve ikinci parametre olarak da hatanın kaynağını içerir.", nameof(sayi));
            }
            else
            {
                MessageBox.Show("Seçilen sayı pozitif olduğu için kod normal bir şekilde çalışır ve throw bloğuna girmez.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bolen = Convert.ToInt32(textBox2.Text);
            int bolunen = Convert.ToInt32(textBox3.Text);
            if(bolunen == 0) 
            {
                throw new ArgumentException("Bölünen sıfır olamaz! \nBu örnekte,\"bolen\" ve \"bolunen\" adlı iki tamsayı parametre alır. Eğer \"bolunen\" sıfıra eşitse, yöntem bir \"ArgumentException\" fırlatır ve hata mesajında \"Bölünen sıfır olamaz!\" ifadesi yer alır.", nameof(bolunen));
            }
            else
            {
                MessageBox.Show("bölme işlemi tamamlandı");
            }
        }
    }
}
