// See https://aka.ms/new-console-template for more information
namespace ConsoleNameSpace{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello, World!");

            Carro carro = new Carro();
            carro.DigaSeuNome();
            Aviao aviao = new Aviao();
            aviao.DigaSeuNome();
            MeusTestes.Carro carro1 = new MeusTestes.Carro();
            carro1.DigaSeuNome();

            Console.Read();
        }
    }

    class Carro{
        public void DigaSeuNome(){
            Console.WriteLine("Eu sou um carro");
        }
    }
}

namespace MeusTestes{
    class Carro{
        public void DigaSeuNome(){
            Console.WriteLine("Eu sou um carro dentro do MeusTestes");
        }
    }
}
class Aviao{
    public void DigaSeuNome(){
        Console.WriteLine("Eu sou um aviao");
    }
}
