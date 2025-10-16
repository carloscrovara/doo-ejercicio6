namespace Ejercicios6_CROVARACarlosMarino
{
    internal class ProductoElectronico : Producto 
    {
        private int mesesGarantia;

        public ProductoElectronico() : base() { }

        public ProductoElectronico(int id, string nombre, float precioBase, int mesesGarantia) : base(id, nombre, precioBase)
        {
            this.mesesGarantia = mesesGarantia;
        }

        public int MesesGarantia
        {
            get => mesesGarantia;
            set => mesesGarantia = value;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Garantía del producto electrónico: {mesesGarantia} meses");
        }
    }
}