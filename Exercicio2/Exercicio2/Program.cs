using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l = new Livro();
            VideoGame v = new VideoGame();
            Loja loja = new Loja();
            //Imposto i = new Imposto();

            // List<Livro> Livro = new List<Livro>();
            // {
            //     new Livro(){Nome="garoto 21", Preco= 40, Qtd=50, Autor="Matthew Quick", Tema="Fantasia", Qpag=300}; //garoto 21
            //     new Livro(){Nome="A jornada", Preco=60, Qtd=30, Autor="Erin e Moulton", Tema="Educativo", Qpag=500}; //a jornada
            //     new Livro(){Nome="Sing", Preco=20, Qtd=50, Autor="Vivi Greene", Tema="Romance", Qpag=500}; //sing
            // }

            // List<VideoGame> videoGame = new List<VideoGame>();
            // {

            //     new VideoGame(){ Nome ="PS4", Preco= 1800, Qtd=100, Marca="Sony", Modelo="Slim", isUsado=false};
            //     new VideoGame(){Nome="PS4", Preco=1800, Qtd=7, Marca="Sony", Modelo="Slim", isUsado=true};
            //     new VideoGame(){Nome="XBOX", Preco=1500, Qtd=500, Marca="Microsoft", Modelo="One", isUsado=false};

            // }

            Livro l1 = new Livro("garoto 21", 40, 50, "Matthew Quick", "Fantasia", 300); //garoto 21
            Livro l2 = new Livro("A jornada", 60, 30, "Erin e Moulton", "educativo", 500); //a jornada
            Livro l3 = new Livro("Sing", 20, 50, "Vivi Greene", "Romance", 500); //sing

            //Nome, preco, qtd, marca, modelo, isusuario
            VideoGame PS4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false); 
            VideoGame PS4usado = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false); 
            VideoGame XBOX = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false); 

            List<Livro> Livro = new List<Livro>();
            Livro.Add(l1);
            Livro.Add(l2);
            Livro.Add(l3);

            List<VideoGame> videoGame = new List<VideoGame>();
            videoGame.Add(PS4);
            videoGame.Add(PS4usado);
            videoGame.Add(XBOX);
            
            Loja americanas = new Loja("Americanas", "12345678", Livro, videoGame);

            //loja.Calculapatrimonio();
            l2.CalculoImposto();
            l3.CalculoImposto();

            PS4usado.CalculoImposto();
            PS4.CalculoImposto();

            americanas.Listalivros();
            americanas.Listavideogame();
            americanas.CalculaPatrimonio();

        }
    }
}
