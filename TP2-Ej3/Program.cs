using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2Ej3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Fachada unfacade = new Fachada ();
			Palabras lista=new Palabras();
			unfacade.ControladorCrearLista (args, lista);
			Console.Write("ingrese su nombre: ");
			String nombre = Console.ReadLine ();
			Partida unaPartida= new Partida();
			Tablero unTablero = new Tablero ();
			unfacade.ControladorPartidaNueva (unaPartida, nombre,unTablero,lista);
			for (int i=0; i<unTablero.palabra.Length; i++) 
			{
				Console.Write("*");
			}


		}
	}
}
