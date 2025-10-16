namespace Ejercicios6_CROVARACarlosMarino
{
    internal abstract class Vehiculo
    {
        protected int id;
        protected string marca;
        protected string modelo;
        protected int anio; 

        public Vehiculo() { }

        public Vehiculo(int id, string marca, string modelo, int anio)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Marca
        {
            get => marca;
            set => marca = value;
        }

        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }

        public int Anio
        {
            get => anio;
            set => anio = value;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"ID: {id}, Marca: {marca}, Modelo: {modelo}, Año: {anio}");
        }
    }
}