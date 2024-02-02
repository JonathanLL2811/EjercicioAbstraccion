
namespace EjercicioAbstraccion
{
    public class Hijo1 : Padre
    {
        public string Hobby { get; set; }

        public override void MetodoAbstracto1()
        {
            Console.WriteLine($"¡Hola! Soy {Nombre}, y mi hobby es {Hobby}.");
        }

        public override void MetodoAbstracto2()
        {
            Console.WriteLine($"¡{Nombre} dice hola desde la implementación del MétodoAbstracto2 en Hijo1!");
        }

        public override void MetodoAbstracto3()
        {
            Console.WriteLine($"Edad de {Nombre}: {Edad}. Dirección: {Direccion}.");
        }

        public void MostrarInfoHijo1()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Hobby: {Hobby}");
        }
    }


}
