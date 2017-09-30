namespace CapaPresentacion
{
    partial class ReporteControlCombustible
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.label7 = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.TxtPlaca = new MetroFramework.Controls.MetroTextBox();
            this.CheckBoxPlacaTodo = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckBoxImcompleto = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxCompleto = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxLiquidacion = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxLiquidacionTodos = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CheckBoxExceso = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxCombustibleTodos = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxAhorro = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxNormal = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CheckBoxMuyMalo = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxMalo = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxRegular = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxTodosTiempo = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxMuyBueno = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxBueno = new MetroFramework.Controls.MetroCheckBox();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.metroDateTime2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.metroDateTime1);
            this.groupBox1.Controls.Add(this.TxtPlaca);
            this.groupBox1.Controls.Add(this.CheckBoxPlacaTodo);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Fecha - Final:";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime2.Location = new System.Drawing.Point(383, 27);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(108, 29);
            this.metroDateTime2.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "Fecha - Inicial:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(251, 29);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(108, 29);
            this.metroDateTime1.TabIndex = 2;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtPlaca.CustomButton.Image = null;
            this.TxtPlaca.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.TxtPlaca.CustomButton.Name = "";
            this.TxtPlaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPlaca.CustomButton.TabIndex = 1;
            this.TxtPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPlaca.CustomButton.UseSelectable = true;
            this.TxtPlaca.CustomButton.Visible = false;
            this.TxtPlaca.Lines = new string[0];
            this.TxtPlaca.Location = new System.Drawing.Point(6, 35);
            this.TxtPlaca.MaxLength = 7;
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.PasswordChar = '\0';
            this.TxtPlaca.PromptText = "Digitar - Placa";
            this.TxtPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPlaca.SelectedText = "";
            this.TxtPlaca.SelectionLength = 0;
            this.TxtPlaca.SelectionStart = 0;
            this.TxtPlaca.ShortcutsEnabled = true;
            this.TxtPlaca.Size = new System.Drawing.Size(229, 23);
            this.TxtPlaca.TabIndex = 1;
            this.TxtPlaca.UseSelectable = true;
            this.TxtPlaca.WaterMark = "Digitar - Placa";
            this.TxtPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CheckBoxPlacaTodo
            // 
            this.CheckBoxPlacaTodo.AutoSize = true;
            this.CheckBoxPlacaTodo.Location = new System.Drawing.Point(6, 19);
            this.CheckBoxPlacaTodo.Name = "CheckBoxPlacaTodo";
            this.CheckBoxPlacaTodo.Size = new System.Drawing.Size(59, 15);
            this.CheckBoxPlacaTodo.TabIndex = 0;
            this.CheckBoxPlacaTodo.Text = "Todos:";
            this.CheckBoxPlacaTodo.UseSelectable = true;
            this.CheckBoxPlacaTodo.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckBoxImcompleto);
            this.groupBox2.Controls.Add(this.CheckBoxCompleto);
            this.groupBox2.Controls.Add(this.CheckBoxLiquidacion);
            this.groupBox2.Controls.Add(this.CheckBoxLiquidacionTodos);
            this.groupBox2.Location = new System.Drawing.Point(401, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 108);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liquidaciones:";
            // 
            // CheckBoxImcompleto
            // 
            this.CheckBoxImcompleto.AutoSize = true;
            this.CheckBoxImcompleto.Location = new System.Drawing.Point(6, 82);
            this.CheckBoxImcompleto.Name = "CheckBoxImcompleto";
            this.CheckBoxImcompleto.Size = new System.Drawing.Size(84, 15);
            this.CheckBoxImcompleto.TabIndex = 77;
            this.CheckBoxImcompleto.Text = "Incompleto";
            this.CheckBoxImcompleto.UseSelectable = true;
            // 
            // CheckBoxCompleto
            // 
            this.CheckBoxCompleto.AutoSize = true;
            this.CheckBoxCompleto.Location = new System.Drawing.Point(6, 61);
            this.CheckBoxCompleto.Name = "CheckBoxCompleto";
            this.CheckBoxCompleto.Size = new System.Drawing.Size(76, 15);
            this.CheckBoxCompleto.TabIndex = 77;
            this.CheckBoxCompleto.Text = "Completo";
            this.CheckBoxCompleto.UseSelectable = true;
            // 
            // CheckBoxLiquidacion
            // 
            this.CheckBoxLiquidacion.AutoSize = true;
            this.CheckBoxLiquidacion.Location = new System.Drawing.Point(6, 40);
            this.CheckBoxLiquidacion.Name = "CheckBoxLiquidacion";
            this.CheckBoxLiquidacion.Size = new System.Drawing.Size(85, 15);
            this.CheckBoxLiquidacion.TabIndex = 75;
            this.CheckBoxLiquidacion.Text = "Liquidacion";
            this.CheckBoxLiquidacion.UseSelectable = true;
            // 
            // CheckBoxLiquidacionTodos
            // 
            this.CheckBoxLiquidacionTodos.AutoSize = true;
            this.CheckBoxLiquidacionTodos.Location = new System.Drawing.Point(6, 19);
            this.CheckBoxLiquidacionTodos.Name = "CheckBoxLiquidacionTodos";
            this.CheckBoxLiquidacionTodos.Size = new System.Drawing.Size(56, 15);
            this.CheckBoxLiquidacionTodos.TabIndex = 74;
            this.CheckBoxLiquidacionTodos.Text = "Todos";
            this.CheckBoxLiquidacionTodos.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CheckBoxExceso);
            this.groupBox3.Controls.Add(this.CheckBoxCombustibleTodos);
            this.groupBox3.Controls.Add(this.CheckBoxAhorro);
            this.groupBox3.Controls.Add(this.CheckBoxNormal);
            this.groupBox3.Location = new System.Drawing.Point(209, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 108);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Combustible:";
            // 
            // CheckBoxExceso
            // 
            this.CheckBoxExceso.AutoSize = true;
            this.CheckBoxExceso.Location = new System.Drawing.Point(6, 82);
            this.CheckBoxExceso.Name = "CheckBoxExceso";
            this.CheckBoxExceso.Size = new System.Drawing.Size(58, 15);
            this.CheckBoxExceso.TabIndex = 80;
            this.CheckBoxExceso.Text = "Exceso";
            this.CheckBoxExceso.UseSelectable = true;
            // 
            // CheckBoxCombustibleTodos
            // 
            this.CheckBoxCombustibleTodos.AutoSize = true;
            this.CheckBoxCombustibleTodos.Location = new System.Drawing.Point(6, 19);
            this.CheckBoxCombustibleTodos.Name = "CheckBoxCombustibleTodos";
            this.CheckBoxCombustibleTodos.Size = new System.Drawing.Size(56, 15);
            this.CheckBoxCombustibleTodos.TabIndex = 78;
            this.CheckBoxCombustibleTodos.Text = "Todos";
            this.CheckBoxCombustibleTodos.UseSelectable = true;
            // 
            // CheckBoxAhorro
            // 
            this.CheckBoxAhorro.AutoSize = true;
            this.CheckBoxAhorro.Location = new System.Drawing.Point(6, 61);
            this.CheckBoxAhorro.Name = "CheckBoxAhorro";
            this.CheckBoxAhorro.Size = new System.Drawing.Size(60, 15);
            this.CheckBoxAhorro.TabIndex = 81;
            this.CheckBoxAhorro.Text = "Ahorro";
            this.CheckBoxAhorro.UseSelectable = true;
            // 
            // CheckBoxNormal
            // 
            this.CheckBoxNormal.AutoSize = true;
            this.CheckBoxNormal.Location = new System.Drawing.Point(6, 40);
            this.CheckBoxNormal.Name = "CheckBoxNormal";
            this.CheckBoxNormal.Size = new System.Drawing.Size(63, 15);
            this.CheckBoxNormal.TabIndex = 79;
            this.CheckBoxNormal.Text = "Normal";
            this.CheckBoxNormal.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CheckBoxMuyMalo);
            this.groupBox4.Controls.Add(this.CheckBoxMalo);
            this.groupBox4.Controls.Add(this.CheckBoxRegular);
            this.groupBox4.Controls.Add(this.CheckBoxTodosTiempo);
            this.groupBox4.Controls.Add(this.CheckBoxMuyBueno);
            this.groupBox4.Controls.Add(this.CheckBoxBueno);
            this.groupBox4.Location = new System.Drawing.Point(23, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 142);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiempos:";
            // 
            // CheckBoxMuyMalo
            // 
            this.CheckBoxMuyMalo.AutoSize = true;
            this.CheckBoxMuyMalo.Location = new System.Drawing.Point(6, 121);
            this.CheckBoxMuyMalo.Name = "CheckBoxMuyMalo";
            this.CheckBoxMuyMalo.Size = new System.Drawing.Size(77, 15);
            this.CheckBoxMuyMalo.TabIndex = 86;
            this.CheckBoxMuyMalo.Text = "Muy Malo";
            this.CheckBoxMuyMalo.UseSelectable = true;
            // 
            // CheckBoxMalo
            // 
            this.CheckBoxMalo.AutoSize = true;
            this.CheckBoxMalo.Location = new System.Drawing.Point(6, 100);
            this.CheckBoxMalo.Name = "CheckBoxMalo";
            this.CheckBoxMalo.Size = new System.Drawing.Size(50, 15);
            this.CheckBoxMalo.TabIndex = 87;
            this.CheckBoxMalo.Text = "Malo";
            this.CheckBoxMalo.UseSelectable = true;
            // 
            // CheckBoxRegular
            // 
            this.CheckBoxRegular.AutoSize = true;
            this.CheckBoxRegular.Location = new System.Drawing.Point(6, 80);
            this.CheckBoxRegular.Name = "CheckBoxRegular";
            this.CheckBoxRegular.Size = new System.Drawing.Size(63, 15);
            this.CheckBoxRegular.TabIndex = 84;
            this.CheckBoxRegular.Text = "Regular";
            this.CheckBoxRegular.UseSelectable = true;
            // 
            // CheckBoxTodosTiempo
            // 
            this.CheckBoxTodosTiempo.AutoSize = true;
            this.CheckBoxTodosTiempo.Location = new System.Drawing.Point(6, 17);
            this.CheckBoxTodosTiempo.Name = "CheckBoxTodosTiempo";
            this.CheckBoxTodosTiempo.Size = new System.Drawing.Size(56, 15);
            this.CheckBoxTodosTiempo.TabIndex = 82;
            this.CheckBoxTodosTiempo.Text = "Todos";
            this.CheckBoxTodosTiempo.UseSelectable = true;
            this.CheckBoxTodosTiempo.CheckedChanged += new System.EventHandler(this.CheckBoxTodosTiempo_CheckedChanged);
            // 
            // CheckBoxMuyBueno
            // 
            this.CheckBoxMuyBueno.AutoSize = true;
            this.CheckBoxMuyBueno.Location = new System.Drawing.Point(6, 38);
            this.CheckBoxMuyBueno.Name = "CheckBoxMuyBueno";
            this.CheckBoxMuyBueno.Size = new System.Drawing.Size(84, 15);
            this.CheckBoxMuyBueno.TabIndex = 83;
            this.CheckBoxMuyBueno.Text = "Muy Bueno";
            this.CheckBoxMuyBueno.UseSelectable = true;
            // 
            // CheckBoxBueno
            // 
            this.CheckBoxBueno.AutoSize = true;
            this.CheckBoxBueno.Location = new System.Drawing.Point(6, 59);
            this.CheckBoxBueno.Name = "CheckBoxBueno";
            this.CheckBoxBueno.Size = new System.Drawing.Size(57, 15);
            this.CheckBoxBueno.TabIndex = 85;
            this.CheckBoxBueno.Text = "Bueno";
            this.CheckBoxBueno.UseSelectable = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::CapaPresentacion.Properties.Resources.Uninstall;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Location = new System.Drawing.Point(481, 230);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(49, 39);
            this.BtnSalir.TabIndex = 79;
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::CapaPresentacion.Properties.Resources.Chart___Google_Docs;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton2.Location = new System.Drawing.Point(401, 215);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(58, 54);
            this.metroButton2.TabIndex = 78;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Doc___Google_Docs1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(308, 215);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(58, 54);
            this.metroButton1.TabIndex = 77;
            this.metroButton1.UseSelectable = true;
            // 
            // ReporteControlCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 279);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteControlCombustible";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox TxtPlaca;
        private MetroFramework.Controls.MetroCheckBox CheckBoxPlacaTodo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroCheckBox CheckBoxImcompleto;
        private MetroFramework.Controls.MetroCheckBox CheckBoxCompleto;
        private MetroFramework.Controls.MetroCheckBox CheckBoxLiquidacion;
        private MetroFramework.Controls.MetroCheckBox CheckBoxLiquidacionTodos;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroCheckBox CheckBoxExceso;
        private MetroFramework.Controls.MetroCheckBox CheckBoxCombustibleTodos;
        private MetroFramework.Controls.MetroCheckBox CheckBoxAhorro;
        private MetroFramework.Controls.MetroCheckBox CheckBoxNormal;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroCheckBox CheckBoxMuyMalo;
        private MetroFramework.Controls.MetroCheckBox CheckBoxMalo;
        private MetroFramework.Controls.MetroCheckBox CheckBoxRegular;
        private MetroFramework.Controls.MetroCheckBox CheckBoxTodosTiempo;
        private MetroFramework.Controls.MetroCheckBox CheckBoxMuyBueno;
        private MetroFramework.Controls.MetroCheckBox CheckBoxBueno;
        private MetroFramework.Controls.MetroButton BtnSalir;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}