namespace Expression
{
    public partial class Form1 : Form
    {
        Queue<string> opz = new Queue<string>();
        Stack<double> calc_opz = new Stack<double>();

        Dictionary<char, int> priority = new Dictionary<char, int>
        {
            { '+', 1 },
            { '-', 1 },
            { '*', 2 },
            { '/', 2 },
            { '(', 0 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = tbExpression.Text;
            GetExpession(input);
            lResult.Text = String.Join(" ", opz.ToArray())+"\r\n";
            lResult.Text += ""+CalcExpression();
        }

        private double CalcExpression()
        {
            foreach(string element in opz)
            {
                switch (element)
                {
                    case "+":calc_opz.Push(calc_opz.Pop() + calc_opz.Pop());break;
                    case "-":calc_opz.Push(-calc_opz.Pop() + calc_opz.Pop()); break;
                    case "*":calc_opz.Push(calc_opz.Pop() * calc_opz.Pop()); break;
                    case "/":
                        double b = calc_opz.Pop(),
                            a = calc_opz.Pop();
                        calc_opz.Push(a/b); break;
                    default: calc_opz.Push(double.Parse(element));break;
                }
            }
            return calc_opz.Pop();
        }

        private void GetExpession(string input)
        {
            Stack<char> operations = new Stack<char>();
            string number = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    number = String.Empty;
                    while (Char.IsDigit(input[i]))
                    {
                        number += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    opz.Enqueue(number);
                    if (i == input.Length) break;
                }
                if ("+-*/()".Contains(input[i]))
                {
                    if (input[i] == ')')
                    {
                        while (operations.Peek() != '(')
                        {
                            opz.Enqueue("" + operations.Pop());
                        }
                        operations.Pop();
                    }
                    else
                    {
                        if (input[i] != '(' && operations.Count > 0 &&
                            priority[operations.Peek()] >= priority[input[i]])
                        {
                            opz.Enqueue("" + operations.Pop());
                        }
                        operations.Push(input[i]);
                    }
                }
            }
            while (operations.Count > 0) opz.Enqueue("" + operations.Pop());
        }
    }
}