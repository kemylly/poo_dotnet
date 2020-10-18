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
            Mago m2 = new Mago("Felipe", 100, 80, 250, 100, 300, 5);
            Mago m3 = new Mago("Soon", 100, 80, 250, 100, 300, 5);
            // List<Mago> Magos = new List<Mago>();
            // Magos.Add(m1);

            //adicionando coisas a guerreiro
            Guerreiro g1 = new Guerreiro("Vinycius", 100, 70, 260, 90, 350, 5);
            Guerreiro g2 = new Guerreiro("Hak", 90, 70, 260, 90, 350, 5);
            Guerreiro g3 = new Guerreiro("Yona", 110, 70, 260, 90, 350, 5);
            // List<Guerreiro> Guerreiros = new List<Guerreiro>();
            // Guerreiros.Add(g1);

            Personagem m = new Mago();
            Personagem g = new Guerreiro();

            //Mago Magia = new Mago("Agua");

            Mago mago = new Mago();
            Guerreiro guerreiro = new Guerreiro();

            List<Mago> magos = new List<Mago>();
            magos.Add(m1);
            magos.Add(m2);
            magos.Add(m3);

            List<Guerreiro> guerreiros = new List<Guerreiro>();
            guerreiros.Add(g1);
            guerreiros.Add(g2);
            guerreiros.Add(g3);

            //int perso = 0;
            String perso = "";
            int resp = 0;
            int escolha = 0;
            //String player = "";

            while(resp != 5)
            {
                resp = Inicio();
                if (resp == 1) //lista personagens
                {
                    //int escolha = 0;

                    Console.WriteLine("1 - Mago");
                    Console.WriteLine("2 - Guerreiro");
                    Console.Write("Digite o numero da sua escolha: ");
                    escolha = Convert.ToInt32(Console.ReadLine());

                    if(escolha == 1)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(" NOME   |  VIDA | MANA | INTELIGENCIA | FORCA | LEVEL ");
                        Console.WriteLine("- " + m1.Nome + " |  " + m1.Vida + "  |  " + m1.Mana + "  |  " + m1.Inteligencia + "  |  " + m1.Forca + "  |  " + m1.Level + "  | ");
                        Console.WriteLine("- " + m2.Nome + " |  " + m2.Vida + "  |  " + m2.Mana + "  |  " + m2.Inteligencia + "  |  " + m2.Forca + "  |  " + m2.Level + "  | ");
                        Console.WriteLine("- " + m3.Nome + " |  " + m3.Vida + "  |  " + m3.Mana + "  |  " + m3.Inteligencia + "  |  " + m3.Forca + "  |  " + m3.Level + "  | ");

                        Console.WriteLine(" ");
                        Console.Write("Digite o nome do personagem que deseja: ");
                        perso = Console.ReadLine();
                        //perso = Convert.ToInt32(Console.ReadLine());

                    }
                    else
                    {
                        if(escolha == 2)
                        {
                            Console.WriteLine(" NOME   |  VIDA | MANA | INTELIGENCIA | FORCA | LEVEL ");
                            Console.WriteLine("- " + g1.Nome + " |  " + g1.Vida + "  |  " + g1.Mana + "  |  " + g1.Inteligencia + "  |  " + g1.Forca + "  |  " + g1.Level + "  |  ");
                            Console.WriteLine("- " + g2.Nome + " |  " + g2.Vida + "  |  " + g2.Mana + "  |  " + g2.Inteligencia + "  |  " + g2.Forca + "  |  " + g2.Level + "  |  ");
                            Console.WriteLine("- " + g3.Nome + " |  " + g3.Vida + "  |  " + g3.Mana + "  |  " + g3.Inteligencia + "  |  " + g3.Forca + "  |  " + g3.Level + "  |  ");

                            Console.WriteLine(" ");
                            Console.Write("Digite o nome do personagem que deseja: ");
                            perso = Console.ReadLine();
                            //perso = Convert.ToInt32(Console.ReadLine());
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

                    Console.ReadKey();
                    Console.Clear();
                }
                //fim da listagem de personagens

                else
                {
                    if(resp == 2) //lista magias
                    {
                        //tenho que pegar o personagem
                        if(escolha == 1)
                        {
                            for (int s = 0; s < magos.Count; s++)
                            {
                                Mago ma = magos[s];
                               
                                if (perso == ma.Nome)
                                {
                                    mago.AprenderMagia(ma.XP, ma.Inteligencia, ma.Level, ma.Mana, ma.Forca);

                                    Console.WriteLine("Poderes atuais: ");
                                    Console.WriteLine("  NOME   |  XP  | MANA | INTELIGENCIA | FORCA | LEVEL ");
                                    Console.WriteLine("-> " + ma.Nome + " |  " + ma.XP + "  |  " + ma.Inteligencia + "  |  " + ma.Level + "  |  " + ma.Mana + "  |  " + ma.Forca + "  | ");

                                }
                            }
                        }
                        else
                        {
                            if(escolha == 2)
                            {
                                Console.WriteLine("Voce escolheu um personagem Guerreiro. Ele nao consgue aprender magia.");
                                Console.WriteLine("Vá em Listar Habilidades e escolha alguma.");

                                //Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Parece que voce não escolheu um personagem ainda!");
                                Console.WriteLine("Vá em Listar personagens e escolha algum.");

                                //Console.Clear();
                            }
                        }
                        //mago.AprenderMagia();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    //fim do aprender magia

                    else
                    {
                        if(resp == 3) //lista habilidades
                        {
                            if (escolha == 1)
                            {
                                Console.WriteLine("Voce escolheu um personagem Mago. Ele nao consgue aprender Habilidades.");
                                Console.WriteLine("Vá em Listar Magias e escolha alguma.");

                                //Console.ReadKey();
                                //Console.Clear();
                            }
                            else
                            {
                                if (escolha == 2) //listar habilidades
                                {
                                    for (int s = 0; s < guerreiros.Count; s++)
                                    {
                                        Guerreiro gr = guerreiros[s];
                                        
                                        if (perso == gr.Nome)
                                        {
                                            guerreiro.AprenderHabilidade(gr.XP, gr.Inteligencia, gr.Level, gr.Mana, gr.Forca);
                                            
                                            Console.WriteLine("Poderes atuais: ");
                                            Console.WriteLine("  NOME   |  XP  | MANA | INTELIGENCIA | FORCA | LEVEL ");
                                            Console.WriteLine("-> " + gr.Nome + " |  " + gr.XP + "  |  " + gr.Inteligencia + "  |  " + gr.Level + "  |  " + gr.Mana + "  |  " + gr.Forca + "  | ");
                                        }
                                    }
                                   
                                }
                                else
                                {
                                    Console.WriteLine("Parece que voce não escolheu um personagem ainda!");
                                    Console.WriteLine("Va em Listar personagens e escolha algum");
                                }
                            }
                            //guerreiro.AprenderHabilidade();
                            Console.ReadKey();
                            Console.Clear();
                        }
                        //fim de aprender habilidade

                        else
                        {
                            if(resp == 4) //lutar - batalhar
                            {
                                //utiliza o metodo de ataque 
                                //e se vencer sobe de nivel
                                Personagem p = new Personagem();

                                //gerar random
                                //Random r = new Random();
                                //int valor = r.Next(magos.Count);
                                //Mago pc = ;
                                //Mago mago1 = magos[perso];
                                //player = r.Next(0.magos.Count);
                                //Mago pc = magos.[perso];

                                //int qtd = guerreiros.Count();
                                //Guerreiro guerreiro1 = new Guerreiro(qtd);

                                //calcular ataque de ambos e verificar quem é o vencedor

                                //int valor = r.Next(qtd);

                                //calculando ataque do personagem escolhido
                                

                                if (escolha == 1)
                                {
                                    //mago.attack(perso);
                                    for (int s = 0; s < magos.Count; s++) //achando personagem que o usuario escolheu
                                    {
                                        Mago mo = magos[s];
                                        //String ps = guerreiro[s];

                                        if (perso == mo.Nome)
                                        {
                                            Console.WriteLine("** Jogador 1 **");
                                            Console.WriteLine("Nome: " + mo.Nome + " | Inteligencia: " + mo.Inteligencia + " | Nivel: " + mo.Level);
                                            mago.attack(mo.Inteligencia, mo.Level);
                                        }
                                    }

                                    //gerar jogador aleatorio para o pc
                                    Random r1 = new Random(); //inteligencia aleatoria
                                    Random r2 = new Random(); //level aleatorio

                                    int Inteligencia1 = r1.Next(100);
                                    int Level1 = r2.Next(5);

                                    String Nome1 = "Pro-player";

                                    Console.WriteLine("\n** Jogador 2 **");
                                    Console.WriteLine("Nome: " + Nome1 + " | Inteligencia: " + Inteligencia1 + " | Nivel: " + Level1);
                                    mago.attack(Inteligencia1, Level1);
                                    
                                    
                                }

                                else
                                {
                                    if(escolha == 2)
                                    {
                                        for (int s = 0; s < guerreiros.Count; s++) //achando personagem que o usuario escolheu
                                        {
                                            Guerreiro go = guerreiros[s];
                                            //String ps = guerreiro[s];

                                            if (perso == go.Nome)
                                            {
                                                Console.WriteLine("** Jogador 1 **");
                                                Console.WriteLine("Nome: " + go.Nome + " | Inteligencia: " + go.Inteligencia + " | Nivel: " + go.Level);
                                                guerreiro.attack(go.Forca, go.Level);
                                            }
                                        }

                                        //gerar jogador aleatorio para o pc
                                        Random r1 = new Random(); //inteligencia aleatoria
                                        Random r2 = new Random(); //level aleatorio

                                        int Inteligencia1 = r1.Next(100);
                                        int Level1 = r2.Next(5);

                                        String Nome1 = "Pro-player";

                                        Console.WriteLine("\n** Jogador 2 **");
                                        Console.WriteLine("Nome: " + Nome1 + " | Inteligencia: " + Inteligencia1 + " | Nivel: " + Level1);
                                        mago.attack(Inteligencia1, Level1);
                                        //int qtd = guerreiros.Count();
                                        //guerreiro.attack(perso, qtd);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Parece que voce não escolheu um personagem ainda!");
                                        Console.WriteLine("Va em Listar personagens e escolha algum");
                                    }

                                }

                                //verificar vencedor e aumentar o nivel dele
                                //mago.LvUp();
                                //guerreiro.LvUp();

                                Console.ReadKey();
                                Console.Clear();
                            }
                            //fim da luta

                            else
                            {
                                //fecha o programa
                            }
                        }
                    }
                }
            }
            static int Inicio()//menu
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
