using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Mas = new int[15];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                Mas[i] = random.Next(-50, 50);
                listBox1.Items.Add("Mas[" + (i+1).ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] < 0) Mas[i] = 0;
                listBox2.Items.Add("Mas[" + Convert.ToString(i+1) + "] = " + Mas[i].ToString());
            }
        }
    }
}
