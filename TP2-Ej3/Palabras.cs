using System;
using System.Collections.Generic;


namespace TP2Ej3
{
	public class Palabras
	{
		private List<String> iListaPalabras;

		public List<String> listaPalabras
		{
			get{ return this.iListaPalabras;}
			set{this.iListaPalabras = value;}
		}

		public String SelectorPalabra()
		{
			Random rnd = new Random ();
			Int16 indice= Convert.ToInt16(rnd.Next (1, 30));

			return this.listaPalabras [indice];
		}
		public void AgregrarPalabras(String pPalabra)
		{
			Random rnd = new Random ();
			Int16 indice=Convert.ToInt16( rnd.Next (1, 30));
			this.listaPalabras [indice] = pPalabra;
		}

		public void AgregarPalabra (String pPalabra)
		{
			this.listaPalabras.Add (pPalabra);
		}
		public Palabras ()
		{
		}
	}
}

