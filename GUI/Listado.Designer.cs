namespace PrecargadoDeInformacion
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
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUser = new DataGridViewTextBoxColumn();
            colTel = new DataGridViewTextBoxColumn();
            colMail = new DataGridViewTextBoxColumn();
            colCalle = new DataGridViewTextBoxColumn();
            colNroPuerta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(276, 340);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(118, 33);
            btnBaja.TabIndex = 7;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(541, 340);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(118, 33);
            btnMod.TabIndex = 6;
            btnMod.Text = "Modificación";
            btnMod.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colUser, colTel, colMail, colCalle, colNroPuerta });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(647, 310);
            dataGridView1.TabIndex = 4;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colUser
            // 
            colUser.HeaderText = "User";
            colUser.Name = "colUser";
            colUser.ReadOnly = true;
            // 
            // colTel
            // 
            colTel.HeaderText = "Tel";
            colTel.Name = "colTel";
            colTel.ReadOnly = true;
            // 
            // colMail
            // 
            colMail.HeaderText = "Mail";
            colMail.Name = "colMail";
            colMail.ReadOnly = true;
            // 
            // colCalle
            // 
            colCalle.HeaderText = "Calle";
            colCalle.Name = "colCalle";
            colCalle.ReadOnly = true;
            // 
            // colNroPuerta
            // 
            colNroPuerta.HeaderText = "Nº puerta";
            colNroPuerta.Name = "colNroPuerta";
            colNroPuerta.ReadOnly = true;
            // 
            // Listado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 386);
            Controls.Add(btnBaja);
            Controls.Add(btnMod);
            Controls.Add(btnAlta);
            Controls.Add(dataGridView1);
            Name = "Listado";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBaja;
        private Button btnMod;
        private Button btnAlta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUser;
        private DataGridViewTextBoxColumn colTel;
        private DataGridViewTextBoxColumn colMail;
        private DataGridViewTextBoxColumn colCalle;
        private DataGridViewTextBoxColumn colNroPuerta;
    }
}