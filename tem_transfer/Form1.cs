using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tem_transfer
{

    public partial class Form1 : Form
    {
        private string number;
        private int count=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void onClick(object sender, EventArgs e)
        {
            Button b = (Button)(sender);
            textBox1.Text = textBox1.Text + b.Text;
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            double tem;
            bool result = double.TryParse(textBox1.Text,out tem);
            
            if (radioButton1.Checked == true)
            {
                tem = (tem*1.8) + 32;
                label1.Text = tem.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                tem = (tem-32)/9*5;
                label1.Text = tem.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }
    }
}
