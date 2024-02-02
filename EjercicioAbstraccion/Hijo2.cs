
namespace EjercicioAbstraccion
{
    public class Hijo2 : Padre
    {
        public float Calificacion { get; set; }

        public override void MetodoAbstracto1()
        {
            Console.WriteLine($"¡Hola! Soy {Nombre}, y mi calificación es {Calificacion}.");
        }

        public override void MetodoAbstracto2()
        {
            Console.WriteLine($"¡{Nombre} dice hola desde la implementación del MétodoAbstracto2 en Hijo2!");
        }

        public override void MetodoAbstracto3()
        {
            Console.WriteLine($"Edad de {Nombre}: {Edad}. Género: {Genero}.");
        }

        public void MostrarInfoHijo2()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Calificación: {Calificacion}");
        }
    }

}
