namespace Ejercicios6_CROVARACarlosMarino;

class Program
{
    static void Main(string[] args)
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        vehiculos.Add(new Auto(1, "Ford", "Ranger", 2025, 4));
        vehiculos.Add(new Moto(2, "Honda", "ADDF-4233", 2024, 300));
        vehiculos.Add(new Camion(3, "Ford", "F-150", 2023, 1000));

        foreach (Vehiculo v in vehiculos)
        {
            v.MostrarInfo();
            Console.WriteLine();
        }
    }
}
