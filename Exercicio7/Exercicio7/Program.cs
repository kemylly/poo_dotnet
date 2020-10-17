using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando os objetos
            //Funcionario f = new Funcionario();
            Vendedor v = new Vendedor();
            Gerente g = new Gerente();
            Supervisor s = new Supervisor();

            //cadastro de informacoes
            v.Nome = "Luis";
            v.Idade = 20;
            v.Salario = 1000;

            g.Nome = "Ana";
            g.Idade = 37;
            g.Salario = 2000;

            s.Nome = "Alex";
            s.Idade = 28;
            s.Salario = 3000;

            //apresentacao do ressultado
            Console.WriteLine("Gerente: " + g.Nome);
            Console.WriteLine("Idade: " + g.Idade);
            g.Bonificacao();   //chamando o metodo de bonificacao
           // Console.WriteLine("Salario: " + g.Salario);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Vendedor: " + v.Nome);
            Console.WriteLine("Idade: " + v.Idade);
            v.Bonificacao();
           // Console.WriteLine("Salario: " + v.Salario);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Supervisor: " + s.Nome);
            Console.WriteLine("Idade: " + s.Idade);
            s.Bonificacao();
            //Console.WriteLine("Salario: " + s.Salario);
            Console.WriteLine("-----------------------------");


           // g.Bonificacao();
           // v.Bonificacao();
           // s.Bonificacao();

            Console.ReadKey();
        }
    }
}
