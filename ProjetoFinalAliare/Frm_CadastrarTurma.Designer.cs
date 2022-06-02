namespace ProjetoFinalAliare
{
    partial class Frm_CadastrarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastrarTurma));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.Cbox_SelecionarSemestre = new System.Windows.Forms.ComboBox();
            this.Cbox_SelecionarPeriodo = new System.Windows.Forms.ComboBox();
            this.Cbox_SelecionarCurso = new System.Windows.Forms.ComboBox();
            this.Lbl_Periodo = new System.Windows.Forms.Label();
            this.Lbl_Semestre = new System.Windows.Forms.Label();
            this.Lbl_Curso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar.Location = new System.Drawing.Point(706, 363);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Cadastrar.TabIndex = 11;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Voltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(708, 403);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.Btn_Voltar.TabIndex = 12;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Cadastro
            // 
            this.Lbl_Cadastro.AutoSize = true;
            this.Lbl_Cadastro.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cadastro.Location = new System.Drawing.Point(318, 28);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(221, 31);
            this.Lbl_Cadastro.TabIndex = 10;
            this.Lbl_Cadastro.Text = "Cadastro de Turma";
            // 
            // Cbox_SelecionarSemestre
            // 
            this.Cbox_SelecionarSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_SelecionarSemestre.FormattingEnabled = true;
            this.Cbox_SelecionarSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cbox_SelecionarSemestre.Location = new System.Drawing.Point(136, 128);
            this.Cbox_SelecionarSemestre.Name = "Cbox_SelecionarSemestre";
            this.Cbox_SelecionarSemestre.Size = new System.Drawing.Size(69, 21);
            this.Cbox_SelecionarSemestre.TabIndex = 29;
            // 
            // Cbox_SelecionarPeriodo
            // 
            this.Cbox_SelecionarPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_SelecionarPeriodo.FormattingEnabled = true;
            this.Cbox_SelecionarPeriodo.Items.AddRange(new object[] {
            "Matutino",
            "Noturno",
            "Integral"});
            this.Cbox_SelecionarPeriodo.Location = new System.Drawing.Point(136, 164);
            this.Cbox_SelecionarPeriodo.Name = "Cbox_SelecionarPeriodo";
            this.Cbox_SelecionarPeriodo.Size = new System.Drawing.Size(168, 21);
            this.Cbox_SelecionarPeriodo.TabIndex = 28;
            // 
            // Cbox_SelecionarCurso
            // 
            this.Cbox_SelecionarCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_SelecionarCurso.FormattingEnabled = true;
            this.Cbox_SelecionarCurso.Location = new System.Drawing.Point(136, 91);
            this.Cbox_SelecionarCurso.Name = "Cbox_SelecionarCurso";
            this.Cbox_SelecionarCurso.Size = new System.Drawing.Size(398, 21);
            this.Cbox_SelecionarCurso.TabIndex = 27;
            // 
            // Lbl_Periodo
            // 
            this.Lbl_Periodo.AutoSize = true;
            this.Lbl_Periodo.Location = new System.Drawing.Point(12, 172);
            this.Lbl_Periodo.Name = "Lbl_Periodo";
            this.Lbl_Periodo.Size = new System.Drawing.Size(112, 13);
            this.Lbl_Periodo.TabIndex = 26;
            this.Lbl_Periodo.Text = "Selecione um periodo:";
            // 
            // Lbl_Semestre
            // 
            this.Lbl_Semestre.AutoSize = true;
            this.Lbl_Semestre.Location = new System.Drawing.Point(12, 136);
            this.Lbl_Semestre.Name = "Lbl_Semestre";
            this.Lbl_Semestre.Size = new System.Drawing.Size(119, 13);
            this.Lbl_Semestre.TabIndex = 25;
            this.Lbl_Semestre.Text = "Selecione um semestre:";
            // 
            // Lbl_Curso
            // 
            this.Lbl_Curso.AutoSize = true;
            this.Lbl_Curso.Location = new System.Drawing.Point(12, 99);
            this.Lbl_Curso.Name = "Lbl_Curso";
            this.Lbl_Curso.Size = new System.Drawing.Size(103, 13);
            this.Lbl_Curso.TabIndex = 24;
            this.Lbl_Curso.Text = "Selecione um curso:";
            // 
            // Frm_CadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.Cbox_SelecionarSemestre);
            this.Controls.Add(this.Cbox_SelecionarPeriodo);
            this.Controls.Add(this.Cbox_SelecionarCurso);
            this.Controls.Add(this.Lbl_Periodo);
            this.Controls.Add(this.Lbl_Semestre);
            this.Controls.Add(this.Lbl_Curso);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(848, 488);
            this.MinimumSize = new System.Drawing.Size(848, 488);
            this.Name = "Frm_CadastrarTurma";
            this.Text = "Cadastrar Curso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Cadastro;
        private System.Windows.Forms.ComboBox Cbox_SelecionarSemestre;
        private System.Windows.Forms.ComboBox Cbox_SelecionarPeriodo;
        private System.Windows.Forms.ComboBox Cbox_SelecionarCurso;
        private System.Windows.Forms.Label Lbl_Periodo;
        private System.Windows.Forms.Label Lbl_Semestre;
        private System.Windows.Forms.Label Lbl_Curso;
    }
}