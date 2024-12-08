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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursos));
            this.txtPesquisa = new ZBobb.AlphaBlendTextBox();
            this.btnAdicionar = new System.Windows.Forms.PictureBox();
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            this.Icone = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            this.SuspendLayout();
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
            // dtGridCursos
            // 
            this.dtGridCursos.AllowUserToAddRows = false;
            this.dtGridCursos.AllowUserToDeleteRows = false;
            this.dtGridCursos.AllowUserToOrderColumns = true;
            this.dtGridCursos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dtGridCursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dtGridCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridCursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGridCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridCursos.ColumnHeadersHeight = 30;
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGridCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridCursos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridCursos.EnableHeadersVisualStyles = false;
            this.dtGridCursos.Location = new System.Drawing.Point(12, 115);
            this.dtGridCursos.Name = "dtGridCursos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridCursos.RowHeadersVisible = false;
            this.dtGridCursos.RowHeadersWidth = 51;
            this.dtGridCursos.RowTemplate.Height = 50;
            this.dtGridCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCursos.Size = new System.Drawing.Size(1273, 596);
            this.dtGridCursos.TabIndex = 4;
            // 
            // Icone
            // 
            this.Icone.FillWeight = 30F;
            this.Icone.HeaderText = "";
            this.Icone.Image = global::SistemaAlunosCursos.Properties.Resources.cursosIcon;
            this.Icone.MinimumWidth = 6;
            this.Icone.Name = "Icone";
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaAlunosCursos.Properties.Resources.fundoCursos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 723);
            this.Controls.Add(this.dtGridCursos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtPesquisa);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZBobb.AlphaBlendTextBox txtPesquisa;
        private System.Windows.Forms.PictureBox btnAdicionar;
        private System.Windows.Forms.DataGridView dtGridCursos;
        private System.Windows.Forms.DataGridViewImageColumn Icone;
    }
}