using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare.Models
{
    [Table("Aluno", Schema = "public")]
    public class Aluno
    {
        [Key]
        public int Matricula { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public string CPF { get; private set; }
        [Required]
        public string Celular { get; private set; }
        [Required]
        public string Email { get; private set; }
        [Required]
        public string CEP { get; private set; }
        [Required]
        public string Endereco { get; private set; }
        [Required]
        public int Numero { get; private set; }
        public string Complemento { get; private set; }
        [Required]
        public string Cidade { get; private set; }
        [Required]
        public string Estado { get; private set; }

        public Aluno() { }

        public Aluno(string nome, string cpf, string endereco, int numero, string cidade, string estado, string cep, string complemento, string celular, string email)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
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

        public void SetNumero(int numero)
        {
            Numero = numero;
        }

        public void SetCidade(string cidade)
        {
            Cidade = cidade;
        }

        public void SetEstado(string estado)
        {
            Estado = estado;
        }
    }
}
