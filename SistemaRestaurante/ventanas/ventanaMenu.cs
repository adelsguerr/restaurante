using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_Periodo3.Clases;

namespace Proyecto_Final_Periodo3.ventanas
{
    public partial class ventanaMenu : Form
    {
        claseManejoArchivo archivoMenu = new claseManejoArchivo();
        List<claseMenu> listaMenu = new List<claseMenu>();

        internal List<claseMenu> ListaMenu { get => listaMenu; set => listaMenu = value; }

        public ventanaMenu()
        {
            InitializeComponent();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            ventanas.ventanaAgregarMenu ventanaAgregarMenu = new ventanaAgregarMenu(this);
            ventanaAgregarMenu.StartPosition = FormStartPosition.CenterParent;
            ventanaAgregarMenu.ShowDialog();

        }

        private void dgvMenu_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
                        
        }

        private void ventanaMenu_Load(object sender, EventArgs e)
        {
            listaMenu.Clear();
            listaMenu = archivoMenu.cargarMenu();
            dgvMenu.DataSource = listaMenu;
         }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            archivoMenu.guardarMenu(listaMenu);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvMenu.CurrentRow.Index;
            listaMenu.RemoveAt(index);
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = listaMenu;
            archivoMenu.guardarMenu(listaMenu);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            Clases.claseMenu menu = new claseMenu();
            menu.Nombre = Convert.ToString(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[0].Value);
            menu.Tipo = Convert.ToString(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[1].Value);
            menu.Precio = Convert.ToString(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[2].Value);

            ventanas.ventanaEditarMenu ventanaEditar = new ventanaEditarMenu(this, menu);
            ventanaEditar.StartPosition = FormStartPosition.CenterParent;
            ventanaEditar.ShowDialog();
                       
        }

        public void actualizarGuardado(Clases.claseMenu menu)
        {
            listaMenu.Add(menu);
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = listaMenu;
            archivoMenu.guardarMenu(listaMenu);
        }

        public void actualizarEdicion(Clases.claseMenu menu)
        {
            listaMenu.ElementAt(dgvMenu.CurrentRow.Index).Nombre = menu.Nombre;
            listaMenu.ElementAt(dgvMenu.CurrentRow.Index).Tipo = menu.Tipo;
            listaMenu.ElementAt(dgvMenu.CurrentRow.Index).Precio = menu.Precio;
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = listaMenu;
            archivoMenu.guardarMenu(listaMenu);
        }
    }
}
