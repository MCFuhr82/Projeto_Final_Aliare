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
            var listaAlunos = GerarDadosRelatorio();

            var alunosParaOrdenar = from x in listaAlunos select x;
            var alunosOrdenados = alunosParaOrdenar.OrderBy(x => x.Matricula);

            dataGridView1.DataSource = alunosOrdenados.ToList();
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
                    AlunoController.DeletarAluno(matricula);
                    dataGridView1.DataSource = AlunoController.ReadAlunos();

                    //Confirmando exclusão para o usuário
                    MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txb_Matricula.Text = "";
                    Txb_Nome.Text = "";
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

        private void Btn_ConsultaPorNome_Click(object sender, EventArgs e)
        {
            var form = new Frm_ConsultarPorNome();
            form.ShowDialog();
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            var listaAlunos = GerarDadosRelatorio();
            var form = new Frm_RelatorioAlunos(listaAlunos);
            form.ShowDialog();
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
                var selectedAluno = dataGridView1.SelectedRows[0].DataBoundItem as Aluno;
                Txb_Matricula.Text = selectedAluno.Matricula.ToString();
                Txb_Nome.Text = selectedAluno.Nome.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message + " - " + ex.Source);
            }
        }

        private List<Aluno> GerarDadosRelatorio()
        {
            var alunos = AlunoController.ReadAlunos();

            var alunosParaOrdenar = from x in alunos select x;
            var alunosOrdenados = alunosParaOrdenar.OrderBy(x => x.Matricula);

            var listaAlunos = alunosOrdenados.ToList();


            return listaAlunos;
        }

        private void MensagemDeSelecao()
        {
            MessageBox.Show("Por favor, selecione um aluno.", "Selecionar aluno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
