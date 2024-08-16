/*Questão 3) Faça uma função que leia números reais informados pelo usuário
enquanto o número lido for negativo. Assim que for lido um número não negativo, a
função deve retornar o número lido. Note que esta função não recebe parâmetros.
No método Main, use a sua função para ler um número real não negativo.*/

using System;
namespace ExercResolv
{
 class Program
 {
 static double LeRealNaoNegativo()
 {
 double numero;
 Console.Write("Informe um número real não negativo: ");
 numero = Convert.ToDouble(Console.ReadLine());
 while (numero < 0)
 {
 Console.WriteLine("Número inválido!");
 Console.Write("Informe um número real não negativo: ");
 numero = Convert.ToDouble(Console.ReadLine());
 }
 return numero;
 }
 static void Main(string[] args)
 {
 double valor = LeRealNaoNegativo();
 Console.WriteLine("Número real não negativo: {0}", valor);
 }
 }
}