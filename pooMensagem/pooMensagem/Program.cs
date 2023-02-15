using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Alo Mundo";
            msg1.ExibirMensagem();

            //msg2 = new Mensagem();
            //msg2.TextoMensagem = "Segundo Obj";
            //msg2.ExibirMensagem();

            Console.ReadKey();
        }
    }
}
