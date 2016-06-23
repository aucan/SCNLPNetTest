using System;
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
    }
}
