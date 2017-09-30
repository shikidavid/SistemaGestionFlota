namespace CapaPresentacion
{
    partial class FrmEstadoVehicular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadoVehicular));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.TxtEstado = new MetroFramework.Controls.MetroTextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrillaEstadoVehicular = new System.Windows.Forms.DataGridView();
            this.TxtBusqueda = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEstadoVehicular)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnNuevo);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.TxtEstado);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 274);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro-Estado Vehicular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Codigo:";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(16, 177);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(105, 42);
            this.BtnNuevo.TabIndex = 11;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(241, 225);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(102, 42);
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
            this.BtnCancelar.Location = new System.Drawing.Point(238, 177);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 42);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(127, 177);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 42);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCodigo
            // 
            // 
            // 
            // 
            this.TxtCodigo.CustomButton.Image = null;
            this.TxtCodigo.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TxtCodigo.CustomButton.Name = "";
            this.TxtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCodigo.CustomButton.TabIndex = 1;
            this.TxtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCodigo.CustomButton.UseSelectable = true;
            this.TxtCodigo.CustomButton.Visible = false;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Lines = new string[0];
            this.TxtCodigo.Location = new System.Drawing.Point(24, 54);
            this.TxtCodigo.MaxLength = 32767;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.PasswordChar = '\0';
            this.TxtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCodigo.SelectedText = "";
            this.TxtCodigo.SelectionLength = 0;
            this.TxtCodigo.SelectionStart = 0;
            this.TxtCodigo.ShortcutsEnabled = true;
            this.TxtCodigo.Size = new System.Drawing.Size(75, 23);
            this.TxtCodigo.TabIndex = 14;
            this.TxtCodigo.UseSelectable = true;
            this.TxtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtEstado
            // 
            // 
            // 
            // 
            this.TxtEstado.CustomButton.Image = null;
            this.TxtEstado.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.TxtEstado.CustomButton.Name = "";
            this.TxtEstado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEstado.CustomButton.TabIndex = 1;
            this.TxtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEstado.CustomButton.UseSelectable = true;
            this.TxtEstado.CustomButton.Visible = false;
            this.TxtEstado.Lines = new string[0];
            this.TxtEstado.Location = new System.Drawing.Point(22, 114);
            this.TxtEstado.MaxLength = 32767;
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.PasswordChar = '\0';
            this.TxtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEstado.SelectedText = "";
            this.TxtEstado.SelectionLength = 0;
            this.TxtEstado.SelectionStart = 0;
            this.TxtEstado.ShortcutsEnabled = true;
            this.TxtEstado.Size = new System.Drawing.Size(272, 23);
            this.TxtEstado.TabIndex = 13;
            this.TxtEstado.UseSelectable = true;
            this.TxtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEstado_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(331, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(90, 30);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GrillaEstadoVehicular);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.TxtBusqueda);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(372, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 276);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda-Estado Vehicular:";
            // 
            // GrillaEstadoVehicular
            // 
            this.GrillaEstadoVehicular.AllowUserToAddRows = false;
            this.GrillaEstadoVehicular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaEstadoVehicular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.GrillaEstadoVehicular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEstadoVehicular.Location = new System.Drawing.Point(6, 74);
            this.GrillaEstadoVehicular.Name = "GrillaEstadoVehicular";
            this.GrillaEstadoVehicular.ReadOnly = true;
            this.GrillaEstadoVehicular.Size = new System.Drawing.Size(413, 195);
            this.GrillaEstadoVehicular.TabIndex = 7;
            this.GrillaEstadoVehicular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEstadoVehicular_CellClick);
            this.GrillaEstadoVehicular.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEstadoVehicular_CellDoubleClick);
            // 
            // TxtBusqueda
            // 
            // 
            // 
            // 
            this.TxtBusqueda.CustomButton.Image = null;
            this.TxtBusqueda.CustomButton.Location = new System.Drawing.Point(297, 1);
            this.TxtBusqueda.CustomButton.Name = "";
            this.TxtBusqueda.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBusqueda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBusqueda.CustomButton.TabIndex = 1;
            this.TxtBusqueda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBusqueda.CustomButton.UseSelectable = true;
            this.TxtBusqueda.CustomButton.Visible = false;
            this.TxtBusqueda.Lines = new string[0];
            this.TxtBusqueda.Location = new System.Drawing.Point(6, 45);
            this.TxtBusqueda.MaxLength = 32767;
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.PasswordChar = '\0';
            this.TxtBusqueda.PromptText = "Buscar Estado Vehicular";
            this.TxtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBusqueda.SelectedText = "";
            this.TxtBusqueda.SelectionLength = 0;
            this.TxtBusqueda.SelectionStart = 0;
            this.TxtBusqueda.ShortcutsEnabled = true;
            this.TxtBusqueda.Size = new System.Drawing.Size(319, 23);
            this.TxtBusqueda.TabIndex = 11;
            this.TxtBusqueda.UseSelectable = true;
            this.TxtBusqueda.WaterMark = "Buscar Estado Vehicular";
            this.TxtBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBusqueda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged_1);
            // 
            // FrmEstadoVehicular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Magnifier1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(803, 298);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstadoVehicular";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "..::EstadoVehicular::..";
            this.Load += new System.EventHandler(this.FrmEstadoVehicular_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEstadoVehicular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GrillaEstadoVehicular;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnSalir;
        private MetroFramework.Controls.MetroTextBox TxtCodigo;
        private MetroFramework.Controls.MetroTextBox TxtEstado;
        private MetroFramework.Controls.MetroTextBox TxtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}