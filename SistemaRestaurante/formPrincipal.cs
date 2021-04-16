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

        private void Home_Load(object sender, EventArgs e)
        {
            ventanas.ventanaLogueo logueo = new ventanas.ventanaLogueo(this);
            this.Enabled = false;
            logueo.ShowDialog();
            this.IsMdiContainer = true;
        }

        private void tsrAdmin_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(Configuracion))
                {
                    bandera = false;
                }
            }

            if (bandera == true)
            {
                Configuracion config = new Configuracion();
                config.MdiParent = this;
                config.Show();
            }
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

        private void tsrUser_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(ventanas.ventanasUsuario.ventanaUsuario))
                {
                    bandera = false;
                }
            }

            if (bandera == true)
            {
                ventanas.ventanasUsuario.ventanaUsuario ventanaUsuario = new ventanas.ventanasUsuario.ventanaUsuario();
                ventanaUsuario.MdiParent = this;
                ventanaUsuario.Show();
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

        internal void botonesAdministrador(bool admin)
        {
            if (!admin)
            {
                btnMenu.Visible = false;
                btnUsuario.Visible = false;
                btnAdmin.Visible = false;
            }
            else
            {
                btnMenu.Visible = true;
                btnUsuario.Visible = true;
                btnAdmin.Visible = true;
            }
        }

        private void tsrChangeUser_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                DialogResult respuesta = MessageBox.Show("¿Quiere cambiar de usuario?", "Cambiar de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    ventanas.ventanaLogueo logueo = new ventanas.ventanaLogueo(this);
                    this.Enabled = false;
                    logueo.ShowDialog();
                    this.IsMdiContainer = true;
                }
                else if (respuesta == DialogResult.No)
                { }
            }
            else
            {
                MessageBox.Show("Hay ventanas abiertas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
