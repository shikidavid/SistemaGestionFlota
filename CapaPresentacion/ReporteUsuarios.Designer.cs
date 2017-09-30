namespace CapaPresentacion
{
    partial class ReporteUsuarios
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
            this.cboperfil = new System.Windows.Forms.ComboBox();
            this.checkBoxPerfil = new System.Windows.Forms.CheckBox();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboperfil);
            this.groupBox1.Controls.Add(this.checkBoxPerfil);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda - Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Perfil - Usuario";
            // 
            // cboperfil
            // 
            this.cboperfil.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboperfil.FormattingEnabled = true;
            this.cboperfil.Location = new System.Drawing.Point(136, 44);
            this.cboperfil.Name = "cboperfil";
            this.cboperfil.Size = new System.Drawing.Size(211, 26);
            this.cboperfil.TabIndex = 11;
            // 
            // checkBoxPerfil
            // 
            this.checkBoxPerfil.AutoSize = true;
            this.checkBoxPerfil.Location = new System.Drawing.Point(364, 46);
            this.checkBoxPerfil.Name = "checkBoxPerfil";
            this.checkBoxPerfil.Size = new System.Drawing.Size(58, 22);
            this.checkBoxPerfil.TabIndex = 7;
            this.checkBoxPerfil.Text = "Todo";
            this.checkBoxPerfil.UseVisualStyleBackColor = true;
            this.checkBoxPerfil.CheckedChanged += new System.EventHandler(this.checkBoxPerfil_CheckedChanged);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::CapaPresentacion.Properties.Resources.Uninstall;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Location = new System.Drawing.Point(553, 97);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(33, 29);
            this.BtnSalir.TabIndex = 19;
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::CapaPresentacion.Properties.Resources.Chart___Google_Docs;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton2.Location = new System.Drawing.Point(493, 77);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(45, 39);
            this.metroButton2.TabIndex = 18;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Doc___Google_Docs1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(493, 32);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(45, 39);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.UseSelectable = true;
            // 
            // ReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 130);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteUsuarios";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboperfil;
        private System.Windows.Forms.CheckBox checkBoxPerfil;
        private MetroFramework.Controls.MetroButton BtnSalir;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}