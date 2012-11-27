using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Class
{
    public class Hotel{
        private string nome;
        private int estrelas;
        private List<TipoPreco> precos;
        private List<Blockout> blackouts;

        public Hotel() { 
        
        }

        public Hotel(string nome, int estrelas, List<TipoPreco> precos){
            this.nome = nome;
            this.estrelas = estrelas;
            this.precos = precos;
        }
        public string Nome{
            get { return nome; }
            set { nome = value; }
        }

        public int Estrelas {
            get { return estrelas; }
            set { estrelas = value; }
        }

        public List<TipoPreco> Precos{
            get { return precos; }
            set { precos = value; }
        }

        public List<Blockout> Blackouts{
            get { return blackouts; }
            set { blackouts = value; }
        }

        public float calularDiaria(Cliente cliente)
        {
            float valor = 0;
            
            foreach (var reserva in cliente.Reserva){
                bool weekEnd = (reserva.Data.DayOfWeek == DayOfWeek.Saturday || reserva.Data.DayOfWeek == DayOfWeek.Sunday) ? true : false;

                var blackout = new Blockout();
                blackout.Data = reserva.Data;
                var hasBlouckout = blackouts.Contains(blackout);

                var precoFiltrado = precos.Where(x => x.DiaSemana == (weekEnd ? "WEEKEND" :"WEEK"));
                var precoReserva = precoFiltrado.First(x => x.TipoCliente == (hasBlouckout ? "REGULAR" : cliente.Tipo)).Preco;
                valor += precoReserva;
            }

            return valor;
        }
    }
}
