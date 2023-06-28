public class Terreno1
{
    private double largura;
    private double comprimento;

    public Terreno1(double largura, double comprimento)
    {
        this.largura = largura;
        this.comprimento = comprimento;
    }


    public double GetComprimento()
    {
        return comprimento;
    }

    public double GetLargura()
    {
        return largura;
    }


    public void SetComprimento(double valor)
    {
       this.comprimento = valor;
    }
    public void SetLargura (double valor)
    {
        this.largura = valor;
    }

    
    public double Area()
    {

        return this.largura * this.comprimento;
    }
    public double ValorTerreno(double valorterreno) 
    
    {
        return Area() * valorterreno; 
    }
}