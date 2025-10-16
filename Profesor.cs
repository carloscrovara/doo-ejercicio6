namespace Ejercicios6_CROVARACarlosMarino
{
    internal class Profesor : Persona
    {
        private string materia;
        private float sueldo;

        public Profesor() : base() { }

        public Profesor(int id, string nombre, string apellido, string materia, float sueldo) : base(id, nombre, apellido)
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