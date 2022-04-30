﻿using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer <ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if(x == y)
            {
                return 0;
            }

            if(x == null)
            {
                return 1;
            }
            if(y == null)
            {
                return -1;
            }

            return x.Agencia.CompareTo(y.Agencia);


            //if(x.Agencia < y.Agencia)
            //{
            //    return -1; // x fica na frente de y
            //}

            //if(x.Agencia == y.Agencia)
            //{
            //    return 0; // são equivalentes
            //}
            //return 1; // Y fica na frente de X

            // Nossas comparações de numeros interiros é equivalente
            // ao que já existe no tipo INT
            // return x.Agencia.CompareTo(y.Agencia);
        }
    }
}
