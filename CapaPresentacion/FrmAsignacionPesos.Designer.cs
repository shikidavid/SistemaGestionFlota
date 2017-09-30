namespace CapaPresentacion
{
    partial class FrmAsignacionPesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacionPesos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBusqueda_TipoVehicular = new System.Windows.Forms.TextBox();
            this.GrillaTipoVehicular = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBusqueda_OrigenDestino = new System.Windows.Forms.TextBox();
            this.GrillaListaOrigenDestino = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Chk = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.BtnCancelar = new MetroFramework.Controls.MetroButton();
            this.BtnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtgalonaje = new System.Windows.Forms.TextBox();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.btnquitar = new System.Windows.Forms.Button();
            this.GrillaAsignacionPeso = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtorigendestino = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtPlacafamilia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTipoVehicular)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaOrigenDestino)).BeginInit();
            this.Chk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAsignacionPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtBusqueda_TipoVehicular);
            this.groupBox2.Controls.Add(this.GrillaTipoVehicular);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 233);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda Tipo- Vehicular:";
            // 
            // TxtBusqueda_TipoVehicular
            // 
            this.TxtBusqueda_TipoVehicular.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda_TipoVehicular.Location = new System.Drawing.Point(71, 32);
            this.TxtBusqueda_TipoVehicular.Name = "TxtBusqueda_TipoVehicular";
            this.TxtBusqueda_TipoVehicular.Size = new System.Drawing.Size(258, 26);
            this.TxtBusqueda_TipoVehicular.TabIndex = 9;
            this.TxtBusqueda_TipoVehicular.TextChanged += new System.EventHandler(this.TxtBusqueda_TipoVehicular_TextChanged);
            // 
            // GrillaTipoVehicular
            // 
            this.GrillaTipoVehicular.AllowUserToAddRows = false;
            this.GrillaTipoVehicular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaTipoVehicular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.GrillaTipoVehicular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaTipoVehicular.Location = new System.Drawing.Point(7, 65);
            this.GrillaTipoVehicular.Name = "GrillaTipoVehicular";
            this.GrillaTipoVehicular.ReadOnly = true;
            this.GrillaTipoVehicular.Size = new System.Drawing.Size(415, 160);
            this.GrillaTipoVehicular.TabIndex = 7;
            this.GrillaTipoVehicular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaTipoVehicular_CellClick);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 231);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda-Origen Destino:";
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
            this.GrillaListaOrigenDestino.Size = new System.Drawing.Size(415, 151);
            this.GrillaListaOrigenDestino.TabIndex = 7;
            this.GrillaListaOrigenDestino.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaListaOrigenDestino_CellClick);
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
            this.Chk.Controls.Add(this.label3);
            this.Chk.Controls.Add(this.label4);
            this.Chk.Controls.Add(this.label7);
            this.Chk.Controls.Add(this.label2);
            this.Chk.Controls.Add(this.label8);
            this.Chk.Controls.Add(this.BtnSalir);
            this.Chk.Controls.Add(this.BtnCancelar);
            this.Chk.Controls.Add(this.BtnGuardar);
            this.Chk.Controls.Add(this.txtgalonaje);
            this.Chk.Controls.Add(this.txtcapacidad);
            this.Chk.Controls.Add(this.btnquitar);
            this.Chk.Controls.Add(this.GrillaAsignacionPeso);
            this.Chk.Controls.Add(this.dateTimePicker1);
            this.Chk.Controls.Add(this.BtnAgregar);
            this.Chk.Controls.Add(this.txtorigendestino);
            this.Chk.Controls.Add(this.TxtCodigo);
            this.Chk.Controls.Add(this.TxtPlacafamilia);
            this.Chk.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk.Location = new System.Drawing.Point(447, 12);
            this.Chk.Name = "Chk";
            this.Chk.Size = new System.Drawing.Size(541, 470);
            this.Chk.TabIndex = 20;
            this.Chk.TabStop = false;
            this.Chk.Text = "Registro De Pesos:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(302, 408);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(109, 49);
            this.BtnSalir.TabIndex = 64;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(170, 408);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(109, 49);
            this.BtnCancelar.TabIndex = 63;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseSelectable = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(37, 408);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(109, 49);
            this.BtnGuardar.TabIndex = 62;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseSelectable = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtgalonaje
            // 
            this.txtgalonaje.Location = new System.Drawing.Point(424, 139);
            this.txtgalonaje.Name = "txtgalonaje";
            this.txtgalonaje.Size = new System.Drawing.Size(109, 26);
            this.txtgalonaje.TabIndex = 25;
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(130, 136);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(121, 26);
            this.txtcapacidad.TabIndex = 23;
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
            // GrillaAsignacionPeso
            // 
            this.GrillaAsignacionPeso.AllowUserToAddRows = false;
            this.GrillaAsignacionPeso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaAsignacionPeso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaAsignacionPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaAsignacionPeso.Location = new System.Drawing.Point(18, 182);
            this.GrillaAsignacionPeso.Name = "GrillaAsignacionPeso";
            this.GrillaAsignacionPeso.ReadOnly = true;
            this.GrillaAsignacionPeso.Size = new System.Drawing.Size(410, 215);
            this.GrillaAsignacionPeso.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(397, 23);
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
            // txtorigendestino
            // 
            this.txtorigendestino.Enabled = false;
            this.txtorigendestino.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorigendestino.Location = new System.Drawing.Point(132, 97);
            this.txtorigendestino.Name = "txtorigendestino";
            this.txtorigendestino.Size = new System.Drawing.Size(403, 26);
            this.txtorigendestino.TabIndex = 8;
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
            // TxtPlacafamilia
            // 
            this.TxtPlacafamilia.Enabled = false;
            this.TxtPlacafamilia.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlacafamilia.Location = new System.Drawing.Point(130, 61);
            this.TxtPlacafamilia.Name = "TxtPlacafamilia";
            this.TxtPlacafamilia.Size = new System.Drawing.Size(255, 26);
            this.TxtPlacafamilia.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tipo Vehicular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Origen Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Capacidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Galonaje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Buscar:";
            // 
            // FrmAsignacionPesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 510);
            this.ControlBox = false;
            this.Controls.Add(this.Chk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAsignacionPesos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.FrmAsignacionPesos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTipoVehicular)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaOrigenDestino)).EndInit();
            this.Chk.ResumeLayout(false);
            this.Chk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAsignacionPeso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtBusqueda_TipoVehicular;
        private System.Windows.Forms.DataGridView GrillaTipoVehicular;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBusqueda_OrigenDestino;
        private System.Windows.Forms.DataGridView GrillaListaOrigenDestino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Chk;
        private System.Windows.Forms.TextBox txtgalonaje;
        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.Button btnquitar;
        public System.Windows.Forms.DataGridView GrillaAsignacionPeso;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnAgregar;
        public System.Windows.Forms.TextBox txtorigendestino;
        private System.Windows.Forms.TextBox TxtCodigo;
        public System.Windows.Forms.TextBox TxtPlacafamilia;
        private MetroFramework.Controls.MetroButton BtnSalir;
        private MetroFramework.Controls.MetroButton BtnCancelar;
        private MetroFramework.Controls.MetroButton BtnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}