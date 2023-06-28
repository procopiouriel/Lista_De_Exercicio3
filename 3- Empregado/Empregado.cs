public class Empregados
{
    private string nome;
    private double salario;
    private DateTime dataadmissao;
    private static double gastos;

    public Empregados(string nome, double salario, DateTime dataadmissao)
    {
        this.nome = nome;
        this.salario = salario;
        this.dataadmissao = dataadmissao;
        gastos += this.salario;
        
    }

    public void Aumento(double porcentagem, double porcentagem1)
    {
        double resultado = (porcentagem * salario) / 100;//AUMENTO
        gastos += resultado;
        

        double resultado1 = (porcentagem * salario) / 100;//AUMENTO
        gastos += resultado;
        Console.WriteLine("Total: " + gastos);
        Console.WriteLine("Aumento feito com sucesso!");
    }
}