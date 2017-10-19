namespace BibliotecaSerializacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mostrarBiblioteca = new System.Windows.Forms.Button();
            this.agregarLibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrarBiblioteca
            // 
            this.mostrarBiblioteca.Location = new System.Drawing.Point(125, 264);
            this.mostrarBiblioteca.Name = "mostrarBiblioteca";
            this.mostrarBiblioteca.Size = new System.Drawing.Size(117, 23);
            this.mostrarBiblioteca.TabIndex = 0;
            this.mostrarBiblioteca.Text = "Mostrar Biblioteca";
            this.mostrarBiblioteca.UseVisualStyleBackColor = true;
            this.mostrarBiblioteca.Click += new System.EventHandler(this.mostrarBiblioteca_Click);
            // 
            // agregarLibro
            // 
            this.agregarLibro.Location = new System.Drawing.Point(443, 264);
            this.agregarLibro.Name = "agregarLibro";
            this.agregarLibro.Size = new System.Drawing.Size(126, 23);
            this.agregarLibro.TabIndex = 1;
            this.agregarLibro.Text = "Agregar Libro";
            this.agregarLibro.UseVisualStyleBackColor = true;
            this.agregarLibro.Click += new System.EventHandler(this.agregarLibro_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 381);
            this.Controls.Add(this.agregarLibro);
            this.Controls.Add(this.mostrarBiblioteca);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mostrarBiblioteca;
        private System.Windows.Forms.Button agregarLibro;
    }
}

