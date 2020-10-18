using System;
using System.Collections.Generic;

namespace Exercicio2
{
    public class Livro: Produto, Imposto
    {
        //construtores
        public Livro():base()
        {
            this.Autor = "";
            this.Tema = "";
            this.Qpag = 0;
        }

        //sobrecarga
        public Livro(String nome, double preco, int qtd, String autor, String tema, int qpag):base(nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.Qpag = qpag;
        }

        //propriedades
        private String autor;
        public String Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        
        private String tema;
        public String Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        
        private int qpag;
        public int Qpag
        {
            get { return qpag; }
            set { qpag = value; }
        }
        

        //metodos
        //metodo comun a todos calculo de imposto
        //1. Se o livro for de tema = “educativo” não se deve cobrar imposto, retornar 0.
        //2. Caso seja de qualquer outro tema, calcular imposto de 10% sobre o preço do livro.
        public double CalculoImposto()
        {
            double imposto = 0;

            //for(int c = 0; c < Tema.Count; c++) //calculo de livro
            //{
                if(this.Tema == "Educativo")
                {
                    //imposto = this.Tema;
                    //return 0;
                }
                else
                {
                    //return Livro[c].Preco + (0.1 * Livro[c].Preco);
                    imposto = this.Preco + (0.1 * this.Preco);
                }
            //}
            return imposto;
        }
        
    }
}