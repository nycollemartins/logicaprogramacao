/*Questão 5) Faça uma função que receba por parâmetro um inteiro N, leia N
números inteiros e retorne a média aritmética dos números positivos lidos. No
método principal (Main), peça para o usuário informar quantos números ele deseja
ler, passe essa informação por parâmetro para a função criada e imprima o retorno
da função com 3 casas decimais*/
using System;
namespace ExercResolv
{
 class Program
 {
 static bool EhVogal(char c)
 {
 switch (c)
 {
 case 'a': case 'e': case 'i': case 'o': case 'u':
 case 'A': case 'E': case 'I': case 'O': case 'U':
 return true;
 default:
 return false;
 }
 }
 static char LeVogal()
 {
 char vogal;
 Console.Write("Informe uma vogal: ");
 vogal = Convert.ToChar(Console.ReadLine());
 while (EhVogal(vogal) == false)
 {
 Console.WriteLine("O caractere informado não é uma vogal!");
 Console.Write("Informe uma vogal: ");
 vogal = Convert.ToChar(Console.ReadLine());
 }
 return vogal;
 }
 static void Main(string[] args)
 {
 char vogal = LeVogal();

 Console.WriteLine("Vogal informada: {0}", vogal);
 }
 }
}