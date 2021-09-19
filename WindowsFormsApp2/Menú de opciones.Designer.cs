
namespace WindowsFormsApp2
{
    partial class Menú
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btCerrar = new System.Windows.Forms.Button();
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.btEleccion = new System.Windows.Forms.Button();
            this.btLlamar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Red;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(606, 174);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblResultado.Visible = false;
            // 
            // btCerrar
            // 
            this.btCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.ForeColor = System.Drawing.Color.Red;
            this.btCerrar.Location = new System.Drawing.Point(441, 239);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(91, 34);
            this.btCerrar.TabIndex = 2;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btEleccion_Click);
            // 
            // txtOpcion
            // 
            this.txtOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcion.Location = new System.Drawing.Point(306, 85);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(152, 38);
            this.txtOpcion.TabIndex = 3;
            this.txtOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpcion.TextChanged += new System.EventHandler(this.txtOpcion_TextChanged);
            // 
            // btEleccion
            // 
            this.btEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEleccion.Location = new System.Drawing.Point(213, 239);
            this.btEleccion.Name = "btEleccion";
            this.btEleccion.Size = new System.Drawing.Size(110, 34);
            this.btEleccion.TabIndex = 6;
            this.btEleccion.Text = "Elección";
            this.btEleccion.UseVisualStyleBackColor = true;
            this.btEleccion.Click += new System.EventHandler(this.btEleccion_Click_1);
            // 
            // btLlamar
            // 
            this.btLlamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLlamar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btLlamar.Location = new System.Drawing.Point(317, 341);
            this.btLlamar.Name = "btLlamar";
            this.btLlamar.Size = new System.Drawing.Size(110, 34);
            this.btLlamar.TabIndex = 7;
            this.btLlamar.Text = "Llamar";
            this.btLlamar.UseVisualStyleBackColor = true;
            this.btLlamar.Click += new System.EventHandler(this.btLlamar_Click);
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLlamar);
            this.Controls.Add(this.btEleccion);
            this.Controls.Add(this.txtOpcion);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.lblResultado);
            this.Name = "Menú";
            this.Text = "Menú de opciones";
            this.Load += new System.EventHandler(this.Menú_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.Button btEleccion;
        private System.Windows.Forms.Button btLlamar;
    }
}

