using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bancos
{
	public class Program
	{
		public static void Main(string[] args)
		{



			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine("BEM VINDO AO BANCO KADABRA!");
			Console.WriteLine(" ");
			Console.WriteLine(" ");

			Contas contas = new Contas();
			Corrente corrente = new Corrente();
			Poupanca poupanca = new Poupanca();
			Salario salario = new Salario();

			while (true)
			{
				
				Console.WriteLine("1- Conta corrente!");
				Console.WriteLine("2- Conta poupança!");
				Console.WriteLine("3- Conta salário!");
				Console.WriteLine("0 - Fechar");
				String banco = Console.ReadLine();


				if (banco == "1")
				{
					Console.Clear();
					while (true)
					{
						Console.WriteLine("CONTA CORRENTE");
						Console.WriteLine("1- Ver extrato!");
						Console.WriteLine("2- Depositar!");
						Console.WriteLine("3- Sacar!");
						Console.WriteLine("4- Voltar!");

						String acao = Console.ReadLine();

						if (acao == "1")
						{
							contas.verExtrato(corrente);

						}
						else if (acao == "2")
						{
							depositando(contas, corrente);
						}
						else if (acao == "3")
						{
							sacando(contas, corrente);
							
						}
						else if (acao == "4")
						{
							Console.Clear();
							break;
						}
						else
						{
							Console.Clear();
							Console.WriteLine("Opção não encontrada, tente novamente!");
						}
					}

				}
				else if (banco == "2")
				{//opçoes da poupança
					Console.Clear();
					while (true)
					{
						Console.WriteLine("CONTA POUPANÇA");
						Console.WriteLine("1- Ver extrato!");
						Console.WriteLine("2- Depositar!");
						Console.WriteLine("3- Sacar!");
						Console.WriteLine("4- Voltar!");

						String acao = Console.ReadLine();
						if (acao == "1")
						{//ver extrato
							contas.verExtrato(poupanca);
						}
						else if (acao == "2")
						{
							depositando(contas, poupanca);
						}
						else if (acao == "3")
						{
							sacando(contas, poupanca);
						}
						else if (acao == "4")
						{
							Console.Clear();
							break;
						}
						else
						{
							Console.Clear();
							Console.WriteLine("Opção não encontrada, tente novamente!");
						}
					}
				}
				else if (banco == "3")
				{//opçoes da salario
					Console.Clear();
					while (true)
					{
						Console.WriteLine("CONTA SALÁRIO");
						Console.WriteLine("1- Ver extrato!");
						Console.WriteLine("2- Sacar!");
						Console.WriteLine("3- Voltar!");
						String acao = Console.ReadLine();
						if (acao == "1")
						{//ver extrato
							contas.verExtrato(salario);
						}
						else if (acao == "2")
						{
							sacando(contas, salario);
						}
						else if (acao == "3")
						{
							Console.Clear();
							break;
						}
						else
						{
							Console.Clear();
							Console.WriteLine("Opção não encontrada, tente novamente!");
						}
					}
				}
				else if (banco == "0")
				{

					System.Environment.Exit(0);

				}
				else
				{//Error
					Console.Clear();
					Console.WriteLine("Opção não encontrada, tente novamente!");
				}

			}
		}
		public static void depositando(Contas contas, IDepositavel depositavel)
		{
			Console.WriteLine("Digite o valor que deseja depositar!");
			Console.Write("R$");
			string transformacao = Console.ReadLine();
			transformacao = transformacao.Replace(@".", ",");
			transformacao = Regex.Replace(transformacao, "[^0-9^ ,]", "");


			
			if (transformacao == "")
			{
				Console.Clear();
				Console.WriteLine("Impossível depositar um valor nulo!");
			}
			else
			{
				double deposito = Convert.ToDouble(transformacao);
				while (true)
				{
					if (deposito == 0)
					{
						Console.Clear();
						Console.WriteLine("Impossível depositar um valor nulo!");
					}
					else
					{

						Console.WriteLine("Deseja realmente depositar o valor de R${0}?", deposito);
						Console.WriteLine("1 - Sim");
						Console.WriteLine("2 - Não");
						String depositar = Console.ReadLine();
						if (depositar == "1")
						{
							contas.depositar(depositavel, deposito);
							break;

						}
						else if (depositar == "2")
						{
							Console.Clear();
							Console.WriteLine("Deposito cancelado com sucesso!");
							break;

						}
						else
						{
							Console.Clear();
							Console.WriteLine("Digito inválido!");
						}
					}
				}

			}
		}
			public static void sacando(Contas contas, IConta conta)
			{
				
			Console.WriteLine("Digite o valor que deseja sacar!");
			Console.Write("R$");
			String transformacao = Console.ReadLine();
			transformacao = transformacao.Replace(@".", @",");
			transformacao = Regex.Replace(transformacao, "[^0-9^ ,]", "");

			if (transformacao == "")
			{
				Console.Clear();
				Console.WriteLine("Impossível sacar um valor nulo!");
			}
			else
			{
				double saque = Convert.ToDouble(transformacao);
				if (conta.GetSaldo() - saque >= -1000)
				{
					if (saque == 0)
					{
						Console.Clear();
						Console.WriteLine("Impossível sacar um valor nulo!");
					}
					else
					{

						while (true)
						{

							Console.WriteLine("Deseja realmente sacar o valor de R${0}?", saque);
							Console.WriteLine("1 - Sim");
							Console.WriteLine("2 - Não");
							String sacar = Console.ReadLine();
							if (sacar == "1")
							{
								contas.sacar(conta, saque);
								break;
							}
							else if (sacar == "2")
							{
								Console.Clear();
								Console.WriteLine("Saque cancelado com sucesso!");
								break;
							}
							else
							{
								Console.Clear();
								Console.WriteLine("Digito inválido!");
							}
						}
					}
				}
				else
				{
					Console.Clear();
					Console.WriteLine("Impossível sacar! Limite alcançado!");
				}
			}
		

		}
	}
}
