﻿namespace CapaPresentacion
{
    partial class FrmListaPlacas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaPlacas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBuscarPlaca = new System.Windows.Forms.TextBox();
            this.dgListarPlaca = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarPlaca)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgListarPlaca);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBuscarPlaca);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 331);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Placa:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(371, 283);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(109, 42);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar";
            // 
            // TxtBuscarPlaca
            // 
            this.TxtBuscarPlaca.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarPlaca.Location = new System.Drawing.Point(109, 29);
            this.TxtBuscarPlaca.Name = "TxtBuscarPlaca";
            this.TxtBuscarPlaca.Size = new System.Drawing.Size(233, 30);
            this.TxtBuscarPlaca.TabIndex = 3;
            this.TxtBuscarPlaca.TextChanged += new System.EventHandler(this.TxtBuscarPlaca_TextChanged);
            // 
            // dgListarPlaca
            // 
            this.dgListarPlaca.AllowUserToAddRows = false;
            this.dgListarPlaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListarPlaca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgListarPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarPlaca.Location = new System.Drawing.Point(15, 78);
            this.dgListarPlaca.Name = "dgListarPlaca";
            this.dgListarPlaca.ReadOnly = true;
            this.dgListarPlaca.Size = new System.Drawing.Size(444, 199);
            this.dgListarPlaca.TabIndex = 15;
            this.dgListarPlaca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarPlaca_CellClick_1);
            this.dgListarPlaca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarPlaca_CellDoubleClick);
            // 
            // FrmListaPlacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 406);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmListaPlacas";
            this.Text = "FrmListaPlacas";
            this.Load += new System.EventHandler(this.FrmListaPlacas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarPlaca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBuscarPlaca;
        public System.Windows.Forms.DataGridView dgListarPlaca;
    }
}