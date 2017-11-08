using System;
using Dados;
using Util;


namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Validacao validacao = new Validacao();

            // bool cpfValido = false;
            // string cpf = "";

            // do{
            //     Console.WriteLine("informe seu CPF");
            //     cpf = Console.ReadLine();                
            //     cpfValido = validacao.ValidaCpf(cpf);
            //     if (cpfValido == false){
            //         Console.WriteLine("Cpf Invalido");
            //     }

            // }
            // while (cpfValido == false);
            // Console.WriteLine("Cpf valido");


            // // Cria o objeto tipo de conta
            // Conta conta = new Conta();

            // // Deposita ou saca um  valor na conta
            // conta.Depositar(450.00);

            // conta.Sacar(175.00);

            // //Informa o valor ao usuario sobre o saldo na conta
            // Console.WriteLine("Seu saldo é: " + conta.Saldo);

            ContaPessoaFisica contapf = new ContaPessoaFisica();
            contapf.Sacar (50.00);
            contapf.Depositar(6000.00);

            Console.WriteLine("Seu saldo é: " + contapf.Saldo);

            ContaPessoaJuridica contapj = new ContaPessoaJuridica();
            contapj.Sacar(600.00);
            contapj.Depositar(15000.00);


        }
    }
}
