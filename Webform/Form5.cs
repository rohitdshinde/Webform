using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webform
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string roll = textBox2.Text;
            string gender = "";
            string qu = "";

            if (radioButton1.Checked == true)
                gender = radioButton1.Text;
            else
               gender= radioButton2.Text;


            if(checkBox1.Checked==true && checkBox2.Checked == true)
            {
                qu = checkBox1.Text + checkBox2.Text;

            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                qu = checkBox1.Text;

            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                qu = checkBox2.Text;

            }
            else
            {
                qu = "";
            }
            MessageBox.Show("Your Name:" + name + "\nRoll No:" + roll + "\nGender:" + gender + "\nQualification:" + qu);


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            MessageBox.Show(text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
