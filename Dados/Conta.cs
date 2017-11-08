    namespace Dados{
        public class Conta{
            public string Numero { get; set; }
            public string  Agencia { get; set; }
            public double Saldo { get;protected set; }
            /// <summary>
            /// Da ao usuario a opcao de Sacar um valor da conta do usuario
            /// </summary>
            /// <param name="Valor">Recebe um valor do tipo double </param>
            /// <returns></returns>
            public virtual double Sacar (double Valor) {
                this.Saldo -= Valor;
                return this.Saldo;}

            /// <summary>
            /// Deposita um valor na conta do usuário
            /// </summary>
            /// <param name="Valor"></param>
            /// <returns></returns>
            public virtual double Depositar(double Valor) {
                this.Saldo += Valor;
                return this.Saldo; }

        }
    }