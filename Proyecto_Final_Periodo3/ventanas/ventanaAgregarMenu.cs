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
    public partial class ventanaAgregarMenu : Form
    {
        private ventanas.ventanaMenu ventanaMenu;
        private Clases.claseMenu objetoMenu = new Clases.claseMenu();
        public ventanaAgregarMenu(ventanas.ventanaMenu ventana)
        {
            ventanaMenu = ventana;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtPrecio.Text == "" || txtNombre.Text == "" || cmbTipo.Text == "")
            {
                MessageBox.Show("Los datos no están completos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                    objetoMenu.Nombre = txtNombre.Text;
                    objetoMenu.Tipo = cmbTipo.Text;
                    objetoMenu.Precio = txtPrecio.Text;
                
                    ventanaMenu.actualizarGuardado(objetoMenu);  

                    txtNombre.Text = "";
                    txtPrecio.Text = "";
                    cmbTipo.SelectedIndex = -1;
            }
   
        }
              private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
