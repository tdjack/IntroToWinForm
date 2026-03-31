using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroToWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Option 1");
            comboBox1.Items.Add("Option 2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Button1 clicked ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Button2 clicked ";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Option 1  clicked ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Option 2  clicked ";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Option 3  clicked ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Option 1 Changed ";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Option 2 Changed ";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Option 3 Changed ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text + " selected ";
        }
    }
}
