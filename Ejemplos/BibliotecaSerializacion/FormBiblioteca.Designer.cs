namespace BibliotecaSerializacion
{
    partial class FormBiblioteca
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
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            this.Serializar = new System.Windows.Forms.Button();
            this.Deserializar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.Location = new System.Drawing.Point(13, 13);
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(423, 277);
            this.listBoxLibros.TabIndex = 0;
            // 
            // Serializar
            // 
            this.Serializar.Location = new System.Drawing.Point(96, 318);
            this.Serializar.Name = "Serializar";
            this.Serializar.Size = new System.Drawing.Size(75, 23);
            this.Serializar.TabIndex = 1;
            this.Serializar.Text = "Serializar";
            this.Serializar.UseVisualStyleBackColor = true;
            this.Serializar.Click += new System.EventHandler(this.Serializar_Click);
            // 
            // Deserializar
            // 
            this.Deserializar.Location = new System.Drawing.Point(305, 317);
            this.Deserializar.Name = "Deserializar";
            this.Deserializar.Size = new System.Drawing.Size(75, 23);
            this.Deserializar.TabIndex = 2;
            this.Deserializar.Text = "Deserializar";
            this.Deserializar.UseVisualStyleBackColor = true;
            this.Deserializar.Click += new System.EventHandler(this.Deserializar_Click);
            // 
            // FormBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 364);
            this.Controls.Add(this.Deserializar);
            this.Controls.Add(this.Serializar);
            this.Controls.Add(this.listBoxLibros);
            this.Name = "FormBiblioteca";
            this.Text = "FormGrilla";
            this.Load += new System.EventHandler(this.FormBiblioteca_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLibros;
        private System.Windows.Forms.Button Serializar;
        private System.Windows.Forms.Button Deserializar;
    }
}