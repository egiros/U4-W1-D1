using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D1
{
    public class Atleti
    {

        private string _nome;
        private int _eta;
        private string _sport;
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

        public int Età

        {
            get
            {
                return _età;
            }
            set
            {
                _età = value;
            }
        }

        public string Sport

        {
            get
            {
                return _sport;
            }
            set
            {
                _sport = value;
            }
        }
        public string Atleti(string nome, int età, string sport)
        {
            Nome = nome;
            Età = età;
            Sport = sport;
        }
    }
}