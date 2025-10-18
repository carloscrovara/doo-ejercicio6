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

        void ModificarVehiculo(
            int id, 
            string nuevaMarca, 
            string nuevoModelo, 
            int nuevoAnio, 
            int? nuevasPuertas = null, 
            int? nuevaCilindrada = null, 
            int? nuevaCarga = null)
        {
            foreach (Vehiculo v in vehiculos)
            {
                if (v.Id == id)
                {
                    v.Marca = nuevaMarca;
                    v.Modelo = nuevoModelo;
                    v.Anio = nuevoAnio;

                    if (v is Auto auto && nuevasPuertas.HasValue)
                    {
                        auto.CantidadPuertas = nuevasPuertas.Value;
                    }
                    else if (v is Moto moto && nuevaCilindrada.HasValue)
                    {
                        moto.Cilindrada = nuevaCilindrada.Value;
                    }
                    else if (v is Camion camion && nuevaCarga.HasValue)
                    {
                        camion.CapacidadCarga = nuevaCarga.Value;
                    }
                }
            }
        }

        ModificarVehiculo(1, "Ford", "Ranger Pro", 2025, nuevasPuertas: 2);
        ModificarVehiculo(2, "Honda", "ADFF-4133", 2024, nuevaCilindrada: 350);
        ModificarVehiculo(4, "Ford", "F-350", 2024, nuevaCarga: 2500);

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
        empleados.Add(new EmpleadoPermanente(25, "Javier", "Iglesias", 70000, 20));

        void AgregarEmpleado(Empleado e)
        {
            empleados.Add(e);
        }

        AgregarEmpleado(new EmpleadoPermanente(5, "Lucía", "Palermo", 55000, 3));

        void ModificarEmpleado(
            int id, 
            string nuevoNombre, 
            string nuevoApellido, 
            float nuevoSueldoBase, 
            int? nuevaAntiguedad = null, 
            float? nuevoValorHora = null, 
            int? nuevasHorasTrabajadas = null)
        {
            foreach (Empleado e in empleados)
            {
                if (e.Id == id)
                {
                    e.Nombre = nuevoNombre;
                    e.Apellido = nuevoApellido;
                    e.SueldoBase = nuevoSueldoBase;

                    if (e is EmpleadoPermanente empPerm && nuevaAntiguedad.HasValue)
                    {
                        empPerm.Antiguedad = nuevaAntiguedad.Value;
                    }
                    else if (e is EmpleadoTemporal empTemp)
                    {
                        if (nuevoValorHora.HasValue)
                            empTemp.ValorHora = nuevoValorHora.Value;
                        if (nuevasHorasTrabajadas.HasValue)
                            empTemp.HorasTrabajadas = nuevasHorasTrabajadas.Value;
                    }
                }
            }
        }
        ModificarEmpleado(1, "Carlos", "Crovara", 52000, nuevaAntiguedad: 6);
        ModificarEmpleado(2, "Mariano", "González", 0, nuevoValorHora: 170, nuevasHorasTrabajadas: 110);

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

        EliminarEmpleado(25);

        Console.WriteLine($"Ejercicio 2 - Sistema de empleados");
        Console.WriteLine();

        foreach (Empleado e in empleados)
        {
            e.MostrarInfo();
            Console.WriteLine();
        }

        // Ejercicio 3
        List<Producto> productos = new List<Producto>();

        productos.Add(new ProductoElectronico(1, "Smartphone", 80000, 24));
        productos.Add(new ProductoAlimenticio(2, "Yogurt", 1500, new DateTime(2025, 5, 30)));
        productos.Add(new ProductoElectronico(3, "Smart TV", 150000, 12));
        productos.Add(new ProductoAlimenticio(4, "Pan", 700, new DateTime(2025, 4, 15)));
        productos.Add(new ProductoAlimenticio(50, "Queso", 2500, new DateTime(2025, 7, 20)));

        void AgregarProducto(Producto p)
        {
            productos.Add(p);
        }

        AgregarProducto(new ProductoElectronico(5, "Tablet", 75000, 18));

        void ModificarProducto(
            int id, 
            string nuevoNombre, 
            float nuevoPrecioBase, 
            int? nuevaGarantia = null, 
            DateTime? nuevoVencimiento = null)
        {
            foreach (Producto p in productos)
            {
                if (p.Id == id)
                {
                    p.Nombre = nuevoNombre;
                    p.PrecioBase = nuevoPrecioBase;

                    if (p is ProductoElectronico prodElec && nuevaGarantia.HasValue)
                    {
                        prodElec.MesesGarantia = nuevaGarantia.Value;
                    }
                    else if (p is ProductoAlimenticio prodAlim && nuevoVencimiento.HasValue)
                    {
                        prodAlim.FechaVencimiento = nuevoVencimiento.Value;
                    }
                }
            }
        }

        ModificarProducto(1, "Smartphone Pro", 90000, nuevaGarantia: 36);
        ModificarProducto(2, "Yogurt Light", 1600, nuevoVencimiento: new DateTime(2025, 6, 15));

        void EliminarProducto(int id)
        {
            Producto productoAEliminar = null;

            foreach (Producto p in productos)
            {
                if (p.Id == id)
                {
                    productoAEliminar = p;
                }
            }

            if (productoAEliminar != null)
            {
                productos.Remove(productoAEliminar);
            }
        }

        EliminarProducto(50);

        Console.WriteLine($"Ejercicio 3 - Inventario de productos");
        Console.WriteLine();

        foreach (Producto p in productos)
        {
            p.MostrarInfo();
            Console.WriteLine();
        }

        // Ejercicio 4
        List<Persona> personas = new List<Persona>();

        personas.Add(new Alumno(1, "Santiago Crovara", 20, 133, 8.5f));
        personas.Add(new Profesor(2, "María Villalba", 55, "Matemáticas", 900000));
        personas.Add(new Alumno(3, "Luciana Castagnon", 24, 233, 9.5f));
        personas.Add(new Profesor(4, "Javier Peralta Ramos", 60, "Historia", 850000));

        void AgregarPersona(Persona p)
        {
            personas.Add(p);
        }

        AgregarPersona(new Alumno(5, "Valentina González", 23, 003, 7.5f));

        void ModificarPersona(
            int id, 
            string nuevoNombre, 
            int nuevaEdad, 
            int? nuevoLegajo = null, 
            float? nuevoPromedio = null, 
            string nuevaMateria = null, 
            float? nuevoSueldo = null)
        {
            foreach (Persona p in personas)
            {
                if (p.Id == id)
                {
                    p.Nombre = nuevoNombre;
                    p.Edad = nuevaEdad;

                    if (p is Alumno alumno)
                    {
                        if (nuevoLegajo.HasValue)
                            alumno.Legajo = nuevoLegajo.Value;
                        if (nuevoPromedio.HasValue)
                            alumno.Promedio = nuevoPromedio.Value;
                    }
                    else if (p is Profesor profesor)
                    {
                        if (nuevaMateria != null)
                            profesor.Materia = nuevaMateria;
                        if (nuevoSueldo.HasValue)
                            profesor.Sueldo = nuevoSueldo.Value;
                    }
                }
            }
        }

        ModificarPersona(1, "Santiago Crovara", 20, nuevoLegajo: 104, nuevoPromedio: 9.1f);
        ModificarPersona(2, "María Villalba", 55, nuevaMateria: "Física", nuevoSueldo: 950000);

        void EliminarPersona(int id)
        {
            Persona personaAEliminar = null;

            foreach (Persona p in personas)
            {
                if (p.Id == id)
                {
                    personaAEliminar = p;
                }
            }

            if (personaAEliminar != null)
            {
                personas.Remove(personaAEliminar);
            }
        }

        EliminarPersona(3);

        Console.WriteLine($"Ejercicio 4 - Gestión de personas");
        Console.WriteLine();

        foreach (Persona p in personas)
        {
            p.MostrarInfo();
            Console.WriteLine();
        }

        // Ejercicio 5
        List<Cuenta> cuentas = new List<Cuenta>();

        cuentas.Add(new CajaAhorro(1, "Mateo Crovara", 150000, 0.05f));
        cuentas.Add(new CuentaCorriente(2, "Ana Vergara", 50000, 20000));
        cuentas.Add(new CajaAhorro(3, "Luis Palermo", 300000, 0.10f));
        cuentas.Add(new CuentaCorriente(4, "Sofía Iglesias", 75000, 15000));
        cuentas.Add(new CajaAhorro(10, "Diego Maradona", 100000, 0.02f));

        void AltaCuenta(Cuenta c)
        {
            cuentas.Add(c);
        }

        AltaCuenta(new CajaAhorro(5, "Camila Crovara", 205000, 0.05f));

        void ModificarCuenta(
            int nroCuenta, 
            string nuevoTitular, 
            float nuevoSaldo, 
            float? nuevaTasaInteres = null, 
            float? nuevoDescubiertoLimite = null)
        {
            foreach (Cuenta c in cuentas)
            {
                if (c.NumeroCuenta == nroCuenta)
                {
                    c.Titular = nuevoTitular;
                    c.Saldo = nuevoSaldo;

                    if (c is CajaAhorro cajaAhorro && nuevaTasaInteres.HasValue)
                    {
                        cajaAhorro.TasaInteres = nuevaTasaInteres.Value;
                    }
                    else if (c is CuentaCorriente cuentaCorriente && nuevoDescubiertoLimite.HasValue)
                    {
                        cuentaCorriente.DescubiertoLimite = nuevoDescubiertoLimite.Value;
                    }
                }
            }
        }

        ModificarCuenta(1, "Mateo Crovara", 160000, nuevaTasaInteres: 0.06f);

        void BajaCuenta(int nroCuenta)
        {
            Cuenta cuentaADarDeBaja = null;

            foreach (Cuenta c in cuentas)
            {
                if (c.NumeroCuenta == nroCuenta)
                {
                    cuentaADarDeBaja = c;
                }
            }

            if (cuentaADarDeBaja != null)
            {
                cuentas.Remove(cuentaADarDeBaja);
            }
        }

        BajaCuenta(10);

        void DepositarEnCuenta(int nroCuenta, float monto)
        {
            foreach (Cuenta c in cuentas)
            {
                if (c.NumeroCuenta == nroCuenta)
                {
                    c.Saldo += monto;
                }
            }
        }

        DepositarEnCuenta(2, 10000);

        void ExtraerEnCuenta(int nroCuenta, float monto)
        {
            foreach (Cuenta c in cuentas)
            {
                if (c.NumeroCuenta == nroCuenta)
                {
                    if (c is CajaAhorro cajaAhorro)
                    {
                        if (cajaAhorro.Saldo >= monto)
                        {
                            cajaAhorro.Saldo -= monto;
                        }
                    }
                    else if (c is CuentaCorriente cuentaCorriente)
                    {
                        if (cuentaCorriente.Saldo + cuentaCorriente.DescubiertoLimite >= monto)
                        {
                            cuentaCorriente.Saldo -= monto;
                        }
                    }
                }
            }
        }

        ExtraerEnCuenta(4, 80000);
        ExtraerEnCuenta(5, 5000);

        void AplicarInteresesEnCajasDeAhorro()
        {
            foreach (Cuenta c in cuentas)
            {
                if (c is CajaAhorro cajaAhorro)
                {
                    float interes = cajaAhorro.Saldo * cajaAhorro.TasaInteres;
                    cajaAhorro.Saldo += interes;
                }
            }
        }
        AplicarInteresesEnCajasDeAhorro();

        Console.WriteLine($"Ejercicio 5 - Sistema Bancario");
        Console.WriteLine();

        foreach (Cuenta c in cuentas)
        {
            c.MostrarInfo();
            Console.WriteLine();
        }
    }
}