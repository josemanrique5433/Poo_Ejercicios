class Program
{
    static void Main(string[] args)
    {
        //creamos objetos de tipo coche.

        Coche.coche1 = new Coche();// creamos objeto o instancia de tipo coche
                                   //damos un estado inicial a nuestro coche


        Coche.coche2 = new Coche();

        Console.WriteLine(coche2.getRuedas());
    }

}

class Coche
{
    //los comportamientos se determinan con las funciones o Métodos
    //Que es un contructor: cual es su comportamiento, su estado inicial, 
    //creamos un constructor:
    public Coche() //public nombre de la clase y parentecis. en este contructor definimos el estado inicial del coche

    {

        ruedas = 4;
        largo = 2300.5;
        ancho = 0.800;


    }
    //declaramos un metodo de acceso para que sea visible el constructor Coche.
    public int getRuedas()
    {
        return ruedas;

    }


    //características de los coches.
    private int ruedas;
    private double largo;
    private double ancho;
    private bool climatizador;
    private string tapiceria;


}