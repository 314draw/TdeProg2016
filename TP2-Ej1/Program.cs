using System;

namespace TP2Ej1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Fachada ControladorFachada = new Fachada ();
			Console.WriteLine ("seleciones una opcion");
			Console.WriteLine ("1.Triangulo");
			Console.WriteLine ("2.Circulo usando 1 punto y el radio");
			Console.WriteLine ("3.Circulo usando valores en ejes X e Y y el radio");
			Console.WriteLine ("0.Salir");
			Int16 op = Convert.ToInt16 (Console.ReadLine ());
			while ((op==1)| (op==2) |(op==3)) {
				switch (op) 
				{
				case 1: 
					Console.Write ("ingrese el primer punto coordenada en eje X: ");
					double pX = Convert.ToDouble (Console.ReadLine ());
					Console.Write ("ingrese el primer punto coordenada en eje Y: ");
					double pY = Convert.ToDouble (Console.ReadLine ());
					Punto pPunto1 =ControladorFachada.ControladorPunto (pX, pY);
					Console.Write ("ingrese el Segundo punto coordenada en eje X: ");
					pX = Convert.ToDouble (Console.ReadLine ());
					Console.Write ("ingrese el Segundo punto coordenada en eje Y: ");
					pY = Convert.ToDouble (Console.ReadLine ());
					Punto pPunto2 =ControladorFachada.ControladorPunto (pX, pY);
					Console.Write ("ingrese el Tercer punto coordenada en eje X: ");
					pX = Convert.ToDouble (Console.ReadLine ());
					Console.Write ("ingrese el Tercer punto coordenada en eje Y: ");
					pY = Convert.ToDouble (Console.ReadLine ());
					Punto pPunto3 = ControladorFachada.ControladorPunto (pX, pY);
					ControladorFachada.ControladorTriangulo (pPunto1, pPunto2, pPunto3);
					break;
				case 2:
					Console.Write ("ingrese el primer punto coordenada en eje X: ");
					double pR = Convert.ToDouble (Console.ReadLine ());
					Console.Write ("ingrese el primer punto coordenada en eje Y: ");
					double pQ = Convert.ToDouble (Console.ReadLine ());
					Punto pCentro =ControladorFachada.ControladorPunto (pR, pQ);
					Console.Write ("ingrese el radio del circulo: ");
					double pRadio = Convert.ToDouble (Console.ReadLine ());
					ControladorFachada.ControladorCirculo (pCentro, pRadio);
					break;
				case 3:
					Console.Write ("ingrese el primer punto coordenada en eje X: ");
					double pS = Convert.ToDouble (Console.ReadLine ());
					Console.Write ("ingrese el primer punto coordenada en eje Y: ");
					double pT = Convert.ToDouble (Console.ReadLine ());
					Console.Write ("ingrese el radio del circulo: ");
					double pRadio2 = Convert.ToDouble (Console.ReadLine ());
					ControladorFachada.ControladorCirculo (pS, pT, pRadio2);
					break;

				}
				Console.WriteLine ("seleciones una opcion");
				Console.WriteLine ("1.Triangulo");
				Console.WriteLine ("2.Circulo usando 1 punto y el radio");
				Console.WriteLine ("3.Circulo usando valores en ejes X e Y y el radio");
				Console.WriteLine ("Presione otra tecla para salir");
				op = Convert.ToInt16 (Console.ReadLine ());
			}
			if (op == 0) 
			{
				Console.WriteLine ("Bye Bye ~(°-°)~");
			}
		}
	}
}
