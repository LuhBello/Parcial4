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
    public partial class FormaNuevaPesca : Form
    {
        public FormaNuevaPesca()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaNuevaPesca_Load(object sender, EventArgs e)
        {
            InicializaLstMetodos();
            InicializaLstCuencas();
        }



        /// <summary>
        /// Inicializa la lista de contratista
        /// </summary>
        private void InicializaLstCuencas()
        {
            lstCuencas.DataSource = null;
            lstCuencas.DataSource = AccesoDatos.ObtieneListaCuencas();
            lstCuencas.DisplayMember = "infoCuencas";
        }

        /// <summary>
        /// Inicializa la lista de árboles
        /// </summary>
        private void InicializaLstMetodos()
        {
            lstMetodos.DataSource = null;
            lstMetodos.DataSource = AccesoDatos.ObtieneListaMetodos();
            lstMetodos.DisplayMember = "InfoMetodos";
        }




        private void btnAgregarPesca_Click(object sender, EventArgs e)
        {
            try
            {
                Pesca unaPesca = new Pesca();
                unaPesca.Peso_Total = Math.Abs(double.Parse(txtTotalHectareas.Text));
                unaPesca.Fecha = dtpFecha.Value;
                unaPesca.Nombre_Metodo = lstMetodos.SelectedItem.ToString();
                unaPesca.Nombre_Cuenca = lstCuencas.SelectedItem.ToString();

                AccesoDatos.GuardarPesca(unaPesca);

                    MessageBox.Show("La cuenca se registró correctamente",
                        "Inserción exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    //Aqui actualizamos las formas de las siembras, si se encuentran abiertas
                    RefrescaFormasPescas();

                    //Cerramos la forma
               
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }
        }


        /// <summary>
        /// Refresca las formas de siembras, si éstas se encuentran abiertas
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
