using System;
class Programa
{
    static void Main(String[] Args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode Entrar!");
        }
        else
            Console.WriteLine("Não Pode Entrar!");
        Console.WriteLine("");

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
