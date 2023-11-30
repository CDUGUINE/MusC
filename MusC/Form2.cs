using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Reponse
        {
            get { return textBox1.Text; }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
            this.Close();
        }
    }
}
