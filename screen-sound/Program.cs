using System;

namespace screen_sound
{
    class Program
    {
        static void Main(string[] args)
        {
            //Screen Sound

            //Delcaração de Variáveis
            string msgBoasVindas = "> Seja bem-vindo ao Screen Sound!";

            //Declaração de Funções
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

                Console.WriteLine("\nDigite a sua opção: ");
                string inputUsr = Console.ReadLine();
                int inputUsrNum = int.Parse(inputUsr);
                switch (inputUsrNum)
                {
                    case 1:
                        Console.WriteLine("Você escolheu a opção " + inputUsrNum);
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu a opção " + inputUsrNum);
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu a opção " + inputUsrNum);
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu a opção " + inputUsrNum);
                        break;
                    case 0:
                        Console.WriteLine("Finalizando programa! Até mais :)");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }


            //Inicio do Programa
            ExibirMsgDeBoasVindas();
            ExibirMenuDeOpcoes();

            Console.ReadLine();
        }
    }
}
