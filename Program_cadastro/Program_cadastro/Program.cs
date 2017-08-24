using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma opção abaixo:\n" +
                "\n1. - INSERIR" +
                "\n2. - ALTERAR" +
                "\n3. - EXCLUIR" +
                "\n4. - SAIR");

            String s1 = null;

            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":
                    List<String> nomes = new List<string>();

                    nomes.Add("Dieison");  //0
                    nomes.Add("Bruna");    //1
                    nomes.Add("Anderson"); //2

                    for (int i = 0; i < nomes.Count; i++)
                    {
                        Console.WriteLine(nomes[i]);
                    }
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("ALTERAR");
                    break;
                case "3":
                    Console.WriteLine("EXCLUIR");
                    break;
                case "4":
                    Console.WriteLine("SAIR");
                    break;

            }
            Console.ReadKey();
        }
    }
}
