using System;
class Programa
{
    static void Main(String[] Args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = false;

        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            Console.WriteLine("Não Pode Entrar!");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
