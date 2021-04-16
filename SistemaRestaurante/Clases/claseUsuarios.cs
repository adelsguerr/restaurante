using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Periodo3.Clases
{
    [Serializable]
    public class claseUsuarios
    {
        private string nombre;
        private string telefono;
        private string direccion;
        private string correo;
        private string puesto;
        private bool administrador;
        private string password;

        public claseUsuarios()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public string Password { get => password; set => password = value; }
    }
}
