namespace ejercicio61form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNresultado_Click(object sender, EventArgs e)
        {

            double X, Binario;
            int N = int.Parse(textbi.Text);
            Binario = 0;
            X = 1;
            while (N >= 1)
            {
                if (N % 2 == 1)
                {
                    Binario = Binario + X;

                }
                N = Math.Truncate(double)(N / 2);
                X = X * 10;
                MessageBox.Show($"el numero {N} convertido a binario es {Binario}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
                Limpieza();
            }

        }
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿desea salir del formulario?", "pregunta",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;

            }
        }
            private void Limpieza()
            {
            textbi.Clear();
            }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }
    }
}