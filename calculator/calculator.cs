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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private decimal operand1 = 0.0m;
        private decimal operand2 = 0.0m;
        private decimal result = 0.0m;
        private int opptype = (int)math.noOperator;

        public enum math
        {

            noOperator = 0,
            add = 1,
            minus = 2,
            times = 3,
            divide = 4,

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "8";

        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "1";

        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "2";

        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "6";

        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "3";

        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "4";

        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "5";

        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "7";

        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "9";

        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {

                display.Clear();
            }
            display.Text = display.Text + "0";

        }

        private void butpnt_Click(object sender, EventArgs e)
        {
            if(!display.Text.Contains("."))
            {
                display.Text += ".";
                
            }
        }

        private void butp_Click(object sender, EventArgs e)
        {
            opptype = 1;

            operand1 = Convert.ToDecimal(display.Text);
            display.Text = "0";

            eqt.Text = operand1 + " +";


        }

        private void butmj_Click(object sender, EventArgs e)
        {
            opptype = 2;

            operand1 = Convert.ToDecimal(display.Text);
            display.Text = "0";

            eqt.Text = operand1 + " -";

        }

        private void butt_Click(object sender, EventArgs e)
        {
            opptype = 3;

            operand1 = Convert.ToDecimal(display.Text);
            display.Text = "0";

            eqt.Text = operand1 + " *";

        }

        private void butd_Click(object sender, EventArgs e)
        {
            opptype = 4;

            operand1 = Convert.ToDecimal(display.Text);
            display.Text = "0";

            eqt.Text = operand1 + " /";

        }

        private void buteql_Click(object sender, EventArgs e)
        {
            operand2 = Convert.ToDecimal(display.Text);

            eqt.Text = "";

            switch (opptype)
            {
                case 1:
                    result = operand1 + operand2;
                    break;

                case 2:
                    result = operand1 - operand2;
                    break;

                case 3:
                    result = operand1 * operand2;
                    break;


                case 4:
                    result = operand1 / operand2;
                    break;
            }
            display.Text = result.ToString();


        }

        private void butc_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void butce_Click(object sender, EventArgs e)
        {
            display.Clear();
            display.Text = "0";
        }

        private void eqt_Click(object sender, EventArgs e)
        {

        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
