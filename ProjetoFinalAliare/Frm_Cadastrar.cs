using System;
using System.Windows.Forms;
using ProjetoFinalAliare.Models;

namespace ProjetoFinalAliare
{
    public partial class Frm_Cadastrar : Form
    {
        public Frm_Cadastrar()
        {
            InitializeComponent();
        }
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            InserirAluno();
        }

        public void InserirAluno()
        {
            var nome = Txb_Nome.Text;
            var email = Txb_Email.Text;
            var cep = Mtxb_CEP.Text;
            var endereco = Txb_Endereco.Text;
            var numero = int.Parse(Txb_Numero.Text);
            var cidade = Txb_Cidade.Text;
            var estado = Txb_Estado.Text;
            var cpf = Mtxb_CPF.Text;
            var telefone = Mtxb_Telefone.Text;
            var complemento = Txb_Complemento.Text;

            using (var context = new Context()) 
            {
                var aluno = new Aluno(nome, cpf, endereco, numero, cidade, estado, cep, complemento, telefone, email);
                context.Aluno.Add(aluno);
                context.SaveChanges();
            }

            MessageBox.Show("Dados inseridos com sucesso!");
            
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
