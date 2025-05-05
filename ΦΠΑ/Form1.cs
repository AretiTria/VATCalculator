namespace ΦΠΑ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnCalculation_click(object sender, EventArgs e)
        {
            double initialPrise = double.Parse(textBox1.Text);
            
            double fpa = double.Parse(textBox2.Text);

            double finalPrice = initialPrise + (initialPrise * (fpa / 100));

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Τα πεδία δεν έχουν συμπληρωθεί!");
            }
            else
            {
               lblfinalPrice.Text = finalPrice.ToString();
            }
        }
    }
}
