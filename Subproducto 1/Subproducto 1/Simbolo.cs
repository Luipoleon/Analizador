using analizador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproducto_1
{
    internal class Simbolo
    {
        private string id, tipo, valor;
        public Simbolo(string id, string tipo, string valor)
        {
            this.id = id;
            this.tipo = tipo;
            this.valor = valor;
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; } 
        }

        public string Tipo 
        { 
            get { return tipo; }
        }

        public string ID
        {
            get { return id; }
        }

    }
}
