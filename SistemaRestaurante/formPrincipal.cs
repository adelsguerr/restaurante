using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

   

        private void tsrMenu_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(ventanas.ventanaMenu))
                {
                    bandera = false;
                }
            }

            if (bandera == true)
            {
                ventanas.ventanaMenu vMenu = new ventanas.ventanaMenu();
                vMenu.MdiParent = this;
                vMenu.Show();
            }
        }

        

        private void tsrTable_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(Orden))
                {
                    bandera = false;
                }
            }

            if (bandera == true)
            {
                Orden ventanaOrden = new Orden(this);
                ventanaOrden.MdiParent = this;
                ventanaOrden.Show();
            }
        }

      

        

        private void tsrExit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                DialogResult respuesta = MessageBox.Show("¿Quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (respuesta == DialogResult.No)
                { }
            }
            else
            {
                MessageBox.Show("Hay ventanas abiertas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
