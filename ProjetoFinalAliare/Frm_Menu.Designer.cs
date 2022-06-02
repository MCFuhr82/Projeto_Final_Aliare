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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Icon_Ajuda = new System.Windows.Forms.PictureBox();
            this.Icon_Curso = new System.Windows.Forms.PictureBox();
            this.Icon_Aluno = new System.Windows.Forms.PictureBox();
            this.Icon_Sobre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Ajuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Curso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Aluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Sobre)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Aluno
            // 
            this.Btn_Aluno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Aluno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aluno.Location = new System.Drawing.Point(205, 358);
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
            this.Btn_Curso.Location = new System.Drawing.Point(424, 358);
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
            this.pictureBox1.Location = new System.Drawing.Point(71, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.Icon_Ajuda);
            this.panel1.Controls.Add(this.Icon_Curso);
            this.panel1.Controls.Add(this.Icon_Aluno);
            this.panel1.Controls.Add(this.Icon_Sobre);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 70);
            this.panel1.TabIndex = 5;
            // 
            // Icon_Ajuda
            // 
            this.Icon_Ajuda.BackColor = System.Drawing.Color.Gainsboro;
            this.Icon_Ajuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon_Ajuda.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Ajuda.Image")));
            this.Icon_Ajuda.Location = new System.Drawing.Point(596, 0);
            this.Icon_Ajuda.Name = "Icon_Ajuda";
            this.Icon_Ajuda.Size = new System.Drawing.Size(100, 70);
            this.Icon_Ajuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Ajuda.TabIndex = 3;
            this.Icon_Ajuda.TabStop = false;
            this.Icon_Ajuda.Click += new System.EventHandler(this.Icon_Ajuda_Click);
            this.Icon_Ajuda.MouseEnter += new System.EventHandler(this.Icon_Ajuda_MouseEnter);
            this.Icon_Ajuda.MouseLeave += new System.EventHandler(this.Icon_Ajuda_MouseLeave);
            // 
            // Icon_Curso
            // 
            this.Icon_Curso.BackColor = System.Drawing.Color.Gainsboro;
            this.Icon_Curso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon_Curso.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Curso.Image")));
            this.Icon_Curso.Location = new System.Drawing.Point(490, 0);
            this.Icon_Curso.Name = "Icon_Curso";
            this.Icon_Curso.Size = new System.Drawing.Size(100, 70);
            this.Icon_Curso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Curso.TabIndex = 2;
            this.Icon_Curso.TabStop = false;
            this.Icon_Curso.Click += new System.EventHandler(this.Icon_Curso_Click);
            this.Icon_Curso.MouseEnter += new System.EventHandler(this.Icon_Curso_MouseEnter);
            this.Icon_Curso.MouseLeave += new System.EventHandler(this.Icon_Curso_MouseLeave);
            // 
            // Icon_Aluno
            // 
            this.Icon_Aluno.BackColor = System.Drawing.Color.Gainsboro;
            this.Icon_Aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon_Aluno.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Aluno.Image")));
            this.Icon_Aluno.Location = new System.Drawing.Point(384, 0);
            this.Icon_Aluno.Name = "Icon_Aluno";
            this.Icon_Aluno.Size = new System.Drawing.Size(100, 70);
            this.Icon_Aluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Aluno.TabIndex = 1;
            this.Icon_Aluno.TabStop = false;
            this.Icon_Aluno.Click += new System.EventHandler(this.Icon_Aluno_Click);
            this.Icon_Aluno.MouseEnter += new System.EventHandler(this.Icon_Aluno_MouseEnter);
            this.Icon_Aluno.MouseLeave += new System.EventHandler(this.Icon_Aluno_MouseLeave);
            // 
            // Icon_Sobre
            // 
            this.Icon_Sobre.BackColor = System.Drawing.Color.Gainsboro;
            this.Icon_Sobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon_Sobre.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Sobre.Image")));
            this.Icon_Sobre.Location = new System.Drawing.Point(702, 0);
            this.Icon_Sobre.Name = "Icon_Sobre";
            this.Icon_Sobre.Size = new System.Drawing.Size(100, 70);
            this.Icon_Sobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Sobre.TabIndex = 0;
            this.Icon_Sobre.TabStop = false;
            this.Icon_Sobre.Click += new System.EventHandler(this.Icon_Sobre_Click);
            this.Icon_Sobre.MouseEnter += new System.EventHandler(this.Icon_Sobre_MouseEnter);
            this.Icon_Sobre.MouseLeave += new System.EventHandler(this.Icon_Sobre_MouseLeave);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Curso);
            this.Controls.Add(this.Btn_Aluno);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aliare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Ajuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Curso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Aluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Sobre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aluno;
        private System.Windows.Forms.Button Btn_Curso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Icon_Ajuda;
        private System.Windows.Forms.PictureBox Icon_Curso;
        private System.Windows.Forms.PictureBox Icon_Aluno;
        private System.Windows.Forms.PictureBox Icon_Sobre;
    }
}