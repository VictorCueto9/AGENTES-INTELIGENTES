namespace Perceptron_Multicapa
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
            this.rbxor = new System.Windows.Forms.RadioButton();
            this.rbejer = new System.Windows.Forms.RadioButton();
            this.dgverdad = new System.Windows.Forms.DataGridView();
            this.lbres = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgverdad)).BeginInit();
            this.SuspendLayout();
            // 
            // rbxor
            // 
            this.rbxor.AutoSize = true;
            this.rbxor.Checked = true;
            this.rbxor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbxor.Location = new System.Drawing.Point(12, 25);
            this.rbxor.Name = "rbxor";
            this.rbxor.Size = new System.Drawing.Size(54, 23);
            this.rbxor.TabIndex = 0;
            this.rbxor.TabStop = true;
            this.rbxor.Text = "XOR";
            this.rbxor.UseVisualStyleBackColor = true;
            // 
            // rbejer
            // 
            this.rbejer.AutoSize = true;
            this.rbejer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbejer.Location = new System.Drawing.Point(12, 59);
            this.rbejer.Name = "rbejer";
            this.rbejer.Size = new System.Drawing.Size(108, 23);
            this.rbejer.TabIndex = 1;
            this.rbejer.Text = "Ejercicio";
            this.rbejer.UseVisualStyleBackColor = true;
            // 
            // dgverdad
            // 
            this.dgverdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgverdad.Location = new System.Drawing.Point(12, 135);
            this.dgverdad.Name = "dgverdad";
            this.dgverdad.Size = new System.Drawing.Size(305, 154);
            this.dgverdad.TabIndex = 2;
            // 
            // lbres
            // 
            this.lbres.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbres.FormattingEnabled = true;
            this.lbres.ItemHeight = 14;
            this.lbres.Items.AddRange(new object[] {
            " "});
            this.lbres.Location = new System.Drawing.Point(323, 38);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(165, 256);
            this.lbres.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(126, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "FeedForward";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbres);
            this.Controls.Add(this.dgverdad);
            this.Controls.Add(this.rbejer);
            this.Controls.Add(this.rbxor);
            this.Name = "Form1";
            this.Text = "FeedForward";
            ((System.ComponentModel.ISupportInitialize)(this.dgverdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbxor;
        private System.Windows.Forms.RadioButton rbejer;
        private System.Windows.Forms.DataGridView dgverdad;
        private System.Windows.Forms.ListBox lbres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

