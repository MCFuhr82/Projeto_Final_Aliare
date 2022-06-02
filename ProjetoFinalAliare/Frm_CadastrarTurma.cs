using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalAliare
{
    public partial class Frm_CadastrarTurma : Form
    {
        public Frm_CadastrarTurma()
        {
            InitializeComponent();
            PopularComboBoxCurso();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cbox_SelecionarCurso.Text) ||
                string.IsNullOrWhiteSpace(Cbox_SelecionarSemestre.Text) ||
                string.IsNullOrEmpty(Cbox_SelecionarPeriodo.Text))
            {
                MessageBox.Show("Favor selecionar Curso, Semestre e Periodo", "Aliare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var curso = CriarTurma();
                UpdateTurma(curso);
            }
        }

        private void UpdateTurma(Curso curso)
        {
            try
            {
                using (var context = new Context())
                {
                    var nomeTurma = Cbox_SelecionarCurso.Text;
                    var turma = TurmaController.SelecionarTurmaPorNome(nomeTurma);

                    turma.Curso = curso;
                    context.Entry(turma).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PopularComboBoxCurso()
        {
            var cursos = CursoController.SelecionarCursos();

            foreach (var curso in cursos)
            {
                Cbox_SelecionarCurso.Items.Add(curso.Nome);
            }
        }

        private Curso CriarTurma()
        {
            try
            {
                var nomeCurso = Cbox_SelecionarCurso.Text;
                var semestre = int.Parse(Cbox_SelecionarSemestre.Text);
                var periodo = Cbox_SelecionarPeriodo.Text;

                var curso = CursoController.SelectCursoPorNome(nomeCurso);
                
                var turma = new Turma(semestre, periodo, nomeCurso);

                TurmaController.InserirTurma(turma);
                
                MessageBox.Show("Dados inseridos com sucesso!");

                return curso;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
