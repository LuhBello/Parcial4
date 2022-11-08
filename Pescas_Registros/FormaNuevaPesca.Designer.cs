namespace Pesca_Registros
{
    partial class FormaNuevaPesca
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
            this.btnAgregarPesca = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalHectareas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMetodos = new System.Windows.Forms.ListBox();
            this.lstCuencas = new System.Windows.Forms.ListBox();
            this.pbxBotonCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(849, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registra Nueva Pesca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarPesca
            // 
            this.btnAgregarPesca.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarPesca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAgregarPesca.ForeColor = System.Drawing.Color.LightCyan;
            this.btnAgregarPesca.Location = new System.Drawing.Point(309, 458);
            this.btnAgregarPesca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPesca.Name = "btnAgregarPesca";
            this.btnAgregarPesca.Size = new System.Drawing.Size(237, 40);
            this.btnAgregarPesca.TabIndex = 33;
            this.btnAgregarPesca.Text = "Agregar Pesca";
            this.btnAgregarPesca.UseVisualStyleBackColor = false;
            this.btnAgregarPesca.Click += new System.EventHandler(this.btnAgregarPesca_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 325);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Peso Total:";
            // 
            // txtTotalHectareas
            // 
            this.txtTotalHectareas.BackColor = System.Drawing.Color.Honeydew;
            this.txtTotalHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHectareas.Location = new System.Drawing.Point(378, 325);
            this.txtTotalHectareas.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalHectareas.Name = "txtTotalHectareas";
            this.txtTotalHectareas.Size = new System.Drawing.Size(76, 26);
            this.txtTotalHectareas.TabIndex = 30;
            this.txtTotalHectareas.Text = "0";
            this.txtTotalHectareas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(378, 366);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(356, 26);
            this.dtpFecha.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cuencas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Árboles:";
            // 
            // lstMetodos
            // 
            this.lstMetodos.BackColor = System.Drawing.Color.Honeydew;
            this.lstMetodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMetodos.FormattingEnabled = true;
            this.lstMetodos.ItemHeight = 20;
            this.lstMetodos.Location = new System.Drawing.Point(388, 93);
            this.lstMetodos.Margin = new System.Windows.Forms.Padding(2);
            this.lstMetodos.Name = "lstMetodos";
            this.lstMetodos.Size = new System.Drawing.Size(226, 64);
            this.lstMetodos.TabIndex = 35;
            // 
            // lstCuencas
            // 
            this.lstCuencas.BackColor = System.Drawing.Color.Honeydew;
            this.lstCuencas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCuencas.FormattingEnabled = true;
            this.lstCuencas.ItemHeight = 20;
            this.lstCuencas.Location = new System.Drawing.Point(388, 179);
            this.lstCuencas.Margin = new System.Windows.Forms.Padding(2);
            this.lstCuencas.Name = "lstCuencas";
            this.lstCuencas.Size = new System.Drawing.Size(226, 64);
            this.lstCuencas.TabIndex = 36;
            // 
            // pbxBotonCerrar
            // 
            this.pbxBotonCerrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pbxBotonCerrar.Image = global::Pesca_Registros.Properties.Resources.cerrar_simbolo_de_boton_circular;
            this.pbxBotonCerrar.Location = new System.Drawing.Point(806, 12);
            this.pbxBotonCerrar.Name = "pbxBotonCerrar";
            this.pbxBotonCerrar.Size = new System.Drawing.Size(20, 20);
            this.pbxBotonCerrar.TabIndex = 2;
            this.pbxBotonCerrar.TabStop = false;
            this.pbxBotonCerrar.Click += new System.EventHandler(this.pbxBotonCerrar_Click);
            // 
            // FormaNuevaPesca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(849, 572);
            this.Controls.Add(this.lstCuencas);
            this.Controls.Add(this.lstMetodos);
            this.Controls.Add(this.btnAgregarPesca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalHectareas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Name = "FormaNuevaPesca";
            this.Text = "FormaNuevaPesca";
            this.Load += new System.EventHandler(this.FormaNuevaPesca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.Button btnAgregarPesca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalHectareas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMetodos;
        private System.Windows.Forms.ListBox lstCuencas;
    }
}