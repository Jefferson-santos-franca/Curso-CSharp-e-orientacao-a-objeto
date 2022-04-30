using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // Visível fora da classe "ModificadoresTeste"
        }
        private void MetodoPrivate()
        {
            // Visível apenas na classe "ModificadoresTeste"
        }
        protected void MetodoProtegido()
        {
            // Visível apenas na classe "ModificadoresTeste" e derivados
        }
        internal void MetodoInterno()
        {
            // Visível apenas para o projeto ByteBank.Modelos!
        }
    }
}
