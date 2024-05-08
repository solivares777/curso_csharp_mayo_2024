/*
 * Created by SharpDevelop.
 * User: Salvador Olivares
 * Date: 5/7/2024
 * Time: 8:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Herencia
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado:Persona
	{
		private String cargo;
		
		public string Cargo {
			get { return cargo; }
			set { cargo = value; }
		}
		private double salario;
		
		public double Salario {
			get { return salario; }
			set { salario = value; }
		}
		private string jefe;
		
		public string Jefe {
			get { return jefe; }
			set { jefe = value; }
		}
	}
}
