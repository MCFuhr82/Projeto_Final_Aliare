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
    public partial class Frm_ConsultarCurso : Form
    {
        public Frm_ConsultarCurso()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            var form = new Frm_CadastrarCurso();
            form.ShowDialog();
        }

        private void Btn_Consulta_Click(object sender, EventArgs e)
        {
            LimparTextBoxes();
            dataGridView1.DataSource = ConsultarListaCurso();
            dataGridView1.Columns["Matricula"].Visible = false;
            
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            var form = new Frm_EditarCurso(Txb_IdCurso.Text);
            form.ShowDialog();
        }
       
        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            var idCurso = int.Parse(Txb_IdCurso.Text);
            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //Rotina de exclusão
                DeletarCurso(idCurso);
                dataGridView1.DataSource = ConsultarListaCurso();

                //Confirmando exclusão para o usuário
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cursos = new List<Curso>();
                var selectedCurso = dataGridView1.SelectedRows[0].DataBoundItem as Curso;
                Txb_IdCurso.Text = selectedCurso.Id.ToString();
                Txb_NomeCurso.Text = selectedCurso.Nome.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message + " - " + ex.Source);
            }
        }

        public List<Curso> ConsultarListaCurso()
        {
            try
            {
                using (var context = new Context())
                {
                    var listaCursos = context.Curso.ToList();
                    return listaCursos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        private void DeletarCurso(int idCurso)
        {
            using (var context = new Context())
            {
                var cursos = context.Curso.ToList();
                foreach (var curso in cursos)
                {
                    if (curso.Id == idCurso)
                    {
                        context.Curso.Remove(curso);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void LimparTextBoxes()
        {
            Txb_IdCurso.Text = null;
            Txb_NomeCurso.Text = null;
        }
    }
}
