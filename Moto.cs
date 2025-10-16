namespace Ejercicios6_CROVARACarlosMarino
{
    internal class Moto : Vehiculo
    {
        private int cilindrada;

        public Moto() : base() { }

        public Moto(int id, string marca, string modelo, int anio, int cilindrada) : base(id, marca, modelo, anio)
        {
            this.cilindrada = cilindrada;
        }
        
        public int Cilindrada
        {
            get => cilindrada;
            set => cilindrada = value;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Cilindrada: {cilindrada}");
        }
    }
}