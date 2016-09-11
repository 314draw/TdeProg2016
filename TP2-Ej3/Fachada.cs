using System;
using System.Collections.Generic;

namespace TP2Ej3
{
	public class Fachada
	{
		public void ControladorCrearLista(string[] args, Palabras plista)
		{
			for (int i=0; i<30; i++) 
			{
				plista.AgregrarPalabras (args [i]);
			}
		}

		public void ControladorPartidaNueva(Partida pPartida,String pNombre,Tablero pTablero,Palabras pLista)
		{
			pPartida = new Partida (pNombre);
			pTablero = new Tablero (pLista.SelectorPalabra ());


		}

		public Boolean controladorNuevoIntento(Char pLetra,Tablero pTablero)
		{
			return pTablero.Intento (pLetra);
		}

		public Boolean controladorFinDeJuego(Tablero pTablero)
		{
			return pTablero.PuntajeEnCero ();
		}



		public Fachada ()
		{
		}
	}
}

