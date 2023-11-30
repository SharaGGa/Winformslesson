using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformslesson
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            label1.Text = "";
        }


        private void button18_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains(","))
                richTextBox1.Text = richTextBox1.Text + ",";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(richTextBox1.Text);
            switch (D)
            {
                case "+": res = dn1 + dn2;
                    break;
                case "-": res = dn1 - dn2;
                    break;
                case "×": res = dn1 * dn2;
                    break;
                case "÷": res = dn1 / dn2;
                    break;

            }
            if (Convert.ToString(res) != "∞")
            {
                label1.Text = N1 + " " + D + " " + richTextBox1.Text + " " + "=";
                D = "=";
                n2 = true;
                N1 = "0";
                richTextBox1.Text = Convert.ToString(res);
            } else
            {
                label1.Text = "Ошибка";
                D = "=";
                n2 = true;
                N1 = "0";
                richTextBox1.Text = "На ноль делить нельзя!";
            }

        }



        private void button6_Click_1(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                richTextBox1.Text = "0";
            }
            Button B = (Button)sender;
            if(richTextBox1.Text=="0")
                richTextBox1.Text = B.Text;
            else
                richTextBox1.Text = richTextBox1.Text + B.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = richTextBox1.Text;
            label1.Text = N1 + " " + B.Text;
            n2 = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                richTextBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (richTextBox1.Text == "0")
                richTextBox1.Text = B.Text;
            else
                richTextBox1.Text = richTextBox1.Text + B.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double plsmns = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = Convert.ToString(-plsmns);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            if (richTextBox1.Text == "")
                richTextBox1.Text = "0";
        }
    }
}
