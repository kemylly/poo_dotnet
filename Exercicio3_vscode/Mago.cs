namespace Exercicio3
{
    public class Mago
    {
        public Mago():base()
        {
            Nome = "";
            Vida = 0;
            Mana = 0;
            XP = 0;
            Inteligencia =0;
            Forca = 0;
            Level = 0;
        }

        public Mago(String nome, int vida, int mana, float xp, int inteligencia, int forca, int level):base()
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
            
        }
    }
}
