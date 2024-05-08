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
	/// <summary>
	/// Description of CuentaBancaria.
	/// </summary>
	public class CuentaBancaria
	{
		private string noCuenta; // Número de la cuenta
    
	    public CuentaBancaria(string noCuenta){
	        this.noCuenta = noCuenta; 
	        System.Console.WriteLine("Instancia creada para cuenta bancaria {0}", noCuenta);
	    }
	
	    public double CalcularIntereses (double saldo){
	        System.Console.WriteLine("CuentaBancaria.Calcular Intereses ()"); 
	        return 0.0;
	    }
	}
}
