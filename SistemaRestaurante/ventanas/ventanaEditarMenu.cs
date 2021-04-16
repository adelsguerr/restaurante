using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas
{
    public partial class ventanaEditarMenu : Form
    {
        private ventanas.ventanaMenu ventanaMenu;
        private Clases.claseMenu objetoMenu = new Clases.claseMenu();
        public ventanaEditarMenu(ventanaMenu vMenu, Clases.claseMenu menu)
        {
            
            InitializeComponent();
            ventanaMenu = vMenu;
            objetoMenu = menu;
            txtNombre.Text = menu.Nombre;
            cmbTipo.Text = menu.Tipo;
            txtPrecio.Text = menu.Precio;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "" || txtNombre.Text == "" || cmbTipo.Text == "")
            {
                MessageBox.Show("Los datos no están completos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                objetoMenu.Nombre = txtNombre.Text;
                objetoMenu.Tipo = cmbTipo.Text;
                objetoMenu.Precio = txtPrecio.Text;

                ventanaMenu.actualizarEdicion(objetoMenu);

            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
