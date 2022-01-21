using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Model
{
    public class Dadosuser
    {
         string Nome;
         string Pass;
        public Dadosuser(string Nome, string Pass)
        {
            this.Nome = Nome;
            this.Pass = Pass;
        }
     
        public string getNome() {
            return Nome;
        }
        public void  SetNome(string Nome) {
            this.Nome = Nome;
        }
        public string getPass()
        {
            return Pass;
        }
        public void SetPass(string Pass)
        {
            this.Nome = Pass;
        }
    }
}
