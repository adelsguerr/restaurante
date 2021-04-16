using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas.ventanasUsuario
{
    public partial class agregarUsuario : Form
    {
        ventanasUsuario.ventanaUsuario ventanaUsuarios = new ventanaUsuario();
        private Clases.claseUsuarios objetoUsuarios = new Clases.claseUsuarios();
        public agregarUsuario(ventanas.ventanasUsuario.ventanaUsuario vUsuarios)
        {

            InitializeComponent();
            ventanaUsuarios = vUsuarios;
        }

        private void agregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validación de campos vacíos
            try
            {
                if (txtNombre.Text == "" || txtDireccion.Text == "" || txtCorreo.Text=="" ||cmbPuesto.Text == "" || txtPassword1.Text == "")
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

                            ventanaUsuarios.actualizarGuardado(objetoUsuarios);

                            foreach (Control controles in this.Controls)
                            {
                                if (controles is TextBox) controles.Text = "";
                            }

                            chkAdministrador.Checked = false;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargar(string nombre, string telefono, string direccion,string correo, string puesto, bool administrador, string password)
        {


        }
        //validacion del correo en agg usuario
        public static bool validacion(string email)
        {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);

        }


        //private void Verificacion_Click(object sender, EventArgs e)
        //{
        //    if (validacion(TxtCorrero.Text))
        //    {
        //        MessageBox.Show("Correo Valido", "Su Correo es valido");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Correo Invalido", "Use el siguiente Formato: Nombre@dominio.com");
        //    }
        //}
    }
}
