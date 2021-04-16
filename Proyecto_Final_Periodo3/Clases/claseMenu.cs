using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Periodo3.Clases
{
    [Serializable]
    public class claseMenu
    {
        private string nombre;
        private string tipo;
        private string precio;


        public claseMenu()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Precio { get => precio; set => precio = value; }
    }
}
