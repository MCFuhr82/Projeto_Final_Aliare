using System;
using System.Windows.Forms;
using ProjetoFinalAliare.Models;

namespace ProjetoFinalAliare
{
    public partial class Frm_CadastrarAluno : Form
    {
        public Frm_CadastrarAluno()
        {
            InitializeComponent();
        }
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            InserirAluno();
            LimparTextBoxes();
        }
        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InserirAluno()
        {
            try
            {
                var nome = Txb_Nome.Text;
                var email = Txb_Email.Text;
                var cep = Mtxb_CEP.Text;
                var endereco = Txb_Endereco.Text;
                var numero = int.Parse(Txb_Numero.Text);
                var cidade = Txb_Cidade.Text;
                var estado = Cbox_Estados.Text;
                var cpf = Mtxb_CPF.Text;
                var telefone = Mtxb_Telefone.Text;
                var complemento = Txb_Complemento.Text;

                using (var context = new Context()) 
                {
                    var aluno = new Aluno(nome, cpf, endereco, numero, cidade, estado, cep, complemento, telefone, email);
                    context.Aluno.Add(aluno);
                    context.SaveChanges();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //método para aceitar apenas números
        private void Txb_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            var form = new Frm_ConsultarAluno();
            form.ShowDialog();
        }

        private void LimparTextBoxes()
        {
            Txb_Nome.Text = null;
            Txb_Email.Text = null;
            Mtxb_CEP.Text = null;
            Txb_Endereco.Text = null;
            Txb_Numero.Text = null;
            Txb_Cidade.Text = null;
            Cbox_Estados.Text = null;
            Mtxb_CPF.Text = null;
            Mtxb_Telefone.Text = null;
            Txb_Complemento.Text = null;
        }
    }
}
