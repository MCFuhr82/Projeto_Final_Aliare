namespace ProjetoFinalAliare
{
    partial class Frm_ConsultarPorNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultarPorNome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txb_Nome = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 314);
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
            this.Lbl_Nome.Location = new System.Drawing.Point(12, 101);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Nome.TabIndex = 11;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Txb_Nome
            // 
            this.Txb_Nome.Location = new System.Drawing.Point(56, 98);
            this.Txb_Nome.Name = "Txb_Nome";
            this.Txb_Nome.Size = new System.Drawing.Size(362, 20);
            this.Txb_Nome.TabIndex = 13;
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
            // Frm_ConsultarPorNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Txb_Nome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Consulta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_ConsultarPorNome";
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
        private System.Windows.Forms.TextBox Txb_Nome;
        private System.Windows.Forms.Button Btn_Imprimir;
    }
}