using System;
using System.Windows.Forms;
using ProjetoFinalAliare.Models;
using Correios.Net;
using System.Data.Entity.Validation;

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
            CriarAluno();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            var form = new Frm_ConsultarAluno();
            form.ShowDialog();
        }

        private void CriarAluno()
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
                var telefone = Mtxb_Telefone.Text;
                var complemento = Txb_Complemento.Text;
                var cpf = Mtxb_CPF.Text;

                var cpfValido = ValidacaoCPF.ValidaCPF(cpf);

                VerificaCamposObrigatorios();

                if (!Mtxb_Telefone.MaskCompleted)
                    MessageBox.Show("Verificar telefone!");
                if (!Mtxb_CEP.MaskCompleted)
                {
                    MessageBox.Show("Informe um CEP válido!");
                }
                else (cpfValido == true)
                {
                    var aluno = new Aluno(nome, cpf, endereco, numero, cidade, estado, cep, complemento, telefone, email);

                    AlunoController.InserirAluno(aluno);
                    MessageBox.Show("Dados inseridos com sucesso!");
                    LimparTextBoxes();
                    Lbl_CpfInválido.Text = null;
                } 
                
            }
            catch (DbEntityValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //método para aceitar apenas números
        private void Txb_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
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

        private void Mtxb_CEP_Leave(object sender, EventArgs e)
        {
            var cepInvalido = LocalizarCEP.LocalizaCEP(Mtxb_CEP.Text);
            if (cepInvalido == false)
            {
                MessageBox.Show("Informe um CEP válido!");
            }
            var endereco = LocalizarCEP.rua;
            Txb_Endereco.Text = endereco;
            var cidade = LocalizarCEP.cidade;
            Txb_Cidade.Text = cidade;
            var uf = LocalizarCEP.estado;
            Cbox_Estados.Text = uf;
        }

        private void Mtxb_CPF_Leave(object sender, EventArgs e)
        {
            var cpf = Mtxb_CPF.Text;
            var cpfValido = ValidacaoCPF.ValidaCPF(cpf);
            if (cpfValido == false)
                Lbl_CpfInválido.Text = "CPF Inválido";
            else
                Lbl_CpfInválido.Text = "";
        }

        private void VerificaCamposObrigatorios()
        {
            try
            {
                if (string.IsNullOrEmpty(Txb_Nome.Text))
                    MessageBox.Show("Campo nome deve ser preenchido");
                if (string.IsNullOrEmpty(Txb_Email.Text))
                    MessageBox.Show("Campo email deve ser preenchido");
                if (string.IsNullOrEmpty(Txb_Endereco.Text))
                    MessageBox.Show("Campo endereco deve ser preenchido");
                if (string.IsNullOrEmpty(Txb_Cidade.Text))
                    MessageBox.Show("Campo cidade deve ser preenchido");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Verificar campo numero!");
                Console.WriteLine(ex.Message);
            }
            catch (DbEntityValidationException)
            {
                throw;
            }
        }
    }
}
