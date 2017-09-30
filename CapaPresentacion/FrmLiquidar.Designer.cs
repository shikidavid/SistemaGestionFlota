namespace CapaPresentacion
{
    partial class FrmLiquidar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txtscaneo = new MetroFramework.Controls.MetroTextBox();
            this.checkescaneo = new MetroFramework.Controls.MetroCheckBox();
            this.txtnumero = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBoxTodo = new MetroFramework.Controls.MetroCheckBox();
            this.txtplaca = new MetroFramework.Controls.MetroTextBox();
            this.DtAsignacionCombustible = new System.Windows.Forms.DataGridView();
            this.DgSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtvueltas = new System.Windows.Forms.TextBox();
            this.txtcantidadconsumo = new System.Windows.Forms.TextBox();
            this.txtexcesoconsumo = new System.Windows.Forms.TextBox();
            this.txtkilometraje = new System.Windows.Forms.TextBox();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.txtobservacion = new MetroFramework.Controls.MetroTextBox();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtAsignacionCombustible)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.txtscaneo);
            this.groupBox1.Controls.Add(this.checkescaneo);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.metroCheckBoxTodo);
            this.groupBox1.Controls.Add(this.txtplaca);
            this.groupBox1.Controls.Add(this.DtAsignacionCombustible);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 325);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liquidacion x Unidad Vehicular";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(1086, 20);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(133, 57);
            this.metroButton2.TabIndex = 33;
            this.metroButton2.Text = "&Buscar";
            this.metroButton2.UseSelectable = true;
            // 
            // txtscaneo
            // 
            // 
            // 
            // 
            this.txtscaneo.CustomButton.Image = null;
            this.txtscaneo.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtscaneo.CustomButton.Name = "";
            this.txtscaneo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtscaneo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtscaneo.CustomButton.TabIndex = 1;
            this.txtscaneo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtscaneo.CustomButton.UseSelectable = true;
            this.txtscaneo.CustomButton.Visible = false;
            this.txtscaneo.Lines = new string[0];
            this.txtscaneo.Location = new System.Drawing.Point(666, 41);
            this.txtscaneo.MaxLength = 32767;
            this.txtscaneo.Name = "txtscaneo";
            this.txtscaneo.PasswordChar = '\0';
            this.txtscaneo.PromptText = "Dato";
            this.txtscaneo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtscaneo.SelectedText = "";
            this.txtscaneo.SelectionLength = 0;
            this.txtscaneo.SelectionStart = 0;
            this.txtscaneo.ShortcutsEnabled = true;
            this.txtscaneo.Size = new System.Drawing.Size(97, 23);
            this.txtscaneo.TabIndex = 32;
            this.txtscaneo.UseSelectable = true;
            this.txtscaneo.WaterMark = "Dato";
            this.txtscaneo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtscaneo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkescaneo
            // 
            this.checkescaneo.AutoSize = true;
            this.checkescaneo.Location = new System.Drawing.Point(563, 49);
            this.checkescaneo.Name = "checkescaneo";
            this.checkescaneo.Size = new System.Drawing.Size(97, 15);
            this.checkescaneo.TabIndex = 31;
            this.checkescaneo.Text = "Dato - Scaneo";
            this.checkescaneo.UseSelectable = true;
            this.checkescaneo.CheckedChanged += new System.EventHandler(this.checkescaneo_CheckedChanged);
            // 
            // txtnumero
            // 
            // 
            // 
            // 
            this.txtnumero.CustomButton.Image = null;
            this.txtnumero.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.txtnumero.CustomButton.Name = "";
            this.txtnumero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtnumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnumero.CustomButton.TabIndex = 1;
            this.txtnumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnumero.CustomButton.UseSelectable = true;
            this.txtnumero.CustomButton.Visible = false;
            this.txtnumero.Lines = new string[0];
            this.txtnumero.Location = new System.Drawing.Point(413, 44);
            this.txtnumero.MaxLength = 2;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.PasswordChar = '\0';
            this.txtnumero.PromptText = "Numero";
            this.txtnumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnumero.SelectedText = "";
            this.txtnumero.SelectionLength = 0;
            this.txtnumero.SelectionStart = 0;
            this.txtnumero.ShortcutsEnabled = true;
            this.txtnumero.Size = new System.Drawing.Size(122, 23);
            this.txtnumero.TabIndex = 30;
            this.txtnumero.UseSelectable = true;
            this.txtnumero.WaterMark = "Numero";
            this.txtnumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // metroCheckBoxTodo
            // 
            this.metroCheckBoxTodo.AutoSize = true;
            this.metroCheckBoxTodo.Location = new System.Drawing.Point(285, 52);
            this.metroCheckBoxTodo.Name = "metroCheckBoxTodo";
            this.metroCheckBoxTodo.Size = new System.Drawing.Size(122, 15);
            this.metroCheckBoxTodo.TabIndex = 29;
            this.metroCheckBoxTodo.Text = "Seleccionar - Todo";
            this.metroCheckBoxTodo.UseSelectable = true;
            this.metroCheckBoxTodo.CheckedChanged += new System.EventHandler(this.metroCheckBoxTodo_CheckedChanged);
            // 
            // txtplaca
            // 
            // 
            // 
            // 
            this.txtplaca.CustomButton.Image = null;
            this.txtplaca.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtplaca.CustomButton.Name = "";
            this.txtplaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtplaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtplaca.CustomButton.TabIndex = 1;
            this.txtplaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtplaca.CustomButton.UseSelectable = true;
            this.txtplaca.CustomButton.Visible = false;
            this.txtplaca.Lines = new string[0];
            this.txtplaca.Location = new System.Drawing.Point(11, 44);
            this.txtplaca.MaxLength = 32767;
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.PasswordChar = '\0';
            this.txtplaca.PromptText = "Buscar Placa";
            this.txtplaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtplaca.SelectedText = "";
            this.txtplaca.SelectionLength = 0;
            this.txtplaca.SelectionStart = 0;
            this.txtplaca.ShortcutsEnabled = true;
            this.txtplaca.Size = new System.Drawing.Size(200, 23);
            this.txtplaca.TabIndex = 24;
            this.txtplaca.UseSelectable = true;
            this.txtplaca.WaterMark = "Buscar Placa";
            this.txtplaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtplaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DtAsignacionCombustible
            // 
            this.DtAsignacionCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtAsignacionCombustible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgSeleccion,
            this.DgApellido,
            this.DgNombre,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.DtAsignacionCombustible.Location = new System.Drawing.Point(8, 86);
            this.DtAsignacionCombustible.Name = "DtAsignacionCombustible";
            this.DtAsignacionCombustible.Size = new System.Drawing.Size(1211, 225);
            this.DtAsignacionCombustible.TabIndex = 13;
            // 
            // DgSeleccion
            // 
            this.DgSeleccion.HeaderText = "Seleccionar";
            this.DgSeleccion.Name = "DgSeleccion";
            // 
            // DgApellido
            // 
            this.DgApellido.HeaderText = "Placa";
            this.DgApellido.Name = "DgApellido";
            this.DgApellido.ReadOnly = true;
            // 
            // DgNombre
            // 
            this.DgNombre.HeaderText = "Fecha";
            this.DgNombre.Name = "DgNombre";
            this.DgNombre.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Origen-Destino";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telefono";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cant-Guias";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cant-Relleno";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Peso-Bruto";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Consumo";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Exceso-C";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tiempo";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Exceso-T";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Estado-General";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Comprobante";
            this.Column11.Name = "Column11";
            // 
            // txtvueltas
            // 
            this.txtvueltas.Enabled = false;
            this.txtvueltas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvueltas.Location = new System.Drawing.Point(97, 478);
            this.txtvueltas.Name = "txtvueltas";
            this.txtvueltas.Size = new System.Drawing.Size(57, 26);
            this.txtvueltas.TabIndex = 17;
            // 
            // txtcantidadconsumo
            // 
            this.txtcantidadconsumo.Enabled = false;
            this.txtcantidadconsumo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadconsumo.Location = new System.Drawing.Point(249, 478);
            this.txtcantidadconsumo.Name = "txtcantidadconsumo";
            this.txtcantidadconsumo.Size = new System.Drawing.Size(57, 26);
            this.txtcantidadconsumo.TabIndex = 19;
            // 
            // txtexcesoconsumo
            // 
            this.txtexcesoconsumo.Enabled = false;
            this.txtexcesoconsumo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexcesoconsumo.Location = new System.Drawing.Point(401, 478);
            this.txtexcesoconsumo.Name = "txtexcesoconsumo";
            this.txtexcesoconsumo.Size = new System.Drawing.Size(57, 26);
            this.txtexcesoconsumo.TabIndex = 21;
            // 
            // txtkilometraje
            // 
            this.txtkilometraje.Enabled = false;
            this.txtkilometraje.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkilometraje.Location = new System.Drawing.Point(577, 478);
            this.txtkilometraje.Name = "txtkilometraje";
            this.txtkilometraje.Size = new System.Drawing.Size(80, 26);
            this.txtkilometraje.TabIndex = 23;
            // 
            // txttiempo
            // 
            this.txttiempo.Enabled = false;
            this.txttiempo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiempo.Location = new System.Drawing.Point(754, 478);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(57, 26);
            this.txttiempo.TabIndex = 26;
            // 
            // txtobservacion
            // 
            // 
            // 
            // 
            this.txtobservacion.CustomButton.Image = null;
            this.txtobservacion.CustomButton.Location = new System.Drawing.Point(1148, 1);
            this.txtobservacion.CustomButton.Name = "";
            this.txtobservacion.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.txtobservacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtobservacion.CustomButton.TabIndex = 1;
            this.txtobservacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtobservacion.CustomButton.UseSelectable = true;
            this.txtobservacion.CustomButton.Visible = false;
            this.txtobservacion.Lines = new string[0];
            this.txtobservacion.Location = new System.Drawing.Point(12, 361);
            this.txtobservacion.MaxLength = 32767;
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.PasswordChar = '\0';
            this.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtobservacion.SelectedText = "";
            this.txtobservacion.SelectionLength = 0;
            this.txtobservacion.SelectionStart = 0;
            this.txtobservacion.ShortcutsEnabled = true;
            this.txtobservacion.Size = new System.Drawing.Size(1232, 85);
            this.txtobservacion.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtobservacion.TabIndex = 30;
            this.txtobservacion.UseSelectable = true;
            this.txtobservacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtobservacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1152, 462);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(92, 57);
            this.BtnSalir.TabIndex = 31;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(997, 462);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(133, 57);
            this.metroButton1.TabIndex = 32;
            this.metroButton1.Text = "&Liquidar";
            this.metroButton1.UseSelectable = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Observacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "N°Vueltas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "C-Consumo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "C-Exceso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Kilometraje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(685, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "T-Tiempo:";
            // 
            // FrmLiquidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1254, 523);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.txtobservacion);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.txtkilometraje);
            this.Controls.Add(this.txtexcesoconsumo);
            this.Controls.Add(this.txtcantidadconsumo);
            this.Controls.Add(this.txtvueltas);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLiquidar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "..::Liquidar::..";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtAsignacionCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtAsignacionCombustible;
        private System.Windows.Forms.TextBox txtvueltas;
        private System.Windows.Forms.TextBox txtcantidadconsumo;
        private System.Windows.Forms.TextBox txtexcesoconsumo;
        private System.Windows.Forms.TextBox txtkilometraje;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DgSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TextBox txttiempo;
        private MetroFramework.Controls.MetroTextBox txtscaneo;
        private MetroFramework.Controls.MetroCheckBox checkescaneo;
        private MetroFramework.Controls.MetroTextBox txtnumero;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxTodo;
        private MetroFramework.Controls.MetroTextBox txtplaca;
        private MetroFramework.Controls.MetroTextBox txtobservacion;
        private MetroFramework.Controls.MetroButton BtnSalir;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}