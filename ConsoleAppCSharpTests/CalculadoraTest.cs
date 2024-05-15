using ConsoleAppCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace ConsoleAppCSharpTests
{
	[TestClass]
	public class CalculadoraTest
	{
		[TestMethod]
		public void AoVerrificarSeUmNumeroEhParDeveRetornarVerdadeiro()
		{
			// Causa/Cenário DEVE Efeito/Resultado
			var calculadora = new Calculadora();
			var par = calculadora.EhPar(2);


			if (par == false)
			{
				throw new Exception("O numero doi sé Par meu amigo!");

			}
		}

		[TestMethod]
		public void AoVerificarSeUmNumeroEhImparDeveRetornarFalso()
		{
			var calculadora = new Calculadora();
			var impar = (calculadora.EhPar(3) == false);

			if (impar == false)
			{
				throw new Exception("O numero tres é Impar meu amigo!");
			}
		}

		[TestMethod]
		public void AoVerificarSeUmTextoEhParDeveRetornarVerdadeiro()
		{
			var calculadora = new Calculadora();
			var par = calculadora.EhPar("123456");

			if(par == false){
				throw new Exception("O número 123456 é´Par meu amigo!");
			}
		}

		[TestMethod]
		public void AoCalcularJurosSimplesDeUmaParcelaDeveInformarValorCorreto(){
			var parcela = 562.3M;
			var taxa = 2.5M;

			var calculadora = new Calculadora();
			var totalDoJuros = calculadora.CalcularTotalJurosSimples(parcela, taxa);

			if (totalDoJuros != 14.0575M){
				throw new Exception("Favor calcular corretamente o valor do juros!");
			}
		}
	}
}
