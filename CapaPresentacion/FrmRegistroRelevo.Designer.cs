namespace CapaPresentacion
{
    partial class FrmRegistroRelevo
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtTipoVehicular = new System.Windows.Forms.TextBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.GrillaTipoVehicular = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOrigenDestino = new System.Windows.Forms.TextBox();
            this.GrillaOrigenDestino = new System.Windows.Forms.DataGridView();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.BtnCancelar = new MetroFramework.Controls.MetroButton();
            this.BtnGuardar = new MetroFramework.Controls.MetroButton();
            this.BtnQuitar = new MetroFramework.Controls.MetroButton();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.TxtRelevo = new MetroFramework.Controls.MetroTextBox();
            this.TxtOrigen = new MetroFramework.Controls.MetroTextBox();
            this.TxtTipo = new MetroFramework.Controls.MetroTextBox();
            this.GrillaRelevo = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTipoVehicular)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaOrigenDestino)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRelevo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.TxtTipoVehicular);
            this.groupBox2.Controls.Add(this.metroButton4);
            this.groupBox2.Controls.Add(this.GrillaTipoVehicular);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 240);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda-Tipo Vehicular:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 17);
            this.label18.TabIndex = 43;
            this.label18.Text = "Buscar:";
            // 
            // TxtTipoVehicular
            // 
            this.TxtTipoVehicular.Location = new System.Drawing.Point(64, 33);
            this.TxtTipoVehicular.Name = "TxtTipoVehicular";
            this.TxtTipoVehicular.Size = new System.Drawing.Size(270, 26);
            this.TxtTipoVehicular.TabIndex = 38;
            this.TxtTipoVehicular.TextChanged += new System.EventHandler(this.TxtTipoVehicular_TextChanged_1);
            this.TxtTipoVehicular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoVehicular_KeyPress);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(340, 19);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(104, 42);
            this.metroButton4.TabIndex = 37;
            this.metroButton4.Text = "&Buscar";
            this.metroButton4.UseSelectable = true;
            // 
            // GrillaTipoVehicular
            // 
            this.GrillaTipoVehicular.AllowUserToAddRows = false;
            this.GrillaTipoVehicular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaTipoVehicular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaTipoVehicular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaTipoVehicular.Location = new System.Drawing.Point(8, 71);
            this.GrillaTipoVehicular.Name = "GrillaTipoVehicular";
            this.GrillaTipoVehicular.ReadOnly = true;
            this.GrillaTipoVehicular.Size = new System.Drawing.Size(436, 163);
            this.GrillaTipoVehicular.TabIndex = 7;
            this.GrillaTipoVehicular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaTipoVehicular_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtOrigenDestino);
            this.groupBox1.Controls.Add(this.GrillaOrigenDestino);
            this.groupBox1.Controls.Add(this.metroButton5);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 233);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda-Origen y Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Buscar:";
            // 
            // TxtOrigenDestino
            // 
            this.TxtOrigenDestino.Location = new System.Drawing.Point(64, 35);
            this.TxtOrigenDestino.Name = "TxtOrigenDestino";
            this.TxtOrigenDestino.Size = new System.Drawing.Size(270, 26);
            this.TxtOrigenDestino.TabIndex = 39;
            this.TxtOrigenDestino.TextChanged += new System.EventHandler(this.TxtOrigenDestino_TextChanged_1);
            this.TxtOrigenDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOrigenDestino_KeyPress);
            // 
            // GrillaOrigenDestino
            // 
            this.GrillaOrigenDestino.AllowUserToAddRows = false;
            this.GrillaOrigenDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaOrigenDestino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaOrigenDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaOrigenDestino.Location = new System.Drawing.Point(8, 67);
            this.GrillaOrigenDestino.Name = "GrillaOrigenDestino";
            this.GrillaOrigenDestino.ReadOnly = true;
            this.GrillaOrigenDestino.Size = new System.Drawing.Size(436, 159);
            this.GrillaOrigenDestino.TabIndex = 38;
            this.GrillaOrigenDestino.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaOrigenDestino_CellClick_1);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(340, 19);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(104, 42);
            this.metroButton5.TabIndex = 38;
            this.metroButton5.Text = "&Buscar";
            this.metroButton5.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.BtnSalir);
            this.groupBox3.Controls.Add(this.BtnCancelar);
            this.groupBox3.Controls.Add(this.BtnGuardar);
            this.groupBox3.Controls.Add(this.BtnQuitar);
            this.groupBox3.Controls.Add(this.BtnAgregar);
            this.groupBox3.Controls.Add(this.TxtRelevo);
            this.groupBox3.Controls.Add(this.TxtOrigen);
            this.groupBox3.Controls.Add(this.TxtTipo);
            this.groupBox3.Controls.Add(this.GrillaRelevo);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(475, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 479);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro - Relevo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Relevo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Origen Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tipo Vehicular:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(370, 423);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(104, 42);
            this.BtnSalir.TabIndex = 36;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(231, 423);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(104, 42);
            this.BtnCancelar.TabIndex = 35;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseSelectable = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(92, 423);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(104, 42);
            this.BtnGuardar.TabIndex = 34;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseSelectable = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Location = new System.Drawing.Point(391, 177);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(104, 42);
            this.BtnQuitar.TabIndex = 33;
            this.BtnQuitar.Text = "&Quitar";
            this.BtnQuitar.UseSelectable = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(391, 129);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(104, 42);
            this.BtnAgregar.TabIndex = 32;
            this.BtnAgregar.Text = "&Agregar";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TxtRelevo
            // 
            this.TxtRelevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtRelevo.CustomButton.Image = null;
            this.TxtRelevo.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.TxtRelevo.CustomButton.Name = "";
            this.TxtRelevo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRelevo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRelevo.CustomButton.TabIndex = 1;
            this.TxtRelevo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRelevo.CustomButton.UseSelectable = true;
            this.TxtRelevo.CustomButton.Visible = false;
            this.TxtRelevo.Lines = new string[0];
            this.TxtRelevo.Location = new System.Drawing.Point(144, 95);
            this.TxtRelevo.MaxLength = 32767;
            this.TxtRelevo.Name = "TxtRelevo";
            this.TxtRelevo.PasswordChar = '\0';
            this.TxtRelevo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRelevo.SelectedText = "";
            this.TxtRelevo.SelectionLength = 0;
            this.TxtRelevo.SelectionStart = 0;
            this.TxtRelevo.ShortcutsEnabled = true;
            this.TxtRelevo.Size = new System.Drawing.Size(146, 23);
            this.TxtRelevo.TabIndex = 26;
            this.TxtRelevo.UseSelectable = true;
            this.TxtRelevo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRelevo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtRelevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRelevo_KeyPress);
            // 
            // TxtOrigen
            // 
            // 
            // 
            // 
            this.TxtOrigen.CustomButton.Image = null;
            this.TxtOrigen.CustomButton.Location = new System.Drawing.Point(308, 1);
            this.TxtOrigen.CustomButton.Name = "";
            this.TxtOrigen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtOrigen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtOrigen.CustomButton.TabIndex = 1;
            this.TxtOrigen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtOrigen.CustomButton.UseSelectable = true;
            this.TxtOrigen.CustomButton.Visible = false;
            this.TxtOrigen.Enabled = false;
            this.TxtOrigen.Lines = new string[0];
            this.TxtOrigen.Location = new System.Drawing.Point(144, 58);
            this.TxtOrigen.MaxLength = 32767;
            this.TxtOrigen.Name = "TxtOrigen";
            this.TxtOrigen.PasswordChar = '\0';
            this.TxtOrigen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtOrigen.SelectedText = "";
            this.TxtOrigen.SelectionLength = 0;
            this.TxtOrigen.SelectionStart = 0;
            this.TxtOrigen.ShortcutsEnabled = true;
            this.TxtOrigen.Size = new System.Drawing.Size(330, 23);
            this.TxtOrigen.TabIndex = 25;
            this.TxtOrigen.UseSelectable = true;
            this.TxtOrigen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtOrigen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtTipo
            // 
            // 
            // 
            // 
            this.TxtTipo.CustomButton.Image = null;
            this.TxtTipo.CustomButton.Location = new System.Drawing.Point(308, 1);
            this.TxtTipo.CustomButton.Name = "";
            this.TxtTipo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtTipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTipo.CustomButton.TabIndex = 1;
            this.TxtTipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTipo.CustomButton.UseSelectable = true;
            this.TxtTipo.CustomButton.Visible = false;
            this.TxtTipo.Enabled = false;
            this.TxtTipo.Lines = new string[0];
            this.TxtTipo.Location = new System.Drawing.Point(144, 24);
            this.TxtTipo.MaxLength = 32767;
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.PasswordChar = '\0';
            this.TxtTipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTipo.SelectedText = "";
            this.TxtTipo.SelectionLength = 0;
            this.TxtTipo.SelectionStart = 0;
            this.TxtTipo.ShortcutsEnabled = true;
            this.TxtTipo.Size = new System.Drawing.Size(330, 23);
            this.TxtTipo.TabIndex = 24;
            this.TxtTipo.UseSelectable = true;
            this.TxtTipo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTipo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GrillaRelevo
            // 
            this.GrillaRelevo.AllowUserToAddRows = false;
            this.GrillaRelevo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaRelevo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaRelevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaRelevo.Location = new System.Drawing.Point(18, 129);
            this.GrillaRelevo.Name = "GrillaRelevo";
            this.GrillaRelevo.ReadOnly = true;
            this.GrillaRelevo.Size = new System.Drawing.Size(367, 277);
            this.GrillaRelevo.TabIndex = 20;
            // 
            // FrmRegistroRelevo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(993, 515);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "FrmRegistroRelevo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTipoVehicular)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaOrigenDestino)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRelevo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GrillaTipoVehicular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView GrillaRelevo;
        private MetroFramework.Controls.MetroTextBox TxtTipo;
        private MetroFramework.Controls.MetroTextBox TxtRelevo;
        private MetroFramework.Controls.MetroTextBox TxtOrigen;
        private MetroFramework.Controls.MetroButton BtnQuitar;
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private MetroFramework.Controls.MetroButton BtnSalir;
        private MetroFramework.Controls.MetroButton BtnCancelar;
        private MetroFramework.Controls.MetroButton BtnGuardar;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.DataGridView GrillaOrigenDestino;
        private System.Windows.Forms.TextBox TxtTipoVehicular;
        private System.Windows.Forms.TextBox TxtOrigenDestino;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}