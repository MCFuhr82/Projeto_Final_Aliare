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
                //retorna uma lista de alunos por curso
                var alunos = CursoController.ListaAlunos(nomeCurso);
                //Exibe a lista de alunos no DataGrid
                TabelaDeAlunos(alunos);
                //Somatório de alunos por curso
                Txb_TotalAlunos.Text = alunos.Count().ToString();
            }
            
        }
        //Método para gerar o Datagridviewer
        private DataTable TabelaDeAlunos(List<Aluno> alunos)
        {
            var dt = new DataTable();
            dt.Columns.Add("Nome");
            dt.Columns.Add("Email");
            dt.Columns.Add("Celular");
            dt.Columns.Add("Cidade");
            dt.Columns.Add("Estado");

            foreach (var aluno in alunos)
            {
                dt.Rows.Add(aluno.Nome, aluno.Email, aluno.Celular, aluno.Cidade, aluno.Estado);
            }

            dataGridView1.DataSource = dt;
            return dt;
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            var form = new Frm_RelatorioCursoAlunos(dt);
            form.ShowDialog();
        }

        private DataTable GerarDadosRelatorio()
        {
            var nomeCurso = Cbox_SelecionaCurso.Text;
            var curso = CursoController.ListaAlunos(nomeCurso);
            var table = TabelaDeAlunos(curso);

            var dt = new DataTable();
            dt.Columns.Add("Nome");
            dt.Columns.Add("Email");
            dt.Columns.Add("Celular");
            dt.Columns.Add("Cidade");
            dt.Columns.Add("Estado");

            foreach (DataRow row in table.Rows)
            {
                dt.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4]);
            }

            return dt;
        }
    }
}
