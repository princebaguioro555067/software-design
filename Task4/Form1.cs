namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 10, 29, 39, 100, 58, 26 };
            int[] sortedNumbers = ProceduralSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
}
