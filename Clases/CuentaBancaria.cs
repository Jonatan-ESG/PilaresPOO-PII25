using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO.Clases
{
	public class CuentaBancaria
	{
		private decimal saldo;
		private string nombreUsuario;
		private string password;
		private List<string> movimientos;

		public CuentaBancaria (string usuario, string password, decimal saldoInicial = 0)
		{
			this.nombreUsuario = usuario;
			this.password = password;
			this.saldo = saldoInicial;
		}

		public void Depositar(decimal montoDeposito) { 

			if(montoDeposito > 0)
			{
				saldo += montoDeposito;
			}

		}

		public decimal ObtenerSaldo(string usuario, string password) {
			
			if (usuario != this.nombreUsuario || password != this.password) {
				return 0;
			}

			return saldo;
		}


	}
}
