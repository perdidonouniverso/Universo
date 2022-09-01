using System;

class Programa
{
	public static void Main(string[] args)
	{
        int escolha, dias, km;
        double valorTotal = 0;

        Console.WriteLine("Digite 1 para escolher carro popular e 2 para caro de luxo:");
        escolha = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if(escolha == 1){
            Console.WriteLine("Digite a quantidade de dias que vai alugar:");
            dias = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite quantos km você percorreu:");
            km = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(km <= 100 && km >= 0){
                valorTotal = km * 0.20;
            }
            else if(km > 100){
                valorTotal = km * 0.10;
            }
            valorTotal = valorTotal + (dias * 90);
            Console.WriteLine("Valor a pagar:");
            Console.WriteLine("R$"+valorTotal);
        }
        if(escolha == 2){
            Console.WriteLine("Digite a quantidade de dias que vai alugar:");
            dias = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite quantos km você percorreu:");
            km = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(km <= 200 && km >= 0){
                valorTotal = km * 0.30;
            }
            else if(km > 200){
                valorTotal = km * 0.25;
            }
            valorTotal = valorTotal + (dias * 150);
            Console.WriteLine("Valor a pagar:");
            Console.WriteLine("R$"+valorTotal);
        }
    }
}
