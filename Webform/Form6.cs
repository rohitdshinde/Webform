using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webform
{
    public partial class Form6 : Form
    {
        string input = "";
        double expressionFirst;
        double expressionSecond;
        int action = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (action == 0)
            {
                expressionFirst = Convert.ToDouble(input);
                action = 4;
                label1.Text = input;
                input = "";
            }
            else
            {
                action = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (action == 0)
            {
                expressionFirst = Convert.ToDouble(input);
                action = 3;
                label1.Text = input;
                input = "";
            }
            else
            {
                action = 3;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (action == 0)
            {
                expressionFirst = Convert.ToDouble(input);
                action = 2;
                label1.Text = input;
                input = "";
            }
            else
            {
                action = 2;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (action == 0)
            {
                expressionFirst = Convert.ToDouble(input);
                action = 1;
                label1.Text = input;
                input = "";
            }
            else
            {
                action = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double answer;
            expressionSecond = Convert.ToDouble(input);
            input = "";
            switch (action)
            {
                case 1:
                    answer = expressionFirst + expressionSecond;
                    label2.Text = Convert.ToString(answer);
                    input = input + answer;
                    action = 0;
                    break;
                case 2:
                    answer = expressionFirst - expressionSecond;
                    label2.Text = Convert.ToString(answer);
                    input = input + answer;
                    action = 0;
                    break;
                case 3:
                    answer = expressionFirst * expressionSecond;
                    label2.Text = Convert.ToString(answer);
                    input = input + answer;
                    action = 0;
                    break;
                case 4:
                    answer = expressionFirst / expressionSecond;
                    label2.Text = Convert.ToString(answer);
                    input = input + answer;
                    action = 0;
                    break;
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = input + "7";
            label1.Text= input;
            label2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            input = input + "8";
            label1.Text = input;
            label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input = input + "9";
            label1.Text = input;
            label2.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input = input + "4";
            label1.Text = input;
            label2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input = input + "5";
            label1.Text = input;
            label2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input = input + "6";
            label1.Text = input;
            label2.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input = input + "3";
            label1.Text = input;
            label2.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input = input + "2";
            label1.Text = input;
            label2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input = input + "1";
            label1.Text = input;
            label2.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input = input + "0";
            label1.Text = input;
            label2.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input = "";
            label1.Text = input;
            label2.Text = "";
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
    

