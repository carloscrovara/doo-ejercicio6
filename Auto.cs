namespace Ejercicios6_CROVARACarlosMarino
{
    internal class Auto : Vehiculo
    {
        protected int cantidadPuertas;

        public Auto() : base() { }

        public Auto(int id, string marca, string modelo, int anio, int cantidadPuertas) : base(id, marca, modelo, anio)
        {
            this.cantidadPuertas = cantidadPuertas;
        }

        public int CantidadPuertas
        {
            get => cantidadPuertas;
            set => cantidadPuertas = value;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Cantidad de puertas del auto: {cantidadPuertas}");
        }
    }
}