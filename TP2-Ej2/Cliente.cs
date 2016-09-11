using System;

namespace TP2Ej2
{
	public class Cliente
	{
		private String iNroDocumento;
		private String iNombre;
		private TipoDocumento iTipoDocumento;

		public String nroDocumento
		{
			get{return this.iNroDocumento;}
			set{this.iNroDocumento = value;}
		}

		public String nombre
		{
			get{ return this.iNombre;}
			set{ this.iNombre = value;}
		}

		public TipoDocumento tipoDocumento
		{
			get{return this.iTipoDocumento;}
			set{this.iTipoDocumento = value;}
		}
		/// <summary>
		/// Incializa una nueva instancia de la clase cliente.
		/// </summary>
		/// <param name="pTipoDocumento">Tipo de documento del cliente.</param>
		/// <param name="pNombre">Nombre del cliente.</param>
		/// <param name="pNroDocumento">Tipo de documento (DNI,CUIT,CUIL,LE,LC).</param>
		public Cliente (TipoDocumento pTipoDocumento,String pNombre,String pNroDocumento)
		{
			this.nombre = pNombre;
			this.nroDocumento = pNroDocumento;
			this.tipoDocumento = pTipoDocumento;
		}
	}
}

