namespace Practica_4
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar que todos los TextBox tengan contenido
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Por favor llena TODOS los campos de números");
                return;
            }

            // Verificar que sean números válidos
            if (!int.TryParse(textBox1.Text, out int a) ||
                !int.TryParse(textBox2.Text, out int b) ||
                !int.TryParse(textBox3.Text, out int c) ||
                !int.TryParse(textBox4.Text, out int d))
            {
                MessageBox.Show("Por favor ingresa solo números válidos");
                return;
            }

            // Mostrar resultados invertidos
            textBox5.Text = d.ToString();
            textBox6.Text = c.ToString();
            textBox7.Text = b.ToString();
            textBox8.Text = a.ToString();
        }
    }
}
