namespace CapaPresentacion
{
    partial class FrmAsignacionCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacionCombustible));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNumero = new System.Windows.Forms.ComboBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.GrillaAsignacion = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CboTipoConductor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBuscarPlaca = new MetroFramework.Controls.MetroTextBox();
            this.GrillaPlaca = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_Apellido = new System.Windows.Forms.RadioButton();
            this.RB_DNI = new System.Windows.Forms.RadioButton();
            this.txtBuscarConductor = new System.Windows.Forms.TextBox();
            this.GrillaConductor = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAsignacion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPlaca)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConductor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.GrillaAsignacion);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.CboTipoConductor);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnNuevo);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.TxtPlaca);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(505, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 442);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion Conductor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtNumero
            // 
            this.TxtNumero.Enabled = false;
            this.TxtNumero.FormattingEnabled = true;
            this.TxtNumero.Items.AddRange(new object[] {
            "1",
            "2"});
            this.TxtNumero.Location = new System.Drawing.Point(397, 58);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(50, 26);
            this.TxtNumero.TabIndex = 22;
            this.TxtNumero.Text = "Seleccione";
            this.TxtNumero.SelectedIndexChanged += new System.EventHandler(this.TxtNumero_SelectedIndexChanged);
            this.TxtNumero.SelectionChangeCommitted += new System.EventHandler(this.TxtNumero_SelectionChangeCommitted);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(406, 300);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(91, 42);
            this.btneliminar.TabIndex = 21;
            this.btneliminar.Text = "Quitar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // GrillaAsignacion
            // 
            this.GrillaAsignacion.AllowUserToAddRows = false;
            this.GrillaAsignacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaAsignacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaAsignacion.Location = new System.Drawing.Point(18, 212);
            this.GrillaAsignacion.Name = "GrillaAsignacion";
            this.GrillaAsignacion.ReadOnly = true;
            this.GrillaAsignacion.Size = new System.Drawing.Size(382, 163);
            this.GrillaAsignacion.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(344, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // CboTipoConductor
            // 
            this.CboTipoConductor.FormattingEnabled = true;
            this.CboTipoConductor.Location = new System.Drawing.Point(131, 156);
            this.CboTipoConductor.Name = "CboTipoConductor";
            this.CboTipoConductor.Size = new System.Drawing.Size(162, 26);
            this.CboTipoConductor.TabIndex = 16;
            this.CboTipoConductor.SelectedIndexChanged += new System.EventHandler(this.CboTipoConductor_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(406, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(16, 389);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnNuevo.Size = new System.Drawing.Size(99, 42);
            this.BtnNuevo.TabIndex = 11;
            this.BtnNuevo.Text = "&Liberar";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(383, 389);
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
            this.BtnCancelar.Location = new System.Drawing.Point(257, 389);
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
            this.BtnGuardar.Location = new System.Drawing.Point(131, 389);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 42);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "&Asignar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Enabled = false;
            this.TxtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(99, 100);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(375, 26);
            this.TxtBuscar.TabIndex = 8;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(80, 40);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(58, 26);
            this.TxtCodigo.TabIndex = 2;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Enabled = false;
            this.TxtPlaca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlaca.Location = new System.Drawing.Point(213, 58);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(136, 26);
            this.TxtPlaca.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtBuscarPlaca);
            this.groupBox2.Controls.Add(this.GrillaPlaca);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 204);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda-Placa";
            // 
            // TxtBuscarPlaca
            // 
            // 
            // 
            // 
            this.TxtBuscarPlaca.CustomButton.Image = null;
            this.TxtBuscarPlaca.CustomButton.Location = new System.Drawing.Point(355, 1);
            this.TxtBuscarPlaca.CustomButton.Name = "";
            this.TxtBuscarPlaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBuscarPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBuscarPlaca.CustomButton.TabIndex = 1;
            this.TxtBuscarPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBuscarPlaca.CustomButton.UseSelectable = true;
            this.TxtBuscarPlaca.CustomButton.Visible = false;
            this.TxtBuscarPlaca.Lines = new string[0];
            this.TxtBuscarPlaca.Location = new System.Drawing.Point(9, 31);
            this.TxtBuscarPlaca.MaxLength = 32767;
            this.TxtBuscarPlaca.Name = "TxtBuscarPlaca";
            this.TxtBuscarPlaca.PasswordChar = '\0';
            this.TxtBuscarPlaca.PromptText = "Busqueda de Placa";
            this.TxtBuscarPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBuscarPlaca.SelectedText = "";
            this.TxtBuscarPlaca.SelectionLength = 0;
            this.TxtBuscarPlaca.SelectionStart = 0;
            this.TxtBuscarPlaca.ShortcutsEnabled = true;
            this.TxtBuscarPlaca.Size = new System.Drawing.Size(377, 23);
            this.TxtBuscarPlaca.TabIndex = 23;
            this.TxtBuscarPlaca.UseSelectable = true;
            this.TxtBuscarPlaca.WaterMark = "Busqueda de Placa";
            this.TxtBuscarPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBuscarPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBuscarPlaca.TextChanged += new System.EventHandler(this.TxtBuscarPlaca_TextChanged);
            // 
            // GrillaPlaca
            // 
            this.GrillaPlaca.AllowUserToAddRows = false;
            this.GrillaPlaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaPlaca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPlaca.Location = new System.Drawing.Point(9, 74);
            this.GrillaPlaca.Name = "GrillaPlaca";
            this.GrillaPlaca.ReadOnly = true;
            this.GrillaPlaca.Size = new System.Drawing.Size(476, 117);
            this.GrillaPlaca.TabIndex = 7;
            this.GrillaPlaca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaDepartamento_CellClick);
            this.GrillaPlaca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaPlaca_CellContentClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(396, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "&Buscar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.RB_Apellido);
            this.groupBox3.Controls.Add(this.RB_DNI);
            this.groupBox3.Controls.Add(this.txtBuscarConductor);
            this.groupBox3.Controls.Add(this.GrillaConductor);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 230);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda-Conductor";
            // 
            // RB_Apellido
            // 
            this.RB_Apellido.AutoSize = true;
            this.RB_Apellido.Location = new System.Drawing.Point(140, 60);
            this.RB_Apellido.Name = "RB_Apellido";
            this.RB_Apellido.Size = new System.Drawing.Size(76, 22);
            this.RB_Apellido.TabIndex = 12;
            this.RB_Apellido.TabStop = true;
            this.RB_Apellido.Text = "Apellido";
            this.RB_Apellido.UseVisualStyleBackColor = true;
            this.RB_Apellido.CheckedChanged += new System.EventHandler(this.RB_Apellido_CheckedChanged);
            // 
            // RB_DNI
            // 
            this.RB_DNI.AutoSize = true;
            this.RB_DNI.Location = new System.Drawing.Point(71, 60);
            this.RB_DNI.Name = "RB_DNI";
            this.RB_DNI.Size = new System.Drawing.Size(52, 22);
            this.RB_DNI.TabIndex = 11;
            this.RB_DNI.TabStop = true;
            this.RB_DNI.Text = "DNI";
            this.RB_DNI.UseVisualStyleBackColor = true;
            // 
            // txtBuscarConductor
            // 
            this.txtBuscarConductor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarConductor.Location = new System.Drawing.Point(71, 28);
            this.txtBuscarConductor.Name = "txtBuscarConductor";
            this.txtBuscarConductor.Size = new System.Drawing.Size(319, 26);
            this.txtBuscarConductor.TabIndex = 9;
            this.txtBuscarConductor.TextChanged += new System.EventHandler(this.txtBuscarConductor_TextChanged);
            // 
            // GrillaConductor
            // 
            this.GrillaConductor.AllowUserToAddRows = false;
            this.GrillaConductor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaConductor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaConductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaConductor.Location = new System.Drawing.Point(6, 88);
            this.GrillaConductor.Name = "GrillaConductor";
            this.GrillaConductor.ReadOnly = true;
            this.GrillaConductor.Size = new System.Drawing.Size(479, 136);
            this.GrillaConductor.TabIndex = 7;
            this.GrillaConductor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaConductor_CellClick);
            this.GrillaConductor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaConductor_CellContentClick);
            this.GrillaConductor.CausesValidationChanged += new System.EventHandler(this.GrillaConductor_CausesValidationChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(396, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "&Buscar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Buscar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Conductor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Tipo Conductor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "N°:";
            // 
            // FrmAsignacionCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1017, 463);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAsignacionCombustible";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "..:: Asignacion - Combustible ::..";
            this.Load += new System.EventHandler(this.FrmAsignacionCombustible_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAsignacion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPlaca)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConductor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CboTipoConductor;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TxtPlaca;
        public System.Windows.Forms.DataGridView GrillaAsignacion;
        public System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GrillaPlaca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscarConductor;
        private System.Windows.Forms.DataGridView GrillaConductor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton RB_Apellido;
        private System.Windows.Forms.RadioButton RB_DNI;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox TxtNumero;
        private MetroFramework.Controls.MetroTextBox TxtBuscarPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}