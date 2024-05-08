/*
 * Created by SharpDevelop.
 * User: Salvador Olivares
 * Date: 5/7/2024
 * Time: 8:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Herencia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Empleado emp = new Empleado();
			
			emp.Cargo="Desarrollador"; 
			emp.Departamento="Tecnologia"; 
			emp.NoCarnet="OA2817";
			emp.Salario=1000.00;
			emp.Nombre="Mauricio Torres";
			
			Console.WriteLine("El carnet es: {0}", emp.NoCarnet); 
			Console.WriteLine("El nombres es: {0}", emp. Nombre);
			Console.WriteLine("El departamento es: {0}", emp. Departamento);
			Console.WriteLine("El Cargo es: {0}", emp.Cargo); 
			Console.WriteLine("El salario es: {0}", emp.Salario);
			Console.ReadKey(true);
		}
	}
}