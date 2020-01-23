using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    
    public partial class Form : System.Windows.Forms.Form
    {
       
        public Form()
        {
            InitializeComponent();
        }
        private string firstString;
        private string secondString;
        private float result;
        private string operation;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void BtnDot_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += ".";


        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            firstString = txtbDisplay.Text;
            txtbDisplay.Text = "";
            txtOperation.Text = "+";
            operation = "+";
        }
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            firstString = txtbDisplay.Text;
            txtbDisplay.Text = "";
            txtOperation.Text = "-";
            operation = "-";
        }
        private void BtnTimes_Click(object sender, EventArgs e)
        {
            firstString = txtbDisplay.Text;
            txtbDisplay.Text = "";
            txtOperation.Text = "*";
            operation = "*";
        }
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            firstString = txtbDisplay.Text;
            txtbDisplay.Text = "";
            txtOperation.Text = "/";
            operation = "/";
        }
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            secondString = txtbDisplay.Text;
            if(operation == "+")
            {
                result = float.Parse(firstString) + float.Parse(secondString);
                txtbDisplay.Text = result.ToString();
            }
            else if (operation == "-")
            {
                result = float.Parse(firstString) - float.Parse(secondString);
                txtbDisplay.Text = result.ToString();
            }
            else if (operation == "*")
            {
                result = float.Parse(firstString) * float.Parse(secondString);
                txtbDisplay.Text = result.ToString();
            }
            else if (operation == "/")
            {
                result = float.Parse(firstString) / float.Parse(secondString);
                txtbDisplay.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("No operation found");
            }
            
        }
       
        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text = "";
            txtOperation.Text = "";
            firstString = "";
            secondString = "";
        }
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            var currentLength = this.txtbDisplay.Text.Length;
            if (currentLength == 0) return;
            var BacksSPace = this.txtbDisplay.Text.Remove(currentLength-1);
            this.txtbDisplay.Text = BacksSPace;
        }
       
       
        private void BtnNumber0_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "0";
        }

        private void BtnNumber1_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "1";
        }

        private void BtnNumber2_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "2";

        }

        private void BtnNumber3_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "3";

        }
        private void BtnNumber4(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "4";

        }

        private void BtnNumber5_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "5";

        }

        private void BtnNumber6_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "6";

        }
        private void BtnNumber7(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "7";

        }
        private void BtnNumber8_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "8";

        }

        private void BtnNumber9_Click(object sender, EventArgs e)
        {
            this.txtbDisplay.Text += "9";

        }
       
        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            MessageBox.Show(btn.Name + "clicked");
        }

        private void TxtOperation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
