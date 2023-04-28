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
    public partial class Datetimesinif : Form
    {
        public Datetimesinif()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# programlama dilinde DateTime sınıfı, tarih ve saat değerlerini işlemek için kullanılan bir sınıftır. Bu sınıfın çeşitli özellikleri ve metodları mevcuttur. Aşağıda DateTime sınıfının bazı özellikleri ve metodları açıklanmaktadır:\r\n\r\nNow: Şu anki tarih ve saat değerini döndürür.\r\nToday: Şu anki tarihi (saat olmadan) döndürür.\r\nDayOfWeek: Tarihin haftanın hangi gününe denk geldiğini belirten bir enum değerini döndürür.\r\nDayOfYear: Yılın kaçıncı günü olduğunu belirten bir tamsayı değerini döndürür.\r\nAddDays: Belirtilen tarihe gün sayısı ekler.\r\nAddMonths: Belirtilen tarihe ay sayısı ekler.\r\nAddYears: Belirtilen tarihe yıl sayısı ekler.\r\nCompare: İki tarih arasındaki ilişkiyi belirler (büyük, küçük, eşit).\r\nEquals: İki tarihin eşit olup olmadığını belirler.\r\nToString: Tarihi belirtilen formata göre bir string olarak döndürür.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
         
            MessageBox.Show($" {simdi}\n\nKod:   DateTime simdi = DateTime.Now;\n\nMessageBox.Show($\" {{simdi}}\");");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;
            MessageBox.Show($" {bugun.ToShortDateString()}\n\nKod:  DateTime bugun = DateTime.Today;\n\nMessageBox.Show($\" {{bugun.ToShortDateString()}}\");");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            MessageBox.Show($" {simdi.DayOfWeek}\n\nKod:   DateTime simdi = DateTime.Now;\r\n            MessageBox.Show($\" {{simdi.DayOfWeek}}\");");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            MessageBox.Show($" {simdi.DayOfYear}\n\nKod:   DateTime simdi = DateTime.Now;\r\n            MessageBox.Show($\" {{simdi.DayOfYear}}\");");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            int gün = Convert.ToInt32(textBox1.Text);
            DateTime yenigun = simdi.AddDays(gün);
            MessageBox.Show($"Eski gün: {simdi} \nYeni gün: {yenigun}\n\nKod : DateTime simdi = DateTime.Now;\nint gün = Convert.ToInt32(textBox1.Text);\nDateTime yenigun = simdi.AddDays(gün);\n\n MessageBox.Show($\"{{yenigun}}\"); ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            int ay = Convert.ToInt32(textBox1.Text);
            DateTime yeniay = simdi.AddMonths(ay);
            MessageBox.Show($"Eski ay: {simdi} \nYeni ay: {yeniay}\n\nKod : DateTime simdi = DateTime.Now;\nint ay = Convert.ToInt32(textBox1.Text);\nDateTime yeniay = simdi.AddMonths(ay);\n\n MessageBox.Show($\"{{yeniay}}\");");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            int yil = Convert.ToInt32(textBox1.Text);
            DateTime yeniyil = simdi.AddYears(yil);
            MessageBox.Show($"Eski yil: {simdi} \nYeni yil: {yeniyil}\n\nKod : DateTime simdi = DateTime.Now;\nint yil = Convert.ToInt32(textBox1.Text);\nDateTime yeniyil = simdi.AddYears(yil);\n\n MessageBox.Show($\"{{yeniyil}}\");");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
