using System;

namespace TP2Ej1
{
	public class Punto
	{

		private double iX;
		private double iY;

		public double X
		{
			get{return this.iX;}
			set{this.iX = value;}
		}
		public double Y
		{
			get{return this.iY;}
			set{this.iY = value;}
		}
		/// <summary>
		/// Calcula la distancia desde el punto a otro punto ingresado
		/// </summary>
		/// <returns>Distancia entre dos puntos</returns>
		/// <param name="pPunto"> Punto que se toma como extremo y el objeto actual se toma como el punto origen</param>
		public double CalcularDistanciaDesde( Punto pPunto)
		{
			return (Math.Sqrt (Math.Pow (pPunto.X - this.X,2) + Math.Pow (pPunto.Y - this.Y, 2)));
		}
		/// <summary>
		/// Constructo de la clase punto
		/// </summary>
		/// <param name="pX">P coordenada del eje x</param>
		/// <param name="pY">P coordenada del eje y</param>
		public Punto (double pX, double pY)
		{
			this.iX=pX;
			this.iY=pY;
		}
	}
}

