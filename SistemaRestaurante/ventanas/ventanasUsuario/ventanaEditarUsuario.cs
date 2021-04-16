using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas.ventanasUsuario
{
    public partial class ventanaEditarUsuario : Form
    {
        private ventanas.ventanasUsuario.ventanaUsuario ventanaUsuario;
        private Clases.claseUsuarios objetoUsuarios = new Clases.claseUsuarios();
        public ventanaEditarUsuario(ventanaUsuario vUser, Clases.claseUsuarios user)
        {
            InitializeComponent();
            ventanaUsuario = vUser;
            txtNombre.Text = user.Nombre;
            txtTelefono.Text = user.Telefono;
            txtDireccion.Text = user.Direccion;
            txtCorreo.Text = user.Correo;
            cmbPuesto.Text = user.Puesto;
            chkAdministrador.Checked = user.Administrador;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtDireccion.Text == "" || txtCorreo.Text == "" || cmbPuesto.Text == "" || txtPassword1.Text == "")
                {
                    MessageBox.Show("Los datos no están completos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtPassword1.Text != txtPassword2.Text)
                    {
                        MessageBox.Show("La contraseña no coincide.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!validacion(txtCorreo.Text))
                        {
                            MessageBox.Show("Correo Invalido", "Use el siguiente Formato: Nombre@dominio.com");
                        }
                        else
                        {
                            objetoUsuarios.Nombre = txtNombre.Text;
                            objetoUsuarios.Telefono = txtTelefono.Text;
                            objetoUsuarios.Direccion = txtDireccion.Text;
                            objetoUsuarios.Correo = txtCorreo.Text;
                            objetoUsuarios.Puesto = cmbPuesto.Text;
                            objetoUsuarios.Administrador = chkAdministrador.Checked;
                            objetoUsuarios.Password = txtPassword1.Text;

                            ventanaUsuario.actualizarEdicion(objetoUsuarios);

                            this.Close();



                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static bool validacion(string email)
        {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
