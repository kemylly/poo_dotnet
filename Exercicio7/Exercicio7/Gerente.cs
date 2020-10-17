using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Gerente: Funcionario
    {
        public void Bonificacao()
        {
            Console.WriteLine("Salario: " + (this.Salario + 10000));
            //return Salario + 10000.00;
        }
    }
}
