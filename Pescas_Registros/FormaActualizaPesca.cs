using System;
using System.Windows.Forms;

namespace Pesca_Registros
{
    public partial class FormaActualizaPesca : Form
    {
        public FormaActualizaPesca()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaActualizaPesca_Load(object sender, EventArgs e)
        {
            InicializaLstInfoPescas();
        }

        private void FormaActualizaPesca_Activated(object sender, EventArgs e)
        {
            InicializaLstInfoPescas();
        }

        /// <summary>
        /// Inicializa la lista que contiene la información resumida de la pescas
        /// </summary>
        public void InicializaLstInfoPescas()
        {
            lstInfoPescas.DataSource = null;
            lstInfoPescas.DataSource = AccesoDatos.ObtieneListaInfoPescas();
            lstInfoPescas.DisplayMember = "infoPesca";

            //Seleccionamos el primer municipio de la lista
            //lstInfoPescas.SelectedIndex = 0;
        }

        private void lstInfoPescas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtenemos el código de la pesca
            string[] infoPesca = lstInfoPescas.SelectedItem.ToString().Split('-');
            int codigo_pesca = int.Parse(infoPesca[0].Trim());
            txtCodigoPesca.Text = codigo_pesca.ToString();
            lstMetodos.SelectedItem = infoPesca[1];
            lstCuencas.SelectedItem=infoPesca[2].Trim();
            txtPeso.Text = infoPesca[3].Trim();
            //Leemos desde la DB, la pesca asociada al codigo_obtenido
            Pesca unaPesca = AccesoDatos.ObtenerPesca(codigo_pesca);
            //Actualizamos la lista de Metodos
            InicializaLstMetodos(unaPesca.Nombre_Metodo);

            //Actualizamos la lista de Cuencas
            InicializaLstCuencas(unaPesca.Nombre_Cuenca);
            //Actualizamos total peso


            //Aqui controlamos la visualización del formato de fecha
            dtpFecha.Value = unaPesca.Fecha;
        }

       




        /// <summary>
        /// Inicializa la lista de los metodos
        /// </summary>
        /// <param name="nombreMetodo">El metodo que se espera sea seleccionado</param>
        private void InicializaLstMetodos(string nombreMetodo)
        {
            lstMetodos.DataSource = null;
            lstMetodos.DataSource = AccesoDatos.ObtieneListaMetodos();
            lstMetodos.DisplayMember = "nombre";

            //Seleccionamos el Metodo que se llama igual al de la pesca seleccionada
            if (string.IsNullOrEmpty(nombreMetodo))
                lstMetodos.SelectedIndex = 0;
            else
                lstMetodos.SelectedIndex = lstMetodos.Items.IndexOf(nombreMetodo);
        }
        public void ActualizarCampos()
        {
            lstInfoPescas.DataSource = AccesoDatos.ObtieneListaInfoPescas();
            lstInfoPescas.Invalidate();
            lstInfoPescas.Refresh();
        }

        /// <summary>
        /// Inicializa la lista de contratista
        /// </summary>
        /// <param name="nombreCuenca">El contratista que se espera sea seleccionado</param>
        private void InicializaLstCuencas(string nombreCuenca)
        {
            lstCuencas.DataSource = null;
            lstCuencas.DataSource = AccesoDatos.ObtieneListaCuencas();
            lstCuencas.DisplayMember = "nombre";

            //Seleccionamos el metodo que se llama igual al de la pesca seleccionada
            if (string.IsNullOrEmpty(nombreCuenca))
                lstCuencas.SelectedIndex = 0;
            else
                lstCuencas.SelectedIndex = lstCuencas.Items.IndexOf(nombreCuenca);
        }

        /// <summary>
        /// Obtiene objeto tipo fecha a partir de su representación como cadena corta
        /// </summary>
        /// <param name="datoFecha">La fecha en formato cadena corta</param>
        /// <returns></returns>
        private bool ObtieneFechaPesca(string datoFecha, out DateTime fechaResultado, out string mensajeError)
        {
            bool resultadoConversion = false;
            try
            {
                string[] laFecha = datoFecha.Split('/');
                fechaResultado = new DateTime(
                    int.Parse(laFecha[2]),
                    int.Parse(laFecha[1]),
                    int.Parse(laFecha[0])
                    );
                resultadoConversion = true;
                mensajeError = "";
            }
            catch(ArgumentOutOfRangeException error)
            { 
                resultadoConversion=false;
                mensajeError = error.Message;
                fechaResultado = DateTime.Now;
            }

            return resultadoConversion;
        }

        private void btnActualizaPesca_Click(object sender, EventArgs e)
        {
            try
            {
                Pesca unaPesca = new Pesca();
                unaPesca.Codigo = int.Parse(txtCodigoPesca.Text);
                unaPesca.Peso_Total = Math.Abs(double.Parse(txtPeso.Text));
                unaPesca.Fecha = dtpFecha.Value;
                unaPesca.Nombre_Metodo = lstMetodos.SelectedItem.ToString();
                unaPesca.Nombre_Cuenca = lstCuencas.SelectedItem.ToString();
                ActualizarCampos();
                AccesoDatos.ActualizarPesca(unaPesca);

                    MessageBox.Show("La pesca se actualizó correctamente",
                        "Actualización exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                //Aqui actualizamos las formas de las pescas, si se encuentran abiertas
                RefrescaFormasPescas();

                //Cerramos la forma
                this.Close();
               
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }
        }


        /// <summary>
        /// Refresca la forma de reporte de pescas, si ésta se encuentra abierta
        /// </summary>
        public void RefrescaFormasPescas()
        {
            //FormaReportePescas
            FormaReportePescas formaReportes =
                (FormaReportePescas)Application.OpenForms["FormaReportePescas"];

            if (formaReportes != null)
                formaReportes.InicializaDgvDetallePescas();
        }


    }
}
