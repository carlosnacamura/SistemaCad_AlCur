namespace SistemaAlunosCursos.Formulários.Forms_Alunos
{
    partial class FrmAlunos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunos));
            this.btnAdicionar = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new ZBobb.AlphaBlendTextBox();
            this.dtGridAlunos = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Icone = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Image = global::SistemaAlunosCursos.Properties.Resources.btnAdicionarAluno;
            this.btnAdicionar.Location = new System.Drawing.Point(-34, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(479, 109);
            this.btnAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackAlpha = 0;
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(841, 51);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(365, 43);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dtGridAlunos
            // 
            this.dtGridAlunos.AllowUserToAddRows = false;
            this.dtGridAlunos.AllowUserToDeleteRows = false;
            this.dtGridAlunos.AllowUserToOrderColumns = true;
            this.dtGridAlunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dtGridAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dtGridAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGridAlunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridAlunos.ColumnHeadersHeight = 30;
            this.dtGridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGridAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridAlunos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridAlunos.EnableHeadersVisualStyles = false;
            this.dtGridAlunos.Location = new System.Drawing.Point(12, 115);
            this.dtGridAlunos.Name = "dtGridAlunos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridAlunos.RowHeadersVisible = false;
            this.dtGridAlunos.RowHeadersWidth = 51;
            this.dtGridAlunos.RowTemplate.Height = 50;
            this.dtGridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridAlunos.Size = new System.Drawing.Size(1273, 596);
            this.dtGridAlunos.TabIndex = 3;
            this.dtGridAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAlunos_CellDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "alunoIcon.ico");
            this.imageList1.Images.SetKeyName(1, "alunosIcon.png");
            this.imageList1.Images.SetKeyName(2, "alunosIcon.png");
            // 
            // Icone
            // 
            this.Icone.FillWeight = 50F;
            this.Icone.HeaderText = "";
            this.Icone.Image = global::SistemaAlunosCursos.Properties.Resources.alunosIcon;
            this.Icone.MinimumWidth = 6;
            this.Icone.Name = "Icone";
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaAlunosCursos.Properties.Resources.fundoCursos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 723);
            this.Controls.Add(this.dtGridAlunos);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnAdicionar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAdicionar;
        private ZBobb.AlphaBlendTextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dtGridAlunos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewImageColumn Icone;
    }
}