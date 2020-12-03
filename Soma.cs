using System;
class MainClass {
    public static void Main (string[] args) {

        int[,] valores = new int[3, 4];

        int[] soma = new int [4];

        for (int a = 0; a < 4; a++) {

            Console.WriteLine("Digete os números da coluna ", a+1);

            soma[a] = 0;

            for (int b = 0; b < 3; b++) {

                valores[b, a] = int.Parse(Console.ReadLine());

                soma[a] += valores[b, a];

            }
        }
        for (int i = 0; i < 4; i++) {
            Console.WriteLine("\nSoma {0} é = {1}", i+1, soma[i]);
        }
    }
}