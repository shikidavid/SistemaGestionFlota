namespace CapaPresentacion
{
    partial class FrmDetalleRelevo
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.BtnGuardar = new MetroFramework.Controls.MetroButton();
            this.TxtTanqueo = new MetroFramework.Controls.MetroTextBox();
            this.TxtKilometraje = new MetroFramework.Controls.MetroTextBox();
            this.CbRelevo = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LstTiempos = new System.Windows.Forms.ListBox();
            this.TxtTotalKilometraje = new MetroFramework.Controls.MetroTextBox();
            this.txttotaltanqueo = new MetroFramework.Controls.MetroTextBox();
            this.GrillaRelevoUnidad = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRelevoUnidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.TxtTanqueo);
            this.groupBox1.Controls.Add(this.TxtKilometraje);
            this.groupBox1.Controls.Add(this.CbRelevo);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda - Relevo:";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroButton1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Uninstall;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.metroButton1.Location = new System.Drawing.Point(271, 154);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(62, 51);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackgroundImage = global::CapaPresentacion.Properties.Resources.Save;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.Location = new System.Drawing.Point(196, 154);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(62, 51);
            this.BtnGuardar.TabIndex = 19;
            this.BtnGuardar.UseSelectable = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtTanqueo
            // 
            // 
            // 
            // 
            this.TxtTanqueo.CustomButton.Image = null;
            this.TxtTanqueo.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.TxtTanqueo.CustomButton.Name = "";
            this.TxtTanqueo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtTanqueo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTanqueo.CustomButton.TabIndex = 1;
            this.TxtTanqueo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTanqueo.CustomButton.UseSelectable = true;
            this.TxtTanqueo.CustomButton.Visible = false;
            this.TxtTanqueo.Lines = new string[0];
            this.TxtTanqueo.Location = new System.Drawing.Point(90, 115);
            this.TxtTanqueo.MaxLength = 32767;
            this.TxtTanqueo.Name = "TxtTanqueo";
            this.TxtTanqueo.PasswordChar = '\0';
            this.TxtTanqueo.PromptText = "Tanqueo";
            this.TxtTanqueo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTanqueo.SelectedText = "";
            this.TxtTanqueo.SelectionLength = 0;
            this.TxtTanqueo.SelectionStart = 0;
            this.TxtTanqueo.ShortcutsEnabled = true;
            this.TxtTanqueo.Size = new System.Drawing.Size(141, 23);
            this.TxtTanqueo.TabIndex = 3;
            this.TxtTanqueo.UseSelectable = true;
            this.TxtTanqueo.WaterMark = "Tanqueo";
            this.TxtTanqueo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTanqueo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtKilometraje
            // 
            // 
            // 
            // 
            this.TxtKilometraje.CustomButton.Image = null;
            this.TxtKilometraje.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.TxtKilometraje.CustomButton.Name = "";
            this.TxtKilometraje.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtKilometraje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtKilometraje.CustomButton.TabIndex = 1;
            this.TxtKilometraje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtKilometraje.CustomButton.UseSelectable = true;
            this.TxtKilometraje.CustomButton.Visible = false;
            this.TxtKilometraje.Lines = new string[0];
            this.TxtKilometraje.Location = new System.Drawing.Point(90, 80);
            this.TxtKilometraje.MaxLength = 32767;
            this.TxtKilometraje.Name = "TxtKilometraje";
            this.TxtKilometraje.PasswordChar = '\0';
            this.TxtKilometraje.PromptText = "Kilometraje";
            this.TxtKilometraje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtKilometraje.SelectedText = "";
            this.TxtKilometraje.SelectionLength = 0;
            this.TxtKilometraje.SelectionStart = 0;
            this.TxtKilometraje.ShortcutsEnabled = true;
            this.TxtKilometraje.Size = new System.Drawing.Size(141, 23);
            this.TxtKilometraje.TabIndex = 2;
            this.TxtKilometraje.UseSelectable = true;
            this.TxtKilometraje.WaterMark = "Kilometraje";
            this.TxtKilometraje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtKilometraje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CbRelevo
            // 
            this.CbRelevo.FormattingEnabled = true;
            this.CbRelevo.ItemHeight = 23;
            this.CbRelevo.Location = new System.Drawing.Point(90, 19);
            this.CbRelevo.Name = "CbRelevo";
            this.CbRelevo.Size = new System.Drawing.Size(214, 29);
            this.CbRelevo.TabIndex = 0;
            this.CbRelevo.UseSelectable = true;
            this.CbRelevo.SelectedIndexChanged += new System.EventHandler(this.CbRelevo_SelectedIndexChanged);
            this.CbRelevo.ValueMemberChanged += new System.EventHandler(this.CbRelevo_ValueMemberChanged);
            this.CbRelevo.SelectedValueChanged += new System.EventHandler(this.CbRelevo_SelectedValueChanged);
            this.CbRelevo.TextChanged += new System.EventHandler(this.CbRelevo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LstTiempos);
            this.groupBox2.Controls.Add(this.TxtTotalKilometraje);
            this.groupBox2.Controls.Add(this.txttotaltanqueo);
            this.groupBox2.Controls.Add(this.GrillaRelevoUnidad);
            this.groupBox2.Location = new System.Drawing.Point(354, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro - Relevo:";
            // 
            // LstTiempos
            // 
            this.LstTiempos.FormattingEnabled = true;
            this.LstTiempos.Location = new System.Drawing.Point(370, 45);
            this.LstTiempos.Name = "LstTiempos";
            this.LstTiempos.Size = new System.Drawing.Size(99, 108);
            this.LstTiempos.TabIndex = 7;
            // 
            // TxtTotalKilometraje
            // 
            this.TxtTotalKilometraje.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.TxtTotalKilometraje.CustomButton.Image = null;
            this.TxtTotalKilometraje.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TxtTotalKilometraje.CustomButton.Name = "";
            this.TxtTotalKilometraje.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtTotalKilometraje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTotalKilometraje.CustomButton.TabIndex = 1;
            this.TxtTotalKilometraje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTotalKilometraje.CustomButton.UseSelectable = true;
            this.TxtTotalKilometraje.CustomButton.Visible = false;
            this.TxtTotalKilometraje.Enabled = false;
            this.TxtTotalKilometraje.Lines = new string[0];
            this.TxtTotalKilometraje.Location = new System.Drawing.Point(126, 184);
            this.TxtTotalKilometraje.MaxLength = 32767;
            this.TxtTotalKilometraje.Name = "TxtTotalKilometraje";
            this.TxtTotalKilometraje.PasswordChar = '\0';
            this.TxtTotalKilometraje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTotalKilometraje.SelectedText = "";
            this.TxtTotalKilometraje.SelectionLength = 0;
            this.TxtTotalKilometraje.SelectionStart = 0;
            this.TxtTotalKilometraje.ShortcutsEnabled = true;
            this.TxtTotalKilometraje.Size = new System.Drawing.Size(75, 23);
            this.TxtTotalKilometraje.TabIndex = 6;
            this.TxtTotalKilometraje.UseCustomBackColor = true;
            this.TxtTotalKilometraje.UseCustomForeColor = true;
            this.TxtTotalKilometraje.UseSelectable = true;
            this.TxtTotalKilometraje.UseStyleColors = true;
            this.TxtTotalKilometraje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTotalKilometraje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txttotaltanqueo
            // 
            this.txttotaltanqueo.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txttotaltanqueo.CustomButton.Image = null;
            this.txttotaltanqueo.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txttotaltanqueo.CustomButton.Name = "";
            this.txttotaltanqueo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttotaltanqueo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttotaltanqueo.CustomButton.TabIndex = 1;
            this.txttotaltanqueo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttotaltanqueo.CustomButton.UseSelectable = true;
            this.txttotaltanqueo.CustomButton.Visible = false;
            this.txttotaltanqueo.Enabled = false;
            this.txttotaltanqueo.Lines = new string[0];
            this.txttotaltanqueo.Location = new System.Drawing.Point(289, 184);
            this.txttotaltanqueo.MaxLength = 32767;
            this.txttotaltanqueo.Name = "txttotaltanqueo";
            this.txttotaltanqueo.PasswordChar = '\0';
            this.txttotaltanqueo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttotaltanqueo.SelectedText = "";
            this.txttotaltanqueo.SelectionLength = 0;
            this.txttotaltanqueo.SelectionStart = 0;
            this.txttotaltanqueo.ShortcutsEnabled = true;
            this.txttotaltanqueo.Size = new System.Drawing.Size(75, 23);
            this.txttotaltanqueo.TabIndex = 4;
            this.txttotaltanqueo.UseCustomBackColor = true;
            this.txttotaltanqueo.UseCustomForeColor = true;
            this.txttotaltanqueo.UseSelectable = true;
            this.txttotaltanqueo.UseStyleColors = true;
            this.txttotaltanqueo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttotaltanqueo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GrillaRelevoUnidad
            // 
            this.GrillaRelevoUnidad.AllowUserToAddRows = false;
            this.GrillaRelevoUnidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaRelevoUnidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaRelevoUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaRelevoUnidad.Location = new System.Drawing.Point(6, 19);
            this.GrillaRelevoUnidad.Name = "GrillaRelevoUnidad";
            this.GrillaRelevoUnidad.Size = new System.Drawing.Size(358, 162);
            this.GrillaRelevoUnidad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Relevos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Kilometraje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Tanqueo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "T-Kilometraje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "T-Tanqueo:";
            // 
            // FrmDetalleRelevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 242);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalleRelevo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmDetalleRelevo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRelevoUnidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TxtTanqueo;
        private MetroFramework.Controls.MetroTextBox TxtKilometraje;
        private MetroFramework.Controls.MetroComboBox CbRelevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GrillaRelevoUnidad;
        private MetroFramework.Controls.MetroButton BtnGuardar;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox TxtTotalKilometraje;
        private MetroFramework.Controls.MetroTextBox txttotaltanqueo;
        private System.Windows.Forms.ListBox LstTiempos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}