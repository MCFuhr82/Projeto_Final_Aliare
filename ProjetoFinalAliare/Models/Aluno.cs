using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare.Models
{
    public class Aluno
    {
        public int Matricula { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Endereco { get; private set; }
        public string CEP { get; private set; }
        public string Complemento { get; private set; }
        public string Celular { get; private set; }
        public string Email { get; private set; }

        public Aluno() { }

        public Aluno(string nome, string cpf, string endereco, string cep, string complemento, string celular, string email)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
            CEP = cep;
            Complemento = complemento;
            Celular = celular;
            Email = email;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public void SetCep(string cep)
        {
            CEP = cep;
        }

        public void SetComplemento(string complemento)
        {
            Complemento = complemento;
        }

        public void SetCelular(string celular)
        {
            Celular = celular;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}
