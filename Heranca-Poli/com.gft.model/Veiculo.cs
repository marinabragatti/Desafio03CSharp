using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Poli.com.gft.model
{
    public abstract class Veiculo
    {
        private String marca;

        private String modelo;

        private String placa;

        private String cor;

        private float km;

        private bool isLigado;

        private int litrosCombustivel;

        private int velocidade;

        private double preco;

        //Getters and Setters
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Cor { get => cor; set => cor = value; }
        public float Km { get => km; set => km = value; }
        public bool IsLigado { get => isLigado; set => isLigado = value; }
        public int LitrosCombustivel { get => litrosCombustivel; set => litrosCombustivel = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public double Preco { get => preco; set => preco = value; }

        protected Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cor = cor;
            this.km = km;
            this.isLigado = isLigado;
            this.litrosCombustivel = litrosCombustivel;
            this.velocidade = velocidade;
            this.preco = preco;
        }

        protected Veiculo()
        {

        }



        //Métodos

        public virtual void Ligar() 
        {
            if (IsLigado)

                Console.WriteLine("O veículo já está ligado");

            else

            {

                IsLigado = true;

                Console.WriteLine("Você ligou o veículo.");

            }
        }

        public virtual void Desligar()
        {
            {

                if (IsLigado)

                {

                    IsLigado = false;

                    Console.WriteLine("Você desligou o avião");

                }

                else

                    Console.WriteLine("O avião já está desligado.");

            }
        }

        public virtual void Acelerar()
        {

        }

        public virtual void Frear()
        {
            {

                if (IsLigado && Velocidade > 0)

                {

                    Velocidade -= 10;

                    Console.WriteLine("Seu veículo agora está a " + Velocidade + "km/h");

                }

                else if (IsLigado == false)

                    Console.WriteLine("Seu veículo está desligado.");

                else

                    Console.WriteLine("Seu veículo está parado.");

            }
        }

        public virtual void Abastecer(int qtdeLitros)
        {

        }

        public virtual void Pintar(String cor)
        {
            Cor = cor;

            Console.WriteLine("Seu veículo agora é " + Cor);
 
        }

    }
}
