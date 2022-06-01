
namespace ProjetoFinalAliare
{
    partial class Frm_RelatorioCursoAlunos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CursoBindingSource
            // 
            this.CursoBindingSource.DataMember = "Alunos";
            this.CursoBindingSource.DataSource = typeof(ProjetoFinalAliare.Models.Curso);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Aluno";
            reportDataSource1.Value = this.AlunoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoFinalAliare.Relatorios.RelatorioCursoAlunos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // AlunoBindingSource
            // 
            this.AlunoBindingSource.DataSource = typeof(ProjetoFinalAliare.Models.Aluno);
            // 
            // Frm_RelatorioCursoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_RelatorioCursoAlunos";
            this.Text = "Frm_RelatorioCursoAlunos";
            this.Load += new System.EventHandler(this.Frm_RelatorioCursoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CursoBindingSource;
        private System.Windows.Forms.BindingSource AlunoBindingSource;
    }
}