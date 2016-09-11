using System;

namespace TP2Ej1
{
	public class Circulo
	{
		private double iRadio;
		private Punto iCentro;

		public double radio
		{
			get{return this.iRadio;}
			set{ this.iRadio = value;}
		}
		public Punto centro
		{
			get{return this.iCentro;}
			set{this.iCentro = value;}
		}
		/// <summary>
		/// Calcula el área de un circulo.
		/// </summary>
		public double Area()
		{
			return (Math.Pow (this.radio,2) * Math.PI);
		}
		/// <summary>
		/// Devuelve el perimetro del circulo.
		/// </summary>
		public double Perimetro()
		{
			return (Math.PI * this.radio * 2);
		}
		/// <summary>
		/// Inicializa una instacia de la clase circulo <see cref="TP2Ej1.Circulo"/>.
		/// </summary>
		/// <param name="pCentro">Variable de tipo punto que representa el centro del circulo</param>
		/// <param name="pRadio">Radio del circulo.</param>
		public Circulo (Punto pCentro, double pRadio)
		{
			this.radio = pRadio;
			this.centro = pCentro;

		}
		/// <summary>
		/// Inicializa una instancia de la clase circulo<see cref="TP2Ej1.Circulo"/>.
		/// </summary>
		/// <param name="pX">Valor en el eje x</param>
		/// <param name="pY">Valor en el eje y</param>
		/// <param name="pRadio">Radio del circulo</param>
		public Circulo(double pX, double pY, double pRadio)
		{
			Punto pAux = new Punto (pX, pY);
			this.centro = pAux;
			this.radio = pRadio;

		}
	}
}

