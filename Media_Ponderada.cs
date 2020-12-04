using System;

class MainClass {
    public static void Main(string[] args) {
        float a;
        float b;
        float c;
        float MediaP;
        
        Console.Write("Digite o valor a: ");
        a = float.Parse(Console.ReadLine());
        Console.Write("Digite outro valor b: ");
        b = float.Parse(Console.ReadLine());
        Console.Write("Digite mais um valor c: ");
        c = float.Parse(Console.ReadLine());
        MediaP = (a * 2) + (b * 3) + (c * 5) / 10;
        
        System.Console.WriteLine("Média Ponderada é: "+MediaP);
    }
}