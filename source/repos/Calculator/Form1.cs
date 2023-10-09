namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            label1_text.Text += "0";
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            label1_text.Text += "1";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            label1_text.Text += "2";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            label1_text.Text += "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            label1_text.Text += "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            label1_text.Text += "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            label1_text.Text += "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            label1_text.Text += "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            label1_text.Text += "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            label1_text.Text += "9";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            label1_text.Text += ".";
        }
        float result = 0;
        bool check = true;
        public string MathFunction()
        {
            string? number = null;
            int index;
            if (check)
            {
                index = -1;
                for (int i = 0; i < label1_text.Text.Length; i++)
                {
                    if (label1_text.Text[i] == '+' || label1_text.Text[i] == '-' || label1_text.Text[i] == '*' || label1_text.Text[i] == '/')
                    {
                        index = i;
                    }
                }
                if (index == -1)
                {
                    for (int i = 0; i < label1_text.Text.Length; i++)
                    {
                        number += label1_text.Text[i];
                    }
                }
                else
                {
                    for (int i = index + 1; i < label1_text.Text.Length; i++)
                    {

                        number += label1_text.Text[i];
                    }

                }

            }
            else
            {
                index = label1_text.Text.LastIndexOf('+');
                for (int i = index + 1; i < label1_text.Text.Length; i++)
                {

                    number += label1_text.Text[i];
                }

            }
            return number;
        }
        private void btn_divise_Click(object sender, EventArgs e)
        {
            string? number = MathFunction();
            if (result == 0) result = float.Parse(number!);
            else result /= float.Parse(number!);
            label1_text.Text += "/";
        }

        private void btn_multiple_Click(object sender, EventArgs e)
        {
            string? number = MathFunction();
            if (result == 0) result = float.Parse(number!);
            else result *= float.Parse(number!);
            label1_text.Text += "*";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            string? number = MathFunction();
            if (result == 0) result = float.Parse(number!);
            else result -= float.Parse(number!);
            label1_text.Text += "-";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            string? number = MathFunction();
            if (result == 0) result = float.Parse(number!);
            else result += float.Parse(number!);
            label1_text.Text += "+";
        }
        public int EqualFunc(ref int index)
        {



            for (int i = 0; i < label1_text.Text.Length; i++)
            {
                if (label1_text.Text[i] == '+' || label1_text.Text[i] == '-' || label1_text.Text[i] == '*' || label1_text.Text[i] == '/')
                {
                    index = i;
                }
            }
          
            return index;
        }
        private void btn_equal_Click(object sender, EventArgs e)
        {
            int index = -1; string? number = null;
            if (check)
            {
                int LastSymbolIndex = EqualFunc(ref index);
                for (int i = LastSymbolIndex + 1; i < label1_text.Text.Length; i++)
                {

                    number += label1_text.Text[i];
                }

               if(label1_text.Text[LastSymbolIndex] == '+') result += float.Parse(number!);
               else if(label1_text.Text[LastSymbolIndex] == '-') result -= float.Parse(number!);
               else if(label1_text.Text[LastSymbolIndex] == '*') result *= float.Parse(number!);
               else if(label1_text.Text[LastSymbolIndex] == '/') result /= float.Parse(number!);
               
                check = false;
            }

            label_result.Text = result.ToString();

        }

        private void btn_positive_negative_Click(object sender, EventArgs e)
        {
            if (label_result.Text != null)
            {
                result *= -1;
                label_result.Text = result.ToString();
            }
        }

        private void btn_percantage_Click(object sender, EventArgs e)
        {
            if (label_result.Text != null)
            {
                result /= 100;
                label_result.Text = result.ToString();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            label1_text.Text = " ";
            label_result.Text = "0";
            result = 0;
            check = true;
        }
    }
}