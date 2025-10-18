namespace Ejercicios6_CROVARACarlosMarino
{
    internal class ProductoAlimenticio : Producto
    {
        protected DateTime fechaVencimiento;

        public ProductoAlimenticio() : base() { }

        public ProductoAlimenticio(int id, string nombre, float precioBase, DateTime fechaVencimiento) : base(id, nombre, precioBase)
        {
            this.fechaVencimiento = fechaVencimiento;
        }

        public DateTime FechaVencimiento
        {
            get => fechaVencimiento;
            set => fechaVencimiento = value;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Fecha de vencimiento del producto alimenticio: {fechaVencimiento.ToString("dd/MM/yyyy")}");
        }
    }
}