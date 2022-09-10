using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            float salarioRecebido, vendas;
            

            Console.WriteLine("Qual o valor de suas vendas? ");
            vendas = Convert.ToSingle(Console.ReadLine());

            if (vendas >= 20000)
            {
                salarioRecebido = (float)(vendas - (vendas * (0.90)));
            } else
            {
                salarioRecebido = (float)(vendas - (vendas * (0.925)));
            }
            Console.WriteLine("Seu salário é de: {0}", salarioRecebido);

            Console.ReadKey();
        }
    }
}
