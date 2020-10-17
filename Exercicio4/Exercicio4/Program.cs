using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Pessoa p = new Pessoa("Joao", 15);
            Pessoa p1 = new Pessoa("Leandro", 21);
            Pessoa p2 = new Pessoa("Paulo", 17);
            Pessoa p3 = new Pessoa("Jessica", 18);

            List<Pessoa> lista = new List<Pessoa>();

            // p.Nome = "Joao";
            // p.Idade = 15;
            lista.Add(p);

            // p.Nome = "Leandro";
            // p.Idade = 21;
            lista.Add(p1);

            // p.Nome = "Paulo";
            // p.Idade = 17;
            lista.Add(p2);

            // p.Nome = "Jessica";
            // p.Idade = 18;

            //List<Pessoa> lista = new List<Pessoa>();
            //lista.Add("Joao", 15);

            lista.Add(p3);

            //object p = lista.add(p);
            //p.adicionarlista();

            // foreach (var item in lista)
            // {
            //     Console.WriteLine(p.Nome + " | " + p.Idade);
            // }


            for (int i = 0; i < lista.Count; i++)  //listando primeira vez
            {
                Console.WriteLine(lista[i].Nome + " | " + lista[i].Idade);
            }


            String aux = "";
            int max = 0;
            for (int a = 0; a < lista.Count; a++)  //achando pessoa mais velha
            {
                Pessoa ps = lista[a];

                if (ps.Idade > max)
                {
                    aux = ps.Nome;
                    max = ps.Idade;
                }
            }
            //Console.WriteLine("Idade: " + max);
            Console.WriteLine("Mais velho: " + aux);


            for (int e = 0; e < lista.Count; e++) //excluindo menores de 18
            {
                Pessoa ps = lista[e];
                //int excluir;

                if (ps.Idade < 18)
                {
                    //lista.Remove(p);
                    //lista.Remove(p2);
                    lista.Remove(ps);
                }
            }
    

            Console.WriteLine(" ");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].Nome + " | " + lista[i].Idade);
            }

            Console.WriteLine(" ");

            //String procurase = "Jessica";
            //bool existe;

            //lista = Convert.ToString();

            //existe = lista.Contains(procurase);

            /*if (existe)
            {
                Console.WriteLine("Idade: ");
            }
            else
            {
                Console.WriteLine("nao existe");
            } */

            Console.ReadKey();
        }
    }
}
