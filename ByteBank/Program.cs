using ByteBank.SistemaMenu;
using System;
using ByteBank.Titular;




namespace Console.ByteBank
{ 

    public class Program
    {
        public static void Main(string[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "Conta teste";
            conta.NumeroConta = 1000;
            conta.Agencia = 001;
            conta.Saldo = 1000;

            conta.Titular = new Titular()
            {
                Cpf = "32233232323",
                Rg = "324234234232",
                Endereço = "Rua Canario",
                NomeConta = "Chição",
            };

            Console.WriteLine($"O saldo atual é: { conta.VerSaldo()}");

            conta.Depositar(150);

            Console.WriteLine($"O saldo atual, após o deposito é: { conta.VerSaldo()}");

            conta.Sacar(900);

            Console.WriteLine($"O saldo atual, após o saque é: { conta.VerSaldo()}");

            conta.Sacar(2000);

        }

    }
     
}