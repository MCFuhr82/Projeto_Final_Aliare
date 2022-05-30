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
    public partial class Frm_Matricular : Form
    {
        public Frm_Matricular()
        {
            InitializeComponent();
        }
        
        public Frm_Matricular(string matricula, string nome)
        {
            InitializeComponent();
            Txb_Matricula.Text = matricula;
            Txb_Nome.Text = nome;
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

        private void Btn_Matricular_Click(object sender, EventArgs e)
        {
            UpdateAluno(int.Parse(Txb_Matricula.Text));
            this.Close();
        }

        private void UpdateAluno(int matricula)
        {
            using (var context = new Context())
            {
                var nomeCurso = Cbox_SelecionaCurso.Text;
                
                var aluno = context.Aluno.Where(x => x.Matricula == matricula).FirstOrDefault();
                              
                var curso = context.Curso.Where(x => x.Nome == nomeCurso).FirstOrDefault();

                if (aluno.Curso != null)
                {
                    MessageBox.Show("Aluno já possui matrícula ativa em outro curso!", "Aliare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    aluno.Curso = curso;
                    context.Entry(aluno).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
        }
    }
}
