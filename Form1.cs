namespace CalculadoraWinApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            double result = num1 + num2;
            MessageBox.Show($"O Resultado dessa Soma �: {result}");
           
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            double result = num1 - num2;
            MessageBox.Show($"O Resultado dessa Subtra��o �: {result}");
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            double result = num1 * num2;
            MessageBox.Show($"O Resultado dessa Multiplica��o �: {result}" );
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("N�o � poss�vel dividir por zero!");
            }
            else
            {

                double result = num1 / num2;
                MessageBox.Show($"O Resultado dessa Divis�o �: {result} ");
                
            }
        }
    }
}