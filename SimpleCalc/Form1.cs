namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        string input1 = "";
        string input2 = "";
        float num1 = 0;
        float num2 = 0;
        float result = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            input1 += button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            input1 += button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            input1 += button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            input1 += button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            input1 += button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            input1 += button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            input1 += button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            input1 += button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            input1 += button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            input1 += button0.Text;
        }
        private void button1__Click(object sender, EventArgs e)
        {
            input2 += button1_.Text;
        }
        private void button2__Click(object sender, EventArgs e)
        {
            input2 += button2_.Text;
        }
        private void button3__Click(object sender, EventArgs e)
        {
            input2 += button3_.Text;
        }
        private void button4__Click(object sender, EventArgs e)
        {
            input2 += button4_.Text;
        }
        private void button5__Click(object sender, EventArgs e)
        {
            input2 += button5_.Text;
        }
        private void button6__Click(object sender, EventArgs e)
        {
            input2 += button6_.Text;
        }
        private void button7__Click(object sender, EventArgs e)
        {
            input2 += button7_.Text;
        }
        private void button8__Click(object sender, EventArgs e)
        {
            input2 += button8_.Text;
        }
        private void button9__Click(object sender, EventArgs e)
        {
            input2 += button9_.Text;
        }
        private void button10__Click(object sender, EventArgs e)
        {
            input2 += button0_.Text;
        }
        private void cboOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            num1 = float.Parse(input1);            
            operation = cboOperation.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboOperation.Items.Add("+");
            cboOperation.Items.Add("-");
            cboOperation.Items.Add("*");
            cboOperation.Items.Add("/");
            cboOperation.Items.Add("^");
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(input2);
            MessageBox.Show("number 1 = " + num1.ToString() + " number 2 = " + num2.ToString() + " operation = " + operation.ToString());
           
            switch (operation)
            {
                case "+":
                    {
                        result = num1 + num2;
                        textBoxResult.Text = result.ToString();
                        break;
                    }
                case "-":
                    {
                        result = num1 - num2;
                        textBoxResult.Text = result.ToString();
                        break;
                    }
                case "*":
                    {
                        result = num1 * num2;
                        textBoxResult.Text = result.ToString();
                        break;
                    }
                case "/":
                    {
                        result = num1 / num2;
                        textBoxResult.Text = result.ToString();
                        break;
                    }
                case "^":
                    {
                        result = powerFunction(num1, num2);
                        textBoxResult.Text = result.ToString();
                        break;
                    }
            }
        }

        private float powerFunction(float num1, float num2)
        {
            if (num1 == 0 || num1 == 1)   //0^a = 0; 1^a = 1; a^0 = 1; a^1 = a.
            {
                return num1;
            }
            else if (num2 == 0)
            {
                return 1;
            }
            else if (num2 == 1)
            {
                return num1;
            }
            else
            {
                return num1 * powerFunction(num1, num2 - 1);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            input1 = "";
            input2 = "";
            num1 = 0;
            num2 = 0;
            result = 0;
            textBoxResult.Text = "";
        }
    }
}