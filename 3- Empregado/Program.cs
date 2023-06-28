using System;

class Empregado
{
    public static void Main(string[] args)
    {

        Empregados funcionario0 = new Empregados("Uriel", 9000, new DateTime(12 /04/2023));
        Empregados funcionario1 = new Empregados("Elias", 23000, new DateTime(12 / 04 / 2023));
        

        Console.WriteLine("Qual a porcentagem de aumento do primeiro funcionario?: ");
        double porcentagem = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual a porcentagem de aumento do segundo funcionario?: ");
        double porcentagem1 = Convert.ToDouble(Console.ReadLine());
        funcionario0.Aumento(porcentagem, porcentagem1);
    }
}