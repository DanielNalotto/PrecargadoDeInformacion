namespace PrecargadoDeInformacion.GUI
{
    partial class AgregarUsuario
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
            txtCalle = new TextBox();
            lblCalle = new Label();
            txtMail = new TextBox();
            lblMail = new Label();
            txtTel = new TextBox();
            btnMasInfo = new Button();
            lblTel = new Label();
            btnAceptar = new Button();
            txtUser = new TextBox();
            lblUser = new Label();
            txtNroPuerta = new TextBox();
            lblNroPuerta = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(13, 260);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(212, 29);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(74, 115);
            txtCalle.Name = "txtCalle";
            txtCalle.ReadOnly = true;
            txtCalle.Size = new Size(151, 23);
            txtCalle.TabIndex = 22;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(13, 118);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(36, 15);
            lblCalle.TabIndex = 21;
            lblCalle.Text = "Calle:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(74, 86);
            txtMail.Name = "txtMail";
            txtMail.ReadOnly = true;
            txtMail.Size = new Size(151, 23);
            txtMail.TabIndex = 20;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(13, 89);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(33, 15);
            lblMail.TabIndex = 19;
            lblMail.Text = "Mail:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(74, 57);
            txtTel.Name = "txtTel";
            txtTel.ReadOnly = true;
            txtTel.Size = new Size(151, 23);
            txtTel.TabIndex = 18;
            // 
            // btnMasInfo
            // 
            btnMasInfo.Location = new Point(13, 225);
            btnMasInfo.Name = "btnMasInfo";
            btnMasInfo.Size = new Size(212, 29);
            btnMasInfo.TabIndex = 17;
            btnMasInfo.Text = "Agregar información de contacto";
            btnMasInfo.UseVisualStyleBackColor = true;
            btnMasInfo.Click += btnMasInfo_Click;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(13, 60);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(27, 15);
            lblTel.TabIndex = 16;
            lblTel.Text = "Tel: ";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(13, 190);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(212, 29);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(74, 12);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(151, 23);
            txtUser.TabIndex = 14;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(13, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(55, 15);
            lblUser.TabIndex = 13;
            lblUser.Text = "Usuario *";
            // 
            // txtNroPuerta
            // 
            txtNroPuerta.Location = new Point(74, 144);
            txtNroPuerta.Name = "txtNroPuerta";
            txtNroPuerta.ReadOnly = true;
            txtNroPuerta.Size = new Size(151, 23);
            txtNroPuerta.TabIndex = 25;
            // 
            // lblNroPuerta
            // 
            lblNroPuerta.AutoSize = true;
            lblNroPuerta.Location = new Point(13, 147);
            lblNroPuerta.Name = "lblNroPuerta";
            lblNroPuerta.Size = new Size(61, 15);
            lblNroPuerta.TabIndex = 24;
            lblNroPuerta.Text = "Nº puerta:";
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 300);
            Controls.Add(txtNroPuerta);
            Controls.Add(lblNroPuerta);
            Controls.Add(btnCancelar);
            Controls.Add(txtCalle);
            Controls.Add(lblCalle);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(txtTel);
            Controls.Add(btnMasInfo);
            Controls.Add(lblTel);
            Controls.Add(btnAceptar);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Name = "AgregarUsuario";
            Text = "AgregarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private TextBox txtCalle;
        private Label lblCalle;
        private TextBox txtMail;
        private Label lblMail;
        private TextBox txtTel;
        private Button btnMasInfo;
        private Label lblTel;
        private Button btnAceptar;
        private TextBox txtUser;
        private Label lblUser;
        private TextBox txtNroPuerta;
        private Label lblNroPuerta;
    }
}