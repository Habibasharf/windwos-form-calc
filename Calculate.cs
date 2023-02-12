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
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
           string y = textBox3.Text;
            string op = textBox2.Text;
            calculateoperator co = new calculateoperator();
            string result = co.CalculateFunction(x, y, op);

            MessageBox.Show(result, "Your result is : ");
        }

        private void Calculate_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
