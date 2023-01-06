using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao banco ByteBank!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Saque");
            Console.WriteLine("2. Depósito");
            Console.WriteLine("3. Transferência");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Você escolheu a opção Saque.");

                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opção Depósito.");

                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opção Transferência.");

                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
