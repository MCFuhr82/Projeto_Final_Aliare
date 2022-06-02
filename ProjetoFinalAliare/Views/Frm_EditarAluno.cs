using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalAliare
{
    public partial class Frm_EditarAluno : Form
    {
        public Frm_EditarAluno()
        {
            InitializeComponent();
        }

        public Frm_EditarAluno(String matricula)
        {
            InitializeComponent();
            Txb_Matricula.Text = matricula;
            PopularTextBoxes(int.Parse(matricula));
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            var aluno = ModificarAluno(int.Parse(Txb_Matricula.Text));

            if (aluno != null)
            {
                AlunoController.UpdateAluno(aluno);
                MessageBox.Show("Dados inseridos com sucesso!");
                this.Close();
            }
        }
        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Modificar dados do aluno
        private Aluno ModificarAluno(int matricula)
        {
            try
            {
                var aluno = AlunoController.SelectAlunoPorId(matricula);
                
                var nome = Txb_Nome.Text;
                var email = Txb_Email.Text;
                var cep = Mtxb_CEP.Text;
                var endereco = Txb_Endereco.Text;
                var numero = int.Parse(Txb_Numero.Text);
                var cidade = Txb_Cidade.Text;
                var estado = Cbox_Estados.Text;
                var telefone = Mtxb_Telefone.Text;
                var complemento = Txb_Complemento.Text;

                var camposObrigatoriosOK = VerificaCamposObrigatorios();

                if (camposObrigatoriosOK == true)
                {
                    aluno.SetNome(nome);
                    aluno.SetEmail(email);
                    aluno.SetCep(cep);
                    aluno.SetEndereco(endereco);
                    aluno.SetNumero(numero);
                    aluno.SetCidade(cidade);
                    aluno.SetEstado(estado);
                    aluno.SetCelular(telefone);
                    aluno.SetComplemento(complemento);

                    return aluno;
                }
                return null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique o campo numero.");
                return null;
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("Verificar todos os campos.");
                return null;
            }
        }

        private void Mtxb_CEP_Leave(object sender, EventArgs e)
        {
            var cepInvalido = LocalizarCEP.LocalizaCEP(Mtxb_CEP.Text);
            if (cepInvalido == false)
            {
                MessageBox.Show("Campo CEP deve ser preenchido com um CEP válido.");
                Mtxb_CEP.Text = null;
            }
            var endereco = LocalizarCEP.rua;
            Txb_Endereco.Text = endereco;
            var cidade = LocalizarCEP.cidade;
            Txb_Cidade.Text = cidade;
            var uf = LocalizarCEP.estado;
            Cbox_Estados.Text = uf;
        }

        private void PopularTextBoxes(int matricula)
        {
            using (var context = new Context())
            {
                var aluno = context.Aluno.Where(x => x.Matricula == matricula).FirstOrDefault();

                var nome = aluno.Nome;
                var email = aluno.Email;
                var cpf = aluno.CPF;
                var cep = aluno.CEP;
                var endereco = aluno.Endereco;
                var numero = aluno.Numero;
                var cidade = aluno.Cidade;
                var estado = aluno.Estado;
                var celular = aluno.Celular;
                var complemento = aluno.Complemento;

                Txb_Nome.Text = nome;
                Txb_Email.Text = email;
                Mtxb_CPF.Text = cpf;
                Mtxb_CEP.Text = cep;
                Txb_Endereco.Text = endereco;
                Txb_Numero.Text = numero.ToString();
                Txb_Cidade.Text = cidade;
                Cbox_Estados.Text = estado;
                Mtxb_Telefone.Text = celular;
                Txb_Complemento.Text = complemento;
            }
        }


        private bool VerificaCamposObrigatorios()
        {
            try
            {
                if (string.IsNullOrEmpty(Txb_Nome.Text))
                {
                    MessageBox.Show("Campo nome deve ser preenchido");
                    return false;
                }
                else if (string.IsNullOrEmpty(Txb_Email.Text))
                {
                    MessageBox.Show("Campo email deve ser preenchido");
                    return false;
                }
                else if (string.IsNullOrEmpty(Txb_Endereco.Text))
                {
                    MessageBox.Show("Campo endereco deve ser preenchido");
                    return false;
                }
                else if (string.IsNullOrEmpty(Txb_Cidade.Text))
                {
                    MessageBox.Show("Campo cidade deve ser preenchido");
                    return false;
                }
                else if (!Mtxb_CEP.MaskCompleted)
                {
                    MessageBox.Show("Campo CEP deve ser preenchido com um CEP válido");
                    return false;
                }
                else if (!Mtxb_Telefone.MaskCompleted)
                {
                    MessageBox.Show("Campo telefone deve ser preenchido");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (DbEntityValidationException)
            {
                throw;
            }
        }
    }

}
