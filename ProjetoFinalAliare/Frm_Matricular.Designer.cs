
namespace ProjetoFinalAliare
{
    partial class Frm_Matricular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Matricular));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cbox_SelecionaCurso = new System.Windows.Forms.ComboBox();
            this.Txb_Matricula = new System.Windows.Forms.TextBox();
            this.Lbl_Matricula = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txb_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_SelecionarCurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(674, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Matricular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cbox_SelecionaCurso
            // 
            this.Cbox_SelecionaCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_SelecionaCurso.FormattingEnabled = true;
            this.Cbox_SelecionaCurso.Location = new System.Drawing.Point(204, 176);
            this.Cbox_SelecionaCurso.Name = "Cbox_SelecionaCurso";
            this.Cbox_SelecionaCurso.Size = new System.Drawing.Size(398, 21);
            this.Cbox_SelecionaCurso.TabIndex = 17;
            // 
            // Txb_Matricula
            // 
            this.Txb_Matricula.Location = new System.Drawing.Point(75, 102);
            this.Txb_Matricula.Name = "Txb_Matricula";
            this.Txb_Matricula.ReadOnly = true;
            this.Txb_Matricula.Size = new System.Drawing.Size(79, 20);
            this.Txb_Matricula.TabIndex = 18;
            // 
            // Lbl_Matricula
            // 
            this.Lbl_Matricula.AutoSize = true;
            this.Lbl_Matricula.Location = new System.Drawing.Point(16, 105);
            this.Lbl_Matricula.Name = "Lbl_Matricula";
            this.Lbl_Matricula.Size = new System.Drawing.Size(53, 13);
            this.Lbl_Matricula.TabIndex = 16;
            this.Lbl_Matricula.Text = "Matricula:";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(160, 105);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Nome.TabIndex = 17;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Txb_Nome
            // 
            this.Txb_Nome.Location = new System.Drawing.Point(204, 102);
            this.Txb_Nome.Name = "Txb_Nome";
            this.Txb_Nome.ReadOnly = true;
            this.Txb_Nome.Size = new System.Drawing.Size(398, 20);
            this.Txb_Nome.TabIndex = 19;
            // 
            // Lbl_SelecionarCurso
            // 
            this.Lbl_SelecionarCurso.AutoSize = true;
            this.Lbl_SelecionarCurso.Location = new System.Drawing.Point(108, 179);
            this.Lbl_SelecionarCurso.Name = "Lbl_SelecionarCurso";
            this.Lbl_SelecionarCurso.Size = new System.Drawing.Size(90, 13);
            this.Lbl_SelecionarCurso.TabIndex = 20;
            this.Lbl_SelecionarCurso.Text = "Selecionar Curso:";
            // 
            // Frm_Matricular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_SelecionarCurso);
            this.Controls.Add(this.Txb_Nome);
            this.Controls.Add(this.Cbox_SelecionaCurso);
            this.Controls.Add(this.Txb_Matricula);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_Matricula);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Matricular";
            this.Text = "Frm_Matricular";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cbox_SelecionaCurso;
        private System.Windows.Forms.TextBox Txb_Matricula;
        private System.Windows.Forms.Label Lbl_Matricula;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txb_Nome;
        private System.Windows.Forms.Label Lbl_SelecionarCurso;
    }
}