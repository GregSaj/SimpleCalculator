namespace SimpleCalculator
{
    public partial class SimpleCalc : Form
    {
        string CalTotal;
        double num1;
        double num2;
        string option;
        double result;
        bool secondOrMoreCalc = false;

        public SimpleCalc()
        {
            InitializeComponent();
        }

        private void displayNumberBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddTextToDisplay(string text)
        {
            displayNumberBox.Text += text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddTextToDisplay("0");
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double num2 = double.Parse(displayNumberBox.Text);

            switch (option)
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
                    result = num1 / num2;
                    break;
                default:
                    break;
            }

            CalTotal = result.ToString();

            displayNumberBox.Text = CalTotal;

            option = String.Empty;

            secondOrMoreCalc = false;

        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(displayNumberBox.Text))
            {
                return;
            }

            CheckIfFirstCalc("+");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(displayNumberBox.Text))
            {
                return;
            }

            CheckIfFirstCalc("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(displayNumberBox.Text))
            {
                return;
            }

            CheckIfFirstCalc("/");

        }

        private void CheckIfFirstCalc(string operationMethod)
        {
            switch (operationMethod)
            {

                case "+":
                    if (secondOrMoreCalc == true)
                    {
                        double num2 = double.Parse(displayNumberBox.Text);

                        switch (option)
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
                                result = num1 / num2;
                                break;
                            default:
                                break;
                        }

                        num1 = result;
                        displayNumberBox.Clear();
                        option = "+";
                    }
                    else
                    {
                        option = "+";
                        num1 = double.Parse(displayNumberBox.Text);
                        displayNumberBox.Clear();
                        secondOrMoreCalc = true;
                    }
                    break;
                case "-":
                    if (secondOrMoreCalc == true)
                    {
                        double num2 = double.Parse(displayNumberBox.Text);

                        switch (option)
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
                                result = num1 / num2;
                                break;
                            default:
                                break;
                        }

                        num1 = result;
                        displayNumberBox.Clear();
                        option = "-";
                    }
                    else
                    {
                        option = "-";
                        num1 = double.Parse(displayNumberBox.Text);
                        displayNumberBox.Clear();
                        secondOrMoreCalc = true;
                    }
                    break;
                case "*":
                    if (secondOrMoreCalc == true)
                    {
                        double num2 = double.Parse(displayNumberBox.Text);

                        switch (option)
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
                                result = num1 / num2;
                                break;
                            default:
                                break;
                        }

                        num1 = result;
                        displayNumberBox.Clear();
                        option = "*";

                    }
                    else
                    {
                        option = "*";
                        num1 = double.Parse(displayNumberBox.Text);
                        displayNumberBox.Clear();
                        secondOrMoreCalc = true;
                    }
                    break;
                case "/":
                    if (secondOrMoreCalc == true)
                    {
                        double num2 = double.Parse(displayNumberBox.Text);

                        switch (option)
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
                                result = num1 / num2;
                                break;
                            default:
                                break;
                        }

                        num1 = result;
                        displayNumberBox.Clear();
                        option = "/";

                    }
                    else
                    {
                        option = "/";
                        num1 = double.Parse(displayNumberBox.Text);
                        displayNumberBox.Clear();
                        secondOrMoreCalc = true;
                    }
                    break;

                default:
                    break;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(displayNumberBox.Text))
            {
                return;
            }
            CheckIfFirstCalc("-");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            displayNumberBox.Clear();
            option = String.Empty;
        }

    }
}