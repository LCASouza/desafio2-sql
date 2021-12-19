using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalSQL
{
    class Contas
    {
        private long numero, codigoDoFornecedor;
        private DateTime dataDeVencimento, dataDeProrrogacao;
        private double valor, acrescimo, desconto;
        private bool contaPaga;

        Contas()
        {
            contaPaga = false;
            numero = codigoDoFornecedor = 0;
            valor = acrescimo = desconto = 0;
        }

        public long CodigoFornecedor { 
            get { 
                return codigoDoFornecedor; 
            } set { 
                codigoDoFornecedor = value; 
            } 
        }

        public DateTime DataVencimento { 
            get { 
                return dataDeVencimento; 
            } 
            set { 
                dataDeVencimento = value; 
            } 
        }

        public DateTime DataProrrogacao 
        { 
            get { 
                return dataDeProrrogacao; 
            } 
            set { 
                dataDeProrrogacao = value; 
            } 
        }

        public long Numero { get { return numero; } set { numero = value; } }

        public double Valor { get { return valor; } set { valor = value; } }

        public double Acrescimo { get { return acrescimo; } set { acrescimo = value; } }

        public double Desconto { get { return desconto; } set { desconto = value; } }

        public bool ContaPaga { get { return contaPaga; } set { contaPaga = value; } }
    }
}
