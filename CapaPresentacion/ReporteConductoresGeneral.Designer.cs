namespace CapaPresentacion
{
    partial class ReporteConductoresGeneral
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
            this.CboTipoContrato = new System.Windows.Forms.ComboBox();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxFechaVencimiento = new System.Windows.Forms.CheckBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CboEstadoConductor = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.checkBoxTipoContrato = new System.Windows.Forms.CheckBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxTipoContrato);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CboTipoContrato);
            this.groupBox1.Controls.Add(this.checkBoxFecha);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "T-Contrato:";
            // 
            // CboTipoContrato
            // 
            this.CboTipoContrato.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoContrato.FormattingEnabled = true;
            this.CboTipoContrato.Location = new System.Drawing.Point(93, 57);
            this.CboTipoContrato.Name = "CboTipoContrato";
            this.CboTipoContrato.Size = new System.Drawing.Size(144, 26);
            this.CboTipoContrato.TabIndex = 5;
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Location = new System.Drawing.Point(342, 25);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(58, 22);
            this.checkBoxFecha.TabIndex = 7;
            this.checkBoxFecha.Text = "Todo";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            this.checkBoxFecha.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(238, 23);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(98, 26);
            this.dtpFechaFinal.TabIndex = 5;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha-F:";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(68, 25);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(98, 26);
            this.dtpFechaInicial.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha-I:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxEstado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBoxFechaVencimiento);
            this.groupBox2.Controls.Add(this.dtpFechaVencimiento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CboEstadoConductor);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conductor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado-C:";
            // 
            // checkBoxFechaVencimiento
            // 
            this.checkBoxFechaVencimiento.AutoSize = true;
            this.checkBoxFechaVencimiento.Location = new System.Drawing.Point(6, 20);
            this.checkBoxFechaVencimiento.Name = "checkBoxFechaVencimiento";
            this.checkBoxFechaVencimiento.Size = new System.Drawing.Size(58, 22);
            this.checkBoxFechaVencimiento.TabIndex = 9;
            this.checkBoxFechaVencimiento.Text = "Todo";
            this.checkBoxFechaVencimiento.UseVisualStyleBackColor = true;
            this.checkBoxFechaVencimiento.CheckedChanged += new System.EventHandler(this.checkBoxFechaVencimiento_CheckedChanged);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(69, 39);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(98, 26);
            this.dtpFechaVencimiento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha-V:";
            // 
            // CboEstadoConductor
            // 
            this.CboEstadoConductor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstadoConductor.FormattingEnabled = true;
            this.CboEstadoConductor.Location = new System.Drawing.Point(243, 20);
            this.CboEstadoConductor.Name = "CboEstadoConductor";
            this.CboEstadoConductor.Size = new System.Drawing.Size(144, 26);
            this.CboEstadoConductor.TabIndex = 9;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::CapaPresentacion.Properties.Resources.Uninstall;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Location = new System.Drawing.Point(521, 171);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(49, 39);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // checkBoxTipoContrato
            // 
            this.checkBoxTipoContrato.AutoSize = true;
            this.checkBoxTipoContrato.Location = new System.Drawing.Point(243, 59);
            this.checkBoxTipoContrato.Name = "checkBoxTipoContrato";
            this.checkBoxTipoContrato.Size = new System.Drawing.Size(58, 22);
            this.checkBoxTipoContrato.TabIndex = 9;
            this.checkBoxTipoContrato.Text = "Todo";
            this.checkBoxTipoContrato.UseVisualStyleBackColor = true;
            this.checkBoxTipoContrato.CheckedChanged += new System.EventHandler(this.checkBoxTipoContrato_CheckedChanged);
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(243, 52);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(58, 22);
            this.checkBoxEstado.TabIndex = 10;
            this.checkBoxEstado.Text = "Todo";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.CheckedChanged += new System.EventHandler(this.checkBoxEstado_CheckedChanged);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::CapaPresentacion.Properties.Resources.Chart___Google_Docs;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton2.Location = new System.Drawing.Point(487, 96);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(83, 65);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Doc___Google_Docs1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(487, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(83, 65);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.UseSelectable = true;
            // 
            // ReporteConductoresGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(574, 216);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteConductoresGeneral";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "..::Conductores - General::..";
            this.Load += new System.EventHandler(this.ReporteConductoresGeneral_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboTipoContrato;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboEstadoConductor;
        private MetroFramework.Controls.MetroButton BtnSalir;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.CheckBox checkBoxTipoContrato;
        private System.Windows.Forms.CheckBox checkBoxEstado;
    }
}