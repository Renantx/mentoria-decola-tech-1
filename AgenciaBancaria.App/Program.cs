using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Criação da conta
                Endereco endereco = new Endereco("Avenida Helio Prates", "lote 12", "Taguatinga", "DF");
                Cliente cliente = new Cliente("Renan", "561864", "458529", endereco);
                ContaCorrente conta = new ContaCorrente(cliente, 200);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" +
                    conta.DigitoVerificador);

                // Abertura de conta
                string senha = "teste123";
                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" +
                    conta.DigitoVerificador);

                // Utilização da conta
                conta.Sacar(50, senha);
                Console.WriteLine(conta.VerSaldo());

                conta.Depositar(70);
                Console.WriteLine(conta.VerSaldo());

                conta.Sacar(30, senha);
                Console.WriteLine(conta.VerSaldo());

                conta.Depositar(1000);
                Console.WriteLine(conta.VerExtrato());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}