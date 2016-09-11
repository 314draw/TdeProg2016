using System;

namespace TP2Ej2
{
	public class Cuenta
	{
		private double iSaldo;
		private double iAcuerdo;

		public double saldo
		{
			get{ return this.iSaldo;}
			set{this.iSaldo = value;}
		}
		public double acuerdo
		{
			get{ return this.iAcuerdo;}
			set{this.iAcuerdo = value;}
		}
		public void AcreditarSaldo(double pSaldo)
		{
			this.saldo += pSaldo;
		}

		public Boolean DebitarSaldo (double pSaldo)
		{
			if (this.saldo>=pSaldo)
			{
				if (this.acuerdo >= pSaldo) 
				{
					return true;
					this.saldo -= pSaldo;
				}
				return false;
			}
			return false;
		}
		/// <summary>
		/// Inicializa una nueva instancia de la clase cuenta utilizando un acuerdo de descubierto.
		/// </summary>
		/// <param name="pAcuerdo">Acuerdo de descubierto</param>
 		public Cuenta (double pAcuerdo)
		{
			this.acuerdo = pAcuerdo;
			this.saldo = 0;
		}
		/// <summary>
		/// Inicializa una nueva instancia de la clase cuenta utilizando un acuerdo de descubierto
		/// y el saldo inicial de la cuenta.
		/// </summary>
		/// <param name="pSaldoInicial">Saldo inicial de la cuenta.</param>
		/// <param name="pAcuerdo">Acuerdo de descubierto</param>
		public Cuenta (double pSaldoInicial,double pAcuerdo)
		{
			this.saldo = pSaldoInicial;
			this.acuerdo = pAcuerdo;
		}
	}
}

