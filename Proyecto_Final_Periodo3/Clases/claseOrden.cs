using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Periodo3.Clases
{
    [Serializable]
    class claseOrden
    {
        

        private string nombre;
        private int cantidad;
        private decimal precio;
        private decimal subtotal;


        public claseOrden()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        
    }
}
