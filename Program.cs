using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootCamp.Class;

namespace BootCamp
{
    class Program
    {
        public Program() { 
        
        }

        static void Main(string[] args){

            Console.WriteLine("Informe a data da reserva no seguinte formato:\n"+
                              "customer_type: dd/mm/yyyy, dd/mm/yyyy, ..., dd/mm/yyyy");

            var cliente = makeInput(Console.ReadLine());
            var hoteis = makeHotel();

            string melhorHotel = MelhorHotel.buscaMelhorHotel(hoteis, cliente);

            Console.WriteLine("Melhor Hotel: " + melhorHotel);
            Console.ReadKey();
        }

        static Cliente makeInput(string inputReserva){
            int keyPipe = inputReserva.IndexOf(":");
            string typeCliente = inputReserva.Substring(0, keyPipe).ToUpper().Trim();
            inputReserva = inputReserva.Substring(keyPipe + 1, inputReserva.Length - keyPipe -1).Trim();
            string[] lstDataReserva = inputReserva.Split(',');

            List<Reserva> lstReserva = new List<Reserva>();
            foreach (var data in lstDataReserva){
                var reserva = new Reserva(Convert.ToDateTime(data));
                lstReserva.Add(reserva);
            }

            var cliente = new Cliente();
            cliente.Reserva = lstReserva;
            cliente.Tipo = typeCliente;

            return cliente;
        }

        static List<Hotel> makeHotel(){
            var lstTipoPreco = new List<TipoPreco>();
            var tPreco = new TipoPreco("REGULAR", "WEEK", 110);
            lstTipoPreco.Add(tPreco);
            tPreco = new TipoPreco("REWARDS", "WEEK", 80);
            lstTipoPreco.Add(tPreco);

            tPreco = new TipoPreco("REGULAR", "WEEKEND", 90);
            lstTipoPreco.Add(tPreco);
            tPreco = new TipoPreco("REWARDS", "WEEKEND", 80);
            lstTipoPreco.Add(tPreco);

            var blackout = new Blockout();
            blackout.Data = Convert.ToDateTime("01/02/2012");
            var blackouts = new List<Blockout>();
            blackouts.Add(blackout);

            var hotel = new Hotel("Lakewood", 3, lstTipoPreco);
            hotel.Blackouts = blackouts;
            
            var lstHotel = new List<Hotel>();
            lstHotel.Add(hotel);

            //-----------------------------------------------------
            lstTipoPreco = new List<TipoPreco>();
            tPreco = new TipoPreco("REGULAR", "WEEK", 160);
            lstTipoPreco.Add(tPreco);
            tPreco = new TipoPreco("REWARDS", "WEEK", 110);
            lstTipoPreco.Add(tPreco);

            tPreco = new TipoPreco("REGULAR", "WEEKEND", 60);
            lstTipoPreco.Add(tPreco);
            tPreco = new TipoPreco("REWARDS", "WEEKEND", 50);
            lstTipoPreco.Add(tPreco);

            hotel = new Hotel("Bridgewood", 4, lstTipoPreco);
            lstHotel.Add(hotel);

            //------------------------------------------------------
            lstTipoPreco = new List<TipoPreco>();
            tPreco = new TipoPreco("REGULAR", "WEEK", 220);
            lstTipoPreco.Add(tPreco);
            tPreco = new TipoPreco("REWARDS", "WEEK", 100);
            lstTipoPreco.Add(tPreco);

            tPreco = new TipoPreco("REGULAR", "WEEKEND", 150);
            lstTipoPreco.Add(tPreco);
            tPreco = new TipoPreco("REWARDS", "WEEKEND", 40);
            lstTipoPreco.Add(tPreco);

            hotel = new Hotel("Lakewood", 5, lstTipoPreco);
            lstHotel.Add(hotel);

            return lstHotel;
        }
    }
}
