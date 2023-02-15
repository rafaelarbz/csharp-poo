using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalcularAreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular a Área de um Retangulo");

            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Informe a altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a base: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());
            retangulo.ExibirDados();
            Console.ReadKey();

        }
    }
}
