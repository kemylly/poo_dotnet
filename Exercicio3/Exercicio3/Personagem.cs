﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Personagem
    {
        //contrutor
        public Personagem()
        {
            Nome = "";
            Vida = 0;
            Mana = 0;
            XP = 0;
            Inteligencia = 0;
            Forca = 0;
            Level = 0;
        }

        public Personagem(String nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            XP = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        //propriedades
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int vida;
        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }

        private int mana;
        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        private float xp;
        public float XP
        {
            get { return xp; }
            set { xp = value; }
        }

        private int inteligencia;
        public int Inteligencia
        {
            get { return inteligencia; }
            set { inteligencia = value; }
        }

        private int forca;
        public int Forca
        {
            get { return forca; }
            set { forca = value; }
        }

        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        //metodo com polimorfismo
        public virtual void LvUp(String Nome)
        {
            Console.WriteLine("Voce est usando o Metodo padrao para subir de nivel");
            //falta uma identificacao pata sabeer de quem estou falando

            Level++;
            Vida = +10;
            Forca = +10;
            Mana = +10;
            Inteligencia = +10;
        }
    }
}
