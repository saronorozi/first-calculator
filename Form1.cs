using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_later
{
    public partial class Form1 : Form
    {
        int x1,x2,result;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt32(txtnumber.Text);
            txtnumber.Text="";
            op="+";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ساخته شده توسط سارونوروزی");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "0";
            this.BackColor = Color.Red;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "1";
            this.BackColor = Color.Pink;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "2";
            this.BackColor = Color.SeaGreen;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "3";
            this.BackColor = Color.Sienna;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "4";
            this.BackColor = Color.SlateBlue;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "5";
            this.BackColor = Color.SteelBlue;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "6";
            this.BackColor = Color.Teal;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "7";
            this.BackColor = Color.Violet;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "8";
            this.BackColor = Color.Peru;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtnumber.Text += "9";
            this.BackColor = Color.PowderBlue;
        }

        private void btnzarn_Click(object sender, EventArgs e)
        {
            txtnumber.Text = "null";
            this.BackColor = Color.YellowGreen;
        }

        private void btnmosavi_Click(object sender, EventArgs e)
        {
            x2 = Convert.ToInt32(txtnumber.Text);
            if (op == "+")
                result = x1 + x2;
            txtnumber.Text = result.ToString();

            if(op == "*")
                result=x1*x2;
            txtnumber.Text=result.ToString();

            if (op == "-")
                result=x1-x2;
                txtnumber.Text = result.ToString();

                if (op == "/")
                    result = x1 / x2;
                txtnumber.Text = result.ToString();
                this.BackColor = Color.Silver;
           
        }

        private void btnmenha_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt32(txtnumber.Text);
            txtnumber.Text = "";
            op = "-";
        }

        private void btntaksim_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt32(txtnumber.Text);
            txtnumber.Text = "";
            op = "*";
            this.BackColor = Color.Yellow;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt32(txtnumber.Text);
            txtnumber.Text="";
                op="/";
                this.BackColor = Color.White;

        }

        private void btndat_Click(object sender, EventArgs e)
        {
            txtnumber.Text += ".";
            this.BackColor = Color.Gold;
        }

        private void btn0_MouseEnter(object sender, EventArgs e)
        {

        }

    }
}
