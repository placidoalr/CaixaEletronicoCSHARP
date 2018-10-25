using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bancos
{
	public class Poupanca : IConta, IDepositavel
	{
		double saldo = 1000;
		int cont = 0;

		public void depositar(double valor)
		{
			saldo = saldo * 1.02;
			saldo += valor;
			Console.Clear();
			Console.WriteLine("Deposito de: R${0} efetuado com sucesso!", valor);
			
		}

		public double GetSaldo()
		{
			return saldo;
		}

		public void sacar(double valor)
		{
			saldo -= valor;
			Console.Clear();
			Console.WriteLine("Saque de: R${0} efetuado com sucesso!", valor);
			
		}

		public void verExtrato()
		{
			Console.Clear();
			Console.WriteLine("Seu extrato é de: R${0}", saldo);
			
			cont += 1;
			if(cont == 3)
			{
				saldo = saldo * 1.02;
				cont = 0;
			}
		}
	}
}
