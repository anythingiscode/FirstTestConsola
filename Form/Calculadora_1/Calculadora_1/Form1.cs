using System.Linq.Expressions;
using System.Reflection;

namespace Calculadora_1
{
    public partial class FormCalculadora : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public FormCalculadora()
        {
            InitializeComponent();
        }

        //Llamada cada vez que se pulse una tecla de un número
        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text=="0")
                txtResultado.Text="";

            txtResultado.Text += boton.Text;
        }

        // Boton " = "
        private void btnIgual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);

            //if(Operador=='+') txtResultado.Text = (Numero1+Numero2).ToString(); 
            switch(Operador)
            {
                case '+':
                    txtResultado.Text = (Numero1 + Numero2).ToString();
                    Numero1 = Convert.ToDouble(txtResultado.Text);              //Guardo el resultado en Numero1 para que asi si seguimos haciendo operaciones se pueden concatenar
                    break;    
                case '-':
                    txtResultado.Text = (Numero1 - Numero2).ToString();
                    Numero1 = Convert.ToDouble(txtResultado.Text);
                    break;
                case '/':
                    if (Numero2 == 0) txtResultado.Text = "Error : DIV / 0";
                    else
                    {
                        txtResultado.Text = (Numero1 / Numero2).ToString();
                        Numero1 = Convert.ToDouble(txtResultado.Text);
                    }
                    break;
                case 'X':
                    txtResultado.Text = (Numero1 * Numero2).ToString();
                    Numero1 = Convert.ToDouble(txtResultado.Text);
                    break;
            }    

                

        }
        //Borrado del caracter de la drcha
        private void btnDel_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length-1);
                //txtResultado = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);  --> Otra solución posible
                  
            } else
            {
                txtResultado.Text = "0";
            }
        }

        //Borrado de TODO
        private void btnC_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';        // '\0'  => caracter vacío
            txtResultado.Text = "0";
        }

        //Borrado de lo que se haya escrito en el momento
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        //Poner la coma
        private void btnComa_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
                
        }

        private void BtnSigno_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(-1 * Convert.ToDouble(txtResultado.Text));
        }

        // Botones de operaciones
        private void ClickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);  // sender es el objeto que tiene el focus. se tiene que poner todo entre parentesis para poder acceder a los atributos del objeto "button"

            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);


            // Se tratan los operadores raiz y potencia a parte porque estas operaciones se realizan sin esperar un segundo operador (var Numero2)
            switch (Operador)
            {
                case '²':
                    Numero1 = Math.Pow(Numero1, 2);              //Guardo el resultado en Numero1 para que asi si seguimos haciendo operaciones se pueden concatenar
                    txtResultado.Text = Numero1.ToString();
                    break;
                case '√':
                    Numero1 = Math.Sqrt(Numero1);              //Guardo el resultado en Numero1 para que asi si seguimos haciendo operaciones se pueden concatenar
                    txtResultado.Text = Numero1.ToString();
                    break;
                default:
                    txtResultado.Text = "0";
                    break;
            }
        }
    }
}