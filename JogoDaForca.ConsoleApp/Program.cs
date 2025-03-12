namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("----------------------------------------------");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0];

                Console.WriteLine($"Você digitou: {chute}");

                Console.ReadLine();
            } while (true);
        }
    }
}
