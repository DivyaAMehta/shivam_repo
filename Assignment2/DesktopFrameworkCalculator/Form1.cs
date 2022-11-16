using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirthmeticFrameworkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tb1.Text);
            int num2 = int.Parse(tb2.Text);
            int sum = num + num2;
            tb3.Text = sum.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tb1.Text);
            int num2 = int.Parse(tb2.Text);
            int sub = num - num2;
            tb4.Text = sub.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tb1.Text);
            int num2 = int.Parse(tb2.Text);
            int mul = num * num2;
            tb5.Text = mul.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tb1.Text);
            int num2 = int.Parse(tb2.Text);
            int div = num / num2;
            tb6.Text = div.ToString();
        }
    }
}
