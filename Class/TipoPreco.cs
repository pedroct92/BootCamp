using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Class
{
    public class TipoPreco{
        private string tipoCliente;
        private string diaSemana;
        private float preco;

        public TipoPreco() { 
        
        }

        public TipoPreco(string tipoCliente, string diaSemana, float preco) {
            this.preco = preco;
            this.tipoCliente = tipoCliente;
            this.diaSemana = diaSemana;
        }

        public string TipoCliente{
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }

        public string DiaSemana{
            get { return diaSemana; }
            set { diaSemana = value; }
        }
        
        public float Preco{
            get { return preco; }
            set { preco = value; }
        }
    }
}
