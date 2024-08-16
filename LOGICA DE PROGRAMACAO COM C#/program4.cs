/*Questão 4) Faça uma função que leia caracteres informados pelo usuário enquanto
o caractere não for uma vogal. Assim que for lida uma vogal, a função deve retornála. Note que esta função não recebe parâmetros. No método Main, use a sua função
para ler uma vogal.*/

using System;
namespace ExercResolv
{
 class Program
 {
 static bool EhVogal(char c)
 {
 if (c == 'a' ||
 c == 'e' ||
 c == 'i' ||
 c == 'o' ||
 c == 'u' ||
 c == 'A' ||
 c == 'E' ||
 c == 'I' ||
 c == 'O' ||
 c == 'U')
 {
 return true;
 }

 return false;
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