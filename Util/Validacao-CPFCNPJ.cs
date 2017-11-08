using System;

namespace Util
{
    public class Validacao

    {
    

public  bool ValidaCpf(string cpfUsuario){
            Console.Clear();
            bool retorno = true;

			string cpfCalculo = "";

			int [] v1 = {10,9,8,7,6,5,4,3,2};
			int [] v2 = {11,10,9,8,7,6,5,4,3,2};

			int resultado = 0;
			int resto = 0;

			// Console.WriteLine("Digite o numero do CPF:");
			// cpfUsuario = Console.ReadLine();

			cpfCalculo = cpfUsuario.Substring(0,9);

			for(int i=0; i< cpfCalculo.Length; i++){
				resultado+= Int16.Parse(cpfCalculo[i].ToString())*v1[i];
			}

			resto= resultado% 11;
			if ( resto < 2 )
		    cpfCalculo += "0";

			else
		    cpfCalculo += (11-resto).ToString();

			resultado = 0;
			
			for(int i=0; i< cpfCalculo.Length; i++){
				resultado+= Int16.Parse(cpfCalculo[i].ToString())*v2[i];
			}

			resto= resultado% 11;
			if ( resto < 2 )
		    cpfCalculo += "0";

			else
		    cpfCalculo += (11-resto).ToString();

			if (cpfUsuario!=cpfCalculo)
            retorno = false;

            return retorno;


         }
    }
}