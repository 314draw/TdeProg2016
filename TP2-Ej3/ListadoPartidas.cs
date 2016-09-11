using System;
using System.Collections.Generic;


namespace TP2Ej3
{
	public class ListadoPartidas
	{
		private List<Partida> iListaPartidas;

		public List<Partida> listapartidas
		{
			get{return this.iListaPartidas;}
			set{ this.iListaPartidas = value;}
		}

		public ListadoPartidas ()
		{

		}
	}
}

