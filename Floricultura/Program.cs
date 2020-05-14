using System;

namespace Floricultura
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Angela";
            funcionario.EnderecoFun.Logradouro = "Rua alameda Jau";
            funcionario.EnderecoFun.Numero = "105";
            funcionario.EnderecoFun.Bairro = "Cerqueira Cesar";
            funcionario.EnderecoFun.Cidade = "Sao Paulo";
            funcionario.EnderecoFun.Estado = "SP";
            funcionario.EnderecoFun.CEP = "0300200-101";

            funcionario.CargoFuncionario.Add(new Cargo { NomeCargo = "Florista",Funcao = "Florista - Criador de arranjos",Especialidade
            ="Fazer Arranjos Casamento"});

            funcionario.NomeBanco = "Itau";
            funcionario.Agencia = "12345-7";
            funcionario.ContaCorrente = "1234567980";
            funcionario.Valor = 1500;
            funcionario.DataPagamento = DateTime.Now;
            funcionario.DadosBancarios();

            Flores flores = new Flores();
            flores.NomeFlor = "Orquidea";
            flores.Especie = "Phalaenopsis violacea";
            flores.Cor = "roxo-violeta";
            flores.Tamanho = "8 cm";
            flores.Cuidados = "Exige bastante umidade do ar, muito sol da manhã e boa ventilação";

            FloresArtificiais floresArtificiais = new FloresArtificiais();
            floresArtificiais.NomeFlorArtificial = "Palmeira";
            floresArtificiais.Cor = "Verde";
            floresArtificiais.Tamanho = "160 cm";
            floresArtificiais.Quantidade = 2;

            Fornecedor fornecedor = new Fornecedor();
            fornecedor.NomeEmpresa = "Orquideas LTDA";
            fornecedor.NomeFantasia = "Orquideas";
            fornecedor.EnderecoEmpresa.Logradouro = "Rua das Colinas";
            fornecedor.EnderecoEmpresa.Numero = "105";
            fornecedor.EnderecoEmpresa.Bairro = "General Peixoto";
            fornecedor.EnderecoEmpresa.Cidade = "Itu";
            fornecedor.EnderecoEmpresa.Estado = "SP";
            fornecedor.EnderecoEmpresa.CEP = "078920-040";


            Console.WriteLine($"Nome do funcionário: {funcionario.Nome}"
                +$"\n Logradouro :{funcionario.EnderecoFun.Logradouro}"
                +$"\n numero: {funcionario.EnderecoFun.Numero}"
                +$"\n Bairro: {funcionario.EnderecoFun.Bairro}"
                +$"\n Cidade: {funcionario.EnderecoFun.Cidade}"
                +$"\n Estado: {funcionario.EnderecoFun.Estado}"
                +$"\n CEP: {funcionario.EnderecoFun.CEP }"
                +$"\n Banco do Funcionario: {funcionario.NomeBanco}"
                +$"\n Agencia :{funcionario.Agencia}"
                +$"\n Conta Corrente:{funcionario.ContaCorrente}"
                +$"\n Salario{funcionario.Valor}");
        }
    }
}
