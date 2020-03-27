using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iesj.bllController;
using Iesj.dtoBusiness;
using Iesj.dal;
using System.Data;

namespace Iesj.bllController
{
    public class Membrosbll
    {
        private string mensagem = string.Empty;
        public string Mensagem { get {return mensagem; } set { mensagem = value; } }

        Conexao bddal = new Conexao();
        public DataTable SelecionarTodos()
        {
            string sql = string.Empty;
            
            sql = "SELECT Id, Nome, Idade, CASE WHEN Sexo = 0 THEN 'Feminino' ELSE 'Sexo' END AS Sexo FROM CadMembro";

            DataTable dtMostrartodos = new DataTable();
           

            bddal = new Conexao();
            bddal.Conectar();

            dtMostrartodos = bddal.GetDataTable(sql);

            return dtMostrartodos;
        }
        public DataTable SelecionarMembrosComParametro(string pesquisa)
        {

            string sql = string.Empty;

            Membrosdto membrosdto = new Membrosdto();

            @pesquisa = membrosdto.Nome;

            sql = "select * from cadmembro where nome like '%' + @pesquisa + '%'";
            DataTable dtMostrartodos = new DataTable();
     

            bddal = new Conexao();
            bddal.Conectar();

            //dtMostrartodos = bddal.GetDataTable(sql,pesquisa);

            return dtMostrartodos;
        }

        public void Inserir(Membrosdto membrosdto)
        {

            bddal.Conectar();
            string comandoSql = "INSERT INTO CadMembro (nome,idade) VALUES ('" + membrosdto.Nome + "','"+membrosdto.Idade+"')";

            bddal.ExecutarComando(comandoSql);

            mensagem = "Dados Salvos com sucesso";
        }
        public void AtualizarMembro(Membrosdto membrosdto)
        {
       
            bddal.Conectar();
            string comandoSql = "UPDATE CadMembro SET Nome = '" + membrosdto.Nome + "', Idade = '"+membrosdto.Idade+"' WHERE ID = " + membrosdto.Id;

            //cmd.CommandText = comandoSql;

            //cmd.Parameters.AddWithValue("@nome", membros.Nome);
            //cmd.Parameters.AddWithValue("@idade", membros.Idade);

            bddal.ExecutarComando(comandoSql);

            mensagem = "Atualizado Com Sucesso";
            //try
        }
    }
}
