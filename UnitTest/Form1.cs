using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringFormatter obj = new StringFormatter();
            textBox2.Text = obj.WebString(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] a;
            //a = new int[] { 3, 1, -2, 5, 4, -2, 1, 7, -1, -1 };
            a = new int[] { -4, -4, -4, -3, -5, -3, 2, 1, 4, 7, 5, 6, 8, 9 };

            ArrayProcessor obj = new ArrayProcessor();
            a = obj.SortAndFilter(a);

            for (int i = 0; i < a.Length; i++)
            {
                listBox2.Items.Insert(i, a[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[,] sec, third;
            sec = new double[,] { { 1, -1 }, { 2, 1 } };
            third = new double[,] { { 1, 2, 4 }, { 5, 1, 2 }, { 3, -1, 1 } };
            double[] res;
            double[] sec_free = new double[2] { -5, -7 };
            double[] third_free = new double[3] { 31, 29, 10 };


            LinearEquationsSystem obj = new LinearEquationsSystem();
            obj.SetCoefficients(third);
            res = obj.Solve(third_free, 3);

            for (int i = 0; i < res.Length; i++)
            {
                listBox1.Items.Insert(i, res[i]);
            }
        }
    }
}
