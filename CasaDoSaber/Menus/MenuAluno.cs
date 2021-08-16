using CasaDoSaber.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoSaber.Menus
{
    public static class MenuAluno
    {
        static int Option = 0;

        public static void OpcoesAluno()
        {
            while (Option != 5)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("         ╔════════════ MENU DE OPÇÕES ════════════════╗    ");
                Console.WriteLine("         ║                                            ║    ");
                Console.WriteLine("         ║             1 CADASTRAR ALUNO              ║    ");
                Console.WriteLine("         ║                                            ║    ");
                Console.WriteLine("         ║             2 CONSULTAR ALUNO              ║    ");
                Console.WriteLine("         ║                                            ║    ");
                Console.WriteLine("         ║             3 ATUALIZAR ALUNO              ║    ");
                Console.WriteLine("         ║                                            ║    ");
                Console.WriteLine("         ║             4 EXCLUIR ALUNO                ║    ");
                Console.WriteLine("         ║                                            ║    ");
                Console.WriteLine("         ║             5 MENU PRINCIPAL               ║    ");
                Console.WriteLine("         ╚════════════════════════════════════════════╝    ");

                Console.Write("\n\n                     SELECIONE UMA OPÇÃO : ");
                Option = int.Parse(Console.ReadLine());
            }
        }
    }
}
