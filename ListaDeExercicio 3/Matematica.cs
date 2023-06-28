public class Matematica
{
    public double Somar(double valor1, double valor2)
    {
        return valor1 + valor2;
    }

    public void Maior(double valor1, double valor2)
    {
        if (valor1 > valor2)
        {
            Console.WriteLine("O maior valor é " + valor1);
        }
        if (valor1 < valor2)
        {
            Console.WriteLine("O maior valor é " + valor2);
        }
        if (valor1 == valor2)
        {
            Console.WriteLine("O maior valor é " + valor1);
        }
    }

    public double RaizQuadrada(double valor)
    {
        return Math.Sqrt(valor);
    }
}