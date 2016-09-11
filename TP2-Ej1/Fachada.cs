using System;

namespace TP2Ej1
{
	public class Fachada
	{
		/// <summary>
		/// Controla los proceso del triangulo
		/// </summary>
		/// <param name="p1">Un vertice del triangulo.</param>
		/// <param name="p2">Un vertice del triangulo.</param>
		/// <param name="p3">Un vertice del triangulo.</param>
		public void ControladorTriangulo (Punto p1,Punto p2,Punto p3)
		{
			Triangulo triang = new Triangulo(p1,p2,p3);
			Console.WriteLine("El área del triangulo es: "+triang.Area()+" y el perimetro es: "+triang.Perimetro());
		}
	    /// <summary>
	    /// Controlador de clase Circulo.
	    /// </summary>
	    /// <param name="pX">Coordenada centro en eje x.</param>
	    /// <param name="pY">Coordenada centro en eje y.</param>
	    /// <param name="pRadio">Radio del circulo</param>
		public void ControladorCirculo(double pX, double pY, double pRadio)
		{
			Circulo circ = new Circulo (pX, pY, pRadio);
			Console.WriteLine("área del triangulo es: {0} y el perimetro es: {1}",circ.Area(),circ.Perimetro());
		}
		/// <summary>
		/// Controlador de clase Circulo
		/// </summary>
		/// <param name="pCentro">Punto del centro del Circulo</param>
		/// <param name="pRadio">Radio del circulo</param>
		public void ControladorCirculo(Punto pCentro, double pRadio)
		{
			Circulo circ = new Circulo (pCentro, pRadio);
			Console.WriteLine("área del triangulo es: {0} y el perimetro es: {1}",circ.Area(),circ.Perimetro());
		}
		/// <summary>
		/// Controlador de cracion de puntos.
		/// </summary>
		/// <returns>Un punto.</returns>
		/// <param name="pX">Valor en el eje x.</param>
		/// <param name="pY">Valor en el eje y.</param>
		public Punto ControladorPunto(double pX,double pY)
		{
			return new Punto (pX, pY);
		}
		/// <summary>
		/// Constructor de clase
		/// </summary>
		public Fachada ()
		{
		}
	}
}

