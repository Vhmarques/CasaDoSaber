using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoSaber.Menus
{
    public static class MenuPrincipal
    {
        static int Option = 0;

        public static void OpcoesPrincipal()
        {
            while (Option != 3)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("         ╔════════════ MENU DE OPÇÕES ════════════════╗    ");
                Console.WriteLine("         ║                                            ║    ");
                Console.WriteLine("         ║             1 MENU ALUNO                   ║    ");
                Console.WriteLine("         ║                                            ║    ");
                Console.WriteLine("         ║             2 MENU PROFESSOR               ║    ");
                Console.WriteLine("         ║                                            ║    ");
                Console.WriteLine("         ║             3 SAIR                         ║    ");
                Console.WriteLine("         ╚════════════════════════════════════════════╝    ");

                Console.Write("\n\n                     SELECIONE UMA OPÇÃO : ");
                Option = int.Parse(Console.ReadLine());

                Console.Clear();                
            }
            Console.Clear();
            Console.WriteLine("Aplicação encerrada com sucesso!!!");
        }
    }
}
