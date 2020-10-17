using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Funcionario
    {
        //construtor
        public Funcionario()
        {
            this.Nome = "";
            this.Idade = 0;
            this.Salario = 0;
        }

        public Funcionario(String nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }

        //atributos
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

        private double salario;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public virtual void Bonificacao()
        {
            //metodo principal - padrao
            //return Salario;
        }
    }
}
