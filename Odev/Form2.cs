using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form2 : Form
    {   
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            Form1 form1 = new Form1();
            int random = a.Next(0, form1.listboxE.Items.Count);
            textBox1.Clear();
            label2.Text = "?";
            label1.Text = form1.listboxE.Items[random] + "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            Form1 form1 = new Form1();
            int random = a.Next(0, form1.listboxE.Items.Count);
            textBox1.Clear();
            label1.Text = "?";
            label2.Text = form1.listBoxT.Items[random] + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;

            Form1 form1 = new Form1();

            if (label2.Text == "?")
            {
                for (i = 0; i < form1.listBoxT.Items.Count; i++)
                {
                    if (label1.Text == form1.listboxE.Items[i].ToString())
                    {
                        if (textBox1.Text == form1.listBoxT.Items[i].ToString())
                        {
                            MessageBox.Show("Congrats");

                            break;
                        }
                        else
                        {
                            MessageBox.Show("Wrong");

                            break;
                        }
                    }
                }

            }

            if (label1.Text == "?")
            {
                for (i = 0; i < form1.listboxE.Items.Count; i++)
                {
                    if (label2.Text == form1.listBoxT.Items[i].ToString())
                    {   
                        if (textBox1.Text == form1.listboxE.Items[i].ToString())
                        { MessageBox.Show("Congrats");
                      
                            break;
                        }
                        else
                        { MessageBox.Show("Wrong");
                           
                            break;
                        }
                    }
                }
                
            }

            

            if (textBox1.Text == "")
            { MessageBox.Show("Please Write a Word"); }



        }
    }
}
