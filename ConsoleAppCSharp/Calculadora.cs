using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharp
{
	public class Calculadora
	{
		public bool EhPar(object expressao)
		{
			var numero = Convert.ToInt32(expressao);
			var resto = numero % 2;
			if (resto == 0) 
				return true;
			return false;
			
		}


		public decimal CalcularTotalJurosSimples(decimal valorDaParcela, decimal percentual){

			var valorDoJuros = valorDaParcela * percentual / 100;

			return valorDoJuros;

		}

		
	}
}
