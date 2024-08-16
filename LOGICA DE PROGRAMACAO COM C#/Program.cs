
/*Questão 1) Faça um procedimento que receba por parâmetro um número inteiro e
escreva “par” se o número recebido por parâmetro for par. Caso contrário, o
procedimento deve escrever “ímpar”. No método principal (Main), leia um número
inteiro e passe-o por parâmetro para o procedimento criado.*/

using System;
namespace ExercResolv
{
 class Program
 {
 static void ImprimirParOuImpar(int numero)
 {
 if (numero % 2 == 0) //se o resto da divisão do número por 2 for zero
 {
 Console.WriteLine("par");
 }
 else //caso contrário
 {
 Console.WriteLine("ímpar");
 }
 }
 static void Main(string[] args)
 {
 int num;
 Console.Write("Informe um número inteiro: ");
 num = Convert.ToInt32(Console.ReadLine());
 ImprimirParOuImpar(num);
 }
 }
}

