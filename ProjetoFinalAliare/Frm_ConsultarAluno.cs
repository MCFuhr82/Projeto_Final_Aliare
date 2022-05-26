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
    public partial class Frm_ConsultarAluno : Form
    {
        
        public Frm_ConsultarAluno()
        {
            InitializeComponent();
            Btn_Editar.Enabled = false;
            Btn_Deletar.Enabled = false;
            Btn_Matricular.Enabled = false;
            
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Consulta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlunoController.ReadAlunos();
            dataGridView1.Columns["IdCurso"].Visible = false;
            Btn_Editar.Enabled = true;
            Btn_Deletar.Enabled = true;
            Btn_Matricular.Enabled = true;

        }
        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            if (Txb_Matricula.Text == "")
            {
                MensagemDeSelecao();
            } 
            else
            {
                var matricula = int.Parse(Txb_Matricula.Text);

                //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    //Rotina de exclusão
                    AlunoController.DeleteAluno(matricula);
                    dataGridView1.DataSource = AlunoController.ReadAlunos();

                    //Confirmando exclusão para o usuário
                    MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            var form = new Frm_CadastrarAluno();
            form.ShowDialog();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (Txb_Matricula.Text == "")
            {
                MensagemDeSelecao();
            }
            else
            {
                var form = new Frm_EditarAluno(Txb_Matricula.Text);
                form.ShowDialog();
            }
        }

        private void Frm_Matricular_Click(object sender, EventArgs e)
        {
            if (Txb_Matricula.Text == "")
            {
                MensagemDeSelecao();
            }
            else
            {
                var form = new Frm_Matricular(Txb_Matricula.Text, Txb_Nome.Text);
                form.ShowDialog();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var alunos = new List<Aluno>();
                var selectedAluno = dataGridView1.SelectedRows[0].DataBoundItem as Aluno;
                Txb_Matricula.Text = selectedAluno.Matricula.ToString();
                Txb_Nome.Text = selectedAluno.Nome.ToString();
                dataGridView1.Columns["IdCurso"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message + " - " + ex.Source);
            }
        }

        private void MensagemDeSelecao()
        {
            MessageBox.Show("Por favor, selecione um aluno.", "Selecionar aluno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        //Selecionar Alunos
        //public List<Aluno> ConsultarListaAluno()
        //{
        //    try
        //    {
        //        using (var context = new Context())
        //        {
        //            var listaAlunos = context.Aluno.ToList();
        //            return listaAlunos;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return null;
        //}
        
        //Deletar Alunos
        //private void DeletarAluno(int matricula)
        //{
        //    using (var context = new Context())
        //    {
        //        var alunos = context.Aluno.ToList();
        //        foreach (var aluno in alunos)
        //        {
        //            if (aluno.Matricula == matricula)
        //            {
        //                context.Aluno.Remove(aluno);
        //                context.SaveChanges();
        //            }
        //        }
        //    }
        //}

    }
}
