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
            MessageBox.Show($"O Resultado dessa Soma é: {result}");
           
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            double result = num1 - num2;
            MessageBox.Show($"O Resultado dessa Subtração é: {result}");
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            double result = num1 * num2;
            MessageBox.Show($"O Resultado dessa Multiplicação é: {result}" );
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("Não é possível dividir por zero!");
            }
            else
            {

                double result = num1 / num2;
                MessageBox.Show($"O Resultado dessa Divisão é: {result} ");
                
            }
        }
    }
}