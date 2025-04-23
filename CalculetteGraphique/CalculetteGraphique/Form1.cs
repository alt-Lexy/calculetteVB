using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculetteGraphique
{
    public partial class Form1 : Form
    {

        // initialization
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; 
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)(sender);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)(sender);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);
            currentInput += btn.Text;
            textBox1.Text = currentInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)(sender);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)(sender);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)(sender);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)(sender);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)(sender);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        //private void Operation()
        //{
        //    if (operationPending)
        //    {
        //        double secondNumber = double.Parse(currentInput);

        //        switch (operation)
        //        {
        //            case "+": result += secondNumber;
        //                break;
        //            case "-": result -= secondNumber;
        //                break;
        //            case "x": result *= secondNumber;
        //                break;
        //            case "/": if (secondNumber != 0)
        //                {
        //                    result /= secondNumber;
        //                }
        //                break;
        //        }

        //        Console.WriteLine(result);

        //        textBox1.Text = result.ToString();
        //        currentInput = "";
        //        operationPending = false;
        //    }
        //}

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;

            //if (operationPending) { 
            //    Operation();
            //}

            //Button button = (Button)(sender);
            //operation = button.Text;
            //result = double.Parse(currentInput);
            //currentInput = "";
            //operationPending = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;

            //if (operationPending)
            //{
            //    Operation();
            //}

            //Button button = (Button)(sender);
            //operation = button.Text;
            //result = double.Parse(currentInput);
            //currentInput = "";
            //operationPending = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;

            //if (operationPending)
            //{
            //    Operation();
            //}

            //Button button = (Button)(sender);
            //operation = button.Text;
            //result = double.Parse(currentInput);
            //currentInput = "";
            //operationPending = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;

            //if (operationPending)
            //{
            //    Operation();
            //}

            //Button button = (Button)(sender);
            //operation = button.Text;
            //result = double.Parse(currentInput);
            //currentInput = "";
            //operationPending = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), textBox1.Text);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);

            textBox1.Text = result.ToString();
            //Operation();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += "/100";
            textBox1.Text = currentInput;
        }
    }
}
