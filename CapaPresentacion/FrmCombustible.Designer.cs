namespace CapaPresentacion
{
    partial class FrmCombustible
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.GrillaAsignacionCombustible = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LnkVerificar = new System.Windows.Forms.LinkLabel();
            this.LblEstado = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.cboestadotiemporuta = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.Txtconsumocombustible = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtkilometrajepororigen = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.TxtKilometraje = new System.Windows.Forms.TextBox();
            this.btnLiquidar = new MetroFramework.Controls.MetroButton();
            this.btnguardar = new MetroFramework.Controls.MetroButton();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.txtrelleno2 = new System.Windows.Forms.TextBox();
            this.txtrelleno1 = new System.Windows.Forms.TextBox();
            this.BtnRelevo = new MetroFramework.Controls.MetroButton();
            this.label30 = new System.Windows.Forms.Label();
            this.txtcantidad2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtexcesoconsumo = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtestadoconsumo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtestadotiempo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtnumeroguias = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtConsumo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtPesoBalanza = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtcantidad1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtCopiloto = new System.Windows.Forms.TextBox();
            this.TxtPiloto = new System.Windows.Forms.TextBox();
            this.cbOrigenDestino = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GrillaDetallePorUnidad = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAsignacionCombustible)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetallePorUnidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBusqueda);
            this.groupBox1.Controls.Add(this.GrillaAsignacionCombustible);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 406);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda - Unidades Vehiculares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.BackColor = System.Drawing.Color.White;
            this.TxtBusqueda.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(59, 30);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(556, 26);
            this.TxtBusqueda.TabIndex = 3;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // GrillaAsignacionCombustible
            // 
            this.GrillaAsignacionCombustible.AllowUserToAddRows = false;
            this.GrillaAsignacionCombustible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaAsignacionCombustible.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaAsignacionCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaAsignacionCombustible.Location = new System.Drawing.Point(10, 70);
            this.GrillaAsignacionCombustible.Name = "GrillaAsignacionCombustible";
            this.GrillaAsignacionCombustible.ReadOnly = true;
            this.GrillaAsignacionCombustible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaAsignacionCombustible.Size = new System.Drawing.Size(605, 325);
            this.GrillaAsignacionCombustible.TabIndex = 4;
            this.GrillaAsignacionCombustible.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaAsignacionCombustible_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LnkVerificar);
            this.groupBox3.Controls.Add(this.LblEstado);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.cboestadotiemporuta);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.Txtconsumocombustible);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.txtkilometrajepororigen);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.TxtKilometraje);
            this.groupBox3.Controls.Add(this.btnLiquidar);
            this.groupBox3.Controls.Add(this.btnguardar);
            this.groupBox3.Controls.Add(this.BtnSalir);
            this.groupBox3.Controls.Add(this.txtrelleno2);
            this.groupBox3.Controls.Add(this.txtrelleno1);
            this.groupBox3.Controls.Add(this.BtnRelevo);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.txtcantidad2);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txtexcesoconsumo);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txtestadoconsumo);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtestadotiempo);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtobservacion);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txttiempo);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtnumeroguias);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.TxtConsumo);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.TxtPesoBalanza);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtcantidad1);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txttelefono);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TxtCopiloto);
            this.groupBox3.Controls.Add(this.TxtPiloto);
            this.groupBox3.Controls.Add(this.cbOrigenDestino);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(645, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 564);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro:";
            // 
            // LnkVerificar
            // 
            this.LnkVerificar.AutoSize = true;
            this.LnkVerificar.Location = new System.Drawing.Point(141, 191);
            this.LnkVerificar.Name = "LnkVerificar";
            this.LnkVerificar.Size = new System.Drawing.Size(60, 17);
            this.LnkVerificar.TabIndex = 82;
            this.LnkVerificar.TabStop = true;
            this.LnkVerificar.Text = "Verificar";
            this.LnkVerificar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkVerificar_LinkClicked);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(528, 129);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(53, 23);
            this.LblEstado.TabIndex = 81;
            this.LblEstado.Text = "label1";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(432, 303);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(74, 17);
            this.label38.TabIndex = 80;
            this.label38.Text = "Ocurrencia:";
            // 
            // cboestadotiemporuta
            // 
            this.cboestadotiemporuta.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestadotiemporuta.FormattingEnabled = true;
            this.cboestadotiemporuta.Location = new System.Drawing.Point(514, 297);
            this.cboestadotiemporuta.Name = "cboestadotiemporuta";
            this.cboestadotiemporuta.Size = new System.Drawing.Size(160, 23);
            this.cboestadotiemporuta.TabIndex = 79;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(5, 164);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 17);
            this.label26.TabIndex = 78;
            this.label26.Text = "Consumo:";
            // 
            // Txtconsumocombustible
            // 
            this.Txtconsumocombustible.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtconsumocombustible.Location = new System.Drawing.Point(84, 159);
            this.Txtconsumocombustible.Name = "Txtconsumocombustible";
            this.Txtconsumocombustible.Size = new System.Drawing.Size(116, 26);
            this.Txtconsumocombustible.TabIndex = 77;
            this.Txtconsumocombustible.TextChanged += new System.EventHandler(this.Txtconsumocombustible_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(258, 262);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(29, 17);
            this.label39.TabIndex = 76;
            this.label39.Text = "KM:";
            // 
            // txtkilometrajepororigen
            // 
            this.txtkilometrajepororigen.Enabled = false;
            this.txtkilometrajepororigen.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkilometrajepororigen.Location = new System.Drawing.Point(296, 252);
            this.txtkilometrajepororigen.Name = "txtkilometrajepororigen";
            this.txtkilometrajepororigen.Size = new System.Drawing.Size(111, 26);
            this.txtkilometrajepororigen.TabIndex = 75;
            this.txtkilometrajepororigen.TextChanged += new System.EventHandler(this.txtkilometrajepororigen_TextChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(1, 261);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(76, 17);
            this.label37.TabIndex = 74;
            this.label37.Text = "Kilometraje:";
            // 
            // TxtKilometraje
            // 
            this.TxtKilometraje.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKilometraje.Location = new System.Drawing.Point(85, 253);
            this.TxtKilometraje.Name = "TxtKilometraje";
            this.TxtKilometraje.Size = new System.Drawing.Size(116, 26);
            this.TxtKilometraje.TabIndex = 73;
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Location = new System.Drawing.Point(145, 512);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(109, 40);
            this.btnLiquidar.TabIndex = 72;
            this.btnLiquidar.Text = "&Liquidar";
            this.btnLiquidar.UseSelectable = true;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(288, 512);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(109, 40);
            this.btnguardar.TabIndex = 71;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseSelectable = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(563, 511);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(109, 40);
            this.BtnSalir.TabIndex = 69;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // txtrelleno2
            // 
            this.txtrelleno2.Enabled = false;
            this.txtrelleno2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrelleno2.Location = new System.Drawing.Point(322, 83);
            this.txtrelleno2.Name = "txtrelleno2";
            this.txtrelleno2.Size = new System.Drawing.Size(112, 24);
            this.txtrelleno2.TabIndex = 62;
            // 
            // txtrelleno1
            // 
            this.txtrelleno1.Enabled = false;
            this.txtrelleno1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrelleno1.Location = new System.Drawing.Point(104, 84);
            this.txtrelleno1.Name = "txtrelleno1";
            this.txtrelleno1.Size = new System.Drawing.Size(117, 24);
            this.txtrelleno1.TabIndex = 61;
            // 
            // BtnRelevo
            // 
            this.BtnRelevo.Location = new System.Drawing.Point(6, 511);
            this.BtnRelevo.Name = "BtnRelevo";
            this.BtnRelevo.Size = new System.Drawing.Size(109, 41);
            this.BtnRelevo.TabIndex = 60;
            this.BtnRelevo.Text = "&Relevo";
            this.BtnRelevo.UseSelectable = true;
            this.BtnRelevo.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(441, 65);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 17);
            this.label30.TabIndex = 59;
            this.label30.Text = "Cantidad:";
            // 
            // txtcantidad2
            // 
            this.txtcantidad2.Enabled = false;
            this.txtcantidad2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad2.Location = new System.Drawing.Point(444, 86);
            this.txtcantidad2.Name = "txtcantidad2";
            this.txtcantidad2.Size = new System.Drawing.Size(59, 24);
            this.txtcantidad2.TabIndex = 58;
            this.txtcantidad2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad2_KeyDown);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(323, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 21);
            this.checkBox2.TabIndex = 56;
            this.checkBox2.Text = "Rellenar:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(415, 168);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(105, 17);
            this.label25.TabIndex = 53;
            this.label25.Text = "Galonaje - Usado:";
            // 
            // txtexcesoconsumo
            // 
            this.txtexcesoconsumo.Enabled = false;
            this.txtexcesoconsumo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexcesoconsumo.Location = new System.Drawing.Point(526, 155);
            this.txtexcesoconsumo.Name = "txtexcesoconsumo";
            this.txtexcesoconsumo.Size = new System.Drawing.Size(111, 26);
            this.txtexcesoconsumo.TabIndex = 52;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(218, 168);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 17);
            this.label24.TabIndex = 49;
            this.label24.Text = "Consu-Guia:";
            // 
            // txtestadoconsumo
            // 
            this.txtestadoconsumo.Enabled = false;
            this.txtestadoconsumo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestadoconsumo.Location = new System.Drawing.Point(296, 162);
            this.txtestadoconsumo.Name = "txtestadoconsumo";
            this.txtestadoconsumo.Size = new System.Drawing.Size(111, 26);
            this.txtestadoconsumo.TabIndex = 48;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(237, 302);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 17);
            this.label23.TabIndex = 47;
            this.label23.Text = "Estado:";
            // 
            // txtestadotiempo
            // 
            this.txtestadotiempo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestadotiempo.Enabled = false;
            this.txtestadotiempo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestadotiempo.Location = new System.Drawing.Point(296, 293);
            this.txtestadotiempo.Name = "txtestadotiempo";
            this.txtestadotiempo.Size = new System.Drawing.Size(111, 26);
            this.txtestadotiempo.TabIndex = 46;
            this.txtestadotiempo.TextChanged += new System.EventHandler(this.txtestadotiempo_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 331);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 17);
            this.label22.TabIndex = 45;
            this.label22.Text = "Observacion:";
            // 
            // txtobservacion
            // 
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacion.Location = new System.Drawing.Point(8, 352);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(666, 140);
            this.txtobservacion.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(27, 298);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 17);
            this.label21.TabIndex = 43;
            this.label21.Text = "Tiempo:";
            // 
            // txttiempo
            // 
            this.txttiempo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiempo.Location = new System.Drawing.Point(83, 294);
            this.txttiempo.MaxLength = 5;
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(117, 26);
            this.txttiempo.TabIndex = 42;
            this.txttiempo.TextChanged += new System.EventHandler(this.txttiempo_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(212, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 17);
            this.label20.TabIndex = 41;
            this.label20.Text = "Planilla/Peso:";
            // 
            // txtnumeroguias
            // 
            this.txtnumeroguias.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeroguias.Location = new System.Drawing.Point(296, 125);
            this.txtnumeroguias.Name = "txtnumeroguias";
            this.txtnumeroguias.Size = new System.Drawing.Size(111, 24);
            this.txtnumeroguias.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 223);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "T-Consumo:";
            // 
            // TxtConsumo
            // 
            this.TxtConsumo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConsumo.Location = new System.Drawing.Point(85, 218);
            this.TxtConsumo.Name = "TxtConsumo";
            this.TxtConsumo.Size = new System.Drawing.Size(116, 26);
            this.TxtConsumo.TabIndex = 38;
            this.TxtConsumo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtConsumo_MouseClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 17);
            this.label18.TabIndex = 37;
            this.label18.Text = "Peso-Balanza:";
            // 
            // TxtPesoBalanza
            // 
            this.TxtPesoBalanza.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesoBalanza.Location = new System.Drawing.Point(87, 123);
            this.TxtPesoBalanza.Name = "TxtPesoBalanza";
            this.TxtPesoBalanza.Size = new System.Drawing.Size(116, 26);
            this.TxtPesoBalanza.TabIndex = 36;
            this.TxtPesoBalanza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPesoBalanza_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(228, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Cantidad:";
            // 
            // txtcantidad1
            // 
            this.txtcantidad1.Enabled = false;
            this.txtcantidad1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad1.Location = new System.Drawing.Point(227, 83);
            this.txtcantidad1.Name = "txtcantidad1";
            this.txtcantidad1.Size = new System.Drawing.Size(64, 24);
            this.txtcantidad1.TabIndex = 34;
            this.txtcantidad1.TextChanged += new System.EventHandler(this.txtcantidad1_TextChanged);
            this.txtcantidad1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad1_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(104, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 21);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Rellenar:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Telefono:";
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(6, 84);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(80, 24);
            this.txttelefono.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(438, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Copiloto:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(198, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Piloto:";
            // 
            // TxtCopiloto
            // 
            this.TxtCopiloto.Enabled = false;
            this.TxtCopiloto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCopiloto.Location = new System.Drawing.Point(441, 36);
            this.TxtCopiloto.Name = "TxtCopiloto";
            this.TxtCopiloto.Size = new System.Drawing.Size(234, 24);
            this.TxtCopiloto.TabIndex = 25;
            // 
            // TxtPiloto
            // 
            this.TxtPiloto.Enabled = false;
            this.TxtPiloto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPiloto.Location = new System.Drawing.Point(201, 36);
            this.TxtPiloto.Name = "TxtPiloto";
            this.TxtPiloto.Size = new System.Drawing.Size(234, 24);
            this.TxtPiloto.TabIndex = 25;
            // 
            // cbOrigenDestino
            // 
            this.cbOrigenDestino.FormattingEnabled = true;
            this.cbOrigenDestino.Location = new System.Drawing.Point(9, 36);
            this.cbOrigenDestino.Name = "cbOrigenDestino";
            this.cbOrigenDestino.Size = new System.Drawing.Size(186, 25);
            this.cbOrigenDestino.TabIndex = 18;
            this.cbOrigenDestino.SelectedIndexChanged += new System.EventHandler(this.cbOrigenDestino_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Origen-Destino:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GrillaDetallePorUnidad);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 157);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle-Registro:";
            // 
            // GrillaDetallePorUnidad
            // 
            this.GrillaDetallePorUnidad.AllowUserToAddRows = false;
            this.GrillaDetallePorUnidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaDetallePorUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDetallePorUnidad.Location = new System.Drawing.Point(10, 25);
            this.GrillaDetallePorUnidad.Name = "GrillaDetallePorUnidad";
            this.GrillaDetallePorUnidad.ReadOnly = true;
            this.GrillaDetallePorUnidad.Size = new System.Drawing.Size(605, 119);
            this.GrillaDetallePorUnidad.TabIndex = 0;
            this.GrillaDetallePorUnidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaDetallePorUnidad_CellClick);
            // 
            // FrmCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 579);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmCombustible";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "..::Combustible::..";
            this.Load += new System.EventHandler(this.FrmCombustible_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAsignacionCombustible)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetallePorUnidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView GrillaDetallePorUnidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtCopiloto;
        private System.Windows.Forms.TextBox TxtPiloto;
        private System.Windows.Forms.ComboBox cbOrigenDestino;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtnumeroguias;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtPesoBalanza;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtcantidad1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtexcesoconsumo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtestadoconsumo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtestadotiempo;
        private System.Windows.Forms.DataGridView GrillaAsignacionCombustible;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtcantidad2;
        private System.Windows.Forms.CheckBox checkBox2;
        private MetroFramework.Controls.MetroButton BtnRelevo;
        private System.Windows.Forms.TextBox txtrelleno1;
        private System.Windows.Forms.TextBox txtrelleno2;
        private MetroFramework.Controls.MetroButton BtnSalir;
        private MetroFramework.Controls.MetroButton btnLiquidar;
        private MetroFramework.Controls.MetroButton btnguardar;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox TxtKilometraje;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtkilometrajepororigen;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cboestadotiemporuta;
        private System.Windows.Forms.TextBox TxtConsumo;
        private System.Windows.Forms.TextBox Txtconsumocombustible;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.LinkLabel LnkVerificar;
    }
}