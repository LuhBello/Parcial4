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
    public partial class FormaBorraPesca : Form
    {
        public FormaBorraPesca()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaBorraPesca_Load(object sender, EventArgs e)
        {
            InicializaLstInfoPescas();
        }

        /// <summary>
        /// Inicializa la lista con la información resumida de las pescas
        /// </summary>
        public void InicializaLstInfoPescas()
        {
            lstInfoPescas.DataSource = null;
            lstInfoPescas.DataSource = AccesoDatos.ObtieneListaInfoPescas();
            lstInfoPescas.DisplayMember = "infoPesca";

            lstInfoPescas.Invalidate();
            lstInfoPescas.Refresh();

            //Seleccionamos el primer municipio de la lista
            lstInfoPescas.SelectedIndex = 0;
        }

        private void lstInfoPescas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] infoPesca = lstInfoPescas.SelectedItem.ToString().Split('-');
            int codigo_pesca = int.Parse(infoPesca[0].Trim());
            txtCodigoPesca.Text = codigo_pesca.ToString();
        }

        private void btnBorraPesca_Click(object sender, EventArgs e)
        {
            int codigoPesca = int.Parse(txtCodigoPesca.Text);

            
            DialogResult resultado = MessageBox.Show("¿Está seguro de querer borrar esta pesca?",
                "Confirmación borrado pesca",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Hand);

            //Si el usuario quiere borrar
            if (resultado == DialogResult.Yes)
            {
                AccesoDatos.BorrarPesca(codigoPesca);

                    MessageBox.Show("La pesca se borró correctamente",
                        "Borrado exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    //Aqui actualizamos las formas de las pescas, si se encuentran abiertas
                    RefrescaFormasPescas();
                    //Cerramos la forma
                    this.Close();
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
