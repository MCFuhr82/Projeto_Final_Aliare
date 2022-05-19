using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare.Controllers
{
    public class AlunoController
    {
        NpgsqlConnection conn = new NpgsqlConnection(Conexao.Conexao.cn);

        //metodo inserir
        public string Inserir(string descricao)
        {
            string resp = "";
            conn.Open();
            try
            {
                //codigo para inserir
                //var formAluno = new Frm_Aluno();
                //var cmd = new NpgsqlCommand();

                //cmd.Connection = conn;
                //cmd.CommandType = System.Data.CommandType.Text;
                //cmd.CommandText = "INSERT INTO tb_aluno (nome_aluno, cpf, endereco, complemento, celular, email) VALUES (@nome, @cpf, @endereco, @complemento, @celular, @email)";
                //string nome = Frm_Aluno.
                //NpgsqlParameter param = new NpgsqlParameter();
                //param.ParameterName

                //SqlParameter parDescricao = new SqlParameter();
                //parDescricao.ParameterName = "@descricao";
                //parDescricao.SqlDbType = SqlDbType.VarChar;
                //parDescricao.Size = 50;
                //sqlCmd.Parameters.Add(parDescricao);

                ////executando a insercao
                //resp = sqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";
            }
            catch (Exception e)
            {
                resp = "Erro: " + e.Message;
            }
            finally
            {
                conn.Close();
            }

            return resp;

        }

    }
}
