using System;
using System.Collections.Generic;
using System.Text;

namespace Floricultura
{
    public class Fornecedor : DadosPagamento
    {
        public Fornecedor()
        {
            EnderecoEmpresa = new Endereco();
        }
        
        public string NomeEmpresa { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco EnderecoEmpresa { get; set; }

        public override void DadosBancarios()
        {
            throw new NotImplementedException();
        }
    }
}
