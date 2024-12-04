namespace SistemaAlunosCursos.Formulários.Forms_Cursos
{
    partial class FrmCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursos));
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new ZBobb.AlphaBlendTextBox();
            this.btnAdicionar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridCursos
            // 
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGridCursos.Location = new System.Drawing.Point(0, 109);
            this.dtGridCursos.Name = "dtGridCursos";
            this.dtGridCursos.RowHeadersWidth = 51;
            this.dtGridCursos.RowTemplate.Height = 24;
            this.dtGridCursos.Size = new System.Drawing.Size(1297, 614);
            this.dtGridCursos.TabIndex = 0;
            this.dtGridCursos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellDoubleClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackAlpha = 0;
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(824, 45);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(365, 43);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Image = global::SistemaAlunosCursos.Properties.Resources.btnAdicionarCurso;
            this.btnAdicionar.Location = new System.Drawing.Point(0, -2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(403, 105);
            this.btnAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaAlunosCursos.Properties.Resources.fundoCursos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 723);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dtGridCursos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridCursos;
        private ZBobb.AlphaBlendTextBox txtPesquisa;
        private System.Windows.Forms.PictureBox btnAdicionar;
    }
}