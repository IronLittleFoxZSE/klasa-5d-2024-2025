using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click_TMP(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            if (Validate(textBoxFirsNumber.Text, textBoxSecondNumber.Text,
                out firstNumber, out secondNumber))
            {
                Calculate('+', firstNumber, secondNumber);
            }
            else
            {
                ShowErrorMessage();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            if (int.TryParse(textBoxFirsNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber + secondNumber;
                labelResult.Text = "Wynik operacji dodawania: " + result;
            }
            else
            {
                labelResult.Text = "Podano nieprawidłowe dane";
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            if (int.TryParse(textBoxFirsNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber - secondNumber;
                labelResult.Text = "Wynik operacji odejmowania: " + result;
            }
            else
            {
                labelResult.Text = "Podano nieprawidłowe dane";
            }
        }

        private void ShowErrorMessage()
        {
            labelResult.Text = "Podano nieprawidłowe dane";
        }

        private bool Validate(string firstStrNumber, string secondStrNumber,
                              out int firstNumber, out int secondNumber)
        {
            //firstNumber = 0;
            secondNumber = 0;
            return int.TryParse(firstStrNumber, out firstNumber)
                && int.TryParse(secondStrNumber, out secondNumber);
        }

        private void Calculate(char operatorToDo, int firstNumber, int secondNumber)
        {
            int result;
            switch (operatorToDo)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    labelResult.Text = "Wynik operacji dodawania: " + result;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    labelResult.Text = "Wynik operacji odejmowania: " + result;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    labelResult.Text = "Wynik operacji mnożenia: " + result;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    labelResult.Text = "Wynik operacji dzielenia: " + result;
                    break;
                default:
                    break;
            }
        }
    }
}
