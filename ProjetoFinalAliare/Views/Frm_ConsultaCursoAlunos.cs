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
    public partial class Frm_ConsultaCursoAlunos : Form
    {
        public Frm_ConsultaCursoAlunos()
        {
            InitializeComponent();
            PopularComboBox();
        }

        private void PopularComboBox()
        {
            var cursos = CursoController.SelecionarCursos();

            foreach (var curso in cursos)
            {
                Cbox_SelecionaCurso.Items.Add(curso.Nome);
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Consulta_Click(object sender, EventArgs e)
        {
            var nomeCurso = Cbox_SelecionaCurso.Text;
            
            if (string.IsNullOrEmpty(nomeCurso))
            {
                MessageBox.Show("Selecione um curso.", "Aliare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                var alunos = CursoController.ListaAlunos(nomeCurso);
                TabelaDeAlunos(alunos);
                Txb_TotalAlunos.Text = alunos.Count().ToString();
            }
            
        }
        private void TabelaDeAlunos(List<Aluno> alunos)
        {
            var dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));
            dt.Columns.Add("Cidade", typeof(string));
            dt.Columns.Add("Estado", typeof(string));

            foreach (var aluno in alunos)
            {
                dt.Rows.Add(aluno.Nome, aluno.Email, aluno.Celular, aluno.Cidade, aluno.Estado);
            }
            dataGridView1.DataSource = dt;
            
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            var form = new Frm_RelatorioCursoAlunos(dt);
            form.ShowDialog();
        }

        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("Nome");
            dt.Columns.Add("Email");
            dt.Columns.Add("Telefone");
            dt.Columns.Add("Cidade");
            dt.Columns.Add("Estado");

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                dt.Rows.Add(item.Cells["Nome"].Value.ToString(),
                            item.Cells["Email"].Value.ToString(),
                            item.Cells["Telefone"].Value.ToString(),
                            item.Cells["Cidade"].Value.ToString(),
                            item.Cells["Estado"].Value.ToString());
            }
            return dt;
        }
    }
}
