using System;

class MainClass {
    public static void Main(string[] args) {
        int[] idade = new int[15];
        int media = 0;
        int acimadaMedia = 0;
        for (int i = 0; i < idade.Length; i++) {
    
        Console.Write("Digite sua idade", i+1);

        idade[i] = int.Parse(Console.ReadLine());

        media += idade[i];
    }
    media /= 15;

    for (int i = 0; i < idade.Length; i++) {

        if (idade[i] > media) {
            acimadaMedia++;
        }

    }
    Console.WriteLine("A média das idades foi {0}\nE teve {1} idades acima da média", media, acimadaMedia);
    }
}