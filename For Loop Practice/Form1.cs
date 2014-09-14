using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Loop_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);

            if (!isNumber)
            {
                MessageBox.Show("Type numbers in the text boxes you dumb fuck!");
            }
            else
        {
                listBox1.Items.Clear();

                double loopStart;
                double loopEnd;
                double multiplyBy = double.Parse(textBox3.Text);

                loopStart = double.Parse(textBox1.Text);
                loopEnd =double.Parse(textBox2.Text);

                double answer = 0;

                for (double i = loopStart; i <= loopEnd; i++)
                {
                    answer = multiplyBy * i;

                    listBox1.Items.Add(i + " times " + multiplyBy + " = " + answer.ToString());
                }
            }
        }
    }
}
