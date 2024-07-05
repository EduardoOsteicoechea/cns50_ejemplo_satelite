namespace ExampleSatelite.Sage50.Visual.Forms
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDatosCliente = new System.Windows.Forms.Button();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSQL = new System.Windows.Forms.Label();
            this.cmdRefrescar = new System.Windows.Forms.Button();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.lblWhere = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnFichaCliente = new System.Windows.Forms.Button();
            this.panelFicha = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.spnLimiteCredito = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFichaCancelar = new System.Windows.Forms.Button();
            this.btnFichaEditarAceptar = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFicha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnLimiteCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatosCliente
            // 
            this.btnDatosCliente.Location = new System.Drawing.Point(12, 24);
            this.btnDatosCliente.Name = "btnDatosCliente";
            this.btnDatosCliente.Size = new System.Drawing.Size(115, 38);
            this.btnDatosCliente.TabIndex = 0;
            this.btnDatosCliente.Text = "Ver Tabla Cliente";
            this.btnDatosCliente.UseVisualStyleBackColor = true;
            this.btnDatosCliente.Click += new System.EventHandler(this.btnDatosCliente_Click);
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.dataGridView1);
            this.panelTabla.Controls.Add(this.lblSQL);
            this.panelTabla.Controls.Add(this.cmdRefrescar);
            this.panelTabla.Controls.Add(this.txtWhere);
            this.panelTabla.Controls.Add(this.lblWhere);
            this.panelTabla.Controls.Add(this.txtSelect);
            this.panelTabla.Controls.Add(this.lblSelect);
            this.panelTabla.Location = new System.Drawing.Point(192, 510);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(718, 507);
            this.panelTabla.TabIndex = 1;
            this.panelTabla.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 362);
            this.dataGridView1.TabIndex = 22;
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Location = new System.Drawing.Point(29, 463);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(16, 13);
            this.lblSQL.TabIndex = 21;
            this.lblSQL.Text = "...";
            // 
            // cmdRefrescar
            // 
            this.cmdRefrescar.Location = new System.Drawing.Point(602, 12);
            this.cmdRefrescar.Name = "cmdRefrescar";
            this.cmdRefrescar.Size = new System.Drawing.Size(92, 23);
            this.cmdRefrescar.TabIndex = 2;
            this.cmdRefrescar.Text = "Refrescar";
            this.cmdRefrescar.UseVisualStyleBackColor = true;
            this.cmdRefrescar.Click += new System.EventHandler(this.cmdRefrescar_Click);
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(90, 47);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(491, 20);
            this.txtWhere.TabIndex = 20;
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.Location = new System.Drawing.Point(13, 50);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(54, 13);
            this.lblWhere.TabIndex = 19;
            this.lblWhere.Text = "Condición";
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(64, 14);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(517, 20);
            this.txtSelect.TabIndex = 18;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(13, 17);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(45, 13);
            this.lblSelect.TabIndex = 17;
            this.lblSelect.Text = "Campos";
            // 
            // btnFichaCliente
            // 
            this.btnFichaCliente.Location = new System.Drawing.Point(12, 78);
            this.btnFichaCliente.Name = "btnFichaCliente";
            this.btnFichaCliente.Size = new System.Drawing.Size(115, 38);
            this.btnFichaCliente.TabIndex = 2;
            this.btnFichaCliente.Text = "Ver Ficha Cliente";
            this.btnFichaCliente.UseVisualStyleBackColor = true;
            this.btnFichaCliente.Click += new System.EventHandler(this.btnFichaCliente_Click);
            // 
            // panelFicha
            // 
            this.panelFicha.Controls.Add(this.btnBorrar);
            this.panelFicha.Controls.Add(this.textBox7);
            this.panelFicha.Controls.Add(this.label9);
            this.panelFicha.Controls.Add(this.spnLimiteCredito);
            this.panelFicha.Controls.Add(this.label8);
            this.panelFicha.Controls.Add(this.btnFichaCancelar);
            this.panelFicha.Controls.Add(this.btnFichaEditarAceptar);
            this.panelFicha.Controls.Add(this.textBox6);
            this.panelFicha.Controls.Add(this.label7);
            this.panelFicha.Controls.Add(this.textBox5);
            this.panelFicha.Controls.Add(this.label6);
            this.panelFicha.Controls.Add(this.textBox4);
            this.panelFicha.Controls.Add(this.label5);
            this.panelFicha.Controls.Add(this.textBox3);
            this.panelFicha.Controls.Add(this.label4);
            this.panelFicha.Controls.Add(this.label1);
            this.panelFicha.Controls.Add(this.textBox2);
            this.panelFicha.Controls.Add(this.label2);
            this.panelFicha.Controls.Add(this.textBox1);
            this.panelFicha.Controls.Add(this.label3);
            this.panelFicha.Location = new System.Drawing.Point(145, 17);
            this.panelFicha.Name = "panelFicha";
            this.panelFicha.Size = new System.Drawing.Size(718, 507);
            this.panelFicha.TabIndex = 23;
            this.panelFicha.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(265, 14);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(135, 20);
            this.textBox7.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "NIF";
            // 
            // spnLimiteCredito
            // 
            this.spnLimiteCredito.DecimalPlaces = 2;
            this.spnLimiteCredito.Enabled = false;
            this.spnLimiteCredito.Location = new System.Drawing.Point(240, 151);
            this.spnLimiteCredito.Name = "spnLimiteCredito";
            this.spnLimiteCredito.Size = new System.Drawing.Size(146, 20);
            this.spnLimiteCredito.TabIndex = 33;
            this.spnLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Limite Crédito";
            // 
            // btnFichaCancelar
            // 
            this.btnFichaCancelar.Location = new System.Drawing.Point(623, 67);
            this.btnFichaCancelar.Name = "btnFichaCancelar";
            this.btnFichaCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaCancelar.TabIndex = 15;
            this.btnFichaCancelar.Text = "Cancelar";
            this.btnFichaCancelar.UseVisualStyleBackColor = true;
            this.btnFichaCancelar.Click += new System.EventHandler(this.btnFichaCancelar_Click);
            // 
            // btnFichaEditarAceptar
            // 
            this.btnFichaEditarAceptar.Location = new System.Drawing.Point(623, 38);
            this.btnFichaEditarAceptar.Name = "btnFichaEditarAceptar";
            this.btnFichaEditarAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaEditarAceptar.TabIndex = 14;
            this.btnFichaEditarAceptar.Text = "Editar";
            this.btnFichaEditarAceptar.UseVisualStyleBackColor = true;
            this.btnFichaEditarAceptar.Click += new System.EventHandler(this.btnFichaEditarAceptar_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(79, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo Iva";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cod.Postal";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(467, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "...";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(467, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "43000001";
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(623, 153);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 34;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 531);
            this.Controls.Add(this.panelFicha);
            this.Controls.Add(this.btnFichaCliente);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.btnDatosCliente);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.panelTabla.ResumeLayout(false);
            this.panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFicha.ResumeLayout(false);
            this.panelFicha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnLimiteCredito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatosCliente;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button cmdRefrescar;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFichaCliente;
        private System.Windows.Forms.Panel panelFicha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFichaCancelar;
        private System.Windows.Forms.Button btnFichaEditarAceptar;
        private System.Windows.Forms.NumericUpDown spnLimiteCredito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBorrar;
    }
}