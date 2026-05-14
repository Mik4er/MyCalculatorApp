using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Зчитування чисел
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            double result = 0;

            // Вибір математичної дії
            switch (comboBox1.Text)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        MessageBox.Show("Ділення на нуль неможливе!");
                        return;
                    }
                    break;
            }

            // Виведення результату
            labelResult.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
