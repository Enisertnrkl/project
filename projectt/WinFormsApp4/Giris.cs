namespace WinFormsApp4
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            this.FormClosing += Giris_FormClosing;
        }
       
        Dictionary<string, string> kayitlar = new Dictionary<string, string>();
        private void Giris_Load(object sender, EventArgs e)
        {
        }
        string[] kullanicibilgi = { "","" };
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kullanicibilgi[0] && textBox2.Text == kullanicibilgi[1])
            { 
                this.Hide();
                Konular frm2 = new Konular();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }
        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Programı kapatmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; 
                }
                else
                {
                    Application.Exit(); 
                }
            }
        }
    }
}