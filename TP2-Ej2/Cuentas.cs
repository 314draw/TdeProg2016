using System;

namespace TP2Ej2
{
	public class Cuentas
	{
		private Cliente iCliente;
		private Cuenta iCajaDeAhorro;
		private Cuenta iCuentaCorriente;

		public Cuenta CajaDeAhorro
		{
			get{ return this.iCajaDeAhorro;}
			set{ this.iCajaDeAhorro = value;}
		}
		public Cuenta CuentaCorriente
		{
			get{return this.iCuentaCorriente;}
			set{this.iCuentaCorriente = value;}
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="TP2Ej2.Cuentas"/> class.
		/// </summary>
		public Cuentas ()
		{
			this.iCliente = new Cliente (TipoDocumento.DNI, 'Pedro', '654.321.987');
			this.CajaDeAhorro=new Cuenta();
			this.iCuentaCorriente = new Cuenta ();

		}
	}
}

