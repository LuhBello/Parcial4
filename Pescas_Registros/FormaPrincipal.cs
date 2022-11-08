/*
Codigo adaptado del proyecto presentado en https://www.youtube.com/watch?v=Z7TfV7LZzp4
https://rjcodeadvance.com/interfaz-grafico-de-usuario-modernista-multi-window-con-c-version-completa/
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pesca_Registros
{
    public partial class FormaPrincipal : Form
    {
        public FormaPrincipal()
        {
            InitializeComponent();
            OcultaPanelesCrud();

            //Reduce el "flickering"
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        #region Funcionalidad para implementar el arrastre de la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxBotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Funcionalidad para manipular formularios dentro del panel

        private void AbrirFormulario<unFormulario>() where unFormulario : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = panelFormularios.Controls.OfType<unFormulario>().FirstOrDefault();
            
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new unFormulario();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CerrarFormulario);
            }
            else
            {
                //si el formulario/instancia existe
                formulario.BringToFront();
            }
        }

        private void OcultaPanelesCrud()
        {
            Panel[] panelesCrud =   
                { 
                    panelCrudArboles, 
                    panelCrudContratistas, 
                    panelCrudPescas 
                };

            foreach(Panel unPanel in panelesCrud)
                unPanel.Visible = false;

            Button[] botonesCrud =
                {
                    btnFormaArboles,
                    btnFormaContratistas,
                    btnFormaPescas
                };

            foreach (Button unBoton in botonesCrud)
            {
                unBoton.BackColor = Color.FromArgb(0, 192, 192);
                unBoton.ForeColor = Color.White;
            }
        }

        private void VisualizaPanelCrud(Panel elPanel, Button botonCrud)
        {
            if (!elPanel.Visible)
            {
                OcultaPanelesCrud();
                elPanel.Visible = true;
                botonCrud.BackColor = Color.FromArgb(0, 192, 192);
                botonCrud.ForeColor = Color.White;
            }
            else
            {
                elPanel.Visible = false;
                botonCrud.BackColor = Color.FromArgb(0, 192, 192);
                botonCrud.ForeColor = Color.White;
            }

        }

        private void CerrarFormulario(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormaReportePescas"] == null)
            {
                btnFormaReportePescas.BackColor = Color.FromArgb(0, 192, 192);
                btnFormaReportePescas.ForeColor = Color.White;
            }
            if (Application.OpenForms["FormaInsertaPesca"] == null)
            {
                btnFormaNuevaPesca.BackColor = Color.FromArgb(0, 192, 192);
                btnFormaNuevaPesca.ForeColor = Color.White;
            }

            if (Application.OpenForms["FormaActualizaPesca"] == null)
            {
                btnFormaActualizaPesca.BackColor = Color.FromArgb(0, 192, 192);
                btnFormaActualizaPesca.ForeColor = Color.White;
            }

            if (Application.OpenForms["FormaBorraPesca"] == null)
            {
                btnFormaBorraPesca.BackColor = Color.FromArgb(0, 192, 192);
                btnFormaBorraPesca.ForeColor = Color.White;
            }
        }

        #endregion

        private void btnFormaPescas_Click(object sender, EventArgs e)
        {
            VisualizaPanelCrud(panelCrudPescas, btnFormaPescas);
        }

        private void btnFormaArboles_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaMetodos>();
        }

        private void btnFormaContratistas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaCuencas>();
        }


        private void btnFormaNuevaPesca_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaNuevaPesca>();
            btnFormaNuevaPesca.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaNuevaPesca.ForeColor = Color.Black;
        }

        private void btnFormaReportePescas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaReportePescas>();
            btnFormaReportePescas.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaReportePescas.ForeColor = Color.Black;
        }

        private void btnFormaActualizaPesca_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaActualizaPesca>();
            btnFormaActualizaPesca.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaActualizaPesca.ForeColor = Color.Black;
        }

        private void btnFormaBorraPesca_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaBorraPesca>();
            btnFormaBorraPesca.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaBorraPesca.ForeColor = Color.Black;
        }

    }
}
