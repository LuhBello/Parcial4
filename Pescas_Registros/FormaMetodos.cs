using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesca_Registros
{
    public partial class FormaMetodos : Form
    {
        public FormaMetodos()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormaMetodos_Load(object sender, EventArgs e)
        {
            InicializaLstInfoMetodos();

        }

        public void InicializaLstInfoMetodos()
        {
            listInfoMetodo.DataSource = null;
            listInfoMetodo.DataSource = AccesoDatos.ObtieneListaInfoMetodos();
            listInfoMetodo.DisplayMember = "infoMetodos";
           // listInfoMetodo.Invalidate();
           // listInfoMetodo.Refresh();
            //Seleccionamos el primer municipio de la lista
            //listInfoMetodo.SelectedIndex = 0;
           // if (string.IsNullOrEmpty(nombreArbol))
            //    lstArboles.SelectedIndex = 0;
            //else
              //  lstArboles.SelectedIndex = lstArboles.Items.IndexOf(nombreArbol);
        }

        public void ActualizarCampos()
        {
            listInfoMetodo.DataSource = AccesoDatos.ObtieneListaInfoMetodos();
            listInfoMetodo.Invalidate();
            listInfoMetodo.Refresh();
        }

        public int ValidarcodigoMetodo(int default_codigo)
        {
            string[] codigo = new string[listInfoMetodo.Items.Count];
            string[] validacion = new string[listInfoMetodo.Items.Count];
            int bandera = 0;
            int[] array = new int[listInfoMetodo.Items.Count];
            validacion = listInfoMetodo.Text.Split('\u002C');
            for (int i = 0; i < validacion.Length; i++)
            {
                codigo = validacion[i].ToString().Split('-');
                array[bandera] = int.Parse(codigo[0]);
                bandera++;
            }
            for (int j = 0; j < listInfoMetodo.Items.Count; j++)
            {
                if (array[j] == default_codigo && default_codigo != listInfoMetodo.SelectedItem.ToString()[0])
                {
                    return listInfoMetodo.Items.Count + 1;
                }
            }
            return default_codigo;
        }
        public string ValidarNombreMetodo(string default_nombre)
        {
            string[] codigo = new string[listInfoMetodo.Items.Count * 2];
            string[] validacion = new string[listInfoMetodo.Items.Count * 2];
            int bandera = 0;
            string[] array = new string[listInfoMetodo.Items.Count];
            validacion = listInfoMetodo.Text.Split('\u002C');
            for (int i = 0; i < validacion.Length; i++)
            {
                codigo = validacion[i].ToString().Split('-');
                array[bandera] = codigo[1];
                bandera++;
            }
            for (int j = 0; j < listInfoMetodo.Items.Count; j++)
            {
                if (array[j] == default_nombre)
                {
                    MessageBox.Show("Ese nombre ya existe.",
                                    "Ingreso Incorrecto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return null;
                }
            }
            return default_nombre;
        }
        public bool BuscarEnPescas(string default_nombre)
        {
            string[] codigo = new string[AccesoDatos.ObtieneListaInfoPescas().Count * 2];
            string[] validacion = new string[AccesoDatos.ObtieneListaInfoPescas().Count];
            int bandera = 0;
            string[] array = new string[AccesoDatos.ObtieneListaInfoPescas().Count];
            for (int i = 0; i < AccesoDatos.ObtieneListaInfoPescas().Count; i++)
            {
                validacion[i] = AccesoDatos.ObtieneListaInfoPescas()[i].ToString();
            }

            for (int i = 0; i < validacion.Length; i++)
            {
                codigo = validacion[i].ToString().Split('-');
                array[bandera] = codigo[2];
                bandera++;
            }
            for (int j = 0; j < AccesoDatos.ObtieneListaInfoPescas().Count; j++)
            {
                if (array[j].Trim().Equals(default_nombre))
                {
                    MessageBox.Show("El metodo tiene dependencias, no se puede borrar.\n Elimina primero las dependencias.",
                                    "Ingreso Incorrecto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void listInfoMetodo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string[] infoMetodo = listInfoMetodo.SelectedItem.ToString().Split('-');
                txtMetodo_N.Text = infoMetodo[1];
                txtMetodo_Codigo.Text = infoMetodo[0];
            }
            catch (Exception exe)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {exe.Message}");
            }
        }

        private void FormaMetodos_Load_1(object sender, EventArgs e)
        {
            InicializaLstInfoMetodos();
        }

        //Actualizar
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Metodo laMetodo = new Metodo();
                laMetodo.Nombre = ValidarNombreMetodo(txtMetodo_N.Text);
                laMetodo.Codigo = int.Parse(txtMetodo_Codigo.Text);
                AccesoDatos.ActualizarMetodo(laMetodo);
                ActualizarCampos();
               
                    MessageBox.Show("El Metodo se actualizó correctamente",
                        "Actualización exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }
        }
        //Borrar
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] infoMetodo = listInfoMetodo.SelectedItem.ToString().Split('-');
                Metodo laMetodo = new Metodo();
                laMetodo.Nombre = infoMetodo[1];
                laMetodo.Codigo = int.Parse(infoMetodo[0]);
                if (BuscarEnPescas(laMetodo.Nombre))
                {
                    AccesoDatos.BorrarMetodo(laMetodo.Codigo);
                    ActualizarCampos();
                   
                        MessageBox.Show("El Metodo se borró correctamente",
                            "Eliminación exitosa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    
                }
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }
        }


        //Nueva
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Metodo laMetodo = new Metodo();//La Metodo
                laMetodo.Codigo = ValidarcodigoMetodo(int.Parse(txtMetodo_Codigo.Text));
                laMetodo.Nombre = ValidarNombreMetodo(txtMetodo_N.Text);
                AccesoDatos.GuardarMetodo(laMetodo);
                ActualizarCampos();

                    MessageBox.Show("El Metodo se agregó correctamente",
                        "Guardado exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }
        }
    }
}