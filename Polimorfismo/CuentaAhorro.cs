/*
 * Created by SharpDevelop.
 * User: Salvador Olivares
 * Date: 5/7/2024
 * Time: 8:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Polimorfismo
{
	/// <summary>
	/// Description of CuentaAhorro.
	/// </summary>
	public class CuentaAhorro:CuentaBancaria
	{
			public CuentaAhorro (string noCuenta): base(noCuenta)
			{
			}
			new public double CalcularIntereses (double saldo)
			{
				System.Console.WriteLine("CuentaAhorro.Calcular Intereses ()"); 
				return saldo + saldo * 3.0/100;
			}
		
	}
}
