namespace Ejercicios6_CROVARACarlosMarino
{
    internal class Camion : Vehiculo
    {
        private float capacidadCarga;

        public Camion() : base() { }

        public Camion(int id, string marca, string modelo, int anio, float capacidadCarga) : base(id, marca, modelo, anio)
        {
            this.capacidadCarga = capacidadCarga;
        }
        
        public float CapacidadCarga
        {
            get => capacidadCarga;
            set => capacidadCarga = value;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Capacidad de carga del camión: {capacidadCarga}");
        }
    }
}