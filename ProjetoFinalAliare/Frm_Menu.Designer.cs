namespace ProjetoFinalAliare
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Btn_Aluno = new System.Windows.Forms.Button();
            this.Btn_Curso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Aluno
            // 
            this.Btn_Aluno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Aluno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aluno.Location = new System.Drawing.Point(205, 290);
            this.Btn_Aluno.Name = "Btn_Aluno";
            this.Btn_Aluno.Size = new System.Drawing.Size(146, 55);
            this.Btn_Aluno.TabIndex = 0;
            this.Btn_Aluno.Text = "Alunos";
            this.Btn_Aluno.UseVisualStyleBackColor = false;
            this.Btn_Aluno.Click += new System.EventHandler(this.Btn_Aluno_Click);
            // 
            // Btn_Curso
            // 
            this.Btn_Curso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Curso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Curso.Location = new System.Drawing.Point(426, 290);
            this.Btn_Curso.Name = "Btn_Curso";
            this.Btn_Curso.Size = new System.Drawing.Size(146, 55);
            this.Btn_Curso.TabIndex = 1;
            this.Btn_Curso.Text = "Curso";
            this.Btn_Curso.UseVisualStyleBackColor = false;
            this.Btn_Curso.Click += new System.EventHandler(this.Btn_Curso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Curso);
            this.Controls.Add(this.Btn_Aluno);
            this.MaximizeBox = false;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aliare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aluno;
        private System.Windows.Forms.Button Btn_Curso;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}