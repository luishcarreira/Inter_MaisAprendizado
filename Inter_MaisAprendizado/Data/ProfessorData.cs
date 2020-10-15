using Inter_MaisAprendizado.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Inter_MaisAprendizado.Data
{
    public class ProfessorData : Data
    {
        public void Create(Professor professor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB;
            cmd.CommandText = "AdicionarProfessor";
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter ParNome = new SqlParameter();
            ParNome.ParameterName = "@Nome";
            ParNome.SqlDbType = SqlDbType.VarChar;
            ParNome.Size = 50;
            ParNome.Value = professor.Nome;
            cmd.Parameters.Add(ParNome);

            SqlParameter ParEmail = new SqlParameter();
            ParEmail.ParameterName = "@Email";
            ParEmail.SqlDbType = SqlDbType.VarChar;
            ParEmail.Size = 30;
            ParEmail.Value = professor.Email;
            cmd.Parameters.Add(ParEmail);

            SqlParameter ParDataNasc = new SqlParameter();
            ParDataNasc.ParameterName = "@DataNasc";
            ParDataNasc.SqlDbType = SqlDbType.Date;
            ParDataNasc.Value = professor.DataNasc;
            cmd.Parameters.Add(ParDataNasc);

            SqlParameter ParCredito = new SqlParameter();
            ParCredito.ParameterName = "@Credito";
            ParCredito.SqlDbType = SqlDbType.Decimal;
            ParCredito.Value = professor.Credito;
            cmd.Parameters.Add(ParCredito);

            // Execução da string 
            cmd.ExecuteNonQuery();
        }

        public void Update(Professor professor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB;
            cmd.CommandText = "AlterarProfessor";
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter ParPessoaId = new SqlParameter();
            ParPessoaId.ParameterName = "@PessoaId";
            ParPessoaId.SqlDbType = SqlDbType.Int;
            ParPessoaId.Value = professor.IdPessoa;
            cmd.Parameters.Add(ParPessoaId);

            SqlParameter ParNome = new SqlParameter();
            ParNome.ParameterName = "@Nome";
            ParNome.SqlDbType = SqlDbType.VarChar;
            ParNome.Size = 50;
            ParNome.Value = professor.Nome;
            cmd.Parameters.Add(ParNome);

            SqlParameter ParEmail = new SqlParameter();
            ParEmail.ParameterName = "@Email";
            ParEmail.SqlDbType = SqlDbType.VarChar;
            ParEmail.Size = 30;
            ParEmail.Value = professor.Email;
            cmd.Parameters.Add(ParEmail);

            SqlParameter ParDataNasc = new SqlParameter();
            ParDataNasc.ParameterName = "@DataNasc";
            ParDataNasc.SqlDbType = SqlDbType.Date;
            ParDataNasc.Value = professor.DataNasc;
            cmd.Parameters.Add(ParDataNasc);

            SqlParameter ParCredito = new SqlParameter();
            ParCredito.ParameterName = "@Credito";
            ParCredito.SqlDbType = SqlDbType.Decimal;
            ParCredito.Value = professor.Credito;
            cmd.Parameters.Add(ParCredito);

            // Execução da string 
            cmd.ExecuteNonQuery();
        }
    }
}
