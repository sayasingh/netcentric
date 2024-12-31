using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);
                string operation = comboBox1.SelectedItem.ToString();

                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            MessageBox.Show("Division by zero is not allowed.", "Error");
                            return;
                        }
                        result = number1 / number2;
                        break;
                    default:
                        MessageBox.Show("Please select a valid operation.", "Error");
                        return;
                }
                labelResult.Text = "Result: " + result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.", "Error");
            }
        
    }
    }
}
