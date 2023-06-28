using System;

class ListaExercicio
{
    public static void Main(string[] args)
    {
        Matematica conexao = new Matematica();

        Console.WriteLine("Escolha uma operações: ");
        Console.WriteLine("1- Soma");
        Console.WriteLine("2- Maior numero");
        Console.WriteLine("3- Raiz quadrada");
        int opcao1 = Convert.ToInt32(Console.ReadLine());

        switch (opcao1)
        {
            case 1:
                Console.WriteLine("Digite o primeiro valor: ");
                double valor1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                double valor2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(conexao.Somar(valor1, valor2));
                break;

            case 2:
                Console.WriteLine("Digite o primeiro valor: ");
                double valor3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                double valor4 = Convert.ToDouble(Console.ReadLine());
                conexao.Maior(valor3, valor4);
                break;

            case 3:
                Console.WriteLine("Digite um valor: ");
                double valor5 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(conexao.RaizQuadrada(valor5));
                break;
        }
    }
}