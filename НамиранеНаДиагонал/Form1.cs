using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НамиранеНаДиагонал
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                label7.Text = "";
                label8.Text = "";
                double value1 = Convert.ToDouble(textBox1.Text);
                double value2 = Convert.ToDouble(textBox2.Text);
               double sum = Math.Sqrt((value1 * value1) + (value2 * value2));

                label1.Text =sum.ToString("0 mm");
            }
            catch (Exception)
            {
                
                textBox1.Text = "";
                textBox2.Text = "";
                label1.Text = "";
                label8.Text = "!!!-ВНИМАНИЕ-!!!";
                   label7.Text = "Грешен формат на стойностите!\n\n" +
                   "Въведете цяло число в милиметри!\n\n" +
                   "Или попълнете всички полета!";
                    throw ;
                
              
            }
            textBox1.SelectAll();
            textBox2.SelectAll();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
