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
    public partial class Frm_RelatorioCursos : Form
    {
        DataTable dt = new DataTable();
        public Frm_RelatorioCursos(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void Frm_RelatorioCursos_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet_Curso", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
