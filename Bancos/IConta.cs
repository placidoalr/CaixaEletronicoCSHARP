using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancos
{
	public interface IConta
	{
		double GetSaldo();

		void verExtrato();

		void sacar(double valor);
	}
}
