namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantHijos = new System.Windows.Forms.TextBox();
            this.txtHs = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImpxhs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.txtImpxHijo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstSueldos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas trabajadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puesto";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre.Location = new System.Drawing.Point(58, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCantHijos
            // 
            this.txtCantHijos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCantHijos.Location = new System.Drawing.Point(58, 179);
            this.txtCantHijos.Name = "txtCantHijos";
            this.txtCantHijos.Size = new System.Drawing.Size(100, 20);
            this.txtCantHijos.TabIndex = 7;
            this.txtCantHijos.TextChanged += new System.EventHandler(this.txtCantHijos_TextChanged);
            this.txtCantHijos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantHijos_KeyPress);
            // 
            // txtHs
            // 
            this.txtHs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHs.Location = new System.Drawing.Point(253, 115);
            this.txtHs.Name = "txtHs";
            this.txtHs.Size = new System.Drawing.Size(100, 20);
            this.txtHs.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApellido.Location = new System.Drawing.Point(58, 115);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.txtImpxhs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboPuesto);
            this.groupBox1.Controls.Add(this.chkCasado);
            this.groupBox1.Controls.Add(this.txtImpxHijo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCuil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCantHijos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHs);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(117, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 238);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtImpxhs
            // 
            this.txtImpxhs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtImpxhs.Location = new System.Drawing.Point(434, 178);
            this.txtImpxhs.Name = "txtImpxhs";
            this.txtImpxhs.ReadOnly = true;
            this.txtImpxhs.Size = new System.Drawing.Size(100, 20);
            this.txtImpxhs.TabIndex = 19;
            this.txtImpxhs.TextChanged += new System.EventHandler(this.txtImpxhs_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "importe por hora";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cboPuesto
            // 
            this.cboPuesto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(253, 177);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(109, 21);
            this.cboPuesto.TabIndex = 17;
            this.cboPuesto.SelectedIndexChanged += new System.EventHandler(this.cboPuesto_SelectedIndexChanged);
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCasado.Location = new System.Drawing.Point(434, 115);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(116, 20);
            this.chkCasado.TabIndex = 16;
            this.chkCasado.Text = "¿Esta casado?";
            this.chkCasado.UseVisualStyleBackColor = true;
            this.chkCasado.CheckedChanged += new System.EventHandler(this.chkCasado_CheckedChanged);
            // 
            // txtImpxHijo
            // 
            this.txtImpxHijo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtImpxHijo.Location = new System.Drawing.Point(434, 51);
            this.txtImpxHijo.Name = "txtImpxHijo";
            this.txtImpxHijo.ReadOnly = true;
            this.txtImpxHijo.Size = new System.Drawing.Size(100, 20);
            this.txtImpxHijo.TabIndex = 15;
            this.txtImpxHijo.TextChanged += new System.EventHandler(this.txtImpxHijo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Importe por hijos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "CUIL";
            // 
            // txtCuil
            // 
            this.txtCuil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCuil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCuil.Location = new System.Drawing.Point(253, 51);
            this.txtCuil.MaxLength = 2;
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(100, 20);
            this.txtCuil.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad de hijos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(222, 289);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 36);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(724, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 44);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(448, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 36);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstSueldos
            // 
            this.lstSueldos.FormattingEnabled = true;
            this.lstSueldos.Location = new System.Drawing.Point(126, 348);
            this.lstSueldos.Name = "lstSueldos";
            this.lstSueldos.Size = new System.Drawing.Size(592, 121);
            this.lstSueldos.TabIndex = 15;
            this.lstSueldos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(823, 534);
            this.Controls.Add(this.lstSueldos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de sueldos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantHijos;
        private System.Windows.Forms.TextBox txtHs;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.TextBox txtImpxHijo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.ListBox lstSueldos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImpxhs;
    }
}

