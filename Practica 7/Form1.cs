namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor, fahrenheit;
            valor = double.Parse(textBox1.Text);
            fahrenheit = valor * (9.0 / 5.0) + 32;
            textBox2.Text = fahrenheit.ToString("0.##");
            label3.Text = "Grados Fahrenheit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor, celsius;
            valor = double.Parse(textBox1.Text);
            celsius = (valor - 32) * (5.0 / 9.0);
            textBox2.Text = celsius.ToString("0.##");
            label3.Text = "Grados Celsius";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "Equivalente en grados";
        }
    }
}
