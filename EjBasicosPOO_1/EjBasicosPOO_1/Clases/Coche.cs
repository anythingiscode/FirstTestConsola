using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBasicosPOO_1.Clases
{
    internal class Coche : Vehiculo     //Así se indica la herencia (padre => Vehiculo)
    {
        /*Haremos que si el coche tiene airbag su precio es el precio del vehiculo  + 200 
         Para ello hay que ir a la clase padre ("Vehiculo") y escribir "virtual" en la declaración
         de la variable (get, set) de precio*/

        #region VARIABLES PRIVADAS

        private bool _airBag;

        #endregion

        #region VARIABLES PÚBLICAS

        public bool AirBag { get => _airBag; set => _airBag = value; }

        #endregion

        #region CONSTRUCTOR

        //Generamos el constructor coche que ya se encorga de llamar al constructor vehiculo 
        public Coche(int id, string marca, string modelo, int km, double precio, bool AirBag) : base(id, marca, modelo, km, precio)
        {
            _airBag = AirBag;
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
                if (AirBag)
                {
                    return base.Precio + 200;                   //Aqui cambiamos el precio si tiene AirBag
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
            if (AirBag)
            {
                return base.ToString() + "> Tiene AirBag";
            }
            else
            {
                return base.ToString() + "> No tiene AirBag";
            }
        }

        #endregion

    }
}
