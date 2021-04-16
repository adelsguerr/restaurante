using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Periodo3.Clases
{
    [Serializable]
    class claseMesa
    {
        private decimal cantidadMesas;
        private decimal propina;

        public claseMesa(decimal cantidadMesas, decimal propina)
        {
            this.cantidadMesas = cantidadMesas;
            this.propina = propina;
        }

        public claseMesa()
        {

        }

        public decimal CantidadMesas { get => cantidadMesas; set => cantidadMesas = value; }
        public decimal Propina { get => propina; set => propina = value; }
    }
}
