namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio, altura;
            double baseArea, lateralArea, totalArea, volumen;

            // Obtener valores de los TextBox
            radio = double.Parse(textBox1.Text);
            altura = double.Parse(textBox2.Text);

            // Cálculos
            baseArea = radio * radio * Math.PI;
            lateralArea = 2 * Math.PI * radio * altura;
            totalArea = 2 * Math.PI * radio * (altura + radio);
            volumen = Math.PI * radio * radio * altura;

            // Mostrar resultados
            textBox3.Text = baseArea.ToString("0.##");
            textBox4.Text = lateralArea.ToString("0.##");
            textBox5.Text = totalArea.ToString("0.##");
            textBox6.Text = volumen.ToString("0.##");
        }
    }
}
