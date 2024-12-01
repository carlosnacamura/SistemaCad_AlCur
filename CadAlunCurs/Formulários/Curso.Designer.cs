
namespace CadAlunCurs.Formulários
{
    partial class Curso
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dtCurso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(51, 18);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(231, 88);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar curso";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(615, 49);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(282, 26);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dtCurso
            // 
            this.dtCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCurso.Location = new System.Drawing.Point(18, 140);
            this.dtCurso.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtCurso.Name = "dtCurso";
            this.dtCurso.Size = new System.Drawing.Size(1020, 534);
            this.dtCurso.TabIndex = 4;
            this.dtCurso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCurso_CellDoubleClick);
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 574);
            this.Controls.Add(this.dtCurso);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnAdicionar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Curso";
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dtCurso;
    }
}