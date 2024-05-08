/*
 * Created by SharpDevelop.
 * User: Salvador Olivares
 * Date: 5/7/2024
 * Time: 8:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Trabajador t = new Trabajador();
        
	        t.NoDui="021000089"; 
	        t.Nombre="Roberto Lopez"; 
	        t.Cargo="Analista de Sistemas";
	        
	        Console.WriteLine("No Dui: {0}", t.NoDui); 
	        Console.WriteLine("Nombre: {0}", t. Nombre); 
	        Console.WriteLine("Cargo: {0}", t.Cargo);
	        t.guardar(); 
	        t.consultar(); 
	        t.modificar(); 
	        t.eliminar();
	        Console.ReadKey(true);
		}
	}
}