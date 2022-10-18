namespace Perceptron
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
            this.cbproblema = new System.Windows.Forms.ComboBox();
            this.dgverdad = new System.Windows.Forms.DataGridView();
            this.btperceptron = new System.Windows.Forms.Button();
            this.lbresultados = new System.Windows.Forms.ListBox();
            this.btclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgverdad)).BeginInit();
            this.SuspendLayout();
            // 
            // cbproblema
            // 
            this.cbproblema.FormattingEnabled = true;
            this.cbproblema.Items.AddRange(new object[] {
            "AND",
            "OR",
            "XOR",
            "Mayoria Simple",
            "Paridad",
            "Ejercicio"});
            this.cbproblema.Location = new System.Drawing.Point(37, 44);
            this.cbproblema.Name = "cbproblema";
            this.cbproblema.Size = new System.Drawing.Size(121, 21);
            this.cbproblema.TabIndex = 0;
            this.cbproblema.SelectedIndexChanged += new System.EventHandler(this.cbproblema_SelectedIndexChanged);
            // 
            // dgverdad
            // 
            this.dgverdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgverdad.Location = new System.Drawing.Point(37, 118);
            this.dgverdad.Name = "dgverdad";
            this.dgverdad.Size = new System.Drawing.Size(510, 258);
            this.dgverdad.TabIndex = 1;
            // 
            // btperceptron
            // 
            this.btperceptron.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btperceptron.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btperceptron.Location = new System.Drawing.Point(437, 44);
            this.btperceptron.Name = "btperceptron";
            this.btperceptron.Size = new System.Drawing.Size(110, 29);
            this.btperceptron.TabIndex = 2;
            this.btperceptron.Text = "Perceptrón";
            this.btperceptron.UseVisualStyleBackColor = false;
            this.btperceptron.Click += new System.EventHandler(this.btperceptron_Click);
            // 
            // lbresultados
            // 
            this.lbresultados.FormattingEnabled = true;
            this.lbresultados.Items.AddRange(new object[] {
            " "});
            this.lbresultados.Location = new System.Drawing.Point(571, 44);
            this.lbresultados.Name = "lbresultados";
            this.lbresultados.Size = new System.Drawing.Size(169, 264);
            this.lbresultados.TabIndex = 3;
            // 
            // btclear
            // 
            this.btclear.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclear.Location = new System.Drawing.Point(627, 348);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(66, 28);
            this.btclear.TabIndex = 4;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Problema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabla de verdad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(614, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.lbresultados);
            this.Controls.Add(this.btperceptron);
            this.Controls.Add(this.dgverdad);
            this.Controls.Add(this.cbproblema);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgverdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbproblema;
        private System.Windows.Forms.DataGridView dgverdad;
        private System.Windows.Forms.Button btperceptron;
        private System.Windows.Forms.ListBox lbresultados;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

