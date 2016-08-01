using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SCNLPNetTest
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        TrEnLemmatizer lm;

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtOutputen.Text = GetOnlyLemma(lm.getLemmasEn(txtInputen.Text));
            txtOutputtr.Text = GetOnlyLemma(lm.getLemmasTR(txtInputtr.Text));
        }

        private void btnGetTdkLemma_Click(object sender, EventArgs e)
        {
            List<String> lemmas = new List<string>();
            foreach (string item in File.ReadAllLines(@"C:\Users\AUcan\Desktop\wordlist.txt"))
            {
                lemmas.Add(GetOnlyLemma(lm.getLemmasTR(item)));
                Console.WriteLine(lemmas.Count);
            } 
            File.WriteAllLines(@"C:\Users\AUcan\Desktop\wordlistlemmas3.txt", lemmas.Distinct());
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            lm = new TrEnLemmatizer();
        }


        private string GetOnlyLemma(string lmResult)
        {
            string result = "";
            string[] temp;
            

            foreach (string item in lmResult.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                temp = item.Split(new char[] { '|' });
                if (!Regex.IsMatch(temp[0], @"[^\w\s]"))
                {
                    result += temp[0] + " ";                    
                }
            }            
            return result.Trim();
        }

        private void btnGetSubLemmas_Click(object sender, EventArgs e)
        {
            List<String> lemmas = new List<string>();
            foreach (string item in File.ReadAllLines(@"C:\Users\AUcan\Desktop\EnSubjectiveTerms.txt"))
            {
                lemmas.Add(GetOnlyLemma(lm.getLemmasEn(item)));
                Console.WriteLine(lemmas.Count);
            }
            File.WriteAllLines(@"C:\Users\AUcan\Desktop\EnSubjectiveLemmas.txt", lemmas);
        }
    }
}
