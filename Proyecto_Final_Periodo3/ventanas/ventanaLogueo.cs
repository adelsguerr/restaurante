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
    public partial class ventanaLogueo : Form
    {
        private Clases.claseManejoArchivo archivoUsuario = new Clases.claseManejoArchivo();
        private List<Clases.claseUsuarios> users = new List<Clases.claseUsuarios>();
        private string[] password;
        private bool[] administrador;
        private formPrincipal formulario1;
        
        public ventanaLogueo(formPrincipal f)
        {
            InitializeComponent();
            formulario1 = f;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ventanaLogueo_Load(object sender, EventArgs e)
        {
            users = archivoUsuario.cargarUsuarios();
            password = new string[users.Count];
            administrador = new bool[users.Count];

            foreach(Clases.claseUsuarios user in users)
            {
                cmbUsuario.Items.Add(user.Nombre);
                password[cmbUsuario.Items.Count - 1] = user.Password;
                administrador[cmbUsuario.Items.Count - 1] = user.Administrador;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int index = cmbUsuario.SelectedIndex;            
            try
            {
                if (txtPassword.Text == password[index])
                {
                    formulario1.Enabled = true;
                    formulario1.botonesAdministrador(administrador[index]);

                    this.Close();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("No ha ingresado la contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No ha seleccionado un usuario", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
