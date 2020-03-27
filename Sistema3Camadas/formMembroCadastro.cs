using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Iesj.bllController;
using Iesj.dtoBusiness;

namespace Iesj
{
    public partial class formMembroCadastro : formMembroPrincipalBase
    {
        Membrosbll Controllermembrosbll = new Membrosbll();
        Membrosdto membrosdto = new Membrosdto();

        protected string mensagem = string.Empty;

        public formMembroCadastro()
        {
            InitializeComponent();
            textBoxIdMembro.Enabled = false;
        }

        public formMembroCadastro(Membrosdto membrosdto)
        {
            InitializeComponent();


            textBoxIdMembro.Text = Convert.ToString(membrosdto.Id);

            textBoxNome.Text = Convert.ToString(membrosdto.Nome);

            textBoxIdade.Text = Convert.ToString(membrosdto.Idade);    

        }


        private void ButtonSalvarMembro_Click(object sender, EventArgs e)
        {

            if (textBoxIdMembro.Text == "" || textBoxIdMembro == null)
            {
                PopulateObjectToSave();

                Controllermembrosbll.Inserir(membrosdto);

                mensagem = Controllermembrosbll.Mensagem;
                MessageBox.Show(mensagem);

                LimparDados();
            }
            else
            {
                PopulateObjectToUpdate();

                Controllermembrosbll.AtualizarMembro(membrosdto);

                mensagem = Controllermembrosbll.Mensagem;
                MessageBox.Show(mensagem);

                LimparDados();
            }

        }

        private void ButtonLimparDadosFormCadastro_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        public void LimparDados()
        {
            textBoxIdMembro.Clear();
            textBoxNome.Clear();
            textBoxIdade.Clear();
            comboBoxSexo.SelectedIndex = -1;
        }
        public void PopulateObjectToSave()
        {
            membrosdto.Nome = textBoxNome.Text;
            membrosdto.Idade = Convert.ToInt32(textBoxIdade.Text);
        }
        public void PopulateObjectToUpdate()
        {
            membrosdto.Id = int.Parse(textBoxIdMembro.Text);

            membrosdto.Nome  = textBoxNome.Text;
            membrosdto.Idade = Convert.ToInt32(textBoxIdade.Text);
        }

    }
}
