using System;
using System.Collections.Generic;

namespace TP2Ej3
{
	public class Caracteres
	{
		private List<Char> iLetras;
		public List<Char> letras
		{
			get{return this.iLetras;}
		}
		private List<Int16> iUtilizado;
		public List<Int16> utilizado
		{
			get{return this.iUtilizado;}
			set{this.iUtilizado = value;}
		}

		public Boolean CaracterUsado(Char pLetra)
		{
			if(utilizado.Contains(this.letras.FindIndex(pLetra))==false)
			{
				this.utilizado.Add(iLetras.FindIndex (pLetra));
				return true;              
		    }
			return false;
		}

		public Caracteres ()
		{
			this.iLetras.Add ('A');
			this.iLetras.Add ('B');
			this.iLetras.Add ('C');
			this.iLetras.Add ('D');
			this.iLetras.Add ('E');
			this.iLetras.Add ('F');
			this.iLetras.Add ('G');
			this.iLetras.Add ('H');
			this.iLetras.Add ('I');
			this.iLetras.Add ('J');
			this.iLetras.Add ('K');
			this.iLetras.Add ('L');
			this.iLetras.Add ('M');
			this.iLetras.Add ('N');
			this.iLetras.Add ('Ñ');
			this.iLetras.Add ('O');
			this.iLetras.Add ('P');
			this.iLetras.Add ('Q');
			this.iLetras.Add ('R');
			this.iLetras.Add ('S');
			this.iLetras.Add ('T');
			this.iLetras.Add ('U');
			this.iLetras.Add ('V');
			this.iLetras.Add ('W');
			this.iLetras.Add ('X');
			this.iLetras.Add ('Y');
			this.iLetras.Add ('Z');
		}
	}
}

