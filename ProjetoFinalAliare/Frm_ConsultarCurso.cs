using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
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
            Btn_Editar.Enabled = false;
            Btn_Deletar.Enabled = false;
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
            dataGridView1.DataSource = CursoController.SelecionarCursos();
            Btn_Editar.Enabled = true;
            Btn_Deletar.Enabled = true;
            dataGridView1.Columns["Alunos"].Visible = false;

        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (Txb_IdCurso.Text == "")
            {
                MensagemDeSelecao();
            }
            else
            {
                var form = new Frm_EditarCurso(Txb_IdCurso.Text);
                form.ShowDialog();
            }
        }
       
        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txb_IdCurso.Text == "")
                {
                    MensagemDeSelecao();
                }
                else
                {
                    var idCurso = int.Parse(Txb_IdCurso.Text);
                    //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        //Rotina de exclusão
                        CursoController.DeleteCurso(idCurso);
                        dataGridView1.DataSource = CursoController.SelecionarCursos();

                        //Confirmando exclusão para o usuário
                        MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("O curso não pode ser excluído. Favor verificar sem existe algum aluno matriculado no curso.", "Aliare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
                       
        private void LimparTextBoxes()
        {
            Txb_IdCurso.Text = null;
            Txb_NomeCurso.Text = null;
        }

        private void MensagemDeSelecao()
        {
            MessageBox.Show("Por favor, selecione um aluno.", "Selecionar aluno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_ConsultaEspecial_Click(object sender, EventArgs e)
        {
            var form = new Frm_ConsultarPorNome();
            form.ShowDialog();
        }

        private void Btn_ConsultaPorCurso_Click(object sender, EventArgs e)
        {
            var form = new Frm_ConsultaCursoAlunos();
            form.ShowDialog();
            
        }
    }
}
