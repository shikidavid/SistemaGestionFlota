namespace CapaPresentacion
{
    partial class ReporteRutas
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
            this.CboTipoVehicular = new System.Windows.Forms.ComboBox();
            this.checkBoxTipo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cborutas = new System.Windows.Forms.ComboBox();
            this.checkBoxRutas = new System.Windows.Forms.CheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CboTipoVehicular);
            this.groupBox1.Controls.Add(this.checkBoxTipo);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relleno Por Tipo Vehicular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo-Vehicular:";
            // 
            // CboTipoVehicular
            // 
            this.CboTipoVehicular.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoVehicular.FormattingEnabled = true;
            this.CboTipoVehicular.Location = new System.Drawing.Point(107, 36);
            this.CboTipoVehicular.Name = "CboTipoVehicular";
            this.CboTipoVehicular.Size = new System.Drawing.Size(210, 26);
            this.CboTipoVehicular.TabIndex = 5;
            // 
            // checkBoxTipo
            // 
            this.checkBoxTipo.AutoSize = true;
            this.checkBoxTipo.Location = new System.Drawing.Point(330, 38);
            this.checkBoxTipo.Name = "checkBoxTipo";
            this.checkBoxTipo.Size = new System.Drawing.Size(58, 22);
            this.checkBoxTipo.TabIndex = 7;
            this.checkBoxTipo.Text = "Todo";
            this.checkBoxTipo.UseVisualStyleBackColor = true;
            this.checkBoxTipo.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cborutas);
            this.groupBox2.Controls.Add(this.checkBoxRutas);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 91);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rutas - Tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rutas:";
            // 
            // cborutas
            // 
            this.cborutas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborutas.FormattingEnabled = true;
            this.cborutas.Location = new System.Drawing.Point(107, 42);
            this.cborutas.Name = "cborutas";
            this.cborutas.Size = new System.Drawing.Size(210, 26);
            this.cborutas.TabIndex = 5;
            // 
            // checkBoxRutas
            // 
            this.checkBoxRutas.AutoSize = true;
            this.checkBoxRutas.Location = new System.Drawing.Point(330, 44);
            this.checkBoxRutas.Name = "checkBoxRutas";
            this.checkBoxRutas.Size = new System.Drawing.Size(58, 22);
            this.checkBoxRutas.TabIndex = 7;
            this.checkBoxRutas.Text = "Todo";
            this.checkBoxRutas.UseVisualStyleBackColor = true;
            this.checkBoxRutas.CheckedChanged += new System.EventHandler(this.checkBoxRutas_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Doc___Google_Docs1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(416, 33);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(53, 48);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::CapaPresentacion.Properties.Resources.Doc___Google_Docs1;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton2.Location = new System.Drawing.Point(416, 135);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(53, 48);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.BackgroundImage = global::CapaPresentacion.Properties.Resources.Chart___Google_Docs;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton3.Location = new System.Drawing.Point(485, 33);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(53, 48);
            this.metroButton3.TabIndex = 15;
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = global::CapaPresentacion.Properties.Resources.Chart___Google_Docs;
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton4.Location = new System.Drawing.Point(485, 135);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(53, 48);
            this.metroButton4.TabIndex = 16;
            this.metroButton4.UseSelectable = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::CapaPresentacion.Properties.Resources.Uninstall;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Location = new System.Drawing.Point(544, 87);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(49, 39);
            this.BtnSalir.TabIndex = 17;
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ReporteRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 206);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteRutas";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.ReporteRutas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboTipoVehicular;
        private System.Windows.Forms.CheckBox checkBoxTipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cborutas;
        private System.Windows.Forms.CheckBox checkBoxRutas;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton BtnSalir;
    }
}