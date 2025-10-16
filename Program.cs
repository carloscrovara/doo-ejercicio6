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

        // Ejercicio 2
        List<Empleado> empleados = new List<Empleado>();
        
        empleados.Add(new EmpleadoPermanente(1, "Carlos", "Crovara", 50000, 5));
        empleados.Add(new EmpleadoTemporal(2, "Mariano", "González", 0, 100, 160));
        empleados.Add(new EmpleadoPermanente(3, "Alicia", "Gallardo", 60000, 10));
        empleados.Add(new EmpleadoTemporal(4, "Camila", "Vergara", 0, 80, 120));

        void AgregarEmpleado(Empleado e)
        {
            empleados.Add(e);
        }

        AgregarEmpleado(new EmpleadoPermanente(5, "Lucía", "Palermo", 55000, 3));

        void ModificarEmpleado(int id, string nuevoNombre, string nuevoApellido, float nuevoSueldoBase)
        {
            foreach (Empleado e in empleados)
            {
                if (e.Id == id)
                {
                    e.Nombre = nuevoNombre;
                    e.Apellido = nuevoApellido;
                    e.SueldoBase = nuevoSueldoBase;
                }
            }
        }

        ModificarEmpleado(2, "Mariano", "Gómez", 0);

        void EliminarEmpleado(int id)
        {
            Empleado empleadoAEliminar = null;

            foreach (Empleado e in empleados)
            {
                if (e.Id == id)
                {
                    empleadoAEliminar = e;
                }
            }

            if (empleadoAEliminar != null)
            {
                empleados.Remove(empleadoAEliminar);
            }
        }

        EliminarEmpleado(3);

        Console.WriteLine($"Ejercicio 2 - Sistema de empleados");
        Console.WriteLine();

        foreach (Empleado e in empleados)
        {
            e.MostrarInfo();
            Console.WriteLine();
        }
    }
}
