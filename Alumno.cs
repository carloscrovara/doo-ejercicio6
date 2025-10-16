namespace Ejercicios6_CROVARACarlosMarino
{
    internal class Alumno : Persona 
    {
        private int legajo;
        private float promedio;

        public Alumno() : base() { }

        public Alumno(int id, string nombre, string apellido, int legajo, float promedio) : base(id, nombre, apellido)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public int Legajo
        {
            get => legajo;
            set => legajo = value;
        }

        public float Promedio
        {
            get => promedio;
            set => promedio = value;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Legajo del alumno: {legajo}, Promedio: {promedio}");
        }
    }
}