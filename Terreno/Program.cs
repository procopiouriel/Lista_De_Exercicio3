using System;

class Terreno
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a largura do terreno: ");
        double largura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o comprimento do terreno: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());
        

        Terreno1 conexao = new Terreno1(largura, comprimento);
        Console.WriteLine(conexao.Area() + " Metros quadrados");

        Console.WriteLine("Digite o valor em metros quadrados do terreno: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Este terreno custa: R$ " + conexao.ValorTerreno(valor));

        
    }
}