using System;

class Programa
{
	public static void Main(string[] args)
	{
        int anosTrabalho;
        string nomeFuncionario;
        double salarioFuncionario;
        double salarioFuncionarioNovo = 0;

        Console.WriteLine("Digite seu nome:");
        nomeFuncionario = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Digite seus anos de empresa:");
        anosTrabalho = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Digite seu salario:");
        salarioFuncionario = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        if(anosTrabalho <= 3 && anosTrabalho >=0){
            salarioFuncionarioNovo = (salarioFuncionario * 0.03) + salarioFuncionario;
        }
        else if(anosTrabalho > 3 && anosTrabalho <= 10){
            salarioFuncionarioNovo = (salarioFuncionario * 0.125) + salarioFuncionario;
        }
        else if(anosTrabalho >10){
            salarioFuncionarioNovo = (salarioFuncionario * 0.20) + salarioFuncionario;
        }

        Console.WriteLine("Olá " + nomeFuncionario+ ", seu salario atual de R$"+salarioFuncionario+ " foi alterado por\n" + "conta de você ter "+ anosTrabalho+ " anos de trabalho na empresa,\n" + "o novo salario vai ser de R$" + salarioFuncionarioNovo + ".");

        



    }
}
