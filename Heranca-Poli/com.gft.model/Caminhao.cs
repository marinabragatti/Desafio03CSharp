using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Poli.com.gft.model
{
    class Caminhao : Veiculo
    {
       

        public override void Acelerar()

        {

            if (IsLigado && Velocidade <= 80 && LitrosCombustivel > 0)

            {

                Velocidade += 20;

                LitrosCombustivel -= 10;

                Console.WriteLine("Você está a " + Velocidade + "km/h");

                Console.WriteLine("Seu caminhão tem " + LitrosCombustivel + " litros de combustível");

            }

            else if (IsLigado == false)

                Console.WriteLine("Ligue o caminhão para acelerar");

            else if (LitrosCombustivel <= 0)

                Console.WriteLine("O caminhão não tem combustível, abasteça.");

            else

                Console.WriteLine("Você está acima do limite de velocidade, não é possível acelerar mais.");

        }



   
        public void Abastecer(float qtdeLitros)

        {
            int qtdeLitros1 = Convert.ToInt32(qtdeLitros);

            if (qtdeLitros1 <= 0)

                Console.WriteLine("Não é possível abastecer um valor inferior a 1 litro");

            else if (IsLigado)

                Console.WriteLine("Desligue o caminhão para abastecer");

            else if (Velocidade > 0)

                Console.WriteLine("O caminhão está em movimento, pare para abastecer");

            else if ((LitrosCombustivel + qtdeLitros1) > 150)

                Console.WriteLine("Não é possível abastecer, faltam " + (Velocidade + qtdeLitros1 - 150) + " para completar o tanque");

            else

            {

                LitrosCombustivel += qtdeLitros1;

                Console.WriteLine("O tanque tem " + LitrosCombustivel + " litros.");

            }

        }



    }
}
