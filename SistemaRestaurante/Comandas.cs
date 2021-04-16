using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Periodo3
{
    class Comandas
    {
        private int numMesa;
        private string nombreMesero;
        private DateTime fechaHora;
        private string pedido;
        private int cantidad;
        private int totalPago;

        public int NumMesa { get => numMesa; set => numMesa = value; }
        public string NombreMesero { get => nombreMesero; set => nombreMesero = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public string Pedido { get => pedido; set => pedido = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int TotalPago { get => totalPago; set => totalPago = value; }
    }
}
