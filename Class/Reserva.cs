using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Class
{
    public class Reserva{
        private DateTime data;

        public Reserva(DateTime data){
            this.data = data;
        }

        public DateTime Data{
            get { return data; }
            set { data = value; }
        }

    }
}
