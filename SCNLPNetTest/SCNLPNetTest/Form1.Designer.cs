namespace SCNLPNetTest
{
    partial class frmTest
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
            this.txtInputen = new System.Windows.Forms.TextBox();
            this.txtOutputen = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtOutputtr = new System.Windows.Forms.TextBox();
            this.txtInputtr = new System.Windows.Forms.TextBox();
            this.btnGetTdkLemma = new System.Windows.Forms.Button();
            this.btnGetSubLemmas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputen
            // 
            this.txtInputen.Location = new System.Drawing.Point(12, 12);
            this.txtInputen.Multiline = true;
            this.txtInputen.Name = "txtInputen";
            this.txtInputen.Size = new System.Drawing.Size(593, 29);
            this.txtInputen.TabIndex = 0;
            this.txtInputen.Text = "We have to break down average accuracy according to artificial and natural proces" +
    "sing";
            // 
            // txtOutputen
            // 
            this.txtOutputen.Location = new System.Drawing.Point(11, 47);
            this.txtOutputen.Multiline = true;
            this.txtOutputen.Name = "txtOutputen";
            this.txtOutputen.Size = new System.Drawing.Size(593, 49);
            this.txtOutputen.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(10, 209);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test it";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtOutputtr
            // 
            this.txtOutputtr.Location = new System.Drawing.Point(10, 154);
            this.txtOutputtr.Multiline = true;
            this.txtOutputtr.Name = "txtOutputtr";
            this.txtOutputtr.Size = new System.Drawing.Size(593, 49);
            this.txtOutputtr.TabIndex = 4;
            // 
            // txtInputtr
            // 
            this.txtInputtr.Location = new System.Drawing.Point(11, 119);
            this.txtInputtr.Multiline = true;
            this.txtInputtr.Name = "txtInputtr";
            this.txtInputtr.Size = new System.Drawing.Size(593, 29);
            this.txtInputtr.TabIndex = 3;
            this.txtInputtr.Text = "Şemsi paşa pasajında sesi büzüşesiceler.";
            // 
            // btnGetTdkLemma
            // 
            this.btnGetTdkLemma.Location = new System.Drawing.Point(103, 209);
            this.btnGetTdkLemma.Name = "btnGetTdkLemma";
            this.btnGetTdkLemma.Size = new System.Drawing.Size(103, 23);
            this.btnGetTdkLemma.TabIndex = 6;
            this.btnGetTdkLemma.Text = "Get TDK Lemma";
            this.btnGetTdkLemma.UseVisualStyleBackColor = true;
            this.btnGetTdkLemma.Click += new System.EventHandler(this.btnGetTdkLemma_Click);
            // 
            // btnGetSubLemmas
            // 
            this.btnGetSubLemmas.Location = new System.Drawing.Point(226, 209);
            this.btnGetSubLemmas.Name = "btnGetSubLemmas";
            this.btnGetSubLemmas.Size = new System.Drawing.Size(134, 23);
            this.btnGetSubLemmas.TabIndex = 7;
            this.btnGetSubLemmas.Text = "Get Subjective Lemmas";
            this.btnGetSubLemmas.UseVisualStyleBackColor = true;
            this.btnGetSubLemmas.Click += new System.EventHandler(this.btnGetSubLemmas_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 240);
            this.Controls.Add(this.btnGetSubLemmas);
            this.Controls.Add(this.btnGetTdkLemma);
            this.Controls.Add(this.txtOutputtr);
            this.Controls.Add(this.txtInputtr);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtOutputen);
            this.Controls.Add(this.txtInputen);
            this.Name = "frmTest";
            this.Text = "Stanford Core NLP .Net Test";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputen;
        private System.Windows.Forms.TextBox txtOutputen;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtOutputtr;
        private System.Windows.Forms.TextBox txtInputtr;
        private System.Windows.Forms.Button btnGetTdkLemma;
        private System.Windows.Forms.Button btnGetSubLemmas;
    }
}

