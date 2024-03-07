class Program
{
    private static void Main(string[] args)
    {
        //creamos nuestro primer objeto o instancia de tipo circulo

        Circulo miCirculo; // creación de objetio de tipo círculo. variable/objeto tipo circulo

        //Como inicamos la variable?

        miCirculo = new Circulo();//Iniciación de variable/objeto de tipo circulo, Instanciar una clase, 
                                  //instanciacion, ejemplarizacion, creacion de ejemplar de clase, se utiliza new

        Console.WriteLine(miCirculo.CalculoArea(5));

        Circulo miCirculo2 = new Circulo();   //segundo objeto que pertenece a la instancia miCirculo
        Console.WriteLine(miCirculo2.CalculoArea(9));
    }
}


class Circulo
{

    private const double pi = 3.1416; //Propiedad de la clase círculo, campo de clase. //Private encasula la variable pi

    public double CalculoArea(int radio) //método de clase: me expecifica que pueden hacer los objetos de tipo círculo
    {

        return pi * radio * radio;

    }


}