namespace Ejercicios6_CROVARACarlosMarino
{
    internal abstract class Producto
    {
        protected int id;
        protected string nombre;
        protected float precioBase;

        public Producto() { }

        public Producto(int id, string nombre, float precioBase)
        {
            this.id = id;
            this.nombre = nombre;
            this.precioBase = precioBase;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public float PrecioBase
        {
            get => precioBase;
            set => precioBase = value;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"ID: {id}, Nombre: {nombre}, Precio base: $ {precioBase}");
        }
    }
}
