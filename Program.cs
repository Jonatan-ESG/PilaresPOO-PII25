using PilaresPOO.Clases;

internal class Program
{
	private static void Main(string[] args)
	{
		CuentaBancaria cuentaNueva = new CuentaBancaria("jsandoval", "12345678", 300);

		cuentaNueva.Depositar(100);

		Console.WriteLine(cuentaNueva.ObtenerSaldo("jsandval", "12345678"));
	}
}