using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Mago: Personagem
    {
        //construtores
        public Mago() : base()
        {
            Nome = "";
            Vida = 0;
            Mana = 0;
            XP = 0;
            Inteligencia = 0;
            Forca = 0;
            Level = 0;
        }

        public Mago(String nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base()
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            XP = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        private List<String> magia;
        public List<String> Magia
        {
            get { return magia; }
            set { magia = value; }
        }

        //metodos
        public void attack(int Inteligencia, int Level)
        {
            int ataque1 = 0;
            Random r = new Random();
            int aux;

            aux = r.Next(300);

            ataque1 = Inteligencia * Level + aux;
            Console.WriteLine("Mens: " + Inteligencia + " " + Level + " " + aux + " = " + ataque1);
            //verificar de quem é o maior ataque
        }

        public override void LvUp()
        {
            //se mago vencer aumentar o nivel dele
            //atributos mana e inteligencia
            Level++;
            Mana = Mana + 10;
            Inteligencia = Inteligencia + 20;
        }

        public void AprenderMagia(float XP, int Level, int Inteligencia, int Mana, int Forca)
        {
            Console.WriteLine("Digite o numero da magia que deseja aprender: ");
            /*Console.WriteLine("1 - Agua ");
            Console.WriteLine("2 - Fogo ");
            Console.WriteLine("3 - Vento ");
            Console.WriteLine("4 - Terra "); */

            List<String> Magia = new List<String>();
            Magia.Add("Agua");
            Magia.Add("Fogo");
            Magia.Add("Vento");
            Magia.Add("Terra");

            int num = 1;
            for (int i = 0; i < Magia.Count; i++)
            {
                Console.WriteLine(num + " - Magia: " + Magia[i]);
                num++;
            }

            Console.Write("Resposta: ");
            int elemento = Convert.ToInt32(Console.ReadLine());

            if(elemento == 1) //agua
            {
                    XP = XP + 10;
                    Level = Level + 1;
                    Inteligencia = Inteligencia + 50;
                    Mana = Mana + 50;
                    Forca = Forca + 10;
            }
            else
            {
                if(elemento == 2)
                {
                    XP = XP + 15;
                    Level = Level + 1;
                    Inteligencia = Inteligencia + 80;
                    Mana = Mana + 40;
                    Forca = Forca + 20;
                }
                else
                {
                    if(elemento == 3)
                    {
                        XP = XP + 15;
                        Level = Level + 1;
                        Inteligencia = Inteligencia + 30;
                        Mana = Mana + 50;
                        Forca = Forca + 20;
                    }
                    else
                    {
                        if(elemento == 4)
                        {
                            XP = XP + 10;
                            Level = Level + 1;
                            Inteligencia = Inteligencia + 40;
                            Mana = Mana + 70;
                            Forca = Forca + 50;
                        }
                        else
                        {
                            Console.WriteLine("Valor invalido"); 
                        }
                    }
                }
            }
            
        }


    }
}
