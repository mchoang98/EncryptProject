using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusWinForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void tiepTucbtn_Click(object sender, EventArgs e)
        {
            var mine = new Form1();
            mine.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mine = new Form1();
            mine.Show();
            this.Hide();
        }
    }
}
