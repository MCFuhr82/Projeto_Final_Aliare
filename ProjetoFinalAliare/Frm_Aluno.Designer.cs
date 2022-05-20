namespace ProjetoFinalAliare
{
    partial class Frm_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Aluno));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
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
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar.Location = new System.Drawing.Point(123, 20);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(139, 50);
            this.Btn_Cadastrar.TabIndex = 2;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
            // 
            // Btn_Consulta
            // 
            this.Btn_Consulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Consulta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consulta.Location = new System.Drawing.Point(418, 20);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(139, 50);
            this.Btn_Consulta.TabIndex = 5;
            this.Btn_Consulta.Text = "Consulta";
            this.Btn_Consulta.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 353);
            this.dataGridView1.TabIndex = 6;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(706, 119);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Editar.TabIndex = 7;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Deletar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deletar.Location = new System.Drawing.Point(708, 159);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(112, 34);
            this.Btn_Deletar.TabIndex = 8;
            this.Btn_Deletar.Text = "Deletar";
            this.Btn_Deletar.UseVisualStyleBackColor = false;
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
            // Frm_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Deletar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Consulta);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Aluno";
            this.Text = "Frm_Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.Button Btn_Consulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Deletar;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}