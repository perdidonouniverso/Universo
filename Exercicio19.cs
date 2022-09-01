using System;

class Programa
{
	public static void Main(string[] args)
	{
        double salario, imovel; 
        int anos;

        Console.WriteLine("Digite seu salario:");
        salario = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite o valor do imovel:");
        imovel = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite em quantos anos pretende pagar:");
        anos = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if(imovel / (anos * 12)  < (0.3 * salario)){
            Console.WriteLine("Seu emprestimo foi liberado:");
        }
        else{
            Console.WriteLine("Seu emprestimo não foi liberado:");
        }

    }
}
