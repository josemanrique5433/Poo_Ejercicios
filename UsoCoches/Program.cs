class Program
{
    static void Main(string[] args)
    {
        //creamos objetos de tipo coche.

        Coche coche1 = new Coche();// creamos objeto o instancia de tipo coche
                                   //damos un estado inicial a nuestro coche

        Console.WriteLine(coche1.getInfoCoche());

        Coche coche2 = new Coche();

        
        Console.WriteLine(coche2.getInfoCoche());

        Coche coche3 = new Coche(4500.25,1200.35);
        Console.WriteLine(coche3.getInfoCoche());
        coche3.setExtras(true, "Cuero");
        Console.WriteLine(coche3.getExtras());
       
    }

    partial class Coche
    {


        //los comportamientos se determinan con las funciones o Métodos
        //Que es un contructor: cual es su comportamiento, su estado inicial, 
        //creamos un constructor:
        public Coche() //public nombre de la clase y parentecis. en este contructor definimos el estado inicial del coche

        {

            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";


        }
    

        public Coche(double largoCoche, double anchoCoche)//Sobre carga de constructor. 
        {

            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";

        }
        

    }

    partial class Coche
    {
          
    public String getInfoCoche() //declaramos un metodo de acceso para que sea visible el constructor Coche.
    {
            return "Información del coche: \n " + " Ruedas: " + ruedas + " Largo: " + largo + " Ancho: " + ancho;

        }

        public void setExtras(bool Climatizador, String Tapiceria) //Primer metodo Setter
        {

            this.climatizador = Climatizador;
            this.tapiceria = Tapiceria;


        }

        public String getExtras()
        {



            return "Extras del Coche: \n" + " Tapiceria: " + tapiceria + " Climatizador: " + climatizador; 

        }

        //características de los coches.
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

    }
}