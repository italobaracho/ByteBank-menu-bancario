using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loggedIn = false;
            string username = "";

            while (true)
            {
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Sair");
                Console.WriteLine("");
                Console.Write("Opção: ");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    if (loggedIn)
                    {
                        Console.WriteLine("Você precisa fazer logout antes de fazer login novamente.");
                        continue;
                    }
                    Console.Write("Nome de usuário: ");
                    string enteredUsername = Console.ReadLine();
                    Console.Write("Senha: ");
                    string password = Console.ReadLine();

                    if (VerifyCredentials(enteredUsername, password))
                    {
                        loggedIn = true;
                        username = enteredUsername;
                        Console.WriteLine("Login realizado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Nome de usuário ou senha inválidos.");
                    }
                }
                else if (option == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
                if (loggedIn)
                {
                    while (true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("1. Saque");
                        Console.WriteLine("2. Depósito");
                        Console.WriteLine("3. Transferência");
                        Console.WriteLine("4. Logout");
                        Console.WriteLine("");
                        Console.Write("Opção: ");

                        option = Console.ReadLine();

                        if (option == "1")
                        {

                            Console.Write("Digite o valor do saque: ");
                            string? amountInput = Console.ReadLine();
                            int amount;
                            if (Int32.TryParse(amountInput, out amount))
                            {
                                if (Withdraw(username, amount))
                                {
                                    Console.WriteLine("Saque realizado com sucesso.");
                                }
                                else
                                {
                                    Console.WriteLine("Saldo insuficiente para realizar o saque.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor do saque inválido.");
                            }
                        }
                        else if (option == "2")
                        {
                            Console.Write("Digite o valor do depósito: ");
                            string? amountInput = Console.ReadLine();
                            int amount;
                            if (Int32.TryParse(amountInput, out amount))
                            {
                                if (Deposit(username, amount))
                                {
                                    Console.WriteLine("Depósito realizado com sucesso.");
                                }
                                else
                                {
                                    Console.WriteLine("Ocorreu um erro ao realizar o depósito.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor do depósito inválido.");
                            }
                        }
                        else if (option == "3")
                        {
                            Console.Write("Digite o nome de usuário do destinatário: ");
                            string recipientUsername = Console.ReadLine();
                            Console.Write("Digite o valor da transferência: ");
                            string amountInput = Console.ReadLine();
                            int amount;
                            if (Int32.TryParse(amountInput, out amount))
                            {
                                if (Transfer(username, recipientUsername, amount))
                                {
                                    Console.WriteLine("Transferência realizada com sucesso.");
                                }
                                else
                                {
                                    Console.WriteLine("Ocorreu um erro ao realizar a transferência.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor da transferência inválido.");
                            }
                        }
                        else if (option == "4")
                        {
                            loggedIn = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                    }
                }
            }
        }

        static bool VerifyCredentials(string username, string password)
        {
            return (username == "user" && password == "pass");
        }
        static bool Withdraw(string username, int amount)
        {
            return true;
        }

        static bool Deposit(string username, int amount)
        {
            return true;
        }

        static bool Transfer(string senderUsername, string recipientUsername, int amount)
        {
            return true;
        }
    }
}
