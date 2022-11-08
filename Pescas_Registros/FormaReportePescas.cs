using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;

namespace Pesca_Registros
{
    public partial class FormaReportePescas : Form
    {
        public FormaReportePescas()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaReportePescas_Load(object sender, EventArgs e)
        {
            InicializaDgvDetallePescas();
        }

        /// <summary>
        /// Inicializa el DataGridView con el detalle de siembras
        /// </summary>
        public void InicializaDgvDetallePescas()
        {
            dgvDetallePescas.DataSource = null;
            dgvDetallePescas.DataSource = AccesoDatos.ObtenerDetallePescas();
        }

        /// <summary>
        /// Actualiza los campos de información sobre la siembra cuando se cambia el item seleccionado en el DataGridView
        /// </summary>
        private void dgvDetallePescas_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvDetallePescas.SelectedRows.Count > 0)
            {
                int codigoPesca = int.Parse(dgvDetallePescas.SelectedRows[0].Cells[0].Value.ToString());
                txtCodigoPesca.Text = codigoPesca.ToString();

                Pesca unaPesca = AccesoDatos.ObtenerPesca(codigoPesca);
            }
            else
            {
                txtCodigoPesca.Text = "";

            }
        }
    }
}
