using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D1
{
    public class Dipendenti
    {

        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string kmTagliando(int attuale)
        {
            if (attuale > 10000) { return "tagliando da effettuare"; }
            else { return "torna tra qualche km :)"; }
        }
    }
}
