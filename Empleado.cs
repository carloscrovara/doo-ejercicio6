namespace Ejercicios6_CROVARACarlosMarino
{
    internal abstract class Empleado 
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected float sueldoBase;

        public Empleado() { }

        public Empleado(int id, string nombre, string apellido, float sueldoBase)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBase = sueldoBase;
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

        public float SueldoBase
        {
            get => sueldoBase;
            set => sueldoBase = value;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"ID: {id}, Nombre: {nombre}, Apellido: {apellido}, Sueldo calculado: {CalcularSueldo()}");
        }

        public abstract float CalcularSueldo();
    }
}