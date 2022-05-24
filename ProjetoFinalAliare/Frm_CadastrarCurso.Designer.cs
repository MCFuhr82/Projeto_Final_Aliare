namespace ProjetoFinalAliare
{
    partial class Frm_CadastrarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastrarCurso));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txb_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_CargaHoraria = new System.Windows.Forms.Label();
            this.Txb_CargaHoraria = new System.Windows.Forms.TextBox();
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
            this.Lbl_Cadastro.Size = new System.Drawing.Size(111, 31);
            this.Lbl_Cadastro.TabIndex = 10;
            this.Lbl_Cadastro.Text = "Cadastro";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(33, 87);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(111, 19);
            this.Lbl_Nome.TabIndex = 11;
            this.Lbl_Nome.Text = "Nome do Curso:";
            // 
            // Txb_Nome
            // 
            this.Txb_Nome.Location = new System.Drawing.Point(150, 86);
            this.Txb_Nome.Name = "Txb_Nome";
            this.Txb_Nome.Size = new System.Drawing.Size(509, 20);
            this.Txb_Nome.TabIndex = 1;
            // 
            // Lbl_CargaHoraria
            // 
            this.Lbl_CargaHoraria.AutoSize = true;
            this.Lbl_CargaHoraria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CargaHoraria.Location = new System.Drawing.Point(33, 136);
            this.Lbl_CargaHoraria.Name = "Lbl_CargaHoraria";
            this.Lbl_CargaHoraria.Size = new System.Drawing.Size(99, 19);
            this.Lbl_CargaHoraria.TabIndex = 17;
            this.Lbl_CargaHoraria.Text = "Carga Horaria:";
            // 
            // Txb_CargaHoraria
            // 
            this.Txb_CargaHoraria.Location = new System.Drawing.Point(150, 136);
            this.Txb_CargaHoraria.Name = "Txb_CargaHoraria";
            this.Txb_CargaHoraria.Size = new System.Drawing.Size(69, 20);
            this.Txb_CargaHoraria.TabIndex = 2;
            this.Txb_CargaHoraria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txb_CargaHoraria_KeyPress);
            // 
            // Frm_CadastrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.Txb_CargaHoraria);
            this.Controls.Add(this.Lbl_CargaHoraria);
            this.Controls.Add(this.Txb_Nome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_CadastrarCurso";
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
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txb_Nome;
        private System.Windows.Forms.Label Lbl_CargaHoraria;
        private System.Windows.Forms.TextBox Txb_CargaHoraria;
    }
}