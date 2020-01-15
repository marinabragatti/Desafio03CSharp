using System;
using Heranca_Poli.com.gft.model;

namespace Heranca_Poli
{
    class Program
    {
        static void Main(string[] args)
        { 

            Aviao av = new Aviao();

            Carro cr = new Carro();

            Caminhao cam = new Caminhao();

            av.Ligar();

            cr.Ligar();

            cam.Ligar();

            av.Desligar();

            av.Abastecer("10");        

        }

    }
}
