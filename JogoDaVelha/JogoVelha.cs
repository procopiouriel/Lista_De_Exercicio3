using System.Runtime.Intrinsics.X86;

public class JogoVelha
{



    private char[,] arraybidimensional = new char[3, 3];


    public string[] jogadores = new string[2];
    public int[] jogadas = new int[2];

    public void Grade(char[,] array)
    {
        Console.WriteLine("   0  1 2");
        array = arraybidimensional;
        Console.WriteLine("0 " + $" {arraybidimensional[0, 0]} | {arraybidimensional[0, 1]} | {arraybidimensional[0, 2]} ");
        Console.WriteLine("1 " + $" {arraybidimensional[1, 0]} | {arraybidimensional[1, 1]} | {arraybidimensional[1, 2]} ");
        Console.WriteLine("2 " + $" {arraybidimensional[2, 0]} | {arraybidimensional[2, 1]} | {arraybidimensional[2, 2]} ");


    }


    public void GradeMelhor(int jogada1, int jogada2)
    {
        for (int i = 0; i < 3; i++)//FOR PARA ANALISAR A LINHA
        {

            for (int j = 0; j < 3; j++)// FOR PARA ANALISAR A COLUNA
            {
                Console.Write("-|");
            }
            Console.WriteLine();
        }
        arraybidimensional[jogada1, jogada2] = 'X';
    }

    public void Jogar()
    {
        int contagem = 0;
        while (true)
        {
            
        
            jogadores[0] = "Jogador 1";
            jogadores[1] = "Jogador 2";

            /*================ jogador 1=====================*/

            Console.WriteLine(jogadores[0] + " escolha a linha que deseja fazer a jogada.");
            int jogada1 = int.Parse(Console.ReadLine());
            Console.WriteLine(jogadores[0] + " escolha a coluna que deseja fazer a jogada.");
            int jogada1_0 = int.Parse(Console.ReadLine());

            while (arraybidimensional[jogada1, jogada1_0] == 'O' || arraybidimensional[jogada1, jogada1_0] == 'X')//OCUPADO
            {

                Console.WriteLine("Esse local de jogada esta indisponivel, escolha outro local para a jogada! ");

                Console.WriteLine(jogadores[0] + " escolha a linha que deseja fazer a jogada.");
                jogada1 = int.Parse(Console.ReadLine());
                Console.WriteLine(jogadores[0] + " escolha a coluna que deseja fazer a jogada.");
                jogada1_0 = int.Parse(Console.ReadLine());
                //arraybidimensional[jogada1, jogada1_0] = 'X';
                Console.Clear();
                Grade(arraybidimensional);

            }

            arraybidimensional[jogada1, jogada1_0] = 'X';
            Console.Clear();
            Grade(arraybidimensional);
            Verificar();
            Console.WriteLine("CON" + contagem);
            if (Verificar() == false)
            {
                contagem++;

            }
            if (contagem == 8)//O JOGO SO TEM 8 CASAS, OU SEJA SE O JOGO TIVER COM TODAS AS CASAS COMPLETAS E NAO TIVER DADO NENHUM GANHADOR AINDA, E PQ DEU EMPATE
            {
                Console.WriteLine("Jogo Empatado!");
                break;
            }

            if (Verificar() == true)//JOGO ACABOU
            {
                break;
                Console.WriteLine("Muito obrigado por usar esse programa!");
            }


            /*================ jogador 2=====================*/

            Console.WriteLine(jogadores[1] + " escolha a linha que deseja fazer a jogada.");
            int jogada2 = int.Parse(Console.ReadLine());
            Console.WriteLine(jogadores[1] + " escolha a coluna que deseja fazer a jogada.");
            int jogada2_0 = int.Parse(Console.ReadLine());

            while (arraybidimensional[jogada2, jogada2_0] == 'O' || arraybidimensional[jogada2, jogada2_0] == 'X')//OCUPADO
            {
                Console.WriteLine("Esse local de jogada esta indisponivel, escolha outro local para a jogada! ");

                Console.WriteLine(jogadores[1] + " escolha a linha que deseja fazer a jogada.");
                jogada2 = int.Parse(Console.ReadLine());
                Console.WriteLine(jogadores[1] + " escolha a coluna que deseja fazer a jogada.");
                jogada2_0 = int.Parse(Console.ReadLine());
                //arraybidimensional[jogada2, jogada2_0] = 'O';
                Console.Clear();
                Grade(arraybidimensional);
            }


            arraybidimensional[jogada2, jogada2_0] = 'O';
            Console.Clear();
            Grade(arraybidimensional);
            Verificar();
            Console.WriteLine("CON1" + contagem);
            if (Verificar() == false)
            {
                contagem++;

            }

            if (Verificar() == true)//JOGO ACABOU
            {
                break;
                Console.WriteLine("Muito obrigado por usar esse programa!");
            }

            if (contagem == 8)//O JOGO SO TEM 8 CASAS, OU SEJA SE O JOGO TIVER COM TODAS AS CASAS COMPLETAS E NAO TIVER DADO NENHUM GANHADOR AINDA, E PQ DEU EMPATE
            {
                Console.WriteLine("Jogo Empatado!");
                break;
            }

        }
    

    }

    public bool Verificar()
    {
      
        //VERIFICAR DIAGONAIS
        if (arraybidimensional[2, 0] == 'O' && arraybidimensional[0, 2] == 'O' && arraybidimensional[1, 1] == 'O')
        {
            Console.WriteLine("O " + jogadores[1] + " venceu!!");
            return true;
        }
        else if (arraybidimensional[2, 0] == 'X' && arraybidimensional[0, 2] == 'X' && arraybidimensional[1, 1] == 'X')
        {
            Console.WriteLine("O " + jogadores[0] + " venceu!!");
            return true;

        }
        if (arraybidimensional[0, 0] == 'O' && arraybidimensional[1, 1] == 'O' && arraybidimensional[2, 2] == 'O')
        {
            Console.WriteLine("O " + jogadores[1] + " venceu!!");
            return true;
        }
        else if (arraybidimensional[0, 0] == 'X' && arraybidimensional[1, 1] == 'X' && arraybidimensional[2, 2] == 'X')
        {
            Console.WriteLine("O " + jogadores[0] + " venceu!!");
            return true;

        }

        //VERIFICAR COLUNAS
        if (arraybidimensional[0, 0] == 'O' && arraybidimensional[1, 0] == 'O' && arraybidimensional[2, 0] == 'O')
        {
            Console.WriteLine("O " + jogadores[1] + " venceu!!");
            return true;
        }
        else if (arraybidimensional[0, 0] == 'X' && arraybidimensional[1, 0] == 'X' && arraybidimensional[2, 0] == 'X')
        {
            Console.WriteLine("O " + jogadores[0] + " venceu!!");
            return true;

        }

        if (arraybidimensional[0, 1] == 'O' && arraybidimensional[1, 1] == 'O' && arraybidimensional[2, 1] == 'O')
        {
            Console.WriteLine("O " + jogadores[1] + " venceu!!");
            return true;
        }
        else if (arraybidimensional[0, 1] == 'X' && arraybidimensional[1, 1] == 'X' && arraybidimensional[2, 1] == 'X')
        {
            Console.WriteLine("O " + jogadores[0] + " venceu!!");
            return true;

        }

        if (arraybidimensional[0, 2] == 'O' && arraybidimensional[1, 2] == 'O' && arraybidimensional[2, 2] == 'O')
        {
            Console.WriteLine("O " + jogadores[1] + " venceu!!");
            return true;
        }
        else if (arraybidimensional[0, 2] == 'X' && arraybidimensional[1, 2] == 'X' && arraybidimensional[2, 2] == 'X')
        {
            Console.WriteLine("O " + jogadores[0] + " venceu!!");
            return true;

        }

        //VERIFICAR LINHAS

        if (arraybidimensional[0, 0] == 'O' && arraybidimensional[0, 1] == 'O' && arraybidimensional[0, 2] == 'O')
        {
            Console.WriteLine("O " + jogadores[1] + " venceu!!");
            return true;
        }
        else if (arraybidimensional[0, 0] == 'X' && arraybidimensional[0, 1] == 'X' && arraybidimensional[0, 2] == 'X')
        {
            Console.WriteLine("O " + jogadores[0] + " venceu!!");
            return true;

        }

        if (arraybidimensional[1, 0] == 'O' && arraybidimensional[1, 1] == 'O' && arraybidimensional[1, 2] == 'O')
        {
            Console.WriteLine("O " + jogadores[1] + " venceu!!");
            return true;
        }
        else if (arraybidimensional[1, 0] == 'X' && arraybidimensional[1, 1] == 'X' && arraybidimensional[1, 2] == 'X')
        {
            Console.WriteLine("O " + jogadores[0] + " venceu!!");
            return true;

        }

        if (arraybidimensional[2, 0] == 'O' && arraybidimensional[1, 0] == 'O' && arraybidimensional[2, 0] == 'O')
        {
            Console.WriteLine("O " + jogadores[1] + " venceu!!");
            return true;
        }
        else if (arraybidimensional[2, 0] == 'X' && arraybidimensional[2, 1] == 'X' && arraybidimensional[2, 2] == 'X')
        {
            Console.WriteLine("O " + jogadores[0] + " venceu!!");
            return true;

        }
        return false;//EMPATE 
    }
}

