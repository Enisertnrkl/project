using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class Mathsinif : Form
    {
        public Mathsinif()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Math sınıfı, matematik işlemleri için statik bir sınıftır. Bu sınıf, sayısal değerler üzerinde birçok matematik işlemi yapmanıza izin verir. Math sınıfı, System namespace'inde yer alır ve C# dilinde çok sık kullanılan bir sınıftır.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            double result = Math.Ceiling(num);
            MessageBox.Show(result.ToString());
        }

        private void Mathsinif_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            double result = Math.Abs(num);
            MessageBox.Show(result.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            double result = Math.Floor(num);
            MessageBox.Show(result.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            double result = Math.Round(num);
            MessageBox.Show(result.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Bir sayı giriniz!!");
                return;
            }
            double num = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = Math.Max(num,num2);
            MessageBox.Show(result.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Bir sayı giriniz!!");
                return;
            }
            double num = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = Math.Min(num,num2);
           
            MessageBox.Show(result.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Bir sayı giriniz!!");
                return;
            }
            double num = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = Math.Pow(num, num2);
            
            MessageBox.Show(result.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            double result = Math.Sqrt(num);
            result = Math.Round(result,3);
            
            MessageBox.Show(result.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.PI.ToString());
        }
    }
}
