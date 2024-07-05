namespace ExampleSatelite.Sage50.Visual.Forms
{
    partial class frmArticulo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSQL = new System.Windows.Forms.Label();
            this.cmdRefrescar = new System.Windows.Forms.Button();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.lblWhere = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTarifas = new System.Windows.Forms.DataGridView();
            this.spnUltimoCoste = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomMarca = new System.Windows.Forms.Label();
            this.lblNomSubFamilia = new System.Windows.Forms.Label();
            this.lblNomFamilia = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnUltimoCoste)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(678, 362);
            this.dataGridView1.TabIndex = 22;
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Location = new System.Drawing.Point(18, 78);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(16, 13);
            this.lblSQL.TabIndex = 21;
            this.lblSQL.Text = "...";
            // 
            // cmdRefrescar
            // 
            this.cmdRefrescar.Location = new System.Drawing.Point(604, 12);
            this.cmdRefrescar.Name = "cmdRefrescar";
            this.cmdRefrescar.Size = new System.Drawing.Size(92, 23);
            this.cmdRefrescar.TabIndex = 2;
            this.cmdRefrescar.Text = "Refrescar";
            this.cmdRefrescar.UseVisualStyleBackColor = true;
            this.cmdRefrescar.Click += new System.EventHandler(this.cmdRefrescar_Click);
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(92, 47);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(491, 20);
            this.txtWhere.TabIndex = 20;
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.Location = new System.Drawing.Point(15, 50);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(67, 13);
            this.lblWhere.TabIndex = 19;
            this.lblWhere.Text = "Filtrar código";
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(66, 14);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(517, 20);
            this.txtSelect.TabIndex = 18;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(15, 17);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(45, 13);
            this.lblSelect.TabIndex = 17;
            this.lblSelect.Text = "Campos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(642, 157);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 34;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnFichaCancelar
            // 
            this.btnFichaCancelar.Location = new System.Drawing.Point(642, 71);
            this.btnFichaCancelar.Name = "btnFichaCancelar";
            this.btnFichaCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaCancelar.TabIndex = 15;
            this.btnFichaCancelar.Text = "Cancelar";
            this.btnFichaCancelar.UseVisualStyleBackColor = true;
            this.btnFichaCancelar.Click += new System.EventHandler(this.btnFichaCancelar_Click);
            // 
            // btnFichaEditarAceptar
            // 
            this.btnFichaEditarAceptar.Location = new System.Drawing.Point(642, 42);
            this.btnFichaEditarAceptar.Name = "btnFichaEditarAceptar";
            this.btnFichaEditarAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaEditarAceptar.TabIndex = 14;
            this.btnFichaEditarAceptar.Text = "Editar";
            this.btnFichaEditarAceptar.UseVisualStyleBackColor = true;
            this.btnFichaEditarAceptar.Click += new System.EventHandler(this.btnFichaEditarAceptar_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(98, 152);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo Iva";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(98, 123);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(57, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marca";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(98, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subfamilia";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(57, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Familia";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(467, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ARTICULO";
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 507);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSQL);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.lblSelect);
            this.tabPage1.Controls.Add(this.txtSelect);
            this.tabPage1.Controls.Add(this.cmdRefrescar);
            this.tabPage1.Controls.Add(this.lblWhere);
            this.tabPage1.Controls.Add(this.txtWhere);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabla Artículo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dataGridViewStock);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridViewTarifas);
            this.tabPage2.Controls.Add(this.spnUltimoCoste);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblNomMarca);
            this.tabPage2.Controls.Add(this.lblNomSubFamilia);
            this.tabPage2.Controls.Add(this.lblNomFamilia);
            this.tabPage2.Controls.Add(this.btnBorrar);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnFichaCancelar);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.btnFichaEditarAceptar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ficha Artículo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Stocks";
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(41, 351);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.ReadOnly = true;
            this.dataGridViewStock.Size = new System.Drawing.Size(606, 121);
            this.dataGridViewStock.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tarifas";
            // 
            // dataGridViewTarifas
            // 
            this.dataGridViewTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarifas.Location = new System.Drawing.Point(41, 208);
            this.dataGridViewTarifas.Name = "dataGridViewTarifas";
            this.dataGridViewTarifas.ReadOnly = true;
            this.dataGridViewTarifas.Size = new System.Drawing.Size(606, 121);
            this.dataGridViewTarifas.TabIndex = 40;
            // 
            // spnUltimoCoste
            // 
            this.spnUltimoCoste.DecimalPlaces = 2;
            this.spnUltimoCoste.Enabled = false;
            this.spnUltimoCoste.Location = new System.Drawing.Point(244, 154);
            this.spnUltimoCoste.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.spnUltimoCoste.Minimum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            -2147483648});
            this.spnUltimoCoste.Name = "spnUltimoCoste";
            this.spnUltimoCoste.Size = new System.Drawing.Size(146, 20);
            this.spnUltimoCoste.TabIndex = 39;
            this.spnUltimoCoste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Último coste";
            // 
            // lblNomMarca
            // 
            this.lblNomMarca.AutoSize = true;
            this.lblNomMarca.Location = new System.Drawing.Point(165, 126);
            this.lblNomMarca.Name = "lblNomMarca";
            this.lblNomMarca.Size = new System.Drawing.Size(77, 13);
            this.lblNomMarca.TabIndex = 37;
            this.lblNomMarca.Text = "Nombre Marca";
            // 
            // lblNomSubFamilia
            // 
            this.lblNomSubFamilia.AutoSize = true;
            this.lblNomSubFamilia.Location = new System.Drawing.Point(165, 100);
            this.lblNomSubFamilia.Name = "lblNomSubFamilia";
            this.lblNomSubFamilia.Size = new System.Drawing.Size(98, 13);
            this.lblNomSubFamilia.TabIndex = 36;
            this.lblNomSubFamilia.Text = "Nombre SubFamilia";
            // 
            // lblNomFamilia
            // 
            this.lblNomFamilia.AutoSize = true;
            this.lblNomFamilia.Location = new System.Drawing.Point(165, 75);
            this.lblNomFamilia.Name = "lblNomFamilia";
            this.lblNomFamilia.Size = new System.Drawing.Size(79, 13);
            this.lblNomFamilia.TabIndex = 35;
            this.lblNomFamilia.Text = "Nombre Familia";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(777, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 42);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 524);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnUltimoCoste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button cmdRefrescar;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomMarca;
        private System.Windows.Forms.Label lblNomSubFamilia;
        private System.Windows.Forms.Label lblNomFamilia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewTarifas;
        private System.Windows.Forms.NumericUpDown spnUltimoCoste;
    }
}