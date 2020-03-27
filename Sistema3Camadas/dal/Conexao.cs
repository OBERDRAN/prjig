using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Iesj.dtoBusiness;


namespace Iesj.dal
{
    class Conexao
    {
        Membrosdto membrosdto = new Membrosdto();

        public SqlConnection conn;
        private DataTable dataTable;
        private SqlDataAdapter daAdapter;
        private SqlDataReader drDataReader;
        private SqlCommandBuilder cbBuilder;

     
        private String server = "NomeDoServiodorDeBancoDeDados";
        private String user = "NomeDoUsuarioDoBancoDeDados";
        private String password = "SenhaDeAcessoAoBancoDeDados";
        private String database = "NomeDoBancoDeDados";



        //public SqlConnection AbrirConexao()
        //{
        //    if (objconexao.State == System.Data.ConnectionState.Closed)
        //    {
        //        objconexao.Open();
        //    }

        //    return objconexao;
        //}

        public void Conectar()
        {
            if (conn != null)
            {
                conn.Close();
            }

            //  string connString = String.Format("server = {0},user id = {1}, password = {2}, database = {3},pooling = false",server,user,password, database);

            string connString = "Password = SenhaDeAcessoAoBancoDeDados; Persist Security Info = True; User ID = NomeDoUsuarioDoBancoDeDados; Initial Catalog=NomeDoBancoDeDados;Data Source=NomeDoServiodorDeBancoDeDados";

            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void ExecutarComando(string comandoSql)
        {
            SqlCommand comando = new SqlCommand(comandoSql, conn);

            //comando.Parameters.AddWithValue("@nome", membrosdto.Nome);
            ////comando.Parameters.AddWithValue("@idade", membros.Idade);


            //cmd.CommandText = sql;

            //cmd.Parameters.AddWithValue("@nome", membros.Nome);
            //cmd.Parameters.AddWithValue("@idade", membros.Idade);


            comando.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetDataTable(string Sql)
        {
            dataTable = new DataTable();


            daAdapter = new SqlDataAdapter(Sql, conn);

            cbBuilder = new SqlCommandBuilder(daAdapter);

            daAdapter.Fill(dataTable);

            return dataTable;
        }

        public SqlDataReader RetDataReader(string Sql)
        {
            SqlCommand comando = new SqlCommand(Sql,conn);

            SqlDataReader drDataReader = comando.ExecuteReader();

            drDataReader.Read();

            return drDataReader;
        }

    }
}
