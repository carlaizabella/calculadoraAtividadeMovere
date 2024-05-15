using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharp //Posso colocar qualquer nome, não existe regra no NAMESPACE **PASTAS** Posso er nome igual porém namespace diferentes. 
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("HelloWW... ");
			Console.WriteLine("Informe um número, por favor...");
			Console.Write("Vamos ver se é par: ");

			var texto = Console.ReadLine();

			if (int.TryParse(texto, out int numero))
			{
				var calculador = new Calculadora();
				var par = calculador.EhPar(numero);


				if (par)
				{
					Console.WriteLine("Muito bonito, vc digitou um número par!");
				}
				else
				{
					Console.WriteLine("Maravilha, este é um número ímpar!");
				}

			}
			else
			{ 
			Console.WriteLine("Amigo! Por favor! PAD... informe um número... ");
			}
		}
	}
}
