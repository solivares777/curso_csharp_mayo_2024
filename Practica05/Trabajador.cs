/*
 * Created by SharpDevelop.
 * User: Salvador Olivares
 * Date: 5/7/2024
 * Time: 8:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica05
{
	/// <summary>
	/// Description of Trabajador.
	/// </summary>
	public class Trabajador
	{
		private string noDui; 
		
		public string NoDui {
			get { return noDui; }
			set { noDui = value; }
		}
		
	    private string nombre; 
	    
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
	    
	    private string cargo;
	    
		public string Cargo {
			get { return cargo; }
			set { cargo = value; }
		}
	    
	    public void guardar(){
        	Console.WriteLine("Guardando");
	    }
	    
	    public void consultar() {
	        Console.WriteLine("Consultando");
	    }
	    
	    public void modificar(){
	        Console.WriteLine("Modificando");
	    }
	    
	    public void eliminar(){
	        Console.WriteLine("Eliminando");
	    }
	    
	}
}
