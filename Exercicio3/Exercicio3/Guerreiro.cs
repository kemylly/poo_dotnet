using System;
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

        }
    }
}
