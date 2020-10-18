using System;
using System.Collections.Generic;

namespace Exercicio2
{
    public class VideoGame: Produto, Imposto 
    {
        //constutor
        public VideoGame(): base()
        {
            this.Marca = "";
            this.Modelo = "";
            this.isUsado = true;
        }

        //sobrecarga
        public VideoGame(String nome, double preco, int qtd, String marca, String modelo, bool isusado) :base(nome, preco,qtd)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.isUsado = isusado;
        }

        //propridades
        private String marca;
         public String Marca
         {
             get { return marca; }
             set { marca = value; }
         }

         private String modelo;
         public String Modelo
         {
             get { return modelo; }
             set { modelo = value; }
         }

         private bool isusado;
         public bool isUsado
         {
             get { return isusado; }
             set { isusado = value; }
         }

        //metodos
        // 1. Se o vídeo game for usado, calcular imposto de 25% sobre o preço do videogame.
        // 2. Se o vídeo game não for usado, calcular imposto de 45% sobre o preço do videogame.
        public double CalculoImposto()
        {
            double imposto = 0;
            
            //for(int g = 0; g < Preco.Count; g++) //calculo de livro
            //{
                if(this.isUsado == true)
                {
                    //return videoGame[g].Preco + (0.25 * videoGame[g].Preco);
                    //double imposto = videoGame[c].Preco + (0.25 * videoGame[c].Preco);
                    imposto = this.Preco + (0.25 * this.Preco);
                }
                else
                {
                    //return videoGame[g].Preco + (0.45 * videoGame[g].Preco);
                    //double imposto = videoGame[c].Preco + (0.45 * videoGame[c].Preco);
                    imposto = this.Preco + (0.45 * this.Preco);
                }
           // }
            return imposto;
        }
        
         
    }
}