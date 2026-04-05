namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] bubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 24, 21, 63, 734, 12, 342, 42 };
            int[] sortedBubble = bubbleSort(arr);
            listBoxResults.DataSource = sortedBubble;
        }

        public int[] descendSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[i] < numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
            return numbers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = { 24, 21, 63, 734, 12, 342, 42 };
            int[] sortedDescend = descendSort(arr);
            listBoxResults.DataSource = sortedDescend;

        }

        public int[] ascendSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arr = { 24, 21, 63, 734, 12, 342, 42 };
            int[] sortedascend = ascendSort(arr);
            listBoxResults.DataSource = sortedascend;

        }
    }
}
