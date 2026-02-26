using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole
{
    public partial class Form1 : Form
    {
        int i,max,min, n=0;
        int[] a = new int[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //načtení
        {           
            a[n] =int.Parse (textBox1.Text);
            n++;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) //výpis
        {
            for (i=0;i<n;i++)
                listBox1.Items.Add(a[i]);
        }

        private void button5_Click(object sender, EventArgs e) // výpis pozpátku
        {
            for (i = n-1; i >= 0; i--)
                listBox2.Items.Add(a[i]);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label2.Text = "Nejvyšší prvek pole: ";
            label3.Text = "Nejmenší prvek pole: ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                max = a[0]; min = a[0];
                for (i = 1; i < n; i++)
                {
                    if (a[i] > max) max = a[i];
                    if (a[i] < min) min = a[i];
                }
                //max=a.Max();
                //min = a.Min();

                label2.Text = "Nejvyšší prvek pole: " + max;
                label3.Text = "Nejmenší prvek pole: " + min;
            }

            else
                MessageBox.Show("Pole je momentálně prázdné!");
                           
        }
    }
}
