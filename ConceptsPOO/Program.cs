using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using calc;
using utils;

namespace foo {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            // string? nome = Console.ReadLine();

            // Console.WriteLine($"Nome: {nome}");

            int num = Utils.stoi(Utils.processInput(Console.ReadLine()));

            int[] multiples = new int[10];
            // int index = 0;
            for (int i = 2; i < multiples.Length; i++) {
                if (num % i == 0) {
                    multiples[i] = i;
                }
            }

            string buf = "";
            foreach(int mul in multiples) {
                if (mul > 0) {
                    buf += mul;
                    buf += " - ";
                }
            }

            if (buf.Length > 0) {
                if (buf[^1] != ' ')
                    Console.WriteLine(buf);
                else 
                    Console.WriteLine(buf[..^3]);
            }

            Container.CheckCapacity(num);

            Container container = new Container(num);
            
            Console.WriteLine($"Container capacity: {container.GetCapacity()}");
            container.AddToCapacity(num*2);
            Console.WriteLine($"Container capacity: {container.GetCapacity()}");

            Container.CheckCapacity(container.GetCapacity());
        }
    }
}
