using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Poli.com.gft.model
{
    class Carro : Veiculo
    {
     
        public override void Acelerar()

        {

            if (IsLigado && Velocidade <= 140 && LitrosCombustivel > 0)

            {

                Velocidade += 20;

                LitrosCombustivel -= 1;

                Console.WriteLine("Você está a " + Velocidade + "km/h");

                Console.WriteLine("Seu carro tem " + LitrosCombustivel + " litros de combustível");

            }

            else if (IsLigado == false)

                Console.WriteLine("Ligue o carro para acelerar");

            else if (LitrosCombustivel <= 0)

                Console.WriteLine("O carro não tem combustível, abasteça.");

            else

                Console.WriteLine("Você está acima do limite de velocidade, não é possível acelerar mais.");

        }




        public override void Abastecer(int qtdeLitros)

        {

            if (qtdeLitros <= 0)

                Console.WriteLine("Não é possível abastecer um valor inferior a 1 litro");

            else if (IsLigado)

                Console.WriteLine("Desligue o carro para abastecer");

            else if (Velocidade > 0)

                Console.WriteLine("O carro está em movimento, pare o carro para abastecer");

            else if ((LitrosCombustivel + qtdeLitros) > 100)

                Console.WriteLine("Não é possível abastecer, faltam " + (Velocidade + qtdeLitros - 100) + " para completar o tanque");

            else

            {

                LitrosCombustivel += qtdeLitros;

                Console.WriteLine("O tanque tem " + LitrosCombustivel + " litros.");

            }

        }


    }
}
