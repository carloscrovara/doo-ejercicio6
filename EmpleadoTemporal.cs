namespace Ejercicios6_CROVARACarlosMarino
{
    internal class EmpleadoTemporal : Empleado 
    {
        protected int horasTrabajadas;
        protected float valorHora;

        public EmpleadoTemporal() : base() { }

        public EmpleadoTemporal(int id, string nombre, string apellido, float sueldoBase, int horasTrabajadas, float valorHora) : base(id, nombre, apellido, sueldoBase)
        {
            this.horasTrabajadas = horasTrabajadas;
            this.valorHora = valorHora;
        }

        public int HorasTrabajadas
        {
            get => horasTrabajadas;
            set => horasTrabajadas = value;
        }

        public float ValorHora
        {
            get => valorHora;
            set => valorHora = value;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"ID: {id}, Nombre: {nombre}, Apellido: {apellido}, Sueldo calculado: $ {CalcularSueldo()}");
        }

        public override float CalcularSueldo()
        {
            return horasTrabajadas * valorHora;
        }
    }
}