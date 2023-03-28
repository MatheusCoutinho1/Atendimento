using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    internal class Cartao
    {
        public int MeuCartao { get; set; }

        public static void DesbloquearCartao()
        {
            Console.WriteLine("Cartão desbloqueado com sucesso!");
        }

        public static void BloquearCartao()
        {
            Console.WriteLine("Cartão bloqueado com sucesso!");
        }

        public static void FalarComAtendente()
        {
            Console.WriteLine("Olá, em que posso ajudar?");
        }

        public static void SairDoSistema()
        {
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine("Volte sempre!");
            Console.WriteLine("=======================");
        }
    }
}
