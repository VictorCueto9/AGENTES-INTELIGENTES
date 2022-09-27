namespace Neurona
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
            this.dgvverdad = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bttabla = new System.Windows.Forms.Button();
            this.tbentradas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvpesos = new System.Windows.Forms.DataGridView();
            this.tbumbral = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btneurona = new System.Windows.Forms.Button();
            this.btlimpia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvverdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvverdad
            // 
            this.dgvverdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvverdad.Location = new System.Drawing.Point(48, 228);
            this.dgvverdad.Name = "dgvverdad";
            this.dgvverdad.Size = new System.Drawing.Size(468, 200);
            this.dgvverdad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. de Entradas";
            // 
            // bttabla
            // 
            this.bttabla.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttabla.Location = new System.Drawing.Point(75, 111);
            this.bttabla.Name = "bttabla";
            this.bttabla.Size = new System.Drawing.Size(76, 65);
            this.bttabla.TabIndex = 2;
            this.bttabla.Text = "Genera Tabla";
            this.bttabla.UseVisualStyleBackColor = true;
            this.bttabla.Click += new System.EventHandler(this.bttabla_Click);
            // 
            // tbentradas
            // 
            this.tbentradas.Location = new System.Drawing.Point(186, 68);
            this.tbentradas.Name = "tbentradas";
            this.tbentradas.Size = new System.Drawing.Size(64, 20);
            this.tbentradas.TabIndex = 3;
            this.tbentradas.Text = "0";
            this.tbentradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesos";
            // 
            // dgvpesos
            // 
            this.dgvpesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpesos.Location = new System.Drawing.Point(270, 45);
            this.dgvpesos.Name = "dgvpesos";
            this.dgvpesos.Size = new System.Drawing.Size(145, 131);
            this.dgvpesos.TabIndex = 5;
            // 
            // tbumbral
            // 
            this.tbumbral.Location = new System.Drawing.Point(439, 66);
            this.tbumbral.Name = "tbumbral";
            this.tbumbral.Size = new System.Drawing.Size(64, 20);
            this.tbumbral.TabIndex = 6;
            this.tbumbral.Text = "0";
            this.tbumbral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Umbral";
            // 
            // btneurona
            // 
            this.btneurona.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneurona.Location = new System.Drawing.Point(437, 111);
            this.btneurona.Name = "btneurona";
            this.btneurona.Size = new System.Drawing.Size(75, 42);
            this.btneurona.TabIndex = 8;
            this.btneurona.Text = "Neurona";
            this.btneurona.UseVisualStyleBackColor = true;
            this.btneurona.Click += new System.EventHandler(this.btneurona_Click);
            // 
            // btlimpia
            // 
            this.btlimpia.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpia.Location = new System.Drawing.Point(522, 364);
            this.btlimpia.Name = "btlimpia";
            this.btlimpia.Size = new System.Drawing.Size(75, 33);
            this.btlimpia.TabIndex = 9;
            this.btlimpia.Text = "Limpia";
            this.btlimpia.UseVisualStyleBackColor = true;
            this.btlimpia.Click += new System.EventHandler(this.btlimpia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tabla de Verdad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btlimpia);
            this.Controls.Add(this.btneurona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbumbral);
            this.Controls.Add(this.dgvpesos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbentradas);
            this.Controls.Add(this.bttabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvverdad);
            this.Name = "Form1";
            this.Text = "Neurona";
            ((System.ComponentModel.ISupportInitialize)(this.dgvverdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvverdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttabla;
        private System.Windows.Forms.TextBox tbentradas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvpesos;
        private System.Windows.Forms.TextBox tbumbral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btneurona;
        private System.Windows.Forms.Button btlimpia;
        private System.Windows.Forms.Label label4;
    }
}

