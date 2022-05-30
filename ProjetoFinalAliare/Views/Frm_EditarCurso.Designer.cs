namespace ProjetoFinalAliare
{
    partial class Frm_EditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditarCurso));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Lbl_EditarCadastro = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txb_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_CargaHoraria = new System.Windows.Forms.Label();
            this.Txb_CargaHoraria = new System.Windows.Forms.TextBox();
            this.Lbl_IdCurso = new System.Windows.Forms.Label();
            this.Txb_IdCurso = new System.Windows.Forms.TextBox();
            this.Btn_voltar = new System.Windows.Forms.Button();
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
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Salvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.Location = new System.Drawing.Point(708, 369);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(112, 34);
            this.Btn_Salvar.TabIndex = 12;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Lbl_EditarCadastro
            // 
            this.Lbl_EditarCadastro.AutoSize = true;
            this.Lbl_EditarCadastro.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EditarCadastro.Location = new System.Drawing.Point(261, 31);
            this.Lbl_EditarCadastro.Name = "Lbl_EditarCadastro";
            this.Lbl_EditarCadastro.Size = new System.Drawing.Size(280, 31);
            this.Lbl_EditarCadastro.TabIndex = 10;
            this.Lbl_EditarCadastro.Text = "Editar cadastro do curso";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(33, 140);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(111, 19);
            this.Lbl_Nome.TabIndex = 11;
            this.Lbl_Nome.Text = "Nome do Curso:";
            // 
            // Txb_Nome
            // 
            this.Txb_Nome.Location = new System.Drawing.Point(150, 139);
            this.Txb_Nome.Name = "Txb_Nome";
            this.Txb_Nome.Size = new System.Drawing.Size(509, 20);
            this.Txb_Nome.TabIndex = 1;
            // 
            // Lbl_CargaHoraria
            // 
            this.Lbl_CargaHoraria.AutoSize = true;
            this.Lbl_CargaHoraria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CargaHoraria.Location = new System.Drawing.Point(45, 186);
            this.Lbl_CargaHoraria.Name = "Lbl_CargaHoraria";
            this.Lbl_CargaHoraria.Size = new System.Drawing.Size(99, 19);
            this.Lbl_CargaHoraria.TabIndex = 17;
            this.Lbl_CargaHoraria.Text = "Carga Horaria:";
            // 
            // Txb_CargaHoraria
            // 
            this.Txb_CargaHoraria.Location = new System.Drawing.Point(150, 186);
            this.Txb_CargaHoraria.Name = "Txb_CargaHoraria";
            this.Txb_CargaHoraria.Size = new System.Drawing.Size(69, 20);
            this.Txb_CargaHoraria.TabIndex = 2;
            // 
            // Lbl_IdCurso
            // 
            this.Lbl_IdCurso.AutoSize = true;
            this.Lbl_IdCurso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdCurso.Location = new System.Drawing.Point(78, 98);
            this.Lbl_IdCurso.Name = "Lbl_IdCurso";
            this.Lbl_IdCurso.Size = new System.Drawing.Size(66, 19);
            this.Lbl_IdCurso.TabIndex = 18;
            this.Lbl_IdCurso.Text = "Id Curso:";
            // 
            // Txb_IdCurso
            // 
            this.Txb_IdCurso.Location = new System.Drawing.Point(150, 97);
            this.Txb_IdCurso.Name = "Txb_IdCurso";
            this.Txb_IdCurso.ReadOnly = true;
            this.Txb_IdCurso.Size = new System.Drawing.Size(69, 20);
            this.Txb_IdCurso.TabIndex = 19;
            // 
            // Btn_voltar
            // 
            this.Btn_voltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_voltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_voltar.Location = new System.Drawing.Point(708, 409);
            this.Btn_voltar.Name = "Btn_voltar";
            this.Btn_voltar.Size = new System.Drawing.Size(112, 34);
            this.Btn_voltar.TabIndex = 20;
            this.Btn_voltar.Text = "Voltar";
            this.Btn_voltar.UseVisualStyleBackColor = false;
            this.Btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // Frm_EditarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.Btn_voltar);
            this.Controls.Add(this.Txb_IdCurso);
            this.Controls.Add(this.Lbl_IdCurso);
            this.Controls.Add(this.Txb_CargaHoraria);
            this.Controls.Add(this.Lbl_CargaHoraria);
            this.Controls.Add(this.Txb_Nome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_EditarCadastro);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_EditarCurso";
            this.Text = "Editar Curso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Label Lbl_EditarCadastro;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txb_Nome;
        private System.Windows.Forms.Label Lbl_CargaHoraria;
        private System.Windows.Forms.TextBox Txb_CargaHoraria;
        private System.Windows.Forms.Label Lbl_IdCurso;
        private System.Windows.Forms.TextBox Txb_IdCurso;
        private System.Windows.Forms.Button Btn_voltar;
    }
}