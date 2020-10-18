using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //adicionando coisas ao mago e a lista dele
            Mago m1 = new Mago("Kemylly", 100, 80, 250, 100, 300, 5);
            // List<Mago> Magos = new List<Mago>();
            // Magos.Add(m1);

            //adicionando coisas a guerreiro
            Guerreiro g1 = new Guerreiro("Vinycius", 100, 70, 260, 90, 350, 5);
            // List<Guerreiro> Guerreiros = new List<Guerreiro>();
            // Guerreiros.Add(g1);

            Personagem m = new Mago();
            Personagem g = new Guerreiro();

            //Mago Magia = new Mago("Agua");

            Mago mago = new Mago();
            Guerreiro guerreiro = new Guerreiro();

            int perso = 0;
            int resp = 0;
            while(resp != 5)
            {
                resp = Inicio();
                if (resp == 1)
                {
                    //int escolha = 0;

                    Console.WriteLine("1 - Mago");
                    Console.WriteLine("2 - Guerreiro");
                    int escolha = Convert.ToInt32(Console.ReadLine());

                    if(escolha == 1)
                    {
                        Console.WriteLine(" NOME   |  VIDA | MANA | INTELIGENCIA | FORCA | LEVEL ");
                        Console.WriteLine("1 - " + m1.Nome + " |  " + m1.Vida + "  |  " + m1.Mana + "  |  " + m1.Inteligencia + "  |  " + m1.Forca + "  |  " + m1.Level + "  | ");
                        
                        Console.WriteLine("Digite o nome do personagem que deseja: ");
                        Console.WriteLine(" ");
                        perso = Convert.ToInt32(Console.ReadLine());

                        
                        //Mago mago = mago[perso]; 
                    }
                    else
                    {
                        if(escolha == 2)
                        {
                            Console.WriteLine(" NOME   |  VIDA | MANA | INTELIGENCIA | FORCA | LEVEL ");
                            Console.WriteLine("2 - " + g1.Nome + " |  " + g1.Vida + "  |  " + g1.Mana + "  |  " + g1.Inteligencia + "  |  " + g1.Forca + "  |  " + g1.Level + "  |  ");
                            
                            Console.WriteLine("Digite o nome do personagem que deseja: ");
                            Console.WriteLine(" ");
                            perso = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Resposta invalida");
                        }
                    }

                    //Console.WriteLine(" NOME   |  VIDA | MANA | INTELIGENCIA | FORCA | LEVEL ");
                    //Console.WriteLine("1 - " + g1.Nome + " |  " + g1.Vida + "  |  " + g1.Mana + "  |  " + g1.Inteligencia + "  |  " + g1.Forca + "  |  " + g1.Level + "  |  ");
                    //Console.WriteLine("2 - " + m1.Nome + " |  " + m1.Vida + "  |  " + m1.Mana + "  |  " + m1.Inteligencia + "  |  " + m1.Forca + "  |  " + m1.Level + "  | ");
                   
                    //Console.WriteLine("Digite o numero do personagem que deseja: ");
                    //Console.WriteLine(" ");
                    //perso = Convert.ToInt32(Console.ReadLine());

                    //Personagem personagem = g
                    Console.ReadKey();
                }
                else
                {
                    if(resp == 2)
                    {
                        //tenho que pegar o personagem
                        mago.AprenderMagia();
                        Console.ReadKey();
                    }
                    else
                    {
                        if(resp == 3)
                        {
                            //tenho que pegar o personagem
                            guerreiro.AprenderHabilidade();
                            Console.ReadKey();
                        }
                        else
                        {
                            if(resp == 4)
                            {
                                //gerar dinamicamente o personagem o pc
                                //pegar o personagem do player
                                Personagem p = new Personagem();

                                //gerar random
                                Random r = new Random();
                                perso = r.Next(0.p.Personagem.Count);
                                Personagem pc = p.Personagem[perso];

                                //calcular ataque de ambos e verificar quem é o vencedor
                                mago.attack();
                                guerreiro.attack();

                                //verificar vencedor e aumentar o nivel dele
                                mago.LvUp();
                                guerreiro.LvUp();

                                Console.ReadKey();
                            }
                            else
                            {
                                
                            }
                        }
                    }
                }
            }
            static int Inicio()
            {
                Console.WriteLine("**Bem vindo aos Gurreiros vs Magos**");
                Console.WriteLine("1 - Listar personagens");
                Console.WriteLine("2 - Listar Magias ");
                Console.WriteLine("3 - Listar Habilidades ");
                Console.WriteLine("4 - Lutar ");
                Console.WriteLine("5 - Sair ");
                Console.Write("Resposta: ");
                int resp = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                return resp;
            }

        }
    }
}
