using System;
using System.Collections.Generic;

namespace Exercicio2
{
    
    public class Loja
    {
        //construtor
        public Loja()
        {
            this.Nome = "";
            this.Cnpj = "";
        }

        //sobrecarga, puxa list livro
        public Loja(String nome, String cnpj, List<Livro> livro, List<VideoGame> videogame)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
        }

        /*public Loja()
        {
            this.Listalivros();
        } */

        //propriedades para a lista de livros e video game
        private List<Livro> livro;
        public List<Livro> Livro
        {
            get { return livro; }
            set { livro = value; }
        }

        private List<VideoGame> videogame;
        public List<VideoGame> videoGame
        {
            get { return videoGame; }
            set { videoGame = value; }
        }
        
        //esta faltando nome, e mais dois campos nesses parametros
        // private void Listalivros()
        // {
        //     this.livro = new List<Livro>();
            
        //     Livro l1 = new Livro("Matthew Quick", "Fantasia", 300); //garoto 21
        //     Livro l2 = new Livro("Erin e Moulton", "Fantasia", 500); //a jornada
        //     Livro l3 = new Livro("Vivi Greene", "Romance", 500); //sing

        //    /* l = new Livro("Matthew Quick", "Fantasia", 300); //garoto 21
        //     this.livro.Add(l);

        //     l = new Livro("Erin e Moulton", "Fantasia", 500); //a jornada
        //     this.livro.Add(l);

        //     3 = new Livro("Vivi Greene", "Romance", 500); //sing
        //     this.livro.Add(l); */
        // }

       /* public void Listalivros()
        {
            for (int i = 0; i < this.Listalivros; i++)
            {
                Console.WriteLine("Livro: "+ i);

            }
        } */
        
        // private List<VideoGame> videogame;
        // public List<VideoGame> VideoGames
        // {
        //     get { return videogame; }
        //     set { videogame = value; }
        // }

        // // private void = Listavideogame()
        // // {
        // //     this.videogame = new List<VideoGame>();

        // //     VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
        // //     VideoGame ps4Usado = new VideoGame("PS4", 1800, 7, "Sony", "Slim", true);
        // //     VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);
        // // }

        //propriedades
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String cnpj;
        public String Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        
        //metodos
        public void Listalivros() //lista todos os livros que uma loja tem
        {
            if(Livro != null) //verificando a dispoibilidade e depois listando
            {
                for(int l = 0; l < Livro.Count; l++)
                {
                    Livro livros = this.Livro[l];
                    Console.WriteLine("Livro: " + livros.Nome + ", " + livros.Preco + ", " + livros.Qtd);
                }
            }
            else
            {
                Console.WriteLine("A loja não tem livros no seu estoque.");
            }
        }

        public void Listavideogame()  //lista todos os vídeo games que uma loja
        {
            if(videoGame != null) 
            {
                for(int v = 0; v < videoGame.Count; v++)
                {
                    VideoGame game = this.videoGame[v];
                    Console.WriteLine("Video-game: "+ game.Modelo + "," + game.Preco + ", " + game.Qtd);
                }
            }
            else
            {
                Console.WriteLine("A loja não tem video-games no seu estoque.");
            }
        }

        //calculo de patrimonio
        public double CalculaPatrimonio()
        {
            double patrimonio = 0; 
            for (int p = 0; p < Livro.Count; p++)
            {
                //double patrimonio = 0; 
                patrimonio = Livro[p].Preco + patrimonio; 
            }
           return patrimonio;
        }
    }
}