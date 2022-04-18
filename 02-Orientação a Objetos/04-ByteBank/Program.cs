using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodo Sacar saldo. . .
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            //Método de transferencia. . .
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);

            bool resultadoTransferencia =  contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);

            Console.WriteLine("Resultado transferência: " + resultadoTransferencia);


            Console.ReadLine();

        }
    }
}
