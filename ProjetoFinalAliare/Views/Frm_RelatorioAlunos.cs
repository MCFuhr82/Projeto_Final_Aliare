using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalAliare
{
    public partial class Frm_RelatorioAlunos : Form
    {
        List<Aluno> listaAlunos = new List<Aluno>();

        public Frm_RelatorioAlunos(List<Aluno> lista)
        {
            InitializeComponent();
            listaAlunos = lista;
        }

        private void Frm_RelatorioAlunos_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", listaAlunos));
            this.reportViewer1.RefreshReport();
        }
    }
}
