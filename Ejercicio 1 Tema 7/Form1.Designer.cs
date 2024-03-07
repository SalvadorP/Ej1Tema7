namespace Ejercicio_1_Tema_7
{
    partial class Form1
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
            this.leerBtn = new System.Windows.Forms.Button();
            this.mostrarBtn = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leerBtn
            // 
            this.leerBtn.Location = new System.Drawing.Point(311, 72);
            this.leerBtn.Name = "leerBtn";
            this.leerBtn.Size = new System.Drawing.Size(159, 51);
            this.leerBtn.TabIndex = 0;
            this.leerBtn.Text = "Leer datos";
            this.leerBtn.UseVisualStyleBackColor = true;
            this.leerBtn.Click += new System.EventHandler(this.leerBtn_Click);
            // 
            // mostrarBtn
            // 
            this.mostrarBtn.Location = new System.Drawing.Point(311, 169);
            this.mostrarBtn.Name = "mostrarBtn";
            this.mostrarBtn.Size = new System.Drawing.Size(159, 49);
            this.mostrarBtn.TabIndex = 1;
            this.mostrarBtn.Text = "Mostrar datos";
            this.mostrarBtn.UseVisualStyleBackColor = true;
            this.mostrarBtn.Click += new System.EventHandler(this.mostrarBtn_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(311, 290);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(51, 20);
            this.resultadoLabel.TabIndex = 2;
            this.resultadoLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.mostrarBtn);
            this.Controls.Add(this.leerBtn);
            this.Name = "Form1";
            this.Text = "Ejercicio 1 Tema 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leerBtn;
        private System.Windows.Forms.Button mostrarBtn;
        private System.Windows.Forms.Label resultadoLabel;
    }
}

