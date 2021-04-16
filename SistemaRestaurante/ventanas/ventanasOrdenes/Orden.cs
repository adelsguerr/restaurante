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
    public partial class Orden : Form
    {
        formPrincipal ventanaPrincipal;

        Clases.claseManejoArchivo archivoMesas = new Clases.claseManejoArchivo();
        public Orden(formPrincipal f)
        {
            InitializeComponent();
            ventanaPrincipal = f;
        }

        private void Orden_Load(object sender, EventArgs e)
        {
            
            Bitmap imagenMesa;
            imagenMesa = new Bitmap(Proyecto_Final_Periodo3.Properties.Resources.Table);
            

            Clases.claseMesa mesa = archivoMesas.cargarMesa();
            if (mesa != null)
            {
                decimal cantidad = mesa.CantidadMesas;
                for (int j = 1; j <= cantidad; j++)
                {

                    var boton = new Button
                    {
                        Name = "btnMesa" + j,
                        Text = Convert.ToString(j),
                        Image = imagenMesa,
                        TextAlign = ContentAlignment.MiddleRight,
                        ImageAlign = ContentAlignment.MiddleLeft,
                        Size = new Size(75, 50),
                        Font = new Font("Microsoft Sans Serif",12,FontStyle.Bold),
                        
                    };

                    boton.Click += new EventHandler(estado);
                    flpMesas.Controls.Add(boton);
                }
            }

            colorear();
        }


        public void estado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Bitmap imagenMesa;
            imagenMesa = new Bitmap(Proyecto_Final_Periodo3.Properties.Resources.OccupiedTable);
            boton.Image = imagenMesa;

            bool bandera = true;
            foreach (Form formulario in Application.OpenForms)
            {
                
                if (formulario.Text == ("Mesa " + boton.Text))
                {
                    bandera = false;
                    
                }
            }

            if (bandera == true)
            {
                ventanas.ventanasOrdenes.ventanaOrden ventanaOrden = new ventanas.ventanasOrdenes.ventanaOrden(Convert.ToInt32(boton.Text),this);
                ventanaOrden.MdiParent = ventanaPrincipal;
                ventanaOrden.Text = "Mesa " + boton.Text;
                ventanaOrden.Show();
                
            }

        }


         public void colorear()
        {
            foreach (Button c in this.flpMesas.Controls)
            {
                List<Clases.claseOrden> listaOrden = new List<Clases.claseOrden>();

                if (c is Button)
                {
                    listaOrden = archivoMesas.cargarOrden(Convert.ToInt32(c.Text));
                    if (listaOrden.Count == 0)
                    {
                        c.Image = new Bitmap(Proyecto_Final_Periodo3.Properties.Resources.Table);
                    }
                    else
                    {
                        c.Image = new Bitmap(Proyecto_Final_Periodo3.Properties.Resources.OccupiedTable);
                    }

                }
            }
        }

        private void flpMesas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
