using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iesj
{
    public partial class formMembroPrincipalBase : Form
    {
        public formMembroPrincipalBase()
        {
            InitializeComponent();
        }

        private void MembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMembroListar membro = new formMembroListar();
            membro.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
