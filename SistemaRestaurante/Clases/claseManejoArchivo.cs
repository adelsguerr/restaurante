using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto_Final_Periodo3.Clases
{
    class claseManejoArchivo
    {

        public claseManejoArchivo()
        {
            List<claseMenu> listaMenu = new List<claseMenu>();
            if (!(File.Exists("archivoMenu.dat")))
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMenu.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, listaMenu);
                fs.Close();
            }

            List<claseUsuarios> listaUsuarios = new List<claseUsuarios>();
            if (!(File.Exists("archivoUsuarios.dat")))
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoUsuarios.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, listaUsuarios);
                fs.Close();
            }
        }

        public List<claseMenu> cargarMenu()
        {
            List<claseMenu> listaMenu = new List<claseMenu>();
            if (File.Exists("archivoMenu.dat"))
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMenu.dat", FileMode.Open, FileAccess.Read);
                listaMenu = (List<Clases.claseMenu>)formater.Deserialize(fs);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Error al leer el archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listaMenu;
        }


        public void guardarMenu(List<claseMenu> lista)
        {
            if (File.Exists("archivoMenu.dat"))
            {
                File.Delete("archivoMenu.dat");
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMenu.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, lista);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<claseUsuarios> cargarUsuarios()
        {
            List<claseUsuarios> listaUsuarios = new List<claseUsuarios>();
            if (File.Exists("archivoUsuarios.dat"))
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoUsuarios.dat", FileMode.Open, FileAccess.Read);
                listaUsuarios = (List<claseUsuarios>)formater.Deserialize(fs);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Error al leer el archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listaUsuarios;
        }

        public void guardarUsuarios(List<claseUsuarios> lista)
        {
            if (File.Exists("archivoUsuarios.dat"))
            {
                File.Delete("archivoUsuarios.dat");
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoUsuarios.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, lista);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<claseOrden> cargarOrden(int numeroMesa)
        {
            List<claseOrden> orden = new List<claseOrden>();

            if (!File.Exists("archivoMesa" + numeroMesa + ".dat"))
            {
                BinaryFormatter formaterCrear = new BinaryFormatter();
                FileStream fsCrear = new FileStream("archivoMesa" + numeroMesa + ".dat", FileMode.Create, FileAccess.Write);
                formaterCrear.Serialize(fsCrear, orden);
                fsCrear.Close();
            }

            BinaryFormatter formater = new BinaryFormatter();
            FileStream fs = new FileStream("archivoMesa" + numeroMesa + ".dat", FileMode.Open, FileAccess.Read);
            orden = (List<claseOrden>)formater.Deserialize(fs);
            fs.Close();

            return orden;
        }

        public void guardarOrden(List<claseOrden> listOrden, int numeroMesa)
        {
            if (File.Exists("archivoMesa" + numeroMesa + ".dat"))
            {
                File.Delete("archivoMesa" + numeroMesa + ".dat");
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMesa" + numeroMesa + ".dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, listOrden);
                fs.Close();
            }
            else
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMesa" + numeroMesa + ".dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, listOrden);
                fs.Close();
            }
        }


        public claseMesa cargarMesa()
        {
            claseMesa mesa;

            if (!File.Exists("configuracion.dat"))
            {
                mesa = new claseMesa();
                BinaryFormatter formaterCrear = new BinaryFormatter();
                FileStream fsCrear = new FileStream("configuracion.dat", FileMode.Create, FileAccess.Write);
                formaterCrear.Serialize(fsCrear, mesa);
                fsCrear.Close();
            }

            BinaryFormatter formater = new BinaryFormatter();
            FileStream fs = new FileStream("configuracion.dat", FileMode.Open, FileAccess.Read);
            mesa = (claseMesa)formater.Deserialize(fs);
            fs.Close();

            return mesa;

        }

        public void guardarMesa(claseMesa objetoMesa)
        {
            if (File.Exists("configuracion.dat"))
            {
                File.Delete("configuracion.dat");
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("configuracion.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, objetoMesa);
                fs.Close();
            }
            else
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("configuracion.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, objetoMesa);
                fs.Close();
            }
        }

    }
}

