// See https://aka.ms/new-console-template for more information
using System;

class program{
    static void Main(){
        Console.Write("White your name: ");
        String nome = Console.ReadLine();

        Console.WriteLine($"hello, {nome}! wellcome to c#");

        // int number = 10;
        // int number_2 = 5;
        // Console.WriteLine("quanto é " + number + "+" +number_2+ "?");
        // int answer = Convert.ToInt32(Console.ReadLine());

        // if(answer == 15){
        //     Console.WriteLine("congratulations, you be right");
        // } else {
        //     Console.WriteLine("you are dumb");
        // }
        
        Console.WriteLine("insira o numero 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("insira o numero 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("insira o numero 3: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int answer = number1 + number2 + number3;
        Console.WriteLine("resultado da soma: "+answer);
    }
}
