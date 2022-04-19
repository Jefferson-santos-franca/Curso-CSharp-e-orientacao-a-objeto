using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {



            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(456, 4578950);
            //    ContaCorrente conta2 = new ContaCorrente(487, 548868);

            //    conta2.Transferir(10000, conta);

            //    conta.Depositar(50);
            //    Console.WriteLine(conta.Saldo);
            //    conta.Sacar(-500);
            //}
            //catch (ArgumentException ex)
            //{
            //    if (ex.ParamName == "numeroConta")
            //    {

            //    }
            //    Console.WriteLine("Argumento com problema: " + ex.ParamName);
            //    Console.WriteLine("Ocorreu uma execeção do tipo ArgumentException");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (SaldoInsuficienteException ex)
            //{
            //    Console.WriteLine(ex.Saldo);
            //    Console.WriteLine(ex.ValorSaque);

            //    Console.WriteLine(ex.StackTrace);

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}         

            //Metodo();

            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH no metodo main.");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {

                leitor.LerProximaLinha();
            }


            // ---------------------------------------------------------------------
            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();               
            //}
            //finally
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }
        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 8885497);
                ContaCorrente conta2 = new ContaCorrente(458, 7894568);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

            }
        }

        private static void Metodo()
        {
           // TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                Dividir(10, divisor);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Fui capturado pelo (NullReferenceException ex)");
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Fui capturado pelo (Expection ex)");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
                // Console.WriteLine("Código depois do throw");
            }
        }
    }
}
