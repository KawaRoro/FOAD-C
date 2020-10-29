using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Additionneur
{
    public partial class Form1 : Form
    {
        private int additionValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonValue = Int32.Parse(button.Tag.ToString());

            richTextBox1.Text = richTextBox1.Text + $"{buttonValue}+";
            additionValue += buttonValue;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            richTextBox1.Text += $" = {additionValue} +";

        }

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            additionValue = 0;
        }

    }
}
