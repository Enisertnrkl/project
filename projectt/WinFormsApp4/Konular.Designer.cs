namespace WinFormsApp4
{
    partial class Konular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Değişkenler");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sabitler");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Döngüler");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Diziler");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Operatörler");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("String Sınıfı");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Math Sınıfı");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("DateTime Sınıfı");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ArrayList Sınıfı");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("HashTable Sınıfı");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("List Sınıfı");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Dictionary Sınıfı");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Try-Catch-Finally");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Exception");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Throw");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Form ve Form Özellikleri");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Konular", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(32, 12);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Degiskenler";
            treeNode1.Text = "Değişkenler";
            treeNode2.Name = "Sabitler";
            treeNode2.Text = "Sabitler";
            treeNode3.Name = "Donguler";
            treeNode3.Text = "Döngüler";
            treeNode4.Name = "Diziler";
            treeNode4.Text = "Diziler";
            treeNode5.Name = "Operatorler";
            treeNode5.Text = "Operatörler";
            treeNode6.Name = "Stringsinif";
            treeNode6.Text = "String Sınıfı";
            treeNode7.Name = "Mathsinif";
            treeNode7.Text = "Math Sınıfı";
            treeNode8.Name = "Datetimesinif";
            treeNode8.Text = "DateTime Sınıfı";
            treeNode9.Name = "Arraylist";
            treeNode9.Text = "ArrayList Sınıfı";
            treeNode10.Name = "hashtable";
            treeNode10.Text = "HashTable Sınıfı";
            treeNode11.Name = "List";
            treeNode11.Text = "List Sınıfı";
            treeNode12.Name = "Dictionary";
            treeNode12.Text = "Dictionary Sınıfı";
            treeNode13.Name = "trycatchfinally";
            treeNode13.Text = "Try-Catch-Finally";
            treeNode14.Name = "exception";
            treeNode14.Text = "Exception";
            treeNode15.Name = "throw";
            treeNode15.Text = "Throw";
            treeNode16.Name = "frmveoz";
            treeNode16.Text = "Form ve Form Özellikleri";
            treeNode17.Name = "Konular";
            treeNode17.Text = "Konular";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treeView.Size = new System.Drawing.Size(431, 385);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // Konular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView);
            this.Name = "Konular";
            this.Text = "Konular";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Konular_FormClosing);
            this.Load += new System.EventHandler(this.Konular_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeView;
    }
}