using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dızıdeyiskenelr_en_buyuk_enkucuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayi = { 999, 1903, 90, 150, 65, 75, 99 }; 
        private void button1_Click(object sender, EventArgs e)
        {
          Array.Sort(sayi);
                listBox1.Items.Clear();
            for (int i = 0; i < sayi.Length; i++)
			{
			 listBox1.Items.Add(sayi[i]);
			}





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(sayi);
            Array.Reverse(sayi);
            listBox1.Items.Clear();
            for (int i = 0; i < sayi.Length; i++)
            {
                listBox1.Items.Add(sayi[i]);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = sayi.Max().ToString();
            label2.Text = sayi.Min().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {   
         label3.Text = sayi.Sum().ToString();
         label4.Text = sayi.Average().ToString();
         
        }
    }
}
