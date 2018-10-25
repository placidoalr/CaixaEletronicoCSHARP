using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancos
{
	public class Contas
	{
		public void verExtrato(IConta c)
		{
			c.verExtrato();
		}
		public void sacar(IConta c, double valor)
		{
			c.sacar(valor);
		}
		public void depositar(IDepositavel d, double valor)
		{
			d.depositar(valor);
		}
	}
}
