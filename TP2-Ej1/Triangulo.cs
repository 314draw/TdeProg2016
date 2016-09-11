using System;

namespace TP2Ej1
{
	public class Triangulo
	{
		private Punto iPunto1;
		private Punto iPunto2;
		private Punto iPunto3;

		public Punto Punto1
		{
			get{return this.iPunto1;}
			set{this.iPunto1 = value;}
		}
		
		public Punto Punto2
		{
			get{return this.iPunto2;}
			set{this.iPunto2 = value;}
		}
		
		public Punto Punto3
		{
			get{return this.iPunto3;}
			set{this.iPunto3 = value;}
		}
		/// <summary>
		/// Calcula el area aplicando la formula de Herón
		/// la raiz cuadrada del semiperimetro por la diferenecia entre el semi perimetro y cada lado
		/// </summary>
		public double Area()
		{
			double a = this.Punto1.CalcularDistanciaDesde (this.Punto2);
			double b = this.Punto2.CalcularDistanciaDesde (this.Punto3);
			double c = this.Punto3.CalcularDistanciaDesde(this.Punto1);
			double semiPerimetro= ((a+b+c)/2);
			return (Math.Sqrt(semiPerimetro*(semiPerimetro-a)*(semiPerimetro-b)*(semiPerimetro-c)));
		}
		/// <summary>
		/// Perimetro de el triangulo.
		/// </summary>
		public double Perimetro()
		{
			double a = this.Punto1.CalcularDistanciaDesde (this.Punto2);
			double b = this.Punto2.CalcularDistanciaDesde (this.Punto3);
			double c = this.Punto3.CalcularDistanciaDesde(this.Punto1);
			return (a + b + c);
		}
		/// <summary>
		/// Constructor de la clase
		/// </summary>
		/// <param name="pPunto1">vertice 1 del triangulo</param>
		/// <param name="pPunto2">vertice 2 del triangulo</param>
		/// <param name="pPunto3">vertice 3 del triangulo</param>
		public Triangulo (Punto pPunto1, Punto pPunto2,Punto pPunto3)
		{
			this.iPunto1 = pPunto1;
			this.iPunto2 = pPunto2;
			this.iPunto3 = pPunto3;
		}
	}
}

