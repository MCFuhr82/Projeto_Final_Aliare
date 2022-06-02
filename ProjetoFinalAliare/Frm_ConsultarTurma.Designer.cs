namespace ProjetoFinalAliare
{
    partial class Frm_ConsultarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultarTurma));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_Matricular = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Lbl_Curso = new System.Windows.Forms.Label();
            this.Lbl_Semestre = new System.Windows.Forms.Label();
            this.Lbl_Periodo = new System.Windows.Forms.Label();
            this.Cbox_SelecionarCurso = new System.Windows.Forms.ComboBox();
            this.Cbox_SelecionarPeriodo = new System.Windows.Forms.ComboBox();
            this.Cbox_SelecionarSemestre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Consulta
            // 
            this.Btn_Consulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Consulta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consulta.Location = new System.Drawing.Point(12, 90);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(139, 27);
            this.Btn_Consulta.TabIndex = 5;
            this.Btn_Consulta.Text = "Consulta";
            this.Btn_Consulta.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 314);
            this.dataGridView1.TabIndex = 6;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Editar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(706, 123);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Editar.TabIndex = 7;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Deletar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Deletar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deletar.Location = new System.Drawing.Point(706, 163);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Deletar.TabIndex = 8;
            this.Btn_Deletar.Text = "Deletar";
            this.Btn_Deletar.UseVisualStyleBackColor = false;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Voltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Voltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(708, 403);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.Btn_Voltar.TabIndex = 9;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cadastrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar.Location = new System.Drawing.Point(706, 203);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Cadastrar.TabIndex = 14;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Btn_Matricular
            // 
            this.Btn_Matricular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Matricular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Matricular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Matricular.Location = new System.Drawing.Point(706, 243);
            this.Btn_Matricular.Name = "Btn_Matricular";
            this.Btn_Matricular.Size = new System.Drawing.Size(114, 34);
            this.Btn_Matricular.TabIndex = 15;
            this.Btn_Matricular.Text = "Matricular";
            this.Btn_Matricular.UseVisualStyleBackColor = false;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Imprimir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.Location = new System.Drawing.Point(706, 283);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(114, 34);
            this.Btn_Imprimir.TabIndex = 17;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.UseVisualStyleBackColor = false;
            // 
            // Lbl_Curso
            // 
            this.Lbl_Curso.AutoSize = true;
            this.Lbl_Curso.Location = new System.Drawing.Point(13, 29);
            this.Lbl_Curso.Name = "Lbl_Curso";
            this.Lbl_Curso.Size = new System.Drawing.Size(103, 13);
            this.Lbl_Curso.TabIndex = 18;
            this.Lbl_Curso.Text = "Selecione um curso:";
            // 
            // Lbl_Semestre
            // 
            this.Lbl_Semestre.AutoSize = true;
            this.Lbl_Semestre.Location = new System.Drawing.Point(13, 60);
            this.Lbl_Semestre.Name = "Lbl_Semestre";
            this.Lbl_Semestre.Size = new System.Drawing.Size(119, 13);
            this.Lbl_Semestre.TabIndex = 19;
            this.Lbl_Semestre.Text = "Selecione um semestre:";
            // 
            // Lbl_Periodo
            // 
            this.Lbl_Periodo.AutoSize = true;
            this.Lbl_Periodo.Location = new System.Drawing.Point(249, 60);
            this.Lbl_Periodo.Name = "Lbl_Periodo";
            this.Lbl_Periodo.Size = new System.Drawing.Size(112, 13);
            this.Lbl_Periodo.TabIndex = 20;
            this.Lbl_Periodo.Text = "Selecione um periodo:";
            // 
            // Cbox_SelecionarCurso
            // 
            this.Cbox_SelecionarCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_SelecionarCurso.FormattingEnabled = true;
            this.Cbox_SelecionarCurso.Location = new System.Drawing.Point(137, 21);
            this.Cbox_SelecionarCurso.Name = "Cbox_SelecionarCurso";
            this.Cbox_SelecionarCurso.Size = new System.Drawing.Size(398, 21);
            this.Cbox_SelecionarCurso.TabIndex = 21;
            // 
            // Cbox_SelecionarPeriodo
            // 
            this.Cbox_SelecionarPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_SelecionarPeriodo.FormattingEnabled = true;
            this.Cbox_SelecionarPeriodo.Items.AddRange(new object[] {
            "Matutino",
            "Noturno",
            "Integral"});
            this.Cbox_SelecionarPeriodo.Location = new System.Drawing.Point(367, 57);
            this.Cbox_SelecionarPeriodo.Name = "Cbox_SelecionarPeriodo";
            this.Cbox_SelecionarPeriodo.Size = new System.Drawing.Size(168, 21);
            this.Cbox_SelecionarPeriodo.TabIndex = 22;
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
            this.Cbox_SelecionarSemestre.Location = new System.Drawing.Point(137, 57);
            this.Cbox_SelecionarSemestre.Name = "Cbox_SelecionarSemestre";
            this.Cbox_SelecionarSemestre.Size = new System.Drawing.Size(69, 21);
            this.Cbox_SelecionarSemestre.TabIndex = 23;
            // 
            // Frm_ConsultarTurma
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
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Matricular);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Deletar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Consulta);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(848, 488);
            this.Name = "Frm_ConsultarTurma";
            this.Text = "Frm_Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Consulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Deletar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.Button Btn_Matricular;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Label Lbl_Curso;
        private System.Windows.Forms.Label Lbl_Semestre;
        private System.Windows.Forms.Label Lbl_Periodo;
        private System.Windows.Forms.ComboBox Cbox_SelecionarCurso;
        private System.Windows.Forms.ComboBox Cbox_SelecionarPeriodo;
        private System.Windows.Forms.ComboBox Cbox_SelecionarSemestre;
    }
}