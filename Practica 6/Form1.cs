namespace Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float baseTri = float.Parse(textBox1.Text);
            float alturaTri = float.Parse(textBox2.Text);
            float area = baseTri * alturaTri / 2;
            textBox3.Text = area.ToString("0.##");
        }
    }
}
