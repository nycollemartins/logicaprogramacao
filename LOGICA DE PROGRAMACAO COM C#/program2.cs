/*Questão 2) Faça uma função que receba por parâmetro um número inteiro e
retorne “par” se o número recebido por parâmetro for par. Caso contrário, a função
deve retornar “ímpar”. No método principal (Main), leia um número inteiro e passeo por parâmetro para a função criada, imprimindo em seguida o seu retorno.*/

using System;
namespace ExercResolv
{
 class Program
 {
 static string RetornarParOuImpar(int numero)
 {
 if (numero % 2 == 0) //se o resto da divisão do número por 2 for zero
 {
 return "par";
 }
 else //caso contrário
 {
 return "ímpar";
 }
 }
 static void Main(string[] args)
 {
 int num;
 Console.Write("Informe um número inteiro: ");
 num = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("{0} é {1}", num, RetornarParOuImpar(num));
 }
 }
}