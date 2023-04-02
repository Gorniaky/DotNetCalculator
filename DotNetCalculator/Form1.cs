using System.Globalization;

namespace DotNetCalculator
{
    public partial class Calculator : Form
    {
        decimal VALUE = 0, VALUE2 = 0;
        char? OPERATOR;
        readonly Dictionary<string, string> NUMBER_KEYS = new Dictionary<string, string>();
        readonly Dictionary<string, char> OPERATOR_KEYS = new Dictionary<string, char>();
        readonly Dictionary<string, string> DECIMAL_KEYS = new Dictionary<string, string>();

        public Calculator()
        {
            InitializeComponent();

            NUMBER_KEYS.Add("D0", "0");
            NUMBER_KEYS.Add("D1", "1");
            NUMBER_KEYS.Add("D2", "2");
            NUMBER_KEYS.Add("D3", "3");
            NUMBER_KEYS.Add("D4", "4");
            NUMBER_KEYS.Add("D5", "5");
            NUMBER_KEYS.Add("D6", "6");
            NUMBER_KEYS.Add("D7", "7");
            NUMBER_KEYS.Add("D8", "8");
            NUMBER_KEYS.Add("D9", "9");

            NUMBER_KEYS.Add("NumPad0", "0");
            NUMBER_KEYS.Add("NumPad1", "1");
            NUMBER_KEYS.Add("NumPad2", "2");
            NUMBER_KEYS.Add("NumPad3", "3");
            NUMBER_KEYS.Add("NumPad4", "4");
            NUMBER_KEYS.Add("NumPad5", "5");
            NUMBER_KEYS.Add("NumPad6", "6");
            NUMBER_KEYS.Add("NumPad7", "7");
            NUMBER_KEYS.Add("NumPad8", "8");
            NUMBER_KEYS.Add("NumPad9", "9");

            OPERATOR_KEYS.Add("Multiply", '*');
            OPERATOR_KEYS.Add("Add", '+');
            OPERATOR_KEYS.Add("Subtract", '-');
            OPERATOR_KEYS.Add("Divide", '/');

            OPERATOR_KEYS.Add("D8, Shift", '*');
            OPERATOR_KEYS.Add("Oemplus, Shift", '+');
            OPERATOR_KEYS.Add("OemMinus", '-');
            OPERATOR_KEYS.Add("LButton, Oemtilde", '/');

            DECIMAL_KEYS.Add("Decimal", ".");
            DECIMAL_KEYS.Add("Oemcomma", ".");
            DECIMAL_KEYS.Add("RButton, Oemtilde", ".");
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            VALUE = 0;
            VALUE2 = 0;
            OPERATOR = null;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 1)
            {
                textBox1.Text = "0";
                return;
            }

            textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            VALUE = Convert.ToDecimal(textBox1.Text, CultureInfo.InvariantCulture);
        }

        private void ButtonNumberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += button.Text;

            VALUE = Convert.ToDecimal(textBox1.Text, CultureInfo.InvariantCulture);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            decimal NEW_VALUE = VALUE;

            if (OPERATOR.HasValue)
            {
                NEW_VALUE = Calculate();
                textBox1.Text = Convert.ToString(NEW_VALUE);
            }

            textBox2.Text = textBox1.Text + " +";
            textBox1.Text = "0";
            VALUE2 = NEW_VALUE;
            VALUE = 0;
            OPERATOR = '+';
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            decimal NEW_VALUE = VALUE;

            if (OPERATOR.HasValue)
            {
                NEW_VALUE = Calculate();
                textBox1.Text = Convert.ToString(NEW_VALUE);
            }

            textBox2.Text = textBox1.Text + " -";
            textBox1.Text = "0";
            VALUE2 = NEW_VALUE;
            VALUE = 0;
            OPERATOR = '-';
        }

        private void ButtonMul_Click(object sender, EventArgs e)
        {
            decimal NEW_VALUE = VALUE;

            if (OPERATOR.HasValue)
            {
                NEW_VALUE = Calculate();
                textBox1.Text = Convert.ToString(NEW_VALUE);
            }

            textBox2.Text = textBox1.Text + " *";
            textBox1.Text = "0";
            VALUE2 = NEW_VALUE;
            VALUE = 0;
            OPERATOR = '*';
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            decimal NEW_VALUE = VALUE;

            if (OPERATOR.HasValue)
            {
                NEW_VALUE = Calculate();
                textBox1.Text = Convert.ToString(NEW_VALUE);
            }

            textBox2.Text = textBox1.Text + " /";
            textBox1.Text = "0";
            VALUE2 = NEW_VALUE;
            VALUE = 0;
            OPERATOR = '/';
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            if (!OPERATOR.HasValue)
            {
                return;
            }

            decimal NEW_VALUE = Calculate();

            textBox1.Text = Convert.ToString(NEW_VALUE);
            textBox2.Text = "";
            VALUE = NEW_VALUE;
            VALUE2 = 0;
            OPERATOR = null;
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(".") > -1)
            {
                return;
            }

            textBox1.Text += ".";
        }

        private decimal Calculate()
        {
            decimal NEW_VALUE = VALUE;

            switch (OPERATOR)
            {
                case '+':
                    NEW_VALUE = VALUE2 + VALUE;
                    break;

                case '-':
                    NEW_VALUE = VALUE2 - VALUE;
                    break;

                case '/':
                    NEW_VALUE = VALUE2 / VALUE;
                    break;

                case '*':
                    NEW_VALUE = VALUE2 * VALUE;
                    break;
            }

            return NEW_VALUE;
        }

        private void KeyDownListener(object sender, KeyEventArgs e)
        {
            if (NUMBER_KEYS.ContainsKey(e.KeyData.ToString()))
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "";
                }

                textBox1.Text += NUMBER_KEYS[e.KeyData.ToString()];

                VALUE = Convert.ToDecimal(textBox1.Text, CultureInfo.InvariantCulture);
            }

            if (OPERATOR_KEYS.ContainsKey(e.KeyData.ToString()))
            {
                decimal NEW_VALUE = VALUE;

                if (OPERATOR.HasValue)
                {
                    NEW_VALUE = Calculate();
                    textBox1.Text = Convert.ToString(NEW_VALUE);
                }

                textBox1.Text = "0";
                VALUE2 = NEW_VALUE;
                VALUE = 0;

                switch (OPERATOR_KEYS[e.KeyData.ToString()])
                {
                    case '+':
                        textBox2.Text = textBox1.Text + " +";
                        OPERATOR = '+';
                        break;

                    case '-':
                        textBox2.Text = textBox1.Text + " -";
                        OPERATOR = '-';
                        break;

                    case '/':
                        textBox2.Text = textBox1.Text + " /";
                        OPERATOR = '/';
                        break;

                    case '*':
                        textBox2.Text = textBox1.Text + " *";
                        OPERATOR = '*';
                        break;
                }
            }

            if (DECIMAL_KEYS.ContainsKey(e.KeyData.ToString()))
            {
                if (textBox1.Text.IndexOf(".") > -1)
                {
                    return;
                }

                textBox1.Text += ".";
            }

            if (e.KeyData.ToString() == "Back")
            {
                if (textBox1.TextLength == 1)
                {
                    textBox1.Text = "0";
                    return;
                }

                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
                VALUE = Convert.ToDecimal(textBox1.Text, CultureInfo.InvariantCulture);
            }

            if (e.KeyData.ToString() == "Return")
            {
                if (!OPERATOR.HasValue)
                {
                    return;
                }

                decimal NEW_VALUE = Calculate();

                textBox1.Text = Convert.ToString(NEW_VALUE);
                textBox2.Text = "";
                VALUE = NEW_VALUE;
                VALUE2 = 0;
                OPERATOR = null;
            }
        }
    }
}