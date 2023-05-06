using System;
class Programa
{
    static void Main(String[] Args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não Pode Entrar!");
            }

        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
