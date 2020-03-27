using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Iesj;
using Iesj.dtoBusiness;
using System.Data.SqlClient;
using Iesj.bllController;

namespace Iesj
{
    public partial class formMembroListarBase : Form
    {

        Membrosbll membrosbll = new Membrosbll();

        public formMembroListarBase()
        {
            InitializeComponent();
        }

        private void ButtonFiltrar_Click(object sender, EventArgs e)
        {
            //if (textBoxNomeListar.Text == "")
            //{
            //    MostrarMembrosGridViewGeral();
            //}
            //else
            //{
            //    Membros membrosModel = new Membros();
            //    MostrarMembrosGridView(membrosModel);
            //}

            if (textBoxNomeListar.Text == "")
            {
                MostrarMembrosGridViewGeral();
            }
            else
            {
                string nomePesquisa;
                nomePesquisa = textBoxNomeListar.Text.Trim();

                MostrarMembrosGridViewComParametro(nomePesquisa);
            }

        }
        public void MostrarMembrosGridViewGeral()
        {
          
            dataGridViewMostrarMembros.DataSource = membrosbll.SelecionarTodos();

        }

        public void MostrarMembrosGridViewComParametro(string pesquisa)
        {
            //membrosModel.Nome = textBoxNomeListar.Text.Trim();
            //dataGridViewMostrarMembros.DataSource = controller.ListarMembrosGridView(membrosModel);

            dataGridViewMostrarMembros.DataSource = membrosbll.SelecionarMembrosComParametro(pesquisa);

        }

        private void ButtonNovoCadastro_Click(object sender, EventArgs e)
        {
            formMembroCadastro cadmembro = new formMembroCadastro();
            cadmembro.ShowDialog();
        }

        private void DataGridViewMostrarMembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMostrarMembros.CurrentRow != null){
                EdiatarCadastroMembro();
            } 
        }

        private void ButtonEditarCadastro_Click(object sender, EventArgs e)
        {
            if(dataGridViewMostrarMembros.CurrentCell != null)
            {
                EdiatarCadastroMembro();
            }

        }

        public void EdiatarCadastroMembro()
        {
            Membrosdto membrosdto = new Membrosdto();

            //CarregarVariaveisDoDataGridView();


            int id = int.Parse(dataGridViewMostrarMembros.CurrentRow.Cells[0].Value.ToString());
            string nome = dataGridViewMostrarMembros.CurrentRow.Cells[1].Value.ToString();
            int idade = int.Parse(dataGridViewMostrarMembros.CurrentRow.Cells[2].Value.ToString());

            //int sexo = int.Parse(dataGridViewMostrarMembros.CurrentRow.Cells[3].Value.ToString());

            membrosdto.Id    = id;
            membrosdto.Nome  = nome;
            membrosdto.Idade = idade;

          //  membrosdto.Sexo = sexo;


            formMembroCadastro cadmembro = new formMembroCadastro(membrosdto);

            cadmembro.ShowDialog();
        }


        //public void CarregarVariaveisDoDataGridView()
        //{


        //    int id = int.Parse(dataGridViewMostrarMembros.CurrentRow.Cells[0].Value.ToString());
        //    string nome = dataGridViewMostrarMembros.CurrentRow.Cells[1].Value.ToString();
        //    int idade = int.Parse(dataGridViewMostrarMembros.CurrentRow.Cells[2].Value.ToString());

        //    string sexo = dataGridViewMostrarMembros.CurrentRow.Cells[3].Value.ToString();

        //}

    }
}
