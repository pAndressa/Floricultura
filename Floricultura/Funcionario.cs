using System;
using System.Collections.Generic;
using System.Text;

namespace Floricultura
{
    public class Funcionario : DadosPagamento
    {
        public Funcionario()
        {
            EnderecoFun = new Endereco();
            CargoFuncionario = new List<Cargo>();
        }

        public string Nome { get; set; }
        public string Estado { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Cel { get; set; }
        public Endereco EnderecoFun { get; set; }
        public List<Cargo> CargoFuncionario { get; set; }

        public override void DadosBancarios()
        {           
            
        }
    }
}
