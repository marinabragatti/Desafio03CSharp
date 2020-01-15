using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Poli.com.gft.model
{
    class Aviao : Veiculo
    {

        public override void Acelerar()

        {

            if (IsLigado && Velocidade <= 300 && LitrosCombustivel > 0)

            {

                Velocidade += 20;

                LitrosCombustivel -= 30;

                Console.WriteLine("Você está a " + Velocidade + "km/h");

                Console.WriteLine("Seu avião tem " + LitrosCombustivel + " litros de combustível");

            }

            else if (IsLigado == false)

                Console.WriteLine("Ligue o avião para acelerar");

            else if (LitrosCombustivel <= 0)

                Console.WriteLine("O avião não tem combustível, abasteça.");

            else

                Console.WriteLine("Você está acima do limite de velocidade, não é possível acelerar mais.");

        }



        public void Abastecer(String qtdeLitros)

        {
            int qtdeLitros1;

            qtdeLitros1 = int.Parse(qtdeLitros);
            
            if (qtdeLitros1 <= 0)

                Console.WriteLine("Não é possível abastecer um valor inferior a 1 litro");

            else if (IsLigado)

                Console.WriteLine("Desligue o avião para abastecer");

            else if (Velocidade > 0)

                Console.WriteLine("O avião está em movimento, pare para abastecer");

            else if ((LitrosCombustivel + qtdeLitros1) > 200)

                Console.WriteLine("Não é possível abastecer, faltam " + (Velocidade + qtdeLitros1 - 200) + " para completar o tanque");

            else

            {

                LitrosCombustivel += qtdeLitros1;

                Console.WriteLine("O tanque tem " + LitrosCombustivel + " litros.");

            }

        }



    }
}
