namespace CapaPresentacion
{
    partial class ReportesUnidadesVehiculares
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
            this.label3 = new System.Windows.Forms.Label();
            this.CboSubTipoVehicular = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboTipoVehicular = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboEstadoVehicular = new System.Windows.Forms.ComboBox();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboSubTipoVehicular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CboTipoVehicular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CboEstadoVehicular);
            this.groupBox1.Controls.Add(this.checkBoxTodos);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidad Vehicular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "SubTipo-Vehicular:";
            // 
            // CboSubTipoVehicular
            // 
            this.CboSubTipoVehicular.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSubTipoVehicular.FormattingEnabled = true;
            this.CboSubTipoVehicular.Location = new System.Drawing.Point(131, 28);
            this.CboSubTipoVehicular.Name = "CboSubTipoVehicular";
            this.CboSubTipoVehicular.Size = new System.Drawing.Size(217, 26);
            this.CboSubTipoVehicular.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo-Vehicular:";
            // 
            // CboTipoVehicular
            // 
            this.CboTipoVehicular.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoVehicular.FormattingEnabled = true;
            this.CboTipoVehicular.Location = new System.Drawing.Point(131, 62);
            this.CboTipoVehicular.Name = "CboTipoVehicular";
            this.CboTipoVehicular.Size = new System.Drawing.Size(217, 26);
            this.CboTipoVehicular.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado-Vehicular:";
            // 
            // CboEstadoVehicular
            // 
            this.CboEstadoVehicular.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstadoVehicular.FormattingEnabled = true;
            this.CboEstadoVehicular.Location = new System.Drawing.Point(131, 103);
            this.CboEstadoVehicular.Name = "CboEstadoVehicular";
            this.CboEstadoVehicular.Size = new System.Drawing.Size(176, 26);
            this.CboEstadoVehicular.TabIndex = 5;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(404, 107);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(58, 22);
            this.checkBoxTodos.TabIndex = 7;
            this.checkBoxTodos.Text = "Todo";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Doc___Google_Docs1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(510, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(58, 54);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::CapaPresentacion.Properties.Resources.Chart___Google_Docs;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton2.Location = new System.Drawing.Point(510, 72);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(58, 54);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.UseSelectable = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::CapaPresentacion.Properties.Resources.Uninstall;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Location = new System.Drawing.Point(519, 131);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(49, 39);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ReportesUnidadesVehiculares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(591, 174);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportesUnidadesVehiculares";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "..::Reportes-Unidades-Vehiculares::..";
            this.Load += new System.EventHandler(this.ReportesUnidadesVehiculares_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboTipoVehicular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboEstadoVehicular;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboSubTipoVehicular;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton BtnSalir;
    }
}