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
            this.lbcolas = new System.Windows.Forms.ListBox();
            this.lbpilas = new System.Windows.Forms.ListBox();
            this.lvcolas = new System.Windows.Forms.ListView();
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
            // lbcolas
            // 
            this.lbcolas.FormattingEnabled = true;
            this.lbcolas.Items.AddRange(new object[] {
            " "});
            this.lbcolas.Location = new System.Drawing.Point(634, 366);
            this.lbcolas.Name = "lbcolas";
            this.lbcolas.Size = new System.Drawing.Size(154, 147);
            this.lbcolas.TabIndex = 3;
            this.lbcolas.UseTabStops = false;
            // 
            // lbpilas
            // 
            this.lbpilas.FormattingEnabled = true;
            this.lbpilas.Items.AddRange(new object[] {
            " "});
            this.lbpilas.Location = new System.Drawing.Point(634, 533);
            this.lbpilas.Name = "lbpilas";
            this.lbpilas.Size = new System.Drawing.Size(154, 108);
            this.lbpilas.TabIndex = 4;
            // 
            // lvcolas
            // 
            this.lvcolas.HideSelection = false;
            this.lvcolas.Location = new System.Drawing.Point(634, 26);
            this.lvcolas.Name = "lvcolas";
            this.lvcolas.Size = new System.Drawing.Size(154, 300);
            this.lvcolas.TabIndex = 5;
            this.lvcolas.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.lvcolas);
            this.Controls.Add(this.lbpilas);
            this.Controls.Add(this.lbcolas);
            this.Controls.Add(this.btsolucion);
            this.Controls.Add(this.btlaberinto);
            this.Controls.Add(this.pB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.Button btlaberinto;
        private System.Windows.Forms.Button btsolucion;
        private System.Windows.Forms.ListBox lbcolas;
        private System.Windows.Forms.ListBox lbpilas;
        private System.Windows.Forms.ListView lvcolas;
    }
}

