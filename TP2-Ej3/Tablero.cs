using System;
using System.Collections.Generic;

namespace TP2Ej3
{
	public class Tablero
	{
		private String iPalabra;
		public String palabra
		{
			get{return this.iPalabra;}
			set{this.iPalabra = value;}
		}

		private Int16 iPuntaje;
		public Int16 puntaje
		{
			get{return this.iPuntaje;}
			set{this.iPuntaje = value;}

		}

		private Caracteres iListaDeCaracteres;
		public Caracteres listaDeCaracteres
		{
			get{return this.iListaDeCaracteres;}
			set{this.iListaDeCaracteres = value;}
		}

		public Boolean Intento(Char pLetra)
		{

			if (this.palabra.Contains(Convert.ToString(pLetra))==true)
			{

				if (this.listaDeCaracteres.CaracterUsado (pLetra) == true) {
					return true;
				}
				return false;
			}
			this.puntaje -= 1;
			return false;
		}

		public Boolean PuntajeEnCero()
		{
			if (this.puntaje == 0) 
			{
				return true;
			}
			return false;
		}

		public Tablero  (String pPalabra)
		{
			this.palabra = pPalabra;
			this.puntaje =10;
		}
		public Tablero  ()
		{

		}
	}
}

