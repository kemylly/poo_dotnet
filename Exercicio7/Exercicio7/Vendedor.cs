using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Vendedor: Funcionario
    {
        public override void Bonificacao()
        {
            Console.WriteLine("Salario: " + (this.Salario + 3000));
            //return Salario + 3000.00;
        }
    }
}
