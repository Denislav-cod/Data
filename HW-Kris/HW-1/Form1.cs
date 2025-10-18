using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string allowedBinary = "01";
            string allowedOctal = "01234567";
            string allowedDecimal = "0123456789";
            string allowedHex = "0123456789ABCDEF";

            if (comboBox1 != null)
            {
                string numToConvert = textBox5.Text;

                // BINARY
                if (comboBox1.SelectedIndex == 0)
                {
                    bool isValid = !string.IsNullOrEmpty(numToConvert) &&
                                   numToConvert.All(c => allowedBinary.Contains(c));
                    if (isValid)
                    {
                        label6.Text = "Binary recognized!";
                        int decimalValue = Convert.ToInt32(numToConvert, 2);
                        textBox1.Text = numToConvert;
                        textBox2.Text = decimalValue.ToString();  // Decimal
                        textBox3.Text = Convert.ToString(decimalValue, 8);  // Octal
                        textBox4.Text = Convert.ToString(decimalValue, 16).ToUpper();  // Hex
                    }
                    else
                    {
                        label6.Text = "Binary number not recognized!";
                        ClearTextBoxes();
                    }
                }
                // OCTAL
                else if (comboBox1.SelectedIndex == 1)
                {
                    bool isValid = !string.IsNullOrEmpty(numToConvert) &&
                                   numToConvert.All(c => allowedOctal.Contains(c));
                    if (isValid)
                    {
                        label6.Text = "Octal recognized!";
                        int decimalValue = Convert.ToInt32(numToConvert, 8);
                        textBox1.Text = Convert.ToString(decimalValue, 2);  // Binary
                        textBox2.Text = decimalValue.ToString();  // Decimal
                        textBox3.Text = numToConvert;  // Octal
                        textBox4.Text = Convert.ToString(decimalValue, 16).ToUpper();  // Hex
                    }
                    else
                    {
                        label6.Text = "Octal number not recognized!";
                        ClearTextBoxes();
                    }
                }
                // DECIMAL
                else if (comboBox1.SelectedIndex == 2)
                {
                    bool isValid = !string.IsNullOrEmpty(numToConvert) &&
                                   numToConvert.All(c => allowedDecimal.Contains(c));
                    if (isValid)
                    {
                        label6.Text = "Decimal recognized!";
                        int decimalValue = int.Parse(numToConvert);
                        textBox1.Text = Convert.ToString(decimalValue, 2);  // Binary
                        textBox2.Text = numToConvert;  // Decimal
                        textBox3.Text = Convert.ToString(decimalValue, 8);  // Octal
                        textBox4.Text = Convert.ToString(decimalValue, 16).ToUpper();  // Hex
                    }
                    else
                    {
                        label6.Text = "Decimal number not recognized!";
                        ClearTextBoxes();
                    }
                }
                // HEXADECIMAL
                else if (comboBox1.SelectedIndex == 3)
                {
                    bool isValid = !string.IsNullOrEmpty(numToConvert) &&
                                   numToConvert.All(c => allowedHex.Contains(c));
                    if (isValid)
                    {
                        label6.Text = "Hex recognized!";
                        int decimalValue = Convert.ToInt32(numToConvert, 16);
                        textBox1.Text = Convert.ToString(decimalValue, 2);  // Binary
                        textBox2.Text = decimalValue.ToString();  // Decimal
                        textBox3.Text = Convert.ToString(decimalValue, 8);  // Octal
                        textBox4.Text = numToConvert.ToUpper();  // Hex
                    }
                    else
                    {
                        label6.Text = "Hex number not recognized!";
                        ClearTextBoxes();
                    }
                }
            }
        }
        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }


    }
    
}
