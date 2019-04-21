using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This is Sample Project by Shyam Mistry

namespace SimpleCalculator1._2
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") ||(operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if(b.Text==".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
            result.Text = result.Text + b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            if (value != 0)
            {
                button6.PerformClick();
                operation = b.Text;
                equation.Text = value + " " + operation;
                operation_pressed = true;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                equation.Text = value + " " + operation;
                operation_pressed = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
             }
            value = Double.Parse(result.Text);
            equation.Text = "";

        }

        
    }
}
