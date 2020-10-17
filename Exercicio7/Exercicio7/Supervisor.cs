using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Supervisor: Funcionario
    {
        public void Bonificacao()
        {
            Console.WriteLine("Salario: " + (this.Salario + 5000));
            //return Salario + 5000.00;
        }
    }
}
