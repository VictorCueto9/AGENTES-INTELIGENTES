namespace Perceptron_Iris_Plant
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
            this.cbplants = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btperceptron = new System.Windows.Forms.Button();
            this.lbdatos = new System.Windows.Forms.ListBox();
            this.lbresultados = new System.Windows.Forms.ListBox();
            this.dgverdad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgverdad)).BeginInit();
            this.SuspendLayout();
            // 
            // cbplants
            // 
            this.cbplants.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbplants.FormattingEnabled = true;
            this.cbplants.Items.AddRange(new object[] {
            "Setosa-Versicolor",
            "Setosa-Virginica",
            "Versicolor-Virginica"});
            this.cbplants.Location = new System.Drawing.Point(13, 58);
            this.cbplants.Name = "cbplants";
            this.cbplants.Size = new System.Drawing.Size(143, 23);
            this.cbplants.TabIndex = 0;
            this.cbplants.SelectedIndexChanged += new System.EventHandler(this.cbplants_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elegir clases";
            // 
            // btperceptron
            // 
            this.btperceptron.BackColor = System.Drawing.Color.OliveDrab;
            this.btperceptron.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btperceptron.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btperceptron.Location = new System.Drawing.Point(16, 107);
            this.btperceptron.Name = "btperceptron";
            this.btperceptron.Size = new System.Drawing.Size(113, 65);
            this.btperceptron.TabIndex = 2;
            this.btperceptron.Text = "Perceptrón";
            this.btperceptron.UseVisualStyleBackColor = false;
            this.btperceptron.Click += new System.EventHandler(this.btperceptron_Click);
            // 
            // lbdatos
            // 
            this.lbdatos.FormattingEnabled = true;
            this.lbdatos.Items.AddRange(new object[] {
            " "});
            this.lbdatos.Location = new System.Drawing.Point(162, 12);
            this.lbdatos.Name = "lbdatos";
            this.lbdatos.Size = new System.Drawing.Size(173, 342);
            this.lbdatos.TabIndex = 3;
            // 
            // lbresultados
            // 
            this.lbresultados.FormattingEnabled = true;
            this.lbresultados.Items.AddRange(new object[] {
            " "});
            this.lbresultados.Location = new System.Drawing.Point(341, 11);
            this.lbresultados.Name = "lbresultados";
            this.lbresultados.Size = new System.Drawing.Size(160, 342);
            this.lbresultados.TabIndex = 4;
            // 
            // dgverdad
            // 
            this.dgverdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgverdad.Location = new System.Drawing.Point(513, 12);
            this.dgverdad.Name = "dgverdad";
            this.dgverdad.Size = new System.Drawing.Size(501, 341);
            this.dgverdad.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 367);
            this.Controls.Add(this.dgverdad);
            this.Controls.Add(this.lbresultados);
            this.Controls.Add(this.lbdatos);
            this.Controls.Add(this.btperceptron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbplants);
            this.Name = "Form1";
            this.Text = "Perceptron Iris Plant";
            ((System.ComponentModel.ISupportInitialize)(this.dgverdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbplants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btperceptron;
        private System.Windows.Forms.ListBox lbdatos;
        private System.Windows.Forms.ListBox lbresultados;
        private System.Windows.Forms.DataGridView dgverdad;
    }
}

