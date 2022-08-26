namespace Practica1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBecu = new System.Windows.Forms.TextBox();
            this.tBx = new System.Windows.Forms.TextBox();
            this.btcalc = new System.Windows.Forms.Button();
            this.btborrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 100);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(308, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ecuación de Primer Grado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ecuación :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "x =";
            // 
            // tBecu
            // 
            this.tBecu.Location = new System.Drawing.Point(326, 223);
            this.tBecu.Name = "tBecu";
            this.tBecu.Size = new System.Drawing.Size(208, 20);
            this.tBecu.TabIndex = 3;
            this.tBecu.Text = "0";
            this.tBecu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBx
            // 
            this.tBx.Location = new System.Drawing.Point(326, 273);
            this.tBx.Name = "tBx";
            this.tBx.ReadOnly = true;
            this.tBx.Size = new System.Drawing.Size(208, 20);
            this.tBx.TabIndex = 4;
            this.tBx.Text = "0";
            this.tBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btcalc
            // 
            this.btcalc.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalc.Location = new System.Drawing.Point(530, 330);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(75, 32);
            this.btcalc.TabIndex = 5;
            this.btcalc.Text = "Calcular";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.btcalc_Click);
            // 
            // btborrar
            // 
            this.btborrar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btborrar.Location = new System.Drawing.Point(251, 330);
            this.btborrar.Name = "btborrar";
            this.btborrar.Size = new System.Drawing.Size(114, 32);
            this.btborrar.TabIndex = 6;
            this.btborrar.Text = "Borrar Datos";
            this.btborrar.UseVisualStyleBackColor = true;
            this.btborrar.Click += new System.EventHandler(this.btborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btborrar);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.tBx);
            this.Controls.Add(this.tBecu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ecuación de Primer Grado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBecu;
        private System.Windows.Forms.TextBox tBx;
        private System.Windows.Forms.Button btcalc;
        private System.Windows.Forms.Button btborrar;
    }
}

