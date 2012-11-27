using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Class
{
    public class Cliente{
        private string tipo;
        private List<Reserva> reserva;

        public List<Reserva> Reserva{
            get { return reserva; }
            set { reserva = value; }
        }

        public string Tipo{
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
