﻿namespace SistemaAlunosCursos
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtNome = new ZBobb.AlphaBlendTextBox();
            this.txtSenha = new ZBobb.AlphaBlendTextBox();
            this.btnEntrar = new System.Windows.Forms.PictureBox();
            this.lblAdicionarUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackAlpha = 0;
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(853, 286);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(375, 35);
            this.txtNome.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.BackAlpha = 0;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.HideSelection = false;
            this.txtSenha.Location = new System.Drawing.Point(853, 418);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(375, 41);
            this.txtSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Image = global::SistemaAlunosCursos.Properties.Resources.btnLogar;
            this.btnEntrar.Location = new System.Drawing.Point(853, 524);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(347, 73);
            this.btnEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.TabStop = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblAdicionarUsuario
            // 
            this.lblAdicionarUsuario.AutoSize = true;
            this.lblAdicionarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicionarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdicionarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarUsuario.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarUsuario.Location = new System.Drawing.Point(848, 626);
            this.lblAdicionarUsuario.Name = "lblAdicionarUsuario";
            this.lblAdicionarUsuario.Size = new System.Drawing.Size(257, 29);
            this.lblAdicionarUsuario.TabIndex = 5;
            this.lblAdicionarUsuario.Text = "Adicionar novo usuário";
            this.lblAdicionarUsuario.Click += new System.EventHandler(this.lblAdicionarUsuario_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaAlunosCursos.Properties.Resources.loginConcertado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 687);
            this.Controls.Add(this.lblAdicionarUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnEntrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZBobb.AlphaBlendTextBox txtNome;
        private ZBobb.AlphaBlendTextBox txtSenha;
        private System.Windows.Forms.PictureBox btnEntrar;
        private System.Windows.Forms.Label lblAdicionarUsuario;
    }
}

