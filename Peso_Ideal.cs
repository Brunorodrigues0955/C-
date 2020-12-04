using System;

class MainClass {
    public static void Main(string[] args) 
    {
        string sexo;
        double PesoId;
        float altura;
        
        Console.Write("Qual o seu sexo? F/M: ");
        sexo = Console.ReadLine();
        
        Console.Write("Qul a sua altura?: ");
        altura = float.Parse(Console.ReadLine());
        
        if (sexo == "M"){
            PesoId = (72.7*altura) - 58;
        }
        else{
            PesoId = (62.1*altura) - 47.7;
            
        }
        System.Console.WriteLine(" Peso ideal é: "+PesoId.ToString("F"));
    }
}

/*Tendo como dados de entrada a altura e o sexo de uma pessoa ("M" para masculino e "F" para feminino) construa um programa que calcule seu peso ideal, utilizando as seguintes 77
para homens: (72,7 * altura) - 58
para mulheres: (62,1 * altura) - 44,7*/