using System;

namespace Atendimento
{
    class Program
    {
        const int DESBLOQUEIO = 1;
        const int BLOQUEIO = 2;
        const int ATENDENTE = 3;
        const int SAIR = 4;

        static void Main(string[] args)
        {
            Cartao MeuCartao = new Cartao();

            Console.WriteLine("Bem-vindo ao sistema de atendimento ao cliente!");
            Console.WriteLine();

            Console.WriteLine($"{"Escolha uma opção:",50}");
            Console.WriteLine($"{"===========================================",50}");
            Console.WriteLine($"{"1 - Desbloqueio de cartão",50}");
            Console.WriteLine($"{"===========================================",50}");
            Console.WriteLine($"{"2 - Bloqueio de cartão",50}");
            Console.WriteLine($"{"===========================================",50}");
            Console.WriteLine($"{"3 - Falar com atendente",50}");
            Console.WriteLine($"{"===========================================",50}");
            Console.WriteLine($"{"4 - Sair do sistema",50}");

            int opcao = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Opção desejada: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    entradaValida = ValidarEntrada(opcao);
                }
                else
                {
                    Console.WriteLine("Opção inválida! Digite uma opção válida.");
                }
            }

            switch (opcao)
            {
                case DESBLOQUEIO:
                    Cartao.DesbloquearCartao();
                    break;
                case BLOQUEIO:
                    Cartao.BloquearCartao();
                    break;
                case ATENDENTE:
                    Cartao.FalarComAtendente();
                    break;
                case SAIR:
                    Cartao.SairDoSistema();
                    break;
                default:
                    Console.WriteLine("Opção informada não existe!");
                    break;
            }
        }
        static bool ValidarEntrada(int opcao)
        {
            if (opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opção inválida! Digite uma opção válida.");
                return false;
            }
            return true;
        }
    }
}
