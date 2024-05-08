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
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string noCarnet;
		
		public string NoCarnet {
			get { return noCarnet; }
			set { noCarnet = value; }
		}
		private string nombre;
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		private string departamento;
		
		public string Departamento {
			get { return departamento; }
			set { departamento = value; }
		}
		
		
	}
}
