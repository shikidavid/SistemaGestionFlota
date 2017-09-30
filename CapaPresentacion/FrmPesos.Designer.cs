namespace CapaPresentacion
{
    partial class FrmPesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Chk_Placa = new System.Windows.Forms.CheckBox();
            this.CbFamilia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.GrillaFamiliaPlaca = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBusqueda_OrigenDestino = new System.Windows.Forms.TextBox();
            this.GrillaListaOrigenDestino = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Chk = new System.Windows.Forms.GroupBox();
            this.ChkAsignacionFamiliar = new System.Windows.Forms.CheckBox();
            this.txtgalonaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.GrillaasignacionPeso = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.txtorigendestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPlacafamilia = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFamiliaPlaca)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaOrigenDestino)).BeginInit();
            this.Chk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaasignacionPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Chk_Placa);
            this.groupBox2.Controls.Add(this.CbFamilia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtBusqueda);
            this.groupBox2.Controls.Add(this.GrillaFamiliaPlaca);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 233);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda Unidad Vehicular:";
            // 
            // Chk_Placa
            // 
            this.Chk_Placa.AutoSize = true;
            this.Chk_Placa.Location = new System.Drawing.Point(335, 69);
            this.Chk_Placa.Name = "Chk_Placa";
            this.Chk_Placa.Size = new System.Drawing.Size(59, 22);
            this.Chk_Placa.TabIndex = 13;
            this.Chk_Placa.Text = "Placa";
            this.Chk_Placa.UseVisualStyleBackColor = true;
            this.Chk_Placa.CheckedChanged += new System.EventHandler(this.Chk_Placa_CheckedChanged);
            // 
            // CbFamilia
            // 
            this.CbFamilia.FormattingEnabled = true;
            this.CbFamilia.Location = new System.Drawing.Point(71, 65);
            this.CbFamilia.Name = "CbFamilia";
            this.CbFamilia.Size = new System.Drawing.Size(258, 26);
            this.CbFamilia.TabIndex = 12;
            this.CbFamilia.SelectedIndexChanged += new System.EventHandler(this.CbFamilia_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Familia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(71, 28);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(258, 26);
            this.TxtBusqueda.TabIndex = 9;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // GrillaFamiliaPlaca
            // 
            this.GrillaFamiliaPlaca.AllowUserToAddRows = false;
            this.GrillaFamiliaPlaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaFamiliaPlaca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.GrillaFamiliaPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaFamiliaPlaca.Location = new System.Drawing.Point(10, 97);
            this.GrillaFamiliaPlaca.Name = "GrillaFamiliaPlaca";
            this.GrillaFamiliaPlaca.ReadOnly = true;
            this.GrillaFamiliaPlaca.Size = new System.Drawing.Size(415, 130);
            this.GrillaFamiliaPlaca.TabIndex = 7;
            this.GrillaFamiliaPlaca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaFamiliaPlaca_CellClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(335, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "&Buscar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtBusqueda_OrigenDestino);
            this.groupBox1.Controls.Add(this.GrillaListaOrigenDestino);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 204);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda-Origen Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar";
            // 
            // TxtBusqueda_OrigenDestino
            // 
            this.TxtBusqueda_OrigenDestino.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda_OrigenDestino.Location = new System.Drawing.Point(71, 28);
            this.TxtBusqueda_OrigenDestino.Name = "TxtBusqueda_OrigenDestino";
            this.TxtBusqueda_OrigenDestino.Size = new System.Drawing.Size(258, 26);
            this.TxtBusqueda_OrigenDestino.TabIndex = 9;
            this.TxtBusqueda_OrigenDestino.TextChanged += new System.EventHandler(this.TxtBusqueda_OrigenDestino_TextChanged);
            // 
            // GrillaListaOrigenDestino
            // 
            this.GrillaListaOrigenDestino.AllowUserToAddRows = false;
            this.GrillaListaOrigenDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaListaOrigenDestino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaListaOrigenDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaListaOrigenDestino.Location = new System.Drawing.Point(9, 74);
            this.GrillaListaOrigenDestino.Name = "GrillaListaOrigenDestino";
            this.GrillaListaOrigenDestino.ReadOnly = true;
            this.GrillaListaOrigenDestino.Size = new System.Drawing.Size(415, 117);
            this.GrillaListaOrigenDestino.TabIndex = 7;
            this.GrillaListaOrigenDestino.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaListaOrigenDestino_CellClick);
            this.GrillaListaOrigenDestino.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaListaOrigenDestino_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(335, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Chk
            // 
            this.Chk.Controls.Add(this.ChkAsignacionFamiliar);
            this.Chk.Controls.Add(this.txtgalonaje);
            this.Chk.Controls.Add(this.label6);
            this.Chk.Controls.Add(this.txtcapacidad);
            this.Chk.Controls.Add(this.label3);
            this.Chk.Controls.Add(this.btnquitar);
            this.Chk.Controls.Add(this.GrillaasignacionPeso);
            this.Chk.Controls.Add(this.dateTimePicker1);
            this.Chk.Controls.Add(this.BtnAgregar);
            this.Chk.Controls.Add(this.BtnSalir);
            this.Chk.Controls.Add(this.BtnCancelar);
            this.Chk.Controls.Add(this.BtnGuardar);
            this.Chk.Controls.Add(this.txtorigendestino);
            this.Chk.Controls.Add(this.label4);
            this.Chk.Controls.Add(this.label2);
            this.Chk.Controls.Add(this.TxtCodigo);
            this.Chk.Controls.Add(this.label7);
            this.Chk.Controls.Add(this.TxtPlacafamilia);
            this.Chk.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk.Location = new System.Drawing.Point(448, 12);
            this.Chk.Name = "Chk";
            this.Chk.Size = new System.Drawing.Size(541, 443);
            this.Chk.TabIndex = 19;
            this.Chk.TabStop = false;
            this.Chk.Text = "Registro De Pesos:";
            // 
            // ChkAsignacionFamiliar
            // 
            this.ChkAsignacionFamiliar.AutoSize = true;
            this.ChkAsignacionFamiliar.Location = new System.Drawing.Point(391, 64);
            this.ChkAsignacionFamiliar.Name = "ChkAsignacionFamiliar";
            this.ChkAsignacionFamiliar.Size = new System.Drawing.Size(120, 22);
            this.ChkAsignacionFamiliar.TabIndex = 26;
            this.ChkAsignacionFamiliar.Text = "Asignar Familia";
            this.ChkAsignacionFamiliar.UseVisualStyleBackColor = true;
            this.ChkAsignacionFamiliar.CheckedChanged += new System.EventHandler(this.ChkAsignacionFamiliar_CheckedChanged);
            // 
            // txtgalonaje
            // 
            this.txtgalonaje.Location = new System.Drawing.Point(424, 132);
            this.txtgalonaje.Name = "txtgalonaje";
            this.txtgalonaje.Size = new System.Drawing.Size(109, 26);
            this.txtgalonaje.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Galonaje:";
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(130, 136);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(121, 26);
            this.txtcapacidad.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Capacidad:";
            // 
            // btnquitar
            // 
            this.btnquitar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitar.Image = ((System.Drawing.Image)(resources.GetObject("btnquitar.Image")));
            this.btnquitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquitar.Location = new System.Drawing.Point(434, 267);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(99, 42);
            this.btnquitar.TabIndex = 21;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // GrillaasignacionPeso
            // 
            this.GrillaasignacionPeso.AllowUserToAddRows = false;
            this.GrillaasignacionPeso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaasignacionPeso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaasignacionPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaasignacionPeso.Location = new System.Drawing.Point(18, 182);
            this.GrillaasignacionPeso.Name = "GrillaasignacionPeso";
            this.GrillaasignacionPeso.ReadOnly = true;
            this.GrillaasignacionPeso.Size = new System.Drawing.Size(410, 200);
            this.GrillaasignacionPeso.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(434, 210);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(101, 42);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(422, 388);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(111, 42);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(293, 388);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(111, 42);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(159, 388);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 42);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtorigendestino
            // 
            this.txtorigendestino.Enabled = false;
            this.txtorigendestino.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorigendestino.Location = new System.Drawing.Point(130, 97);
            this.txtorigendestino.Name = "txtorigendestino";
            this.txtorigendestino.Size = new System.Drawing.Size(403, 26);
            this.txtorigendestino.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Origen-Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(130, 24);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(58, 30);
            this.TxtCodigo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Familia/Placa:";
            // 
            // TxtPlacafamilia
            // 
            this.TxtPlacafamilia.Enabled = false;
            this.TxtPlacafamilia.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlacafamilia.Location = new System.Drawing.Point(130, 61);
            this.TxtPlacafamilia.Name = "TxtPlacafamilia";
            this.TxtPlacafamilia.Size = new System.Drawing.Size(255, 26);
            this.TxtPlacafamilia.TabIndex = 3;
            // 
            // FrmPesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(994, 466);
            this.ControlBox = false;
            this.Controls.Add(this.Chk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "..::Registro Pesos::..";
            this.Load += new System.EventHandler(this.FrmPesos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFamiliaPlaca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaOrigenDestino)).EndInit();
            this.Chk.ResumeLayout(false);
            this.Chk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaasignacionPeso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridView GrillaFamiliaPlaca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBusqueda_OrigenDestino;
        private System.Windows.Forms.DataGridView GrillaListaOrigenDestino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Chk;
        private System.Windows.Forms.TextBox txtgalonaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnquitar;
        public System.Windows.Forms.DataGridView GrillaasignacionPeso;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.TextBox txtorigendestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtPlacafamilia;
        private System.Windows.Forms.CheckBox Chk_Placa;
        private System.Windows.Forms.ComboBox CbFamilia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ChkAsignacionFamiliar;
    }
}