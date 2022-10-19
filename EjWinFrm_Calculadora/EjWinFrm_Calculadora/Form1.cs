using Microsoft.VisualBasic;

namespace EjWinFrm_Calculadora
{
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            decimal resultado = nudOp1.Value + nudOp2.Value;

            txtResultado.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            decimal resultado = nudOp1.Value - nudOp2.Value;

            txtResultado.Text = resultado.ToString();

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            decimal resultado = nudOp1.Value * nudOp2.Value;

            txtResultado.Text = resultado.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (nudOp2.Value == 0)
            {
                MessageBox.Show("Error DIV por 0");
            }
            else
            {
                decimal resultado = nudOp1.Value / nudOp2.Value;

                txtResultado.Text = resultado.ToString();
            }
            
        }
    }
}