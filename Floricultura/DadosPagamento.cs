using System;
using System.Collections.Generic;
using System.Text;

namespace Floricultura
{
    public abstract class DadosPagamento
    {
        public string NomeBanco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }


        public virtual void DadosBancarios()
        { }
        
    }
}
