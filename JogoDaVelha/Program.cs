using System;

class JogoDaVelha1
{
    public static void Main(string[] args)
    {
        JogoVelha conexao = new JogoVelha();
        conexao.Grade(null);
        conexao.Jogar();
        
    }
}