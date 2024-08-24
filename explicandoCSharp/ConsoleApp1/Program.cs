namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite nºs a serem somados.");

        Console.WriteLine("1º nº: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2º nº: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Soma = {Soma(num1, num2)}");

        Console.WriteLine("Aperte Enter para finalizar o programa.");

        Console.ReadLine();
    }

    public static int Soma(int num1, int num2){
        return num1 + num2;
    }
}
