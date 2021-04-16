using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto_Final_Periodo3
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            bool ventanaAbierta = true;
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(Orden))
                {
                    ventanaAbierta = false;
                }
            }

            if (ventanaAbierta == true)
            {
                bool bandera = true;
                if (nudNumberTable.Value <= 0)
                {
                    bandera = false;
                }
                if (nudTip.Value < 0)
                {
                    bandera = false;
                    errConfig.SetError(nudTip, "Ingrese un número mayor a 5");
                }
                else
                    errConfig.SetError(nudTip, null);



                if (bandera)
                {
                    decimal propina = nudTip.Value, cantidad = nudNumberTable.Value;
                    Clases.claseMesa mesa = new Clases.claseMesa(cantidad,propina);
                    if (GuardarConfig(mesa))
                    {
                        MessageBox.Show("Se ha actualizado la configuración");
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido guardar la configuración");
                    }
                }
            }
            else
            {
                MessageBox.Show("Cierra la venta de ordenes para actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

         
        }

        private bool GuardarConfig(Clases.claseMesa mesa)
        {
            try
            {
                File.Delete("configuracion.dat");
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream("configuracion.dat", FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, mesa);
                fs.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        private void Configuración_Load(object sender, EventArgs e)
        {
            Clases.claseManejoArchivo archivoMesas = new Clases.claseManejoArchivo();
            Clases.claseMesa mesas = archivoMesas.cargarMesa();
            if (nudNumberTable.Value < 1)
            {
                nudNumberTable.Value = 1;
            }
            else
            {
                nudNumberTable.Value = mesas.CantidadMesas;
                nudTip.Value = mesas.Propina;
            }


            
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
