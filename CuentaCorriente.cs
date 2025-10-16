namespace Ejercicios6_CROVARACarlosMarino
{
    internal class CuentaCorriente : Cuenta
    {
        private float descubiertoLimite;

        public CuentaCorriente() : base() { }

        public CuentaCorriente(int numeroCuenta, string titular, float saldo, float descubiertoLimite) : base(numeroCuenta, titular, saldo)
        {
            this.descubiertoLimite = descubiertoLimite;
        }

        public float DescubiertoLimite
        {
            get => descubiertoLimite;
            set => descubiertoLimite = value;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Límite de descubierto de Cuenta Corriente: $ {descubiertoLimite}");
        }
    }
}