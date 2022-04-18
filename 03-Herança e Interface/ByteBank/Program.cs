using ByteBank.Funcionarios;
using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        public static object SIstemaInterno { get; private set; }

        static void Main(string[] args)
        {
            // CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "1234";

            GerenteDeConta camila = new GerenteDeConta("326.155.654-20");
            camila.Nome = "Camila";
            camila.Senha = "1221";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "1414";

            sistemaInterno.Logar(parceiro, "1414");
            sistemaInterno.Logar(roberta, "1234");
            sistemaInterno.Logar(camila, "1221");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer jefferson = new Designer("091.094.689-27");
            jefferson.Nome = "Jefferson";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.155.654-20");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(jefferson);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
