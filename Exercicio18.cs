using System;

class Programa
{
	public static void Main(string[] args)
	{
        double ret1, ret2, ret3;



        Console.WriteLine("Digite o tamanho em metros da primeira reta:");
        ret1 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Digite o tamanho em metros da segunda reta:");
        ret2 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Digite o tamanho em metros da terceira reta:");
        ret3 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        if((ret1 + ret2) <= ret3 || (ret2 + ret3) <= ret1 || (ret3 + ret2) <= ret1){
        Console.WriteLine("Não é possivel montar um triangulo com essas retas");
        }
        else{
            if(ret1 == ret2 && ret2 == ret3){
                Console.WriteLine("É um triangulo equilátero");
            }
            if(ret1 == ret2 && ret2 != ret3 || ret2 == ret3 && ret2 != ret1 ||ret1 == ret3 && ret3 != ret2  ){
                Console.WriteLine("É um triangulo eisóseles");
            }
            if(ret1 != ret2 && ret2 != ret3 && ret1 != ret3  ){
                Console.WriteLine("É um triangulo escaleno");
            }
        }


    }
}
