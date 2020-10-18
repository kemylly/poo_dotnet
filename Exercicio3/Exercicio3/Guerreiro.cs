﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Guerreiro: Personagem
    {
        //construtores
        public Guerreiro() : base()
        {
            Nome = "";
            Vida = 0;
            Mana = 0;
            XP = 0;
            Inteligencia = 0;
            Forca = 0;
            Level = 0;
        }

        public Guerreiro(String nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base()
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            XP = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        private List<String> habilidade;
        public List<String> Habilidade
        {
            get { return habilidade; }
            set { habilidade = value; }
        }

        //metodos
        public void attack()
        {

        }
        public override void LvUp()
        {

        }

        public void AprenderHabilidade()
        {
            Console.WriteLine("Digite o numero da habilidade que deseja aprender: ");

            List<String> Habilidade = new List<String>();
            Habilidade.Add("Espada");
            Habilidade.Add("Lutar");
            Habilidade.Add("Arco");
            Habilidade.Add("Lanca");

            int num = 1;
            for (int h = 0; h < Habilidade.Count; h++)
            {
                Console.WriteLine(num + " - Habilidade: " + Habilidade[h]);
                num++;
            }

            Console.Write("Resposta: ");
            int elemento = Convert.ToInt32(Console.ReadLine());

            if (elemento == 1) //agua
            {
                if (Nome == "Kemylly")
                {
                    XP = XP + 10;
                    Level = Level + 1;
                    Inteligencia = Inteligencia + 50;
                    Mana = Mana + 50;
                    Forca = Forca + 10;
                }

            }
            else
            {
                if (elemento == 2)
                {
                    XP = XP + 15;
                    Level = Level + 1;
                    Inteligencia = Inteligencia + 40;
                    Mana = Mana + 40;
                    Forca = Forca + 60;
                }
                else
                {
                    if (elemento == 3)
                    {
                        XP = XP + 15;
                        Level = Level + 1;
                        Inteligencia = Inteligencia + 80;
                        Mana = Mana + 50;
                        Forca = Forca + 40;
                    }
                    else
                    {
                        if (elemento == 4)
                        {
                            XP = XP + 10;
                            Level = Level + 1;
                            Inteligencia = Inteligencia + 30;
                            Mana = Mana + 60;
                            Forca = Forca + 70;
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
