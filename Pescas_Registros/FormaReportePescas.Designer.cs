namespace Pesca_Registros
{
    partial class FormaReportePescas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pbxBotonCerrar = new System.Windows.Forms.PictureBox();
            this.dgvDetallePescas = new System.Windows.Forms.DataGridView();
            this.txtCodigoPesca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePescas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pescas registradas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxBotonCerrar
            // 
            this.pbxBotonCerrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pbxBotonCerrar.Image = global::Pesca_Registros.Properties.Resources.cerrar_simbolo_de_boton_circular;
            this.pbxBotonCerrar.Location = new System.Drawing.Point(802, 12);
            this.pbxBotonCerrar.Name = "pbxBotonCerrar";
            this.pbxBotonCerrar.Size = new System.Drawing.Size(20, 20);
            this.pbxBotonCerrar.TabIndex = 2;
            this.pbxBotonCerrar.TabStop = false;
            this.pbxBotonCerrar.Click += new System.EventHandler(this.pbxBotonCerrar_Click);
            // 
            // dgvDetallePescas
            // 
            this.dgvDetallePescas.AllowUserToAddRows = false;
            this.dgvDetallePescas.AllowUserToDeleteRows = false;
            this.dgvDetallePescas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDetallePescas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePescas.GridColor = System.Drawing.Color.LightBlue;
            this.dgvDetallePescas.Location = new System.Drawing.Point(28, 51);
            this.dgvDetallePescas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetallePescas.Name = "dgvDetallePescas";
            this.dgvDetallePescas.ReadOnly = true;
            this.dgvDetallePescas.RowHeadersWidth = 51;
            this.dgvDetallePescas.RowTemplate.Height = 24;
            this.dgvDetallePescas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallePescas.Size = new System.Drawing.Size(774, 394);
            this.dgvDetallePescas.TabIndex = 8;
            this.dgvDetallePescas.SelectionChanged += new System.EventHandler(this.dgvDetallePescas_SelectionChanged);
            // 
            // txtCodigoPesca
            // 
            this.txtCodigoPesca.BackColor = System.Drawing.Color.Honeydew;
            this.txtCodigoPesca.Enabled = false;
            this.txtCodigoPesca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPesca.Location = new System.Drawing.Point(237, 464);
            this.txtCodigoPesca.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPesca.Name = "txtCodigoPesca";
            this.txtCodigoPesca.Size = new System.Drawing.Size(98, 26);
            this.txtCodigoPesca.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 470);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pesca seleccionada:";
            // 
            // FormaReportePescas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(834, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoPesca);
            this.Controls.Add(this.dgvDetallePescas);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Name = "FormaReportePescas";
            this.Text = "FormaReportePescas";
            this.Load += new System.EventHandler(this.FormaReportePescas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePescas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.DataGridView dgvDetallePescas;
        private System.Windows.Forms.TextBox txtCodigoPesca;
        private System.Windows.Forms.Label label2;
    }
}