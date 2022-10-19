using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBasicosPOO_1.Clases
{
    internal class Moto : Vehiculo
    {
        /*Haremos que si el coche tiene airbag su precio es el precio del vehiculo  + 50 
         Para ello hay que ir a la clase padre ("Vehiculo") y escribir "virtual" en la declaración
         de la variable (get, set) de precio*/

        #region VARIABLES PRIVADAS

        private bool _sidecar;

        #endregion

        #region VARIABLES PÚBLICAS

        public bool Sidecar { get => _sidecar; set => _sidecar = value; }

        #endregion

        #region CONSTRUCTOR

        //Generamos el constructor coche que ya se encorga de llamar al constructor vehiculo 
        public Moto(int id, string marca, string modelo, int km, double precio, bool Sidecar) : base(id, marca, modelo, km, precio)
        {
            _sidecar = Sidecar;
        }

        #endregion

        #region MÉTODOS PRIVADOS

        #endregion

        #region MÉTODOS PÚBLICOS

        //public override double Precio { get => base.Precio; set => base.Precio = value; }

        public override double Precio
        {
            get
            {
                if (Sidecar)
                {
                    return base.Precio + 50;            //Aqui cambia el precio si tiene Sidecar
                }
                else
                {
                    return base.Precio;
                }
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            if (Sidecar)
            {
                return base.ToString() + "> Tiene Sidecar";
            }
            else
            {
                return base.ToString() + "> NO tiene Sidecar";
            }
        }
    }
}
        #endregion