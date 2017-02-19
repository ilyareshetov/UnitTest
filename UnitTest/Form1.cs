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
            a = new int[10] { 3, 1, -2, 5, 4, -2, 1, 7, -1, -1 };

            ArrayProcessor obj = new ArrayProcessor();
            a = obj.SortAndFilter(a);

            for (int i = 0; i < a.Length; i++)
            {
                listBox2.Items.Insert(i, a[i]);
            }
        }
    }
}
