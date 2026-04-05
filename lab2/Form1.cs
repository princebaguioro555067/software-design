namespace lab2 // done
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            else return n * RecursiveFactorial(n - 1);
        }
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return 0;
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }
        public long RecursiveFibonacci(int n)
        {
            if (n <= 0)
                return 0;

            if (n == 1)
                return 1;

            else
                return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFibonacciInput.Text, out int n))
            {
                long result = RecursiveFibonacci(n);
                lblFibonacciResult.Text = $"Fibonacci number {n}: {result}";
            }
        }

        public double RecursivePower(double baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            return baseNum * RecursivePower(baseNum, exponent - 1);
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBaseInput.Text, out double baseNum) && int.TryParse(txtExponentInput.Text, out int exponent))
            {
                double result = RecursivePower(baseNum, exponent);
                lblRecursiveResult.Text = $"{baseNum} raised to the power of {exponent}: {result}";
            }
        }
    }
}
