namespace senhas;

public class Prpgram
{
    static void Main(string[] args)
    {
        //Faça um programa para ver se a senha autoriza a sua entrada. E depois este programa deve imprimir se a pessoa esta
        //altorizada. Lembrando que a senha de autorização é 123.

        int x, senha;

        Console.WriteLine("Entre com a senha:");
        Console.Write("Senha = ");
        x = int.Parse(Console.ReadLine());

        senha = 0;

        while(x != 123)
        {
            Console.WriteLine("ACESSO NEGADO");
            Console.Write("Entre com uma nova tentativa = ");
            x = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("ACESSO AUTORIZADO");
    }
}