/*
 * Created by SharpDevelop.
 * User: Salvador Olivares
 * Date: 5/7/2024
 * Time: 8:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Polimorfismo
{
	class Program
	{
		const string noCuenta = "1480227902";
		
		public static void Main(string[] args)
		{
			// Creamos instancia de clase base
			CuentaBancaria cuenta = new CuentaBancaria(noCuenta);
			// Creamos instancia de clase derivada
			
			CuentaCorriente cuentaCorriente = new CuentaCorriente (noCuenta);
			// Creamos instancia de clase derivada
			
			CuentaAhorro cuentaAhorro = new CuentaAhorro(noCuenta);
			// Invocamos método de la clase base
			
			cuenta.CalcularIntereses(100.00);
			
			double saldoCuentaCorriente = cuentaCorriente.CalcularIntereses(100.00);
			
			//Invocamos método de la clase derivada
			double saldoCuentaAhorro = cuentaAhorro.CalcularIntereses(100.00);
			
			Console.WriteLine("Saldo Cuenta Ahorro: {0}", saldoCuentaCorriente); Console.WriteLine("Saldo Cuenta Ahorro: {0} ", saldoCuentaAhorro);
			
			Console.ReadKey(true);
		}
	}
}