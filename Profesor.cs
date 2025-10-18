namespace Ejercicios6_CROVARACarlosMarino
{
    internal class Profesor : Persona
    {
        protected string materia;
        protected float sueldo;

        public Profesor() : base() { }

        public Profesor(int id, string nombre, int edad, string materia, float sueldo) : base(id, nombre, edad)
        {
            this.materia = materia;
            this.sueldo = sueldo;
        }

        public string Materia
        {
            get => materia;
            set => materia = value;
        }

        public float Sueldo
        {
            get => sueldo;
            set => sueldo = value;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Materia del profesor: {materia}, Sueldo: $ {sueldo}");
        }
    }
}