namespace ProjetoFinalAliare
{
    partial class Frm_ConsultarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultarCurso));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Matricula = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txb_IdCurso = new System.Windows.Forms.TextBox();
            this.Txb_NomeCurso = new System.Windows.Forms.TextBox();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_ConsultaPorCurso = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
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
            this.Btn_Consulta.Location = new System.Drawing.Point(12, 28);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(139, 50);
            this.Btn_Consulta.TabIndex = 5;
            this.Btn_Consulta.Text = "Consulta";
            this.Btn_Consulta.UseVisualStyleBackColor = false;
            this.Btn_Consulta.Click += new System.EventHandler(this.Btn_Consulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 314);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(706, 123);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Editar.TabIndex = 7;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Deletar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deletar.Location = new System.Drawing.Point(706, 163);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Deletar.TabIndex = 8;
            this.Btn_Deletar.Text = "Deletar";
            this.Btn_Deletar.UseVisualStyleBackColor = false;
            this.Btn_Deletar.Click += new System.EventHandler(this.Btn_Deletar_Click);
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
            // Lbl_Matricula
            // 
            this.Lbl_Matricula.AutoSize = true;
            this.Lbl_Matricula.Location = new System.Drawing.Point(13, 100);
            this.Lbl_Matricula.Name = "Lbl_Matricula";
            this.Lbl_Matricula.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Matricula.TabIndex = 10;
            this.Lbl_Matricula.Text = "IdCurso:";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(157, 100);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Nome.TabIndex = 11;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Txb_IdCurso
            // 
            this.Txb_IdCurso.Location = new System.Drawing.Point(72, 97);
            this.Txb_IdCurso.Name = "Txb_IdCurso";
            this.Txb_IdCurso.ReadOnly = true;
            this.Txb_IdCurso.Size = new System.Drawing.Size(79, 20);
            this.Txb_IdCurso.TabIndex = 12;
            // 
            // Txb_NomeCurso
            // 
            this.Txb_NomeCurso.Location = new System.Drawing.Point(201, 97);
            this.Txb_NomeCurso.Name = "Txb_NomeCurso";
            this.Txb_NomeCurso.Size = new System.Drawing.Size(334, 20);
            this.Txb_NomeCurso.TabIndex = 13;
            // 
            // Btn_Cadastrar
            // 
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
            // Btn_ConsultaPorCurso
            // 
            this.Btn_ConsultaPorCurso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_ConsultaPorCurso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConsultaPorCurso.Location = new System.Drawing.Point(201, 28);
            this.Btn_ConsultaPorCurso.Name = "Btn_ConsultaPorCurso";
            this.Btn_ConsultaPorCurso.Size = new System.Drawing.Size(139, 50);
            this.Btn_ConsultaPorCurso.TabIndex = 15;
            this.Btn_ConsultaPorCurso.Text = " Consulta Curso";
            this.Btn_ConsultaPorCurso.UseVisualStyleBackColor = false;
            this.Btn_ConsultaPorCurso.Click += new System.EventHandler(this.Btn_ConsultaPorCurso_Click);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.Location = new System.Drawing.Point(706, 243);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(114, 34);
            this.Btn_Imprimir.TabIndex = 16;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.UseVisualStyleBackColor = false;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Frm_ConsultarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_ConsultaPorCurso);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Txb_NomeCurso);
            this.Controls.Add(this.Txb_IdCurso);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_Matricula);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Deletar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Consulta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_ConsultarCurso";
            this.Text = "Frm_Curso";
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
        private System.Windows.Forms.Label Lbl_Matricula;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txb_IdCurso;
        private System.Windows.Forms.TextBox Txb_NomeCurso;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.Button Btn_ConsultaPorCurso;
        private System.Windows.Forms.Button Btn_Imprimir;
    }
}