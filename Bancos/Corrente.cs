using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bancos
{
	public class Corrente : IConta, IDepositavel
	{
		double saldo = 1000;

		public double GetSaldo()
		{
			return saldo;
		}



		public void depositar(double valor)
		{
			saldo -= 0.10;
			saldo += valor;
			Console.Clear();
			Console.WriteLine("Deposito de: R${0} efetuado com sucesso!", valor);
			
		}



		public void sacar(double valor)
		{
			saldo -= 0.10;
			saldo -= valor;
			Console.Clear();
			Console.WriteLine("Saque de: R${0} efetuado com sucesso!", valor);
			
		}

		public void verExtrato()
		{
			saldo -= 0.10;
			Console.Clear();
			Console.WriteLine("Seu extrato é de: R${0}", saldo);
			
		}
	}
}
