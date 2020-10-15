using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Veiculo
    {
        //construtores
        public Veiculo()
        {
            this.Marca = "Fiat";
            this.Modelo = "Palio";
            this.Placa = "XXX - 1234";
            this.Cor = "Preto";
            this.KM = 0;
            this.isLigado = true;
            this.litrosCombustivel = 0;
            this.Velocidade = 0;
            this.Preco = 20.000;
        }

        //sobrecarga
        public Veiculo(String marca, String modelo, String placa, String cor, float km, bool isligado, int litroscombustivel, int velocidade, Double preco)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.KM = km;
            this.isLigado = isligado;
            this.litrosCombustivel = litroscombustivel;
            this.Velocidade = velocidade;
            this.Preco = preco;
        }

        //propriedades
        private String marca;
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private String modelo;
        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private String placa;
        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private String cor;
        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private float km;
        public float KM
        {
            get { return km; }
            set { km = value; }
        }

        private bool isligado;
        public bool isLigado
        {
            get { return isligado; }
            set { isligado = value; }
        }

        private int litroscombustivel;
        public int litrosCombustivel
        {
            get { return litroscombustivel; }
            set { litroscombustivel = value; }
        }

        private int velocidade;
        public int Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        //metodo
        public void Acelerar()
        {
            this.Velocidade = this.Velocidade + 20;
            Console.WriteLine("Adicionado 20 a velocidade");
            Console.WriteLine("Velocidade atual: " + this.Velocidade);
        }

        public void Abastecer()
        {
            int cont = 1;

            while (cont == 1)
            {
                Console.Write("Digite a quantidade de combustivel que será adicionada: ");
                int Combustivel = Convert.ToInt32(Console.ReadLine());
                if (Combustivel <= 60 && Combustivel >= 0)
                {
                    cont = 0;
                    litrosCombustivel = litrosCombustivel + Combustivel;
                   
                }
                else
                {
                    Console.WriteLine("Essa quantidade esse o maximo do tanque");
                    cont = 1;
                }
            }

            Console.WriteLine("O tanque esta com " + this.litrosCombustivel + " litros de combutivel");
        }

        public void Frear()
        {
            if (this.Velocidade > 0)
            {
                this.Velocidade = this.Velocidade - 20;

                if (this.Velocidade <= 0)
                {
                    Console.WriteLine("Veiculo foi parado.");
                }
                else
                {
                    Console.WriteLine("A velocidade agora está em: " + this.Velocidade);
                }
            }
            else
            {
                Console.WriteLine("Veiculo já está parado");
            }
        }

        public void Pintar()
        {
            Console.Write("Digite uma cor: ");
            this.Cor = Console.ReadLine();
        }

        public void Ligar()
        {
            if (this.isLigado == true)
            {
                Console.WriteLine("Veiculo já está ligado");
            }
            else
            {
                isLigado = true;
            }
        }

        public void Desligar()
        {
            if(this.isLigado == true)
            {
                if(this.Velocidade <= 0)
                {
                    this.isLigado = false;
                    Console.WriteLine("Veiculo desligado");
                }
                else
                {
                    Console.WriteLine("Perigo, veiculo ainda está com velocidade");
                }
            }
            else
            {
                Console.WriteLine("Veiculo já está desligado");
            }
        }

        public void Status()
        {
            Console.WriteLine("Marca: " + this.Marca + " | Modelo: " + this.Modelo + " | Placa: " + this.Placa);
            Console.WriteLine("Cor: " + this.Cor + " | Ligado: " + this.isLigado + " | Preco: " + this.Preco);
            Console.WriteLine("Velocidade: " + this.Velocidade + " | Combustivel: " + this.litrosCombustivel);
           
        }
    }
}
