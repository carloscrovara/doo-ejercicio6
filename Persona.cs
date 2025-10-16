namespace Ejercicios6_CROVARACarlosMarino
{
    internal abstract class Persona
    {
        protected int id;
        protected string nombre;
        protected string apellido;

        public Persona() { }

        public Persona(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
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

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Id: {id}, Nombre: {nombre}, Apellido: {apellido}");
        }
    }
}