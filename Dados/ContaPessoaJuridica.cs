using System;

namespace Dados
{
    public class ContaPessoaJuridica:Conta
    {
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }

         public override double Sacar (double valor){
            Console.WriteLine("Você sacou de sua conta Pessoa Juridica: "  + valor);
            this.Saldo = base.Sacar (valor + 0.50);
            return this.Saldo;
        }
         public override double Depositar (double valor){
             Console.WriteLine("Você depositou em sua conta Pessoa Juridica: "  +valor);
            this.Saldo = base.Depositar (valor + 0.10);
            return this.Saldo;
        }
        public void CadastrarConta(string Numero, string Agencia, string Conta, string RazaoSocial, DateTime DataAbertura, string CNPJ){

        }
    }
}