namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double resultado;
            n1 = Convert.ToDouble(txtnumero1.Text);
            n2 = Convert.ToDouble(txtnumero2.Text);
            resultado = (n1 + n2);
            MessageBox.Show(Convert.ToString(resultado));
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double resultado;
            n1 = Convert.ToDouble(txtnumero1.Text);
            n2 = Convert.ToDouble(txtnumero2.Text);
            resultado = (n1 - n2);
            MessageBox.Show(Convert.ToString(resultado));
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double resultado;
            n1 = Convert.ToDouble(txtnumero1.Text);
            n2 = Convert.ToDouble(txtnumero2.Text);
            resultado = (n1 * n2);
            MessageBox.Show(Convert.ToString(resultado));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double resultado;
            n1 = Convert.ToDouble(txtnumero1.Text);
            n2 = Convert.ToDouble(txtnumero2.Text);
            resultado = (n1 / n2);
            MessageBox.Show(Convert.ToString(resultado));
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double resultado;
            n1 = Convert.ToDouble(txtnumero1.Text);
            n2 = Convert.ToDouble(txtnumero2.Text);
            resultado = (n1 * n2) / 100;
            MessageBox.Show(Convert.ToString(resultado));
        }

        private void txtnumero1_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtnumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=44)
            {
                e.Handled = true;
            }
        }

        private void txtnumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=44)
            {
                e.Handled = true;
            }
        }
    }
}
