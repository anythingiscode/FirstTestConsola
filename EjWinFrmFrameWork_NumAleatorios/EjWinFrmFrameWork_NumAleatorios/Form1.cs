using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjWinFrmFrameWork_NumAleatorios
{
    public partial class frmNumAleatorios : Form
    {
        public frmNumAleatorios()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());       //Genera un código aleatorio que no se repite            

            Control[] txtBoxs = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };   //La Clase Control es el padre de los obj que ponemos en un Formulario asi que podemos crear una array de objetos formulario que quedarán identificados por el num de indice de la array

            for(int i = 0; i < 6; i++)
            {
                txtBoxs[i].Text = Convert.ToString(random.Next(1,49));
            }
        }
    }
}
