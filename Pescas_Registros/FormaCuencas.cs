using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pesca_Registros
{
    public partial class FormaCuencas : Form
    {
        public FormaCuencas()
        {
            InitializeComponent();

        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listInfoCuencas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                    string[] infoCuenca = listInfoCuencas.SelectedItem.ToString().Split('-');
                    txtCuencaN.Text = infoCuenca[1];
                    txtCodigo_Cuenca.Text = infoCuenca[0];
            }catch(Exception exe)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {exe.Message}");
            }
        }

        private void FormaCuencas_Load(object sender, EventArgs e)
        {
            InicializaLstInfoCuencas();
            
        }

        public void InicializaLstInfoCuencas()
        {
            listInfoCuencas.DataSource = null;
            listInfoCuencas.DataSource = AccesoDatos.ObtieneListaInfoCuencas();
            listInfoCuencas.DisplayMember = "infoCuencas";
            listInfoCuencas.Invalidate();
            listInfoCuencas.Refresh();
            
            //Seleccionamos el primer municipio de la lista
            //listInfoCuencas.SelectedIndex = 0;
        }

        public void ActualizarCampos()
        {
            listInfoCuencas.DataSource = AccesoDatos.ObtieneListaInfoCuencas();
            listInfoCuencas.Invalidate();
            listInfoCuencas.Refresh();
        }


        public bool BuscarEnPescas(string default_nombre)
        {
            string[] codigo = new string[AccesoDatos.ObtieneListaInfoPescas().Count*2];
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
                    MessageBox.Show("La cuenca tiene dependencias, no se puede borrar.\n Elimina primero las dependencias.",
                                    "Ingreso Incorrecto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }



        public int ValidarcodigoCuenca(int default_codigo)
        {
            string[] codigo = new string[listInfoCuencas.Items.Count];
            string[] validacion = new string[listInfoCuencas.Items.Count];
            int bandera = 0;
            int[] array = new int[listInfoCuencas.Items.Count];


            for (int i = 0; i < listInfoCuencas.Items.Count; i++)
            {
                validacion[i] = listInfoCuencas.Items[i].ToString();
            }

            for (int i = 0; i < validacion.Length; i++)
            {
                codigo = validacion[i].ToString().Split('-');
                array[bandera] = int.Parse(codigo[0]);
                bandera++;
            }

            // && default_codigo != listInfoCuencas.SelectedItem.ToString()[0]
            for (int j = 0; j < listInfoCuencas.Items.Count; j++)
            {
                if (array[j] == default_codigo)
                {
                    return listInfoCuencas.Items.Count + 1;
                }
            }
            return default_codigo;
        }
        public string ValidarNombreCuenca(string default_nombre)
        {
            string[] codigo = new string[listInfoCuencas.Items.Count*2];
            string[] validacion = new string[listInfoCuencas.Items.Count];
            int bandera = 0;
            string[] array = new string[listInfoCuencas.Items.Count];


            for (int i = 0; i < listInfoCuencas.Items.Count; i++)
            {
                validacion[i] = listInfoCuencas.Items[i].ToString();
            }

            for (int i = 0; i < validacion.Length; i++)
            {
                codigo = validacion[i].ToString().Split('-');
                array[bandera] = codigo[1];
                bandera++;
            }
            for (int j = 0; j < listInfoCuencas.Items.Count; j++)
            {
                if (array[j].Equals(default_nombre))
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

        //Boton actualizar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string[] infoCuenca = listInfoCuencas.SelectedItem.ToString().Split('-');
                Cuenca laCuenca = new Cuenca();
                laCuenca.Nombre = ValidarNombreCuenca(txtCuencaN.Text);
                laCuenca.Codigo = int.Parse(txtCodigo_Cuenca.Text);
                AccesoDatos.ActualizarCuenca(laCuenca);
                ActualizarCampos();
                    MessageBox.Show("La cuenca se actualizó correctamente",
                        "Actualización exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }
        }

        //Boton Borrar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                    string[] infoCuenca = listInfoCuencas.SelectedItem.ToString().Split('-');
                    Cuenca laCuenca = new Cuenca();
                    laCuenca.Nombre = infoCuenca[1];
                    laCuenca.Codigo = int.Parse(infoCuenca[0]);
                if (AccesoDatos.ValidaCuenca(laCuenca))
                {
                    if (BuscarEnPescas(laCuenca.Nombre))
                    {
                        AccesoDatos.BorrarCuenca(laCuenca.Codigo);
                        ActualizarCampos();
                        MessageBox.Show("La cuenca se borró correctamente",
                            "Eliminación exitosa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("La cuenca no se puede borrar ya que tiene dependencias.",
                            "Eliminación Fallida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }
        }

       

        //Boton Nueva
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //string[] infoCuenca = listInfoCuencas.SelectedItem.ToString().Split('-');
                Cuenca laCuenca = new Cuenca();

                laCuenca.Codigo = ValidarcodigoCuenca(int.Parse(txtCodigo_Cuenca.Text));
                laCuenca.Nombre = ValidarNombreCuenca(txtCuencaN.Text);
                AccesoDatos.GuardarCuenca(laCuenca);
                ActualizarCampos();
                
                    MessageBox.Show("La cuenca se agregó correctamente",
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
