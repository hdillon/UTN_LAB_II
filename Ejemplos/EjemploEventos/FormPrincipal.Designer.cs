namespace EjemploEventos
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
            this.btnManejadorClick = new System.Windows.Forms.Button();
            this.btnManejadorDobleClick = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnMouseHover = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManejadorClick
            // 
            this.btnManejadorClick.Location = new System.Drawing.Point(12, 114);
            this.btnManejadorClick.Name = "btnManejadorClick";
            this.btnManejadorClick.Size = new System.Drawing.Size(146, 23);
            this.btnManejadorClick.TabIndex = 0;
            this.btnManejadorClick.Text = "Manejador Click";
            this.btnManejadorClick.UseVisualStyleBackColor = true;
            // 
            // btnManejadorDobleClick
            // 
            this.btnManejadorDobleClick.Location = new System.Drawing.Point(166, 114);
            this.btnManejadorDobleClick.Name = "btnManejadorDobleClick";
            this.btnManejadorDobleClick.Size = new System.Drawing.Size(146, 23);
            this.btnManejadorDobleClick.TabIndex = 1;
            this.btnManejadorDobleClick.Text = "Manejador Doble Click";
            this.btnManejadorDobleClick.UseVisualStyleBackColor = true;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(166, 44);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(146, 20);
            this.txtTexto.TabIndex = 3;
            // 
            // btnMouseHover
            // 
            this.btnMouseHover.Location = new System.Drawing.Point(318, 114);
            this.btnMouseHover.Name = "btnMouseHover";
            this.btnMouseHover.Size = new System.Drawing.Size(146, 23);
            this.btnMouseHover.TabIndex = 4;
            this.btnMouseHover.Text = "Manejador Mouse Hover";
            this.btnMouseHover.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(166, 160);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(146, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover Manejadores";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 254);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnMouseHover);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnManejadorDobleClick);
            this.Controls.Add(this.btnManejadorClick);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManejadorClick;
        private System.Windows.Forms.Button btnManejadorDobleClick;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnMouseHover;
        private System.Windows.Forms.Button btnRemover;
    }
}

