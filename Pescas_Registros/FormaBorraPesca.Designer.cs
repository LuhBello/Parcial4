namespace Pesca_Registros
{
    partial class FormaBorraPesca
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
            this.pbxBotonCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoPesca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstInfoPescas = new System.Windows.Forms.ListBox();
            this.btnBorraPesca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Text = "Borrar Pesca existente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoPesca
            // 
            this.txtCodigoPesca.BackColor = System.Drawing.Color.Azure;
            this.txtCodigoPesca.Enabled = false;
            this.txtCodigoPesca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPesca.Location = new System.Drawing.Point(456, 142);
            this.txtCodigoPesca.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPesca.Name = "txtCodigoPesca";
            this.txtCodigoPesca.Size = new System.Drawing.Size(76, 26);
            this.txtCodigoPesca.TabIndex = 57;
            this.txtCodigoPesca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(232, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Código siembra seleccionada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Pesca:";
            // 
            // lstInfoPescas
            // 
            this.lstInfoPescas.BackColor = System.Drawing.Color.Honeydew;
            this.lstInfoPescas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInfoPescas.FormattingEnabled = true;
            this.lstInfoPescas.ItemHeight = 20;
            this.lstInfoPescas.Location = new System.Drawing.Point(142, 60);
            this.lstInfoPescas.Margin = new System.Windows.Forms.Padding(2);
            this.lstInfoPescas.Name = "lstInfoPescas";
            this.lstInfoPescas.Size = new System.Drawing.Size(626, 64);
            this.lstInfoPescas.TabIndex = 54;
            this.lstInfoPescas.SelectedIndexChanged += new System.EventHandler(this.lstInfoPescas_SelectedIndexChanged);
            // 
            // btnBorraPesca
            // 
            this.btnBorraPesca.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBorraPesca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBorraPesca.ForeColor = System.Drawing.Color.LightCyan;
            this.btnBorraPesca.Location = new System.Drawing.Point(311, 282);
            this.btnBorraPesca.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorraPesca.Name = "btnBorraPesca";
            this.btnBorraPesca.Size = new System.Drawing.Size(224, 32);
            this.btnBorraPesca.TabIndex = 59;
            this.btnBorraPesca.Text = "Borrar esta siembra";
            this.btnBorraPesca.UseVisualStyleBackColor = false;
            this.btnBorraPesca.Click += new System.EventHandler(this.btnBorraPesca_Click);
            // 
            // FormaBorraPesca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(849, 572);
            this.Controls.Add(this.btnBorraPesca);
            this.Controls.Add(this.txtCodigoPesca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstInfoPescas);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaBorraPesca";
            this.Text = "FormaBorraPesca";
            this.Load += new System.EventHandler(this.FormaBorraPesca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoPesca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstInfoPescas;
        private System.Windows.Forms.Button btnBorraPesca;
    }
}