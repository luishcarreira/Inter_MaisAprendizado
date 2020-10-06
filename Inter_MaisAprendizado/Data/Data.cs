using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Inter_MaisAprendizado.Data
{
    public class Data : IDisposable
    {
        //Atributo: vai nos permitir conectar com Banco de Dados
        protected SqlConnection connectionDB;

        public Data()
        {
            try
            {
                //string de conexão com o banco de dados
                string strConexao = @"Data Source=DESKTOP-I1FBU43\SQLEXPRESS;Initial Catalog=;Integrated Security=true";

                connectionDB = new SqlConnection(strConexao);
                connectionDB.Open();
            }
            catch (SqlException er)
            {
                Console.WriteLine("Erro de banco " + er);
            }
        }

        public void Dispose()
        {
            connectionDB.Close();
        }
    }
}
