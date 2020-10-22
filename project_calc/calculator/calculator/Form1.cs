using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private String num1 = ""; // holding value of texbox before clicked any operations ( + , - , / , * )button .  
        private String num2 = ""; // holding value of texbox when we clicked ( = ) button .
        private String op = "";   //for holding operation character like + , / , - , * .
        private String temp = ""; //for holding value of textbox when we cut last character of string .

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender , KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //add buttons for numbers  0 - 9 

        //for number 0
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        //for number 1
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        //for number 2
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        //for number 3
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        //for number 4
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        //for number 5
        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        //for number 6
        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        //for number 7
        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        //for number 8
        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        //for number 9
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        //for buttons like  . , +/- -------------------------------------------------------------------------

        //for number .
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ( . ) Pressed ");
        }

        //for button +/-
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ( +/- ) Pressed ");
        }

        //for operation like / , * , - , + --------------------------------------------------------------------

        //for operation /
        private void button4_Click_1(object sender, EventArgs e)
        {
            op = "/";
            num1 = textBox1.Text;
            textBox1.Text = "";
        }

        //for operation *
        private void button8_Click_1(object sender, EventArgs e)
        {
            op = "*";
            num1 = textBox1.Text;
            textBox1.Text = "";
        }

        //for operation -
        private void button9_Click_1(object sender, EventArgs e)
        {
            op = "-";
            num1 = textBox1.Text;
            textBox1.Text = "";
        }

        //for operation +
        private void button13_Click_1(object sender, EventArgs e)
        {
            op = "+";
            num1 = textBox1.Text;
            textBox1.Text = "";
        }


        //for operation like clear,CE,C ------------------------------------------------------------------------

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ( CE ) Pressed ");
        }
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            temp = textBox1.Text;
            temp = temp.Remove(temp.Length - 1);
            textBox1.Text = temp;
        }


        //for equal -------------------------------------------------------------------------------------------------

        private void button17_Click(object sender, EventArgs e)
        {
            num2 = textBox1.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show(" Enter Number First ");
            }
            else
            {
                //here num1 = string before clicked operation
                //num2 is hold the value of textbox when we clicked  ( = ) 
                

                if (op == "+") { textBox1.Text = Convert.ToString(double.Parse(num1) + double.Parse(num2)); }
                if (op == "-") { textBox1.Text = Convert.ToString(double.Parse(num1) - double.Parse(num2)); }
                if (op == "*") { textBox1.Text = Convert.ToString(double.Parse(num1) * double.Parse(num2)); }
                if (op == "/") { textBox1.Text = Convert.ToString(double.Parse(num1) / double.Parse(num2)); }
            }
        }
    }
}
