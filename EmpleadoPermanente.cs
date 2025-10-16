namespace Ejercicios6_CROVARACarlosMarino
{
    internal class EmpleadoPermanente : Empleado
    {
        protected int antiguedad;
        public EmpleadoPermanente() : base() { }

        public EmpleadoPermanente(int id, string nombre, string apellido, float sueldoBase, int antiguedad) : base(id, nombre, apellido, sueldoBase)
        {
            this.antiguedad = antiguedad;
        }

        public int Antiguedad
        {
            get => antiguedad;
            set => antiguedad = value;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"ID: {id}, Nombre: {nombre}, Apellido: {apellido}, Sueldo calculado: $ {CalcularSueldo()}");
        }

        public override float CalcularSueldo()
        {
            float adicional = sueldoBase * 0.01f * antiguedad;
            return sueldoBase + adicional;
        }
    }
}