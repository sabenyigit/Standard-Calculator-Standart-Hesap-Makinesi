using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiDENE
{
    public partial class Form1 : Form
    {
        double x, y;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);

            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") 
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button22_Click(object sender, EventArgs e) 
        {
            if (Convert.ToDouble(textBox1.Text) > 0)
            {
                textBox1.Text=textBox1.Text.Remove(textBox1.Text.Length-1,1);
                
                if(textBox1.Text.Length == 0 )
                { 
                    textBox1.Text = "0"; 
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if ( islem=="+")
            {
                textBox1.Text= Convert.ToString(x+y);
                label1.Text="";
            }

            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }

            if (islem == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }

            if (islem == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }

            if (islem == "mod")
            {
                textBox1.Text = Convert.ToString(x % y);
                label1.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "*";
            label1.Text = textBox1.Text + "x";
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "/";
            label1.Text = textBox1.Text + "÷";
            textBox1.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                double deger = Double.Parse(textBox1.Text);
                textBox1.Text = (deger / 100).ToString();
                label1.Text = deger.ToString() + "%";
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(textBox1.Text);

            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bolumx = Convert.ToDouble(textBox1.Text);

            bolumx = 1 / (bolumx);
            textBox1.Text = Convert.ToString(bolumx);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";
            
        }
    }
}
