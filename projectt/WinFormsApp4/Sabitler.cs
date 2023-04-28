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
    public partial class Sabitler : Form
    {
        
        public Sabitler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sabitler, C# programlama dilinde değerleri değiştirilemeyen değişkenlerdir. Bir kez tanımlandığında, programın başka yerlerinde değiştirilemezler. Sabitler, programın farklı yerlerinde aynı değerlerin kullanılması gerektiğinde ve bu değerlerin yanlışlıkla değiştirilmesini önlemek istediğimizde kullanışlıdır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("const int sabitSayi = 10;\n" +
                "const string sabitMetin = \"Merhaba Dünya\";\n\n" +
                "Yukarıdaki örnekte, \"sabitSayi\" ve \"sabitMetin\" sabitleri tanımlanmıştır. \"sabitSayi\" değişkeni tamsayı türünde, değeri 10'dur. \"sabitMetin\" değişkeni ise string (metin) türündedir, değeri \"Merhaba Dünya\"'dır. Bu sabitler, programın başka yerlerinde değiştirilemezler ve kodun daha anlaşılır olmasını sağlarlar.");
        }
    }
}
