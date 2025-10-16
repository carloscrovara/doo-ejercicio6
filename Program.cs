namespace Ejercicios6_CROVARACarlosMarino;

class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        vehiculos.Add(new Auto(1, "Ford", "Ranger", 2025, 4));
        vehiculos.Add(new Moto(2, "Honda", "ADDF-4233", 2024, 300));
        vehiculos.Add(new Camion(3, "Ford", "F-150", 2023, 1000));
        vehiculos.Add(new Camion(4, "Ford", "F-350", 2024, 2000));

        void AgregarVehiculo(Vehiculo v)
        {
            vehiculos.Add(v);
        }

        AgregarVehiculo(new Auto(5, "Chevrolet", "Onix", 2022, 5));

        void ModificarVehiculo(int id, string nuevaMarca, string nuevoModelo, int nuevoAnio)
        {
            foreach (Vehiculo v in vehiculos)
            {
                if (v.Id == id)
                {
                    v.Marca = nuevaMarca;
                    v.Modelo = nuevoModelo;
                    v.Anio = nuevoAnio;
                }
            }
        }

        ModificarVehiculo(2, "Yamaha", "YZF-313", 2025);

        void EliminarVehiculo(int id)
        {
            Vehiculo vehiculoAEliminar = null;

            foreach (Vehiculo v in vehiculos)
            {
                if (v.Id == id)
                {
                    vehiculoAEliminar = v;
                }
            }

            if (vehiculoAEliminar != null)
            {
                vehiculos.Remove(vehiculoAEliminar);
            }
        }

        EliminarVehiculo(3);

        Console.WriteLine($"Ejercicio 1 - Gestión de vehículos");
        Console.WriteLine();
        
        foreach (Vehiculo v in vehiculos)
        {
            v.MostrarInfo();
            Console.WriteLine();
        }
    }
}
