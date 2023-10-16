using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float result;
                float a = Convert.ToInt32(textBox1.Text);
                float b = Convert.ToInt32(textBox2.Text);
                string S = Convert.ToString(a / b);
                bool result1 = float.TryParse(S, out result);
                if (result1 == true)
                {
                    label2.Text = S;
                }

            }
            catch
            {
                MessageBox.Show("Вы ввели неправильное значение!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int result;
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                string S = Convert.ToString(a * b);
                bool result1 = int.TryParse(S, out result);
                if (result1 == true)
                {
                    label2.Text = S;
                }

            }
            catch
            {
                MessageBox.Show("Вы ввели неправильное значение!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int result;
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                string S = Convert.ToString(a - b);
                bool result1 = int.TryParse(S, out result);
                if (result1 == true)
                {
                    label2.Text = S;
                }

            }
            catch
            {
            MessageBox.Show("Вы ввели неправильное значение!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    int result;
                    int a = Convert.ToInt32(textBox1.Text);
                    int b = Convert.ToInt32(textBox2.Text);
                    string S = Convert.ToString(a + b);
                    bool result1 = int.TryParse(S, out result);
                    if(result1 == true)
                    {
                        label2.Text = S;
                    }
                
                }
                catch
                {

                    MessageBox.Show("Вы ввели неправильное значение!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                label2.Text = "0";
        }
    }
}
