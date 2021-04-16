using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas.ventanasUsuario
{
    public partial class ventanaUsuario : Form
    {

        Clases.claseManejoArchivo archivoUsuarios = new Clases.claseManejoArchivo();
        List<Clases.claseUsuarios> listaUsuarios = new List<Clases.claseUsuarios>();
        public ventanaUsuario()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventanaUsuario_Load(object sender, EventArgs e)
        {
            listaUsuarios.Clear();
            listaUsuarios = archivoUsuarios.cargarUsuarios();
            dgvUsuarios.DataSource = listaUsuarios;
            dgvUsuarios.ClearSelection();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            agregarUsuario ventanaAgregar = new agregarUsuario(this);
            ventanaAgregar.StartPosition = FormStartPosition.CenterParent;
            ventanaAgregar.ShowDialog();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            archivoUsuarios.guardarUsuarios(listaUsuarios);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            Clases.claseUsuarios users = new Clases.claseUsuarios();
            users.Nombre = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value);
            users.Telefono = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[1].Value);
            users.Direccion = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[2].Value);
            users.Correo = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[3].Value);
            users.Puesto = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[4].Value);
            users.Administrador = Convert.ToBoolean(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[5].Value);
            users.Password = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[6].Value);
            ventanasUsuario.ventanaEditarUsuario ventanaEditar = new ventanaEditarUsuario(this,users);
            ventanaEditar.StartPosition = FormStartPosition.CenterParent;
            ventanaEditar.ShowDialog();

        }

        public void actualizarGuardado(Clases.claseUsuarios usuarios)
        {
            listaUsuarios.Add(usuarios);
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
            archivoUsuarios.guardarUsuarios(listaUsuarios);
        }

        public void actualizarEdicion(Clases.claseUsuarios users)
        {
            listaUsuarios.ElementAt(dgvUsuarios.CurrentRow.Index).Nombre = users.Nombre;
            listaUsuarios.ElementAt(dgvUsuarios.CurrentRow.Index).Telefono= users.Telefono;
            listaUsuarios.ElementAt(dgvUsuarios.CurrentRow.Index).Direccion = users.Direccion;
            listaUsuarios.ElementAt(dgvUsuarios.CurrentRow.Index).Correo = users.Correo;
            listaUsuarios.ElementAt(dgvUsuarios.CurrentRow.Index).Puesto = users.Puesto;
            listaUsuarios.ElementAt(dgvUsuarios.CurrentRow.Index).Administrador = users.Administrador;
            listaUsuarios.ElementAt(dgvUsuarios.CurrentRow.Index).Password = users.Password;

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
            archivoUsuarios.guardarUsuarios(listaUsuarios);

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvUsuarios.CurrentRow.Index;
            listaUsuarios.RemoveAt(index);
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
            archivoUsuarios.guardarUsuarios(listaUsuarios);
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
