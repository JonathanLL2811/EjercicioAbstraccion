

namespace EjercicioAbstraccion
{
    public abstract class Padre
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }

     
        public abstract void MetodoAbstracto1();
        public abstract void MetodoAbstracto2();
        public abstract void MetodoAbstracto3();
    }

}
