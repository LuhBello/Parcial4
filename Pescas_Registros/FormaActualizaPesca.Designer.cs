namespace Pesca_Registros
{
    partial class FormaActualizaPesca
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
            this.lstInfoPescas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCuencas = new System.Windows.Forms.ListBox();
            this.lstMetodos = new System.Windows.Forms.ListBox();
            this.btnActualizaPesca = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoPesca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(849, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actualiza Pesca existente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxBotonCerrar
            // 
            this.pbxBotonCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxBotonCerrar.Image = global::Pesca_Registros.Properties.Resources.cerrar_simbolo_de_boton_circular;
            this.pbxBotonCerrar.Location = new System.Drawing.Point(806, 12);
            this.pbxBotonCerrar.Name = "pbxBotonCerrar";
            this.pbxBotonCerrar.Size = new System.Drawing.Size(20, 20);
            this.pbxBotonCerrar.TabIndex = 2;
            this.pbxBotonCerrar.TabStop = false;
            this.pbxBotonCerrar.Click += new System.EventHandler(this.pbxBotonCerrar_Click);
            // 
            // lstInfoPescas
            // 
            this.lstInfoPescas.BackColor = System.Drawing.Color.Honeydew;
            this.lstInfoPescas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInfoPescas.FormattingEnabled = true;
            this.lstInfoPescas.ItemHeight = 20;
            this.lstInfoPescas.Location = new System.Drawing.Point(126, 68);
            this.lstInfoPescas.Margin = new System.Windows.Forms.Padding(2);
            this.lstInfoPescas.Name = "lstInfoPescas";
            this.lstInfoPescas.Size = new System.Drawing.Size(626, 124);
            this.lstInfoPescas.TabIndex = 3;
            this.lstInfoPescas.SelectedIndexChanged += new System.EventHandler(this.lstInfoPescas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesca:";
            // 
            // lstCuencas
            // 
            this.lstCuencas.BackColor = System.Drawing.Color.Honeydew;
            this.lstCuencas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCuencas.FormattingEnabled = true;
            this.lstCuencas.ItemHeight = 20;
            this.lstCuencas.Location = new System.Drawing.Point(412, 340);
            this.lstCuencas.Margin = new System.Windows.Forms.Padding(2);
            this.lstCuencas.Name = "lstCuencas";
            this.lstCuencas.Size = new System.Drawing.Size(226, 64);
            this.lstCuencas.TabIndex = 51;
            // 
            // lstMetodos
            // 
            this.lstMetodos.BackColor = System.Drawing.Color.Honeydew;
            this.lstMetodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMetodos.FormattingEnabled = true;
            this.lstMetodos.ItemHeight = 20;
            this.lstMetodos.Location = new System.Drawing.Point(412, 259);
            this.lstMetodos.Margin = new System.Windows.Forms.Padding(2);
            this.lstMetodos.Name = "lstMetodos";
            this.lstMetodos.Size = new System.Drawing.Size(226, 64);
            this.lstMetodos.TabIndex = 50;
            // 
            // btnActualizaPesca
            // 
            this.btnActualizaPesca.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnActualizaPesca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizaPesca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaPesca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizaPesca.Location = new System.Drawing.Point(343, 511);
            this.btnActualizaPesca.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizaPesca.Name = "btnActualizaPesca";
            this.btnActualizaPesca.Size = new System.Drawing.Size(224, 32);
            this.btnActualizaPesca.TabIndex = 48;
            this.btnActualizaPesca.Text = "Actualiza Pesca";
            this.btnActualizaPesca.UseVisualStyleBackColor = false;
            this.btnActualizaPesca.Click += new System.EventHandler(this.btnActualizaPesca_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 431);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Peso Total:";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.Honeydew;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(412, 425);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(76, 26);
            this.txtPeso.TabIndex = 45;
            this.txtPeso.Text = "0";
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dtpFecha.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(412, 462);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(338, 26);
            this.dtpFecha.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Cuencas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Métodos de Pesca: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 219);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Código pesca seleccionada:";
            // 
            // txtCodigoPesca
            // 
            this.txtCodigoPesca.BackColor = System.Drawing.Color.Honeydew;
            this.txtCodigoPesca.Enabled = false;
            this.txtCodigoPesca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPesca.Location = new System.Drawing.Point(412, 213);
            this.txtCodigoPesca.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPesca.Name = "txtCodigoPesca";
            this.txtCodigoPesca.Size = new System.Drawing.Size(76, 26);
            this.txtCodigoPesca.TabIndex = 53;
            this.txtCodigoPesca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormaActualizaPesca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(849, 572);
            this.Controls.Add(this.txtCodigoPesca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstCuencas);
            this.Controls.Add(this.lstMetodos);
            this.Controls.Add(this.btnActualizaPesca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstInfoPescas);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaActualizaPesca";
            this.Text = "FormaActualizaPesca";
            this.Activated += new System.EventHandler(this.FormaActualizaPesca_Activated);
            this.Load += new System.EventHandler(this.FormaActualizaPesca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.ListBox lstInfoPescas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCuencas;
        private System.Windows.Forms.ListBox lstMetodos;
        private System.Windows.Forms.Button btnActualizaPesca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoPesca;
    }
}