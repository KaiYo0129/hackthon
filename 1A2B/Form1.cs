using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B
{
    public partial class Form1 : Form
    {
        
        String randomString = "";
        int[] randomNumber;
        int A = 0, B = 0, count = 0;
        private List<String> list = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            while (randomString.Length < 4)
            {
                int enterrandom = random.Next(0, 10);
                var h = randomString.Intersect(enterrandom.ToString());
                if (h.Count()<1)
                {
                    randomString += enterrandom.ToString();
                }
            }
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(randomString);
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String a;
            int A = 0, B = 0,number;
            if (textBox1.Text.Distinct().Count() == 4&& int.TryParse(textBox1.Text, out number))  //判斷輸入進來的值  是否重複(重複的數字合併後為4位數)&&是否是數字
            {
                 a = textBox1.Text;
                 var guest = randomString.Intersect(a);   //交集兩個字串  判斷有無同樣內容
                 if (guest.Count() > 0)                   //判斷是否有交集的字串個數
                 {
                     A = randomString.Count((x) => randomString.IndexOf(x) == a.IndexOf(x));         //以RANDOM的數值數數，去判斷亂數的索引值與輸入的索引值相同，求其個數為多少
                     B = guest.Count() - A;
                 }
                 else
                 {
                    addList(A, B);
                    MessageBox.Show("失敗");
                 }
                 if (A == 4)
                 {
                     addList(A, B);
                     MessageBox.Show("過關");
                     button3.Enabled = false;
                 }
                 else
                 {
                     addList(A, B);
                     MessageBox.Show("失敗");
                 }
            }
            else
            {
                MessageBox.Show("Error Enter");
            }
        }

        private void addList(int A,int B)
        {
            list.Add(textBox1.Text + "    :    " + A + "A" + B + "B");
            ChangeData();
        }

        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            list.Clear();
            ChangeData();
            textBox1.Clear();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = true;
        }
    }
}
