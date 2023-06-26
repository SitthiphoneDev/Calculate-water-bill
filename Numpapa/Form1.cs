using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numpapa
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt10.Text);
            int num2 = int.Parse(txt11.Text);

            int sum1 = num1 * 1379;
            int sum2 = num2 * 1910;

            txt13.Text = sum1.ToString();
            txt19.Text = sum2.ToString();

            int num3 = sum1 + sum2;
            txtnum.Text = num3.ToString();

            int pern = int.Parse(txtpern.Text);
            float huk = float.Parse(txthuk.Text);

            float sum = num3 + pern + huk;
            float tax = (float)((sum) * 0.07);

            txtag.Text = tax.ToString();
            float total_price = sum + tax;
            txttotal.Text = total_price.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txt13.Enabled = false;
            txt19.Enabled = false;
            txtnum.Enabled = false;
            txtag.Enabled = false;
            txttotal.Enabled = false;
        }
    }
}
