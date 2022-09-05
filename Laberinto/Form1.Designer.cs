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
            this.lbcola = new System.Windows.Forms.Label();
            this.lbpila = new System.Windows.Forms.Label();
            this.lb_cola = new System.Windows.Forms.ListBox();
            this.lb_pila = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // pB
            // 
            this.pB.Location = new System.Drawing.Point(12, 12);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(591, 581);
            this.pB.TabIndex = 0;
            this.pB.TabStop = false;
            // 
            // btlaberinto
            // 
            this.btlaberinto.Location = new System.Drawing.Point(54, 609);
            this.btlaberinto.Name = "btlaberinto";
            this.btlaberinto.Size = new System.Drawing.Size(75, 36);
            this.btlaberinto.TabIndex = 1;
            this.btlaberinto.Text = "Genera Laberinto";
            this.btlaberinto.UseVisualStyleBackColor = true;
            this.btlaberinto.Click += new System.EventHandler(this.btlaberinto_Click);
            // 
            // btsolucion
            // 
            this.btsolucion.Location = new System.Drawing.Point(279, 622);
            this.btsolucion.Name = "btsolucion";
            this.btsolucion.Size = new System.Drawing.Size(75, 23);
            this.btsolucion.TabIndex = 2;
            this.btsolucion.Text = "Solución";
            this.btsolucion.UseVisualStyleBackColor = true;
            this.btsolucion.Click += new System.EventHandler(this.btsolucion_Click);
            // 
            // lbcola
            // 
            this.lbcola.AutoSize = true;
            this.lbcola.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcola.Location = new System.Drawing.Point(609, 23);
            this.lbcola.Name = "lbcola";
            this.lbcola.Size = new System.Drawing.Size(49, 23);
            this.lbcola.TabIndex = 6;
            this.lbcola.Text = "COLA";
            // 
            // lbpila
            // 
            this.lbpila.AutoSize = true;
            this.lbpila.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpila.Location = new System.Drawing.Point(609, 342);
            this.lbpila.Name = "lbpila";
            this.lbpila.Size = new System.Drawing.Size(43, 23);
            this.lbpila.TabIndex = 7;
            this.lbpila.Text = "PILA";
            // 
            // lb_cola
            // 
            this.lb_cola.FormattingEnabled = true;
            this.lb_cola.HorizontalScrollbar = true;
            this.lb_cola.Items.AddRange(new object[] {
            " "});
            this.lb_cola.Location = new System.Drawing.Point(609, 49);
            this.lb_cola.Name = "lb_cola";
            this.lb_cola.Size = new System.Drawing.Size(179, 277);
            this.lb_cola.TabIndex = 8;
            // 
            // lb_pila
            // 
            this.lb_pila.FormattingEnabled = true;
            this.lb_pila.HorizontalScrollbar = true;
            this.lb_pila.Items.AddRange(new object[] {
            " "});
            this.lb_pila.Location = new System.Drawing.Point(609, 368);
            this.lb_pila.Name = "lb_pila";
            this.lb_pila.Size = new System.Drawing.Size(179, 277);
            this.lb_pila.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.lb_pila);
            this.Controls.Add(this.lb_cola);
            this.Controls.Add(this.lbpila);
            this.Controls.Add(this.lbcola);
            this.Controls.Add(this.btsolucion);
            this.Controls.Add(this.btlaberinto);
            this.Controls.Add(this.pB);
            this.Name = "Form1";
            this.Text = "Laberinto";
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.Button btlaberinto;
        private System.Windows.Forms.Button btsolucion;
        private System.Windows.Forms.Label lbcola;
        private System.Windows.Forms.Label lbpila;
        private System.Windows.Forms.ListBox lb_cola;
        private System.Windows.Forms.ListBox lb_pila;
    }
}

