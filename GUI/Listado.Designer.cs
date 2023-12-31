﻿namespace PrecargadoDeInformacion
{
    partial class Listado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Listado());
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBaja = new Button();
            btnMod = new Button();
            btnAlta = new Button();
            dgv = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUser = new DataGridViewTextBoxColumn();
            colTel = new DataGridViewTextBoxColumn();
            colMail = new DataGridViewTextBoxColumn();
            colCalle = new DataGridViewTextBoxColumn();
            colNroPuerta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(330, 341);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(118, 33);
            btnBaja.TabIndex = 7;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(640, 340);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(118, 33);
            btnMod.TabIndex = 6;
            btnMod.Text = "Modificación";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(12, 340);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(118, 33);
            btnAlta.TabIndex = 5;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colId, colUser, colTel, colMail, colCalle, colNroPuerta });
            dgv.Location = new Point(12, 12);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(746, 310);
            dgv.TabIndex = 4;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 40;
            // 
            // colUser
            // 
            colUser.HeaderText = "User";
            colUser.Name = "colUser";
            colUser.ReadOnly = true;
            colUser.Width = 130;
            // 
            // colTel
            // 
            colTel.HeaderText = "Tel";
            colTel.Name = "colTel";
            colTel.ReadOnly = true;
            colTel.Width = 120;
            // 
            // colMail
            // 
            colMail.HeaderText = "Mail";
            colMail.Name = "colMail";
            colMail.ReadOnly = true;
            colMail.Width = 150;
            // 
            // colCalle
            // 
            colCalle.HeaderText = "Calle";
            colCalle.Name = "colCalle";
            colCalle.ReadOnly = true;
            colCalle.Width = 150;
            // 
            // colNroPuerta
            // 
            colNroPuerta.HeaderText = "Nº puerta";
            colNroPuerta.Name = "colNroPuerta";
            colNroPuerta.ReadOnly = true;
            colNroPuerta.Width = 110;
            // 
            // Listado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 386);
            Controls.Add(btnBaja);
            Controls.Add(btnMod);
            Controls.Add(btnAlta);
            Controls.Add(dgv);
            Name = "Listado";
            Text = "Listado";
            Load += Listado_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBaja;
        private Button btnMod;
        private Button btnAlta;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUser;
        private DataGridViewTextBoxColumn colTel;
        private DataGridViewTextBoxColumn colMail;
        private DataGridViewTextBoxColumn colCalle;
        private DataGridViewTextBoxColumn colNroPuerta;
    }
}