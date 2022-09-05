namespace Laberinto
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
            this.pB = new System.Windows.Forms.PictureBox();
            this.btlaberinto = new System.Windows.Forms.Button();
            this.btsolucion = new System.Windows.Forms.Button();
            this.lvcolas = new System.Windows.Forms.ListView();
            this.lbcola = new System.Windows.Forms.Label();
            this.lbpila = new System.Windows.Forms.Label();
            this.lvpila = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // pB
            // 
            this.pB.Location = new System.Drawing.Point(12, 12);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(591, 629);
            this.pB.TabIndex = 0;
            this.pB.TabStop = false;
            // 
            // btlaberinto
            // 
            this.btlaberinto.Location = new System.Drawing.Point(51, 647);
            this.btlaberinto.Name = "btlaberinto";
            this.btlaberinto.Size = new System.Drawing.Size(75, 36);
            this.btlaberinto.TabIndex = 1;
            this.btlaberinto.Text = "Genera Laberinto";
            this.btlaberinto.UseVisualStyleBackColor = true;
            this.btlaberinto.Click += new System.EventHandler(this.btlaberinto_Click);
            // 
            // btsolucion
            // 
            this.btsolucion.Location = new System.Drawing.Point(278, 654);
            this.btsolucion.Name = "btsolucion";
            this.btsolucion.Size = new System.Drawing.Size(75, 23);
            this.btsolucion.TabIndex = 2;
            this.btsolucion.Text = "Solución";
            this.btsolucion.UseVisualStyleBackColor = true;
            this.btsolucion.Click += new System.EventHandler(this.btsolucion_Click);
            // 
            // lvcolas
            // 
            this.lvcolas.HideSelection = false;
            this.lvcolas.Location = new System.Drawing.Point(634, 49);
            this.lvcolas.Name = "lvcolas";
            this.lvcolas.Size = new System.Drawing.Size(154, 284);
            this.lvcolas.TabIndex = 5;
            this.lvcolas.UseCompatibleStateImageBehavior = false;
            // 
            // lbcola
            // 
            this.lbcola.AutoSize = true;
            this.lbcola.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcola.Location = new System.Drawing.Point(631, 22);
            this.lbcola.Name = "lbcola";
            this.lbcola.Size = new System.Drawing.Size(49, 23);
            this.lbcola.TabIndex = 6;
            this.lbcola.Text = "COLA";
            // 
            // lbpila
            // 
            this.lbpila.AutoSize = true;
            this.lbpila.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpila.Location = new System.Drawing.Point(631, 349);
            this.lbpila.Name = "lbpila";
            this.lbpila.Size = new System.Drawing.Size(43, 23);
            this.lbpila.TabIndex = 7;
            this.lbpila.Text = "PILA";
            // 
            // lvpila
            // 
            this.lvpila.HideSelection = false;
            this.lvpila.Location = new System.Drawing.Point(634, 375);
            this.lvpila.Name = "lvpila";
            this.lvpila.Size = new System.Drawing.Size(154, 284);
            this.lvpila.TabIndex = 8;
            this.lvpila.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.lvpila);
            this.Controls.Add(this.lbpila);
            this.Controls.Add(this.lbcola);
            this.Controls.Add(this.lvcolas);
            this.Controls.Add(this.btsolucion);
            this.Controls.Add(this.btlaberinto);
            this.Controls.Add(this.pB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.Button btlaberinto;
        private System.Windows.Forms.Button btsolucion;
        private System.Windows.Forms.ListView lvcolas;
        private System.Windows.Forms.Label lbcola;
        private System.Windows.Forms.Label lbpila;
        private System.Windows.Forms.ListView lvpila;
    }
}

