namespace Ejercicios6_CROVARACarlosMarino
{
    internal abstract class Persona
    {
        protected int id;
        protected string nombre;
        protected int edad;

        public Persona() { }

        public Persona(int id, string nombre, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
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

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Id: {id}, Nombre: {nombre}, Edad: {edad}");
        }
    }
}