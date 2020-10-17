using System;
using System.Collections.Generic;

namespace Exercicio4
{
    public class Pessoa
    {
        //contrutor
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }

        //sobrecarga
        public Pessoa(String nome, int idade)
         {
             this.Nome = nome;
             this.Idade = idade;
         }

        //propriedades
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        //public static int Count { get; internal set; }

        // List<Pessoa> lista;
        // lista = new List<Pessoa>();

        //List<Pessoa> lista = new List<Pessoa>();

        // public void adicionarlista()
        // {
        //     lista.Add();
        // }

        //metodo
        // public void Listapessoas()
        // {
        //     // for(int i = 0; i < this.lista.Count; i++)
        //     // {
        //     //     Console.WriteLine(this.Nome + " | " + this.Idade);
        //     // }

        //     foreach(var item in lista)
        //     {
        //         Console.WriteLine(this.Nome + " | " + this.Idade);
        //     }

        // }

        // public void IdadePessoa()
        // {  
        //       lista.RemoveAll(a <18);
        //  }
    }

}