using System;

class MainClass {
    public static void Main(string[] args) 
    {
        string sexo, estadoCivil, continuar;
        
        int idade, quantidade;
        
        quantidade = 0;
        
        continuar = "S";
        
        while(continuar == "S") {
            Console.Write("\nQual o seu xexo? ");
            sexo = Console.ReadLine().ToUpper();
            
            Console.Write("Sua idade? ");
            idade = int.Parse(Console.ReadLine());
            
            Console.Write("Seu Estado Civil? S/C (Solteiro = S, Casado = C): ");
            estadoCivil = Console.ReadLine().ToUpper();
            
            if(sexo == "F" && idade < 21 && estadoCivil == "S"){
                quantidade++;
            }
            Console.Write("continuar? S/N ");
            continuar = Console.ReadLine().ToUpper();
        }
        Console.Write("Atendem aos padrões = "+quantidade);
    }
}

/* Fazer um programa que mostre quantas pessoas de um grupo satisfazem os seguintes requisitos:
 sexo feminino(F), idade menor que 21 anos, e estado civil solteiro(S). Responder sim("S") para continuar leitura de dados.*/