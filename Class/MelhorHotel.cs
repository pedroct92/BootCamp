using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Class
{
    public class MelhorHotel{

        public static string buscaMelhorHotel(List<Hotel> lstHotel, Cliente cliente) {
            int melhor = 0;
            int totalIgual = 0;

            for (int i = 0; i < lstHotel.Count; i++){
                if (i == 0)
                    melhor = i;
                else{

                    if (lstHotel[i].calularDiaria(cliente) < lstHotel[melhor].calularDiaria(cliente))
                    {
                        melhor = i;
                    }
                    else if (lstHotel[i].calularDiaria(cliente) == lstHotel[melhor].calularDiaria(cliente))
                    {
                        totalIgual++;
                    }
                }
            }

            if (totalIgual ==  lstHotel.Count) {

                for (int i = 0; i < lstHotel.Count; i++) {
                    if (lstHotel[i].Estrelas > lstHotel[melhor].Estrelas)
                        melhor = i;
                }
            }

            return lstHotel[melhor].Nome;       
        }
    }
}
