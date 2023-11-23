using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen_sound
{
    class Program
    {
        static void Main(string[] args)
        {
            //Screen Sound

            //Delcaração de Variáveis - Início
            string msgBoasVindas = "> Seja bem-vindo ao Screen Sound!";
            //Delcaração de Variáveis - Fim

            //Declaração de Funções - Início
            void ExibirMsgDeBoasVindas()
            {
                Console.WriteLine(@"
                █▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
                ▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
                ");
                Console.WriteLine(msgBoasVindas);
            }

            void ExibirMenuDeOpcoes()
            {
                Console.WriteLine("\n>> MENU DE OPÇÔES:");
                Console.WriteLine("+-----------------------------+");
                Console.WriteLine("| 1.Registrar Banda           |");
                Console.WriteLine("| 2.Listar Todas as Bandas    |");
                Console.WriteLine("| 3.Avaliar Banda             |");
                Console.WriteLine("| 4.Exibir Média de uma Banda |");
                Console.WriteLine("| 0.Encerrar                  |");
                Console.WriteLine("+-----------------------------+");
            }

            //Delcaração de Funções - Fim


            ExibirMsgDeBoasVindas();
            ExibirMenuDeOpcoes();
            Console.ReadLine();
        }
    }
}
