using System;
using System.Collections.Generic;
using System.Linq;
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
        public void attack()
        {

        }
        public override void LvUp()
        {

        }

        public void AprenderMagia()
        {
            Console.WriteLine("Digite o numero da magia que deseja: ");
            Console.WriteLine("1 - Agua ");
            List<String> Magia = new List<String>();
            Magia.Add("Agua");
        }


    }
}
