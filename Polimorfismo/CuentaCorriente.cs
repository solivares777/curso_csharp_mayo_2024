/*
 * Created by SharpDevelop.
 * User: Salvador Olivares
 * Date: 5/7/2024
 * Time: 8:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Polimorfismo
{
	/// <summary>
	/// Description of CuentaCorriente.
	/// </summary>
	public class CuentaCorriente: CuentaBancaria
	{
		public CuentaCorriente(string noCuenta) : base(noCuenta){
			
		}

		new public double CalcularIntereses (double saldo){
			System.Console.WriteLine("CuentaCorriente.Calcular Intereses ("); return saldo + saldo * 2.5/100;
		}
	}
}
