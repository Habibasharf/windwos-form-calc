using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTask7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Calculate c = new Calculate();
            this.Hide();
            c.ShowDialog();
            this.Show();

        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            Reverse r = new Reverse();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
