using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas.ventanasOrdenes
{
    public partial class ventanaOrden : Form
    {
        List<Clases.claseOrden> listaOrden = new List<Clases.claseOrden>();
        Clases.claseManejoArchivo archivoOrden = new Clases.claseManejoArchivo();
        Orden ventanaO;
        public ventanaOrden(int num,Orden v)
        {
            InitializeComponent();
            lblMesaNum.Text = Convert.ToString(num);
            ventanaO = v;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Clases.claseMenu> listaMenu = new List<Clases.claseMenu>();
            Clases.claseManejoArchivo archivoMenu = new Clases.claseManejoArchivo();

            listaMenu = archivoMenu.cargarMenu();
            dgvMenu.Columns.Clear();

            switch (cmbTipo.Text)
            {
                case "Entradas":
                    dgvMenu.DataSource = null;
                    listaMenu = listaMenu.FindAll(item => item.Tipo == "Entrada");
                    break;

                case "Platos fuertes":
                    dgvMenu.DataSource = null;
                    listaMenu = listaMenu.FindAll(item => item.Tipo == "Plato fuerte");
                    break;

                case "Bebidas":
                    dgvMenu.DataSource = null;
                    listaMenu = listaMenu.FindAll(item => item.Tipo == "Bebida");
                    break;

                case "Postres":
                    dgvMenu.DataSource = null;
                    listaMenu = listaMenu.FindAll(item => item.Tipo == "Postre");
                    break;
            }

            dgvMenu.DataSource = listaMenu;
            dgvMenu.Columns[0].Width = 160;
            dgvMenu.Columns[1].Visible = false;
            dgvMenu.Columns[2].Visible = false;

            DataGridViewButtonColumn columna = new DataGridViewButtonColumn();
            dgvMenu.Columns.Add(columna);
            dgvMenu.Columns[3].Width = 60;

            foreach(DataGridViewRow dgr in dgvMenu.Rows)
            {
                DataGridViewCell buttonCell = dgr.Cells[3];
                buttonCell.Value = "Agregar";
                
            }


        }

        public void clickAgregar()
        {

        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.claseOrden objetoOrden = new Clases.claseOrden();
            
            dgvOrden.Columns.Clear();
            dgvOrden.DataSource = null;
            if (dgvMenu.CurrentCell.ColumnIndex == 3)
            {
                objetoOrden.Nombre = Convert.ToString(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[0].Value);
                objetoOrden.Cantidad = Convert.ToInt32(nudCantidad.Value);
                objetoOrden.Precio = Convert.ToDecimal(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[2].Value);
                objetoOrden.Subtotal = objetoOrden.Cantidad * objetoOrden.Precio;
                listaOrden.Add(objetoOrden);
            }
            dgvOrden.DataSource = listaOrden;
            archivoOrden.guardarOrden(listaOrden, Convert.ToInt32(lblMesaNum.Text));
            sumar();
        }

        private void dgvOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void sumar()
        {

            decimal total = 0;

            for(int i = 0;i < dgvOrden.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgvOrden.Rows[i].Cells[3].Value);
            }

            lblTotal.Text = "$" + total;

        }

        private void btbCerrar_Click(object sender, EventArgs e)
        {
            ventanaO.colorear();
            this.Close();
            
        }

        private void ventanaOrden_Load(object sender, EventArgs e)
        {
            Clases.claseManejoArchivo ordenes = new Clases.claseManejoArchivo();
            listaOrden = ordenes.cargarOrden(Convert.ToInt32(lblMesaNum.Text));
            if (listaOrden.Count != 0)
            {
                dgvOrden.DataSource = listaOrden;
            }

            sumar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listaOrden.RemoveAt(dgvOrden.CurrentCell.ColumnIndex);
            dgvOrden.DataSource = null;
            dgvOrden.DataSource = listaOrden;

            archivoOrden.guardarOrden(listaOrden,Convert.ToInt32(lblMesaNum.Text));
            sumar();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if(listaOrden.Count == 0)
            {
                MessageBox.Show("La orden está vacía", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogR = MessageBox.Show("¿El cliente pagará la cuenta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dialogR == DialogResult.Yes)
                {
                    MessageBox.Show("La cuenta es de " + lblTotal.Text, "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaOrden.Clear();
                    archivoOrden.guardarOrden(listaOrden,Convert.ToInt32(lblMesaNum.Text));
                    ventanaO.colorear();
                    this.Close();
                }
            }


            

        }
    }
}
