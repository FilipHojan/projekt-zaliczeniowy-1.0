﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_zaliczeniowy_1._0
{
    public partial class Form5 : Form
    {
        double firstNumber;
        double secondNumber;
        string operation;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sin(number).ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            textBox1.Text = Math.Cos(number).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            textBox1.Text = Math.Tan(number).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textBox1.Text);

            switch (operation)
            {
                case "+":
                    textBox1.Text = (firstNumber + secondNumber).ToString();
                    break;

                case "-":
                    textBox1.Text = (firstNumber - secondNumber).ToString();
                    break;

                case "*":
                    textBox1.Text = (firstNumber * secondNumber).ToString();
                    break;

                case "/":
                    textBox1.Text = (firstNumber / secondNumber).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
