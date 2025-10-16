namespace Ejercicios6_CROVARACarlosMarino
{
    internal abstract class Cuenta
    {
        protected int numeroCuenta;
        protected string titular;
        protected float saldo;

        public Cuenta() { }

        public Cuenta(int numeroCuenta, string titular, float saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldo;
        }

        public int NumeroCuenta
        {
            get => numeroCuenta;
            set => numeroCuenta = value;
        }

        public string Titular
        {
            get => titular;
            set => titular = value;
        }

        public float Saldo
        {
            get => saldo;
            set => saldo = value;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Número de Cuenta: {numeroCuenta}, Titular {titular}, Saldo: $ {saldo}");
        }
    }
}