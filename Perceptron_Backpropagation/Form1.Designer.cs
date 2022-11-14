namespace Perceptron_Backpropagation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tberror = new System.Windows.Forms.TextBox();
            this.tbepocas = new System.Windows.Forms.TextBox();
            this.tbalpha = new System.Windows.Forms.TextBox();
            this.dgvcapsocul = new System.Windows.Forms.DataGridView();
            this.capa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neuronas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcrear = new System.Windows.Forms.TextBox();
            this.btcrear = new System.Windows.Forms.Button();
            this.cbproblema = new System.Windows.Forms.ComboBox();
            this.btback = new System.Windows.Forms.Button();
            this.btlimpia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbres = new System.Windows.Forms.ListBox();
            this.dgverdad = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcapsocul)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgverdad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tberror);
            this.groupBox1.Controls.Add(this.tbepocas);
            this.groupBox1.Controls.Add(this.tbalpha);
            this.groupBox1.Controls.Add(this.dgvcapsocul);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbcrear);
            this.groupBox1.Controls.Add(this.btcrear);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Red Neuronal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Error:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Epocas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Razón de Aprendizaje:";
            // 
            // tberror
            // 
            this.tberror.Location = new System.Drawing.Point(262, 266);
            this.tberror.Name = "tberror";
            this.tberror.Size = new System.Drawing.Size(100, 22);
            this.tberror.TabIndex = 6;
            this.tberror.Text = "0.01";
            this.tberror.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbepocas
            // 
            this.tbepocas.Location = new System.Drawing.Point(75, 266);
            this.tbepocas.Name = "tbepocas";
            this.tbepocas.Size = new System.Drawing.Size(100, 22);
            this.tbepocas.TabIndex = 5;
            this.tbepocas.Text = "5000";
            this.tbepocas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbalpha
            // 
            this.tbalpha.Location = new System.Drawing.Point(181, 230);
            this.tbalpha.Name = "tbalpha";
            this.tbalpha.Size = new System.Drawing.Size(100, 22);
            this.tbalpha.TabIndex = 4;
            this.tbalpha.Text = "0.98";
            this.tbalpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvcapsocul
            // 
            this.dgvcapsocul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcapsocul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.capa,
            this.neuronas});
            this.dgvcapsocul.Location = new System.Drawing.Point(66, 69);
            this.dgvcapsocul.Name = "dgvcapsocul";
            this.dgvcapsocul.Size = new System.Drawing.Size(243, 150);
            this.dgvcapsocul.TabIndex = 3;
            // 
            // capa
            // 
            this.capa.HeaderText = "Capa Oculta";
            this.capa.Name = "capa";
            // 
            // neuronas
            // 
            this.neuronas.HeaderText = "Neuronas por Capa";
            this.neuronas.Name = "neuronas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. de Capas Ocultas";
            // 
            // tbcrear
            // 
            this.tbcrear.Location = new System.Drawing.Point(158, 32);
            this.tbcrear.Name = "tbcrear";
            this.tbcrear.Size = new System.Drawing.Size(123, 22);
            this.tbcrear.TabIndex = 1;
            this.tbcrear.Text = "2";
            this.tbcrear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btcrear
            // 
            this.btcrear.Location = new System.Drawing.Point(287, 31);
            this.btcrear.Name = "btcrear";
            this.btcrear.Size = new System.Drawing.Size(75, 23);
            this.btcrear.TabIndex = 0;
            this.btcrear.Text = "Crear";
            this.btcrear.UseVisualStyleBackColor = true;
            this.btcrear.Click += new System.EventHandler(this.btcrear_Click);
            // 
            // cbproblema
            // 
            this.cbproblema.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbproblema.FormattingEnabled = true;
            this.cbproblema.Items.AddRange(new object[] {
            "AND",
            "OR",
            "XOR",
            "Mayoría-Simple",
            "Paridad",
            "Ejercicio"});
            this.cbproblema.Location = new System.Drawing.Point(51, 343);
            this.cbproblema.Name = "cbproblema";
            this.cbproblema.Size = new System.Drawing.Size(138, 22);
            this.cbproblema.TabIndex = 1;
            // 
            // btback
            // 
            this.btback.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btback.Location = new System.Drawing.Point(251, 343);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(123, 23);
            this.btback.TabIndex = 7;
            this.btback.Text = "Backpropagation";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btlimpia
            // 
            this.btlimpia.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpia.Location = new System.Drawing.Point(420, 343);
            this.btlimpia.Name = "btlimpia";
            this.btlimpia.Size = new System.Drawing.Size(75, 23);
            this.btlimpia.TabIndex = 8;
            this.btlimpia.Text = "Limpia";
            this.btlimpia.UseVisualStyleBackColor = true;
            this.btlimpia.Click += new System.EventHandler(this.btlimpia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbres);
            this.groupBox2.Controls.Add(this.dgverdad);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(409, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 302);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // lbres
            // 
            this.lbres.FormattingEnabled = true;
            this.lbres.ItemHeight = 14;
            this.lbres.Items.AddRange(new object[] {
            " "});
            this.lbres.Location = new System.Drawing.Point(432, 31);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(152, 242);
            this.lbres.TabIndex = 1;
            // 
            // dgverdad
            // 
            this.dgverdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgverdad.Location = new System.Drawing.Point(11, 30);
            this.dgverdad.Name = "dgverdad";
            this.dgverdad.Size = new System.Drawing.Size(415, 257);
            this.dgverdad.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Problema a Resolver:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btlimpia);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.cbproblema);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Backpropagation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcapsocul)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgverdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tberror;
        private System.Windows.Forms.TextBox tbepocas;
        private System.Windows.Forms.TextBox tbalpha;
        private System.Windows.Forms.DataGridView dgvcapsocul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcrear;
        private System.Windows.Forms.Button btcrear;
        private System.Windows.Forms.ComboBox cbproblema;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btlimpia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbres;
        private System.Windows.Forms.DataGridView dgverdad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn capa;
        private System.Windows.Forms.DataGridViewTextBoxColumn neuronas;
    }
}

