using EjercicioAbstraccion;

internal class Program
{
    class Programa
    {
        static void Main()
        {
      
            Hijo1 hijo1 = new Hijo1
            {
                Nombre = "Juan",
                Edad = 25,
                Genero = "Masculino",
                Direccion = "Calle Principal, tegucigalpa",
                Hobby = "Pintar"
            };

            Hijo2 hijo2 = new Hijo2
            {
                Nombre = "María",
                Edad = 20,
                Genero = "Femenino",
                Direccion = "Calle Nueva, Tela",
                Calificacion = 9.5f
            };

          
            Console.WriteLine("Información del Hijo1:");
            hijo1.MostrarInfoHijo1();
            hijo1.MetodoAbstracto1();
            hijo1.MetodoAbstracto2();
            hijo1.MetodoAbstracto3();

            Console.WriteLine("\nInformación del Hijo2:");
            hijo2.MostrarInfoHijo2();
            hijo2.MetodoAbstracto1();
            hijo2.MetodoAbstracto2();
            hijo2.MetodoAbstracto3();
        }
    }
}