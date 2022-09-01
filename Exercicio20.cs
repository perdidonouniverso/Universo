using System;

class Programa
{
	public static void Main(string[] args)
	{
        int peso, altura;

        Console.WriteLine("Digite sua altura:");
        altura = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite seu peso:");
        peso = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        int imc = peso / (altura*altura);

        if(imc < 18.5){
            Console.WriteLine("Abaixo do peso");
        }
        else if(imc < 25 && imc > 18.5){
            Console.WriteLine("Peso ideal");
        }
        else if(imc < 30 && imc > 25){
            Console.WriteLine("Sobrepeso");
        }
        else if(imc < 40 && imc > 30){
            Console.WriteLine("Obesidade");
        }
        else if(imc > 40){
            Console.WriteLine("Obesidade mórbida");
        }
    }
}

