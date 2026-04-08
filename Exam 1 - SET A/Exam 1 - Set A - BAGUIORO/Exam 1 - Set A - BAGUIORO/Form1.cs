using System.Diagnostics;

namespace Exam_1___Set_A___BAGUIORO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            double price = 12.00, discount = 0;

            txtPrice.Text = price.ToString("F2");
            txtDiscount.Text = discount.ToString("F2");
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            double price = 20.25, discount = 5;

            txtPrice.Text = price.ToString("F2");
            txtDiscount.Text = discount.ToString();
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            double price = 100, discount = 7;

            txtPrice.Text = price.ToString("F2");
            txtDiscount.Text = discount.ToString();
        }

        private void btnCompute_Click_1(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtPrice.Text);
            double discount = Convert.ToDouble(txtDiscount.Text) * 0.01;
            int quantity = int.Parse(txtQuantity.Text);


            double VAT, VATable, Total;

            VAT = ((price + (price * discount)) * quantity) * 0.12;
            VATable = (quantity * (price + (price * discount))) - VAT;
            Total = (price + (price * discount)) * quantity;

            txtVATable.Text = VATable.ToString("F2");
            txtVAT.Text = VAT.ToString("F2");
            txtTotal.Text = Total.ToString("F2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = string.Empty;
            txtPrice.Text= string.Empty;
            txtDiscount.Text = string.Empty;
            txtVAT.Text = string.Empty;
            txtVATable.Text= string.Empty;
            txtTotal.Text = string.Empty;
        }
    }
}
