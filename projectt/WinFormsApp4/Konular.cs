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
    public partial class Konular : Form
    {
        public Konular()
        {
            InitializeComponent();
        }

        private void Konular_Load(object sender, EventArgs e)
        {

            
        }
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch(e.Node.Name)
            {
                case "Degiskenler":
                    Degiskenler degiskenler = new Degiskenler();
                    degiskenler.ShowDialog();
                    break;

                case "Sabitler":
                    Sabitler sabitler = new Sabitler();
                    sabitler.ShowDialog();
                    break;
                case "Donguler":
                    Donguler döngüler = new Donguler();
                    döngüler.ShowDialog();
                    break;
                case "Diziler":
                    Diziler diziler = new Diziler();
                    diziler.ShowDialog();
                    break;
                case "Operatorler":
                    Operatorler operatorler= new Operatorler();
                    operatorler.ShowDialog();
                    break;
                case "Stringsinif":
                    Stringsinif stringsinif= new Stringsinif();
                    stringsinif.ShowDialog();
                    break;
                case "Mathsinif":
                    Mathsinif mathsinifi = new Mathsinif();
                    mathsinifi.ShowDialog();
                    break;
                case "Datetimesinif":
                    Datetimesinif datetimesinif = new Datetimesinif();
                    datetimesinif.ShowDialog();
                    break;
                case "Arraylist":
                    Arraylist arraylist= new Arraylist();
                    arraylist.ShowDialog();
                    break;

                case "hashtable":
                    HashTablefrm hashtablefrm = new HashTablefrm();
                    hashtablefrm.ShowDialog();
                    break;
                case "List":
                    Listfrm list = new Listfrm();
                    list.ShowDialog();
                    break;
                case "Dictionary":
                    Dictionaryfrm dictionary = new Dictionaryfrm();
                    dictionary.ShowDialog();
                    break;
                case "trycatchfinally":
                    TryCatch trycatch = new TryCatch();
                    trycatch.ShowDialog();
                    break;
                case "exception":
                    Exception exception = new Exception();
                    exception.ShowDialog();
                    break;
                case "throw":
                    Throwfrm thrw = new Throwfrm();
                    thrw.ShowDialog();
                    break;
                case "frmveoz":
                    Formozfrm formozfrm = new Formozfrm();
                    formozfrm.ShowDialog(); 
                    break;



            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Konular_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
