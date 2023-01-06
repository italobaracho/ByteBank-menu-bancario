using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaMenu
{ 
    public class Titular
    {
        public int Agencia { get; set; }    
        public int NumeroConta { get; set; }
        public int NomeConta { get; set; }
        public Titular Nome { get: set; }
        public Decimal Saldo { get; set; } 
        public Decimal VerSaldo()
        {
            return Saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                Console.WriteLine("Saque não pode ser realizado, pos não tem saldo suficiente");
        }



    }
}
