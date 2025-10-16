namespace Ejercicios6_CROVARACarlosMarino
{
    internal class CajaAhorro : Cuenta
    {
        private float tasaInteres;

        public CajaAhorro() : base() { }

        public CajaAhorro(int numeroCuenta, string titular, float saldo, float tasaInteres) : base(numeroCuenta, titular, saldo)
        {
            this.tasaInteres = tasaInteres;
        }

        public float TasaInteres
        {
            get => tasaInteres;
            set => tasaInteres = value;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Tasa de interés de Caja de Ahorro: {tasaInteres}%");
        }
    }
}