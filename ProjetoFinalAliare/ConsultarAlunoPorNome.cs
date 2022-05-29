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
    public partial class Frm_ConsultarPorNome : Form
    {
        public Frm_ConsultarPorNome()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Consulta_Click(object sender, EventArgs e)
        {
            var nomeAluno = Txb_Nome.Text;

            if (string.IsNullOrEmpty(nomeAluno))
            {
                MessageBox.Show("Preencha o nome do aluno");
            }
            else
            {
                var alunos = ListaAlunosPorNome();
                TabelaDeSelecao(alunos);
            }
        }

        private List<Aluno> ListaAlunosPorNome()
        {
            var nomeAluno = Txb_Nome.Text;
            var context = new Context();

            var aluno = context.Aluno.SqlQuery($"SELECT * FROM public.\"Aluno\" as Aluno WHERE Aluno.\"Nome\" LIKE '%{nomeAluno}%'").ToList();
            
            return aluno;
        }

        private void TabelaDeSelecao(List<Aluno> alunos)
        {
            var dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Cidade", typeof(string));
            dt.Columns.Add("Curso", typeof(string));

            foreach (var aluno in alunos)
            {
                if (aluno.Curso == null)
                {
                    dt.Rows.Add(aluno.Nome, aluno.Email, aluno.Cidade, "");
                }
                else
                {
                    dt.Rows.Add(aluno.Nome, aluno.Email, aluno.Cidade, aluno.Curso.Nome);
                }
            }

            dataGridView1.DataSource = dt;
        }
    }
}
