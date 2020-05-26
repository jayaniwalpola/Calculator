using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtbox_Result.Text == "0") || (isOperationPerformed))
                txtbox_Result.Clear();

            isOperationPerformed = false;

            Button button=(Button)sender;
            if(button.Text==".")
            {
                if(!txtbox_Result.Text.Contains("."))
                    txtbox_Result.Text = txtbox_Result.Text + button.Text;
            }
            else
            txtbox_Result.Text = txtbox_Result .Text+ button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(result!=0)
            {
                btnequal.PerformClick();
                operation = button.Text;
                labelCurrentOperation.Text = result + " " + operation;
                isOperationPerformed = true;

            }
            else
            {
                operation = button.Text;
                result = Double.Parse(txtbox_Result.Text);
                labelCurrentOperation.Text = result + " " + operation;
                isOperationPerformed = true;
            }
            
        }

        private void button4_click(object sender, EventArgs e)
        {
            txtbox_Result.Text = "0";
            
        }

        private void button5_click(object sender, EventArgs e)
        {
            txtbox_Result.Text = "0";
            result = 0;
        }

        private void button6_click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    txtbox_Result.Text = (result + Double.Parse(txtbox_Result.Text)).ToString();
                    break;
                case "-":
                    txtbox_Result.Text = (result - Double.Parse(txtbox_Result.Text)).ToString();
                    break;
                case "*":
                    txtbox_Result.Text = (result * Double.Parse(txtbox_Result.Text)).ToString();
                    break;
                case "/":
                    txtbox_Result.Text = (result / Double.Parse(txtbox_Result.Text)).ToString();
                    break;
                
                default:
                    break;
            }
            result = Double.Parse(txtbox_Result.Text);
            labelCurrentOperation.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
