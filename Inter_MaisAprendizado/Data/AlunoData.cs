using Inter_MaisAprendizado.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Inter_MaisAprendizado.Data
{
    public class AlunoData : Data
    {
        public void Create(Aluno aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB;
            cmd.CommandText = "AdicionarAluno";
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter ParNome = new SqlParameter();
            ParNome.ParameterName = "@Nome";
            ParNome.SqlDbType = SqlDbType.VarChar;
            ParNome.Size = 50;
            ParNome.Value = aluno.Nome;
            cmd.Parameters.Add(ParNome);

            SqlParameter ParEmail = new SqlParameter();
            ParEmail.ParameterName = "@Email";
            ParEmail.SqlDbType = SqlDbType.VarChar;
            ParEmail.Size = 30;
            ParEmail.Value = aluno.Email;
            cmd.Parameters.Add(ParEmail);

            SqlParameter ParDataNasc = new SqlParameter();
            ParDataNasc.ParameterName = "@DataNasc";
            ParDataNasc.SqlDbType = SqlDbType.Date;
            ParDataNasc.Value = aluno.DataNasc;
            cmd.Parameters.Add(ParDataNasc);

            SqlParameter ParTelefone = new SqlParameter();
            ParTelefone.ParameterName = "@Telefone";
            ParTelefone.SqlDbType = SqlDbType.VarChar;
            ParTelefone.Size = 15;
            ParTelefone.Value = aluno.Telefone;
            cmd.Parameters.Add(ParTelefone);

            // Execução da string 
            cmd.ExecuteNonQuery();
        }

        public void Update(Aluno aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB;
            cmd.CommandText = "AlterarAluno";
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter ParPessoaId = new SqlParameter();
            ParPessoaId.ParameterName = "@PessoaId";
            ParPessoaId.SqlDbType = SqlDbType.Int;
            ParPessoaId.Value = aluno.IdPessoa;
            cmd.Parameters.Add(ParPessoaId);

            SqlParameter ParNome = new SqlParameter();
            ParNome.ParameterName = "@Nome";
            ParNome.SqlDbType = SqlDbType.VarChar;
            ParNome.Size = 50;
            ParNome.Value = aluno.Nome;
            cmd.Parameters.Add(ParNome);

            SqlParameter ParEmail = new SqlParameter();
            ParEmail.ParameterName = "@Email";
            ParEmail.SqlDbType = SqlDbType.VarChar;
            ParEmail.Size = 30;
            ParEmail.Value = aluno.Email;
            cmd.Parameters.Add(ParEmail);

            SqlParameter ParDataNasc = new SqlParameter();
            ParDataNasc.ParameterName = "@DataNasc";
            ParDataNasc.SqlDbType = SqlDbType.Date;
            ParDataNasc.Value = aluno.DataNasc;
            cmd.Parameters.Add(ParDataNasc);

            SqlParameter ParTelefone = new SqlParameter();
            ParTelefone.ParameterName = "@Telefone";
            ParTelefone.SqlDbType = SqlDbType.VarChar;
            ParTelefone.Size = 15;
            ParTelefone.Value = aluno.Telefone;
            cmd.Parameters.Add(ParTelefone);

            // Execução da string 
            cmd.ExecuteNonQuery();
        }
    }
}
