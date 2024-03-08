internal class Program
{
    private static void Main(string[] args)
    {
        ConversorEuroDolar obj = new ConversorEuroDolar();

        obj.cambiaValorEuro(1.05);

        Console.WriteLine(obj.Convierte(50));

    }
}
class ConversorEuroDolar
{

    private double euro = 1.253;

    public double Convierte(double cantidad)
    {


        return cantidad * euro;
    }
    public void cambiaValorEuro(double nuevoValor)
    {
        if (nuevoValor < 0) euro = 1.253;
        else euro = nuevoValor;
    
        euro = nuevoValor;
    
    }
}