namespace pryCUEVASSP1DEFINITIVA
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblModulo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ptbFondo = new System.Windows.Forms.PictureBox();
            lblModulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.BackColor = System.Drawing.Color.Red;
            lblModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblModulo.Location = new System.Drawing.Point(54, 266);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new System.Drawing.Size(77, 25);
            lblModulo.TabIndex = 10;
            lblModulo.Text = "Módulo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Red;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(54, 149);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 25);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUsuario.Location = new System.Drawing.Point(199, 149);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 22);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged_1);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.Color.Red;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(54, 195);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(114, 25);
            this.lblContrasenia.TabIndex = 8;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Enabled = false;
            this.txtContrasenia.Location = new System.Drawing.Point(199, 195);
            this.txtContrasenia.MaxLength = 10;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(125, 22);
            this.txtContrasenia.TabIndex = 9;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged_1);
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.Enabled = false;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(199, 266);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(121, 24);
            this.cmbModulo.TabIndex = 11;
            this.cmbModulo.SelectedIndexChanged += new System.EventHandler(this.cmbModulo_SelectedIndexChanged_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAceptar.Enabled = false;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(45, 348);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 51);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(199, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 51);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ptbFondo
            // 
            this.ptbFondo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ptbFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbFondo.ErrorImage = null;
            this.ptbFondo.Image = global::pryCUEVASSP1DEFINITIVA.Properties.Resources.LOGIN;
            this.ptbFondo.Location = new System.Drawing.Point(0, 0);
            this.ptbFondo.Name = "ptbFondo";
            this.ptbFondo.Size = new System.Drawing.Size(755, 503);
            this.ptbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFondo.TabIndex = 14;
            this.ptbFondo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 503);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(lblModulo);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.ptbFondo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox ptbFondo;
    }
}

