using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SCNLPNetTest
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        StanfordCore sc = new StanfordCore();
        TRLemmatizer trlm = new TRLemmatizer();
        private void btnTest_Click(object sender, EventArgs e)
        {
            txtOutputen.Text = sc.getLemmas(txtInputen.Text);
            txtOutputtr.Text = trlm.getLemmas(txtInputtr.Text);
        }

        private void btnGetTdkLemma_Click(object sender, EventArgs e)
        {
            List<String> lemmas = new List<string>();
            foreach (string item in File.ReadAllLines(@"C:\Users\AUcan\Desktop\wordlist.txt"))
            {
                lemmas.Add(GetOnlyLemma(item));
                Console.WriteLine(lemmas.Count);
            }
            File.WriteAllLines(@"C:\Users\AUcan\Desktop\wordlistlemmas2.txt", lemmas);
        }

        private string GetOnlyLemma(string item)
        {
            string strlemmas = trlm.getLemmas(item);
            string result="";

            foreach (string itm in strlemmas.Split())
            {
                result += itm.Split(new char[] { '|' })[0]+" ";
            }
            return result.Trim();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void frmTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
