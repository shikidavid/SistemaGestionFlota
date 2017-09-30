namespace CapaPresentacion
{
    partial class FrmExportarData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportarData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.btngenerar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.btngenerar);
            this.groupBox1.Controls.Add(this.BtnSeleccionar);
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 200);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar BD";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(473, 152);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(104, 42);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.Image")));
            this.btngenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngenerar.Location = new System.Drawing.Point(18, 115);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(281, 60);
            this.btngenerar.TabIndex = 13;
            this.btngenerar.Text = "&Generar Copia Seguridad";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Image")));
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(426, 59);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(127, 48);
            this.BtnSeleccionar.TabIndex = 11;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(18, 69);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(374, 26);
            this.TxtBuscar.TabIndex = 8;
            // 
            // FrmExportarData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(605, 228);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExportarData";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "..::ExportarData::..";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private MetroFramework.Controls.MetroButton BtnSalir;
    }
}