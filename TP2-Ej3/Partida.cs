using System;

namespace TP2Ej3
{
	public class Partida
	{
		private String iNombre;
		private Int16 iPuntaje;
		private DateTime iFechaInicio;
		private DateTime iFechaFin;
		private Boolean iResultado;

		public String nombre
		{
			get{ return this.iNombre;}
			set{ this.iNombre = value;}
		}

		public Int16 puntaje
		{
			get{return this.iPuntaje;}
			set{ this.iPuntaje = value;}
		}

		public DateTime fechaInicio
		{
			get { return this.iFechaInicio;}
			set { this.iFechaInicio = value;}
		}

		public DateTime fechaFin
		{
			get { return this.iFechaFin;}
			set { this.iFechaFin = value;}
		}

		public Boolean resultado
		{
			get {return this.iResultado;}
			set{this.iResultado = value;}
		}

		public void LimitePuntaje(Int16 pPuntaje)
		{
			this.puntaje = pPuntaje;
		}
		public Partida (String pNombre)
		{
			this.nombre = pNombre;
			this.fechaInicio = DateTime.Now;
			this.iResultado = false;
		}
		public Partida ()
		{
		
		}
	}
}

