
namespace ProjetoFinalAliare.Views
{
    partial class Frm_Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastrar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txb_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Mtxb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Mtxb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txb_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Endereco = new System.Windows.Forms.Label();
            this.Txb_Endereco = new System.Windows.Forms.TextBox();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Mtxb_CEP = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Txb_Complemento = new System.Windows.Forms.TextBox();
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
            this.Btn_Cadastrar.TabIndex = 7;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
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
            this.Lbl_Nome.Size = new System.Drawing.Size(50, 19);
            this.Lbl_Nome.TabIndex = 11;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Txb_Nome
            // 
            this.Txb_Nome.Location = new System.Drawing.Point(89, 86);
            this.Txb_Nome.Name = "Txb_Nome";
            this.Txb_Nome.Size = new System.Drawing.Size(570, 20);
            this.Txb_Nome.TabIndex = 12;
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CPF.Location = new System.Drawing.Point(33, 185);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(41, 19);
            this.Lbl_CPF.TabIndex = 13;
            this.Lbl_CPF.Text = "CPF:";
            // 
            // Mtxb_CPF
            // 
            this.Mtxb_CPF.Location = new System.Drawing.Point(89, 184);
            this.Mtxb_CPF.Mask = "000,000,000-00";
            this.Mtxb_CPF.Name = "Mtxb_CPF";
            this.Mtxb_CPF.Size = new System.Drawing.Size(91, 20);
            this.Mtxb_CPF.TabIndex = 14;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefone.Location = new System.Drawing.Point(269, 185);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(63, 19);
            this.Lbl_Telefone.TabIndex = 15;
            this.Lbl_Telefone.Text = "Telefone:";
            // 
            // Mtxb_Telefone
            // 
            this.Mtxb_Telefone.Location = new System.Drawing.Point(338, 184);
            this.Mtxb_Telefone.Mask = "(99) 00000-0000";
            this.Mtxb_Telefone.Name = "Mtxb_Telefone";
            this.Mtxb_Telefone.Size = new System.Drawing.Size(100, 20);
            this.Mtxb_Telefone.TabIndex = 16;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(33, 136);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(45, 19);
            this.Lbl_Email.TabIndex = 17;
            this.Lbl_Email.Text = "Email:";
            // 
            // Txb_Email
            // 
            this.Txb_Email.Location = new System.Drawing.Point(89, 136);
            this.Txb_Email.Name = "Txb_Email";
            this.Txb_Email.Size = new System.Drawing.Size(570, 20);
            this.Txb_Email.TabIndex = 18;
            // 
            // Lbl_Endereco
            // 
            this.Lbl_Endereco.AutoSize = true;
            this.Lbl_Endereco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Endereco.Location = new System.Drawing.Point(33, 233);
            this.Lbl_Endereco.Name = "Lbl_Endereco";
            this.Lbl_Endereco.Size = new System.Drawing.Size(70, 19);
            this.Lbl_Endereco.TabIndex = 19;
            this.Lbl_Endereco.Text = "Endereço:";
            // 
            // Txb_Endereco
            // 
            this.Txb_Endereco.Location = new System.Drawing.Point(109, 234);
            this.Txb_Endereco.Name = "Txb_Endereco";
            this.Txb_Endereco.Size = new System.Drawing.Size(550, 20);
            this.Txb_Endereco.TabIndex = 20;
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CEP.Location = new System.Drawing.Point(512, 186);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(41, 19);
            this.Lbl_CEP.TabIndex = 21;
            this.Lbl_CEP.Text = "CEP:";
            // 
            // Mtxb_CEP
            // 
            this.Mtxb_CEP.Location = new System.Drawing.Point(559, 184);
            this.Mtxb_CEP.Mask = "00000-000";
            this.Mtxb_CEP.Name = "Mtxb_CEP";
            this.Mtxb_CEP.Size = new System.Drawing.Size(100, 20);
            this.Mtxb_CEP.TabIndex = 22;
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Complemento.Location = new System.Drawing.Point(33, 285);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(97, 19);
            this.Lbl_Complemento.TabIndex = 23;
            this.Lbl_Complemento.Text = "Complemento:";
            // 
            // Txb_Complemento
            // 
            this.Txb_Complemento.Location = new System.Drawing.Point(136, 286);
            this.Txb_Complemento.Name = "Txb_Complemento";
            this.Txb_Complemento.Size = new System.Drawing.Size(523, 20);
            this.Txb_Complemento.TabIndex = 24;
            // 
            // Frm_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.Txb_Complemento);
            this.Controls.Add(this.Lbl_Complemento);
            this.Controls.Add(this.Mtxb_CEP);
            this.Controls.Add(this.Lbl_CEP);
            this.Controls.Add(this.Txb_Endereco);
            this.Controls.Add(this.Lbl_Endereco);
            this.Controls.Add(this.Txb_Email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Mtxb_Telefone);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Mtxb_CPF);
            this.Controls.Add(this.Lbl_CPF);
            this.Controls.Add(this.Txb_Nome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Cadastrar";
            this.Text = "Cadastrar";
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
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.MaskedTextBox Mtxb_CPF;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.MaskedTextBox Mtxb_Telefone;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txb_Email;
        private System.Windows.Forms.Label Lbl_Endereco;
        private System.Windows.Forms.TextBox Txb_Endereco;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.MaskedTextBox Mtxb_CEP;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.TextBox Txb_Complemento;
    }
}