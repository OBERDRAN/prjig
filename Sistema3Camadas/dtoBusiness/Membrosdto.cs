using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iesj.dtoBusiness
{
    public class Membrosdto
    {
        private int id;

        private string nome;

        private int idade;

        private int sexo = 0;
       

        public int Id { get {return id; } set { id = value; } }
        public string Nome { get {return nome; } set { nome = value; } }
        public int Idade { get {return idade; } set { idade = value; } }
        public int Sexo { get {return sexo; } set { sexo = value; } }

    }
}
