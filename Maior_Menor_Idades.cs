using System;

class MainClass {
    public static void Main(string[] args) 
    {
        int Maior, Menor, media, idade;
        media = 0;
        Maior = 0;
        Menor = 0;
        
        for(int i = 1; i<=20; i++){
            Console.Write("digite a sua idade "+i+": ");
            idade = int.Parse(Console.ReadLine());
            media = media+idade;
            if(Maior == 0){
                Maior = idade;
            }
            if(Menor == 0){
                Menor = idade;
            }
            if(idade > Maior){
                Maior = idade;
            }
            if(idade < Menor){
                Menor = idade;
            }
        }
        media = media/20;
        Console.WriteLine("A maior idade é:"+Maior);
        Console.WriteLine("A menor idade é:"+Menor);
        Console.WriteLine("A média é:"+media);
    }
}
/*Fazer um programa que leia a idade de 20 alunos e que informe qual é a menor e a maior idade lida. Calcular a média das idades e mostrar.*/