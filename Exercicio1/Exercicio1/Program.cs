using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo();

            int inicio = 0;

            while(inicio != 7)
            {
                v.Status();

                Console.WriteLine(" 1 - Acelerar");
                Console.WriteLine(" 2 - Abastecer");
                Console.WriteLine(" 3 - Frear");
                Console.WriteLine(" 4 - Pintar");
                Console.WriteLine(" 5 - Ligar");
                Console.WriteLine(" 6 - Desligar");
                Console.WriteLine(" 7 - Sair");

                Console.WriteLine(" ");
                Console.Write("Digite o numero do que deseja: ");
                inicio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");

                if (inicio == 1)
                {
                    v.Acelerar();
                    Console.ReadKey();
                }
                else
                {
                    if(inicio == 2)
                    {
                        v.Abastecer();
                        Console.ReadKey();
                    }
                    else
                    {
                        if(inicio == 3)
                        {
                            v.Frear();
                            Console.ReadKey();
                        }
                        else
                        {
                            if(inicio == 4)
                            {
                                v.Pintar();
                                Console.ReadKey();
                            }
                            else
                            {
                                if(inicio == 5)
                                {
                                    v.Ligar();
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if(inicio == 6)
                                    {
                                        v.Desligar();
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saindo");
                                    }
                                }
                            }
                        }
                    }
                }
                

                Console.Clear();
            }

        }
    }
}
