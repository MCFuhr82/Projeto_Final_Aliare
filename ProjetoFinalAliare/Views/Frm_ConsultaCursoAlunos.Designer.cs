namespace ProjetoFinalAliare
{
    partial class Frm_ConsultaCursoAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaCursoAlunos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Cbox_SelecionaCurso = new System.Windows.Forms.ComboBox();
            this.Lbl_QuantidadeAlunos = new System.Windows.Forms.Label();
            this.Txb_TotalAlunos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // Btn_Consulta
            // 
            this.Btn_Consulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Consulta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consulta.Location = new System.Drawing.Point(706, 88);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(114, 29);
            this.Btn_Consulta.TabIndex = 5;
            this.Btn_Consulta.Text = "Consulta";
            this.Btn_Consulta.UseVisualStyleBackColor = false;
            this.Btn_Consulta.Click += new System.EventHandler(this.Btn_Consulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 349);
            this.dataGridView1.TabIndex = 6;
            // 
            // Btn_Voltar
            // 
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
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(12, 36);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(37, 13);
            this.Lbl_Nome.TabIndex = 11;
            this.Lbl_Nome.Text = "Curso:";
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.Location = new System.Drawing.Point(706, 123);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(114, 34);
            this.Btn_Imprimir.TabIndex = 15;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.UseVisualStyleBackColor = false;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Cbox_SelecionaCurso
            // 
            this.Cbox_SelecionaCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_SelecionaCurso.FormattingEnabled = true;
            this.Cbox_SelecionaCurso.Location = new System.Drawing.Point(55, 33);
            this.Cbox_SelecionaCurso.Name = "Cbox_SelecionaCurso";
            this.Cbox_SelecionaCurso.Size = new System.Drawing.Size(288, 21);
            this.Cbox_SelecionaCurso.Sorted = true;
            this.Cbox_SelecionaCurso.TabIndex = 16;
            // 
            // Lbl_QuantidadeAlunos
            // 
            this.Lbl_QuantidadeAlunos.AutoSize = true;
            this.Lbl_QuantidadeAlunos.Location = new System.Drawing.Point(12, 65);
            this.Lbl_QuantidadeAlunos.Name = "Lbl_QuantidadeAlunos";
            this.Lbl_QuantidadeAlunos.Size = new System.Drawing.Size(148, 13);
            this.Lbl_QuantidadeAlunos.TabIndex = 17;
            this.Lbl_QuantidadeAlunos.Text = "Alunos matriculados no curso:";
            // 
            // Txb_TotalAlunos
            // 
            this.Txb_TotalAlunos.Location = new System.Drawing.Point(166, 62);
            this.Txb_TotalAlunos.Name = "Txb_TotalAlunos";
            this.Txb_TotalAlunos.ReadOnly = true;
            this.Txb_TotalAlunos.Size = new System.Drawing.Size(46, 20);
            this.Txb_TotalAlunos.TabIndex = 18;
            // 
            // Frm_ConsultaCursoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.Txb_TotalAlunos);
            this.Controls.Add(this.Lbl_QuantidadeAlunos);
            this.Controls.Add(this.Cbox_SelecionaCurso);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Consulta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_ConsultaCursoAlunos";
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
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.ComboBox Cbox_SelecionaCurso;
        private System.Windows.Forms.Label Lbl_QuantidadeAlunos;
        private System.Windows.Forms.TextBox Txb_TotalAlunos;
    }
}