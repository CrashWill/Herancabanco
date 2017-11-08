namespace Dados
{
    public class ContaPessoaFisica: Conta
    {
        public Pessoa Pessoa { get; set; }// este metodo chama-se agregação de classe
        public string NomeCliente { get; set; }
        public string  DataNascimento { get; set; }      
        
        
        public override double Sacar (double valor){
            this.Saldo = base.Sacar (valor + 0.10);
            return this.Saldo;
        }
        public override double Depositar (double valor){
            System.Console.WriteLine("Efetuou um deposito em sua conta Pessoa Fisica no valor de:" + valor);
            this.Saldo += valor + 0.01;
            return this.Saldo;
        }
    }
}