namespace CapaPresentacion
{
    partial class FrmImportarData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportarData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnimportar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.TxtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.btnimportar);
            this.groupBox1.Controls.Add(this.BtnNuevo);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 213);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importar BD";
            // 
            // btnimportar
            // 
            this.btnimportar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportar.Image = ((System.Drawing.Image)(resources.GetObject("btnimportar.Image")));
            this.btnimportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimportar.Location = new System.Drawing.Point(55, 139);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(262, 60);
            this.btnimportar.TabIndex = 13;
            this.btnimportar.Text = "&Importar Base de Dato";
            this.btnimportar.UseVisualStyleBackColor = true;
            this.btnimportar.Click += new System.EventHandler(this.btnimportar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(411, 38);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(141, 48);
            this.BtnNuevo.TabIndex = 11;
            this.BtnNuevo.Text = "&Elegir";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(465, 165);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(104, 42);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // TxtBuscar
            // 
            // 
            // 
            // 
            this.TxtBuscar.CustomButton.Image = null;
            this.TxtBuscar.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.TxtBuscar.CustomButton.Name = "";
            this.TxtBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBuscar.CustomButton.TabIndex = 1;
            this.TxtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBuscar.CustomButton.UseSelectable = true;
            this.TxtBuscar.CustomButton.Visible = false;
            this.TxtBuscar.Lines = new string[0];
            this.TxtBuscar.Location = new System.Drawing.Point(29, 50);
            this.TxtBuscar.MaxLength = 32767;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.PromptText = "Seleccionar la Ruta";
            this.TxtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.SelectionLength = 0;
            this.TxtBuscar.SelectionStart = 0;
            this.TxtBuscar.ShortcutsEnabled = true;
            this.TxtBuscar.Size = new System.Drawing.Size(360, 23);
            this.TxtBuscar.TabIndex = 16;
            this.TxtBuscar.UseSelectable = true;
            this.TxtBuscar.WaterMark = "Seleccionar la Ruta";
            this.TxtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmImportarData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 235);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportarData";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "..::Importar Data::..";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button btnimportar;
        private MetroFramework.Controls.MetroButton BtnSalir;
        private MetroFramework.Controls.MetroTextBox TxtBuscar;
    }
}