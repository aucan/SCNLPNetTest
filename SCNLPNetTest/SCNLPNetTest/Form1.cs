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
        private void btnTest_Click(object sender, EventArgs e)
        {
            txtOutput.Text = sc.getAnnotation(txtInput.Text);
            var ws=sc.getAnnotatedWords(txtInput.Text);
            MessageBox.Show(ws.Count.ToString());
        } 
    }
}
