namespace SistemaAlunosCursos.Formulários.Forms_Usuarios
{
    partial class FrmCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarUsuario));
            this.txtNome = new ZBobb.AlphaBlendTextBox();
            this.txtSenha = new ZBobb.AlphaBlendTextBox();
            this.btnCadastrar = new System.Windows.Forms.PictureBox();
            this.txtConfirmSenha = new ZBobb.AlphaBlendTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackAlpha = 0;
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(58, 308);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 30);
            this.txtNome.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.BackAlpha = 0;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(58, 388);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(325, 30);
            this.txtSenha.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Image = global::SistemaAlunosCursos.Properties.Resources.btnCadastrar;
            this.btnCadastrar.Location = new System.Drawing.Point(42, 514);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(341, 121);
            this.btnCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtConfirmSenha
            // 
            this.txtConfirmSenha.BackAlpha = 0;
            this.txtConfirmSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtConfirmSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmSenha.Location = new System.Drawing.Point(58, 478);
            this.txtConfirmSenha.Multiline = true;
            this.txtConfirmSenha.Name = "txtConfirmSenha";
            this.txtConfirmSenha.PasswordChar = '*';
            this.txtConfirmSenha.Size = new System.Drawing.Size(325, 30);
            this.txtConfirmSenha.TabIndex = 3;
            // 
            // FrmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaAlunosCursos.Properties.Resources.fundoCadUsuariosMelhorado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 631);
            this.Controls.Add(this.txtConfirmSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarUsuario";
            this.Text = "Formulário de cadastramento";
            this.Load += new System.EventHandler(this.FrmCadastrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZBobb.AlphaBlendTextBox txtNome;
        private ZBobb.AlphaBlendTextBox txtSenha;
        private System.Windows.Forms.PictureBox btnCadastrar;
        private ZBobb.AlphaBlendTextBox txtConfirmSenha;
    }
}