using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using calc;
using utils;

namespace foo {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("0) Sair");
            Console.WriteLine("1) Somar números");
            Console.WriteLine("2) Verificar Primo");
            Console.WriteLine("3) Inválido");
            Console.WriteLine("4) Inválido");
            Console.WriteLine("5) Inválido");
            Console.WriteLine("6) Inválido");

            while (true) {
                int op = Utils.stoi(Utils.processInput(Console.ReadLine()));

                if (op == 0)
                    break;

                switch (op) {
                    case 1:
                        {
                            Console.WriteLine("Entrar com dois números para soma: ");
                            int x = Utils.stoi(Utils.processInput(Console.ReadLine()));
                            int y = Utils.stoi(Utils.processInput(Console.ReadLine()));
                            Console.WriteLine($"Soma: {Utils.sum(x, y)}");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Entrar com um número para descobrir se é primo: ");
                            int x = Utils.stoi(Utils.processInput(Console.ReadLine()));
                            Utils.VerifyPrime(x);
                        }
                        break;
                    default:
                        Console.WriteLine("Inválido");
                        break;
                }
            }
        }
    }
}
