namespace ProjetoFinalAliare
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txb_Login = new System.Windows.Forms.TextBox();
            this.Txb_Password = new System.Windows.Forms.TextBox();
            this.Btn_Conectar = new System.Windows.Forms.Button();
            this.Img_Login = new System.Windows.Forms.PictureBox();
            this.Img_Aliare = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Aliare)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Login.Location = new System.Drawing.Point(252, 139);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Login.TabIndex = 1;
            this.Lbl_Login.Text = "Login:";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Password.Location = new System.Drawing.Point(225, 182);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(73, 17);
            this.Lbl_Password.TabIndex = 2;
            this.Lbl_Password.Text = "Password:";
            // 
            // Txb_Login
            // 
            this.Txb_Login.Location = new System.Drawing.Point(311, 135);
            this.Txb_Login.Name = "Txb_Login";
            this.Txb_Login.Size = new System.Drawing.Size(135, 20);
            this.Txb_Login.TabIndex = 3;
            // 
            // Txb_Password
            // 
            this.Txb_Password.Location = new System.Drawing.Point(311, 178);
            this.Txb_Password.Name = "Txb_Password";
            this.Txb_Password.PasswordChar = '*';
            this.Txb_Password.Size = new System.Drawing.Size(135, 20);
            this.Txb_Password.TabIndex = 4;
            // 
            // Btn_Conectar
            // 
            this.Btn_Conectar.Location = new System.Drawing.Point(329, 213);
            this.Btn_Conectar.Name = "Btn_Conectar";
            this.Btn_Conectar.Size = new System.Drawing.Size(100, 44);
            this.Btn_Conectar.TabIndex = 5;
            this.Btn_Conectar.Text = "Conectar";
            this.Btn_Conectar.UseVisualStyleBackColor = true;
            this.Btn_Conectar.Click += new System.EventHandler(this.Btn_Conectar_Click);
            // 
            // Img_Login
            // 
            this.Img_Login.Image = ((System.Drawing.Image)(resources.GetObject("Img_Login.Image")));
            this.Img_Login.Location = new System.Drawing.Point(12, 103);
            this.Img_Login.Name = "Img_Login";
            this.Img_Login.Size = new System.Drawing.Size(161, 154);
            this.Img_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Login.TabIndex = 6;
            this.Img_Login.TabStop = false;
            // 
            // Img_Aliare
            // 
            this.Img_Aliare.Image = ((System.Drawing.Image)(resources.GetObject("Img_Aliare.Image")));
            this.Img_Aliare.InitialImage = null;
            this.Img_Aliare.Location = new System.Drawing.Point(174, 12);
            this.Img_Aliare.Name = "Img_Aliare";
            this.Img_Aliare.Size = new System.Drawing.Size(132, 75);
            this.Img_Aliare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Aliare.TabIndex = 7;
            this.Img_Aliare.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 326);
            this.Controls.Add(this.Img_Aliare);
            this.Controls.Add(this.Img_Login);
            this.Controls.Add(this.Btn_Conectar);
            this.Controls.Add(this.Txb_Password);
            this.Controls.Add(this.Txb_Login);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Login);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            ((System.ComponentModel.ISupportInitialize)(this.Img_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Aliare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txb_Login;
        private System.Windows.Forms.TextBox Txb_Password;
        private System.Windows.Forms.Button Btn_Conectar;
        private System.Windows.Forms.PictureBox Img_Login;
        private System.Windows.Forms.PictureBox Img_Aliare;
    }
}

