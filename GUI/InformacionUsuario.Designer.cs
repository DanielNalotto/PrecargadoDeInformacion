namespace PrecargadoDeInformacion.GUI
{
    partial class InformacionUsuario
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblContacto = new Label();
            txtPuerta = new TextBox();
            lblPuerta = new Label();
            txtCalle = new TextBox();
            lblCalle = new Label();
            lblDir = new Label();
            txtMail = new TextBox();
            lblMail = new Label();
            txtTel = new TextBox();
            lblTel = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(14, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(224, 26);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(14, 233);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(224, 26);
            btnAceptar.TabIndex = 35;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblContacto.Location = new Point(14, 14);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(63, 17);
            lblContacto.TabIndex = 34;
            lblContacto.Text = "Contacto";
            // 
            // txtPuerta
            // 
            txtPuerta.Location = new Point(87, 174);
            txtPuerta.Name = "txtPuerta";
            txtPuerta.Size = new Size(151, 23);
            txtPuerta.TabIndex = 33;
            // 
            // lblPuerta
            // 
            lblPuerta.AutoSize = true;
            lblPuerta.Location = new Point(14, 177);
            lblPuerta.Name = "lblPuerta";
            lblPuerta.Size = new Size(67, 15);
            lblPuerta.TabIndex = 32;
            lblPuerta.Text = "Nro Puerta:";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(56, 145);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(182, 23);
            txtCalle.TabIndex = 31;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(14, 148);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(36, 15);
            lblCalle.TabIndex = 30;
            lblCalle.Text = "Calle:";
            // 
            // lblDir
            // 
            lblDir.AutoSize = true;
            lblDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDir.Location = new Point(14, 119);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(66, 17);
            lblDir.TabIndex = 29;
            lblDir.Text = "Dirección";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(75, 72);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(163, 23);
            txtMail.TabIndex = 28;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(14, 75);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(33, 15);
            lblMail.TabIndex = 27;
            lblMail.Text = "Mail:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(75, 43);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(163, 23);
            txtTel.TabIndex = 26;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(14, 46);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(27, 15);
            lblTel.TabIndex = 25;
            lblTel.Text = "Tel: ";
            // 
            // InformacionUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 306);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblContacto);
            Controls.Add(txtPuerta);
            Controls.Add(lblPuerta);
            Controls.Add(txtCalle);
            Controls.Add(lblCalle);
            Controls.Add(lblDir);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(txtTel);
            Controls.Add(lblTel);
            Name = "InformacionUsuario";
            Text = "InformacionUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblContacto;
        private TextBox txtPuerta;
        private Label lblPuerta;
        private TextBox txtCalle;
        private Label lblCalle;
        private Label lblDir;
        private TextBox txtMail;
        private Label lblMail;
        private TextBox txtTel;
        private Label lblTel;
    }
}