using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancos
{
	class Salario : IConta
	{
		public double saldo = 1000;

		public double GetSaldo()
		{
			return saldo;
		}

		

		public void sacar(double valor)
		{
			Console.Clear();
			saldo -= valor;
			Console.WriteLine("Saque de: R${0} efetuado com sucesso!", valor);
			
		}

		public void verExtrato()
		{
			Console.Clear();
			Console.WriteLine("Seu extrato é de: R${0}", saldo);
			
		}
	}
}
