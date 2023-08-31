using System.Collections;
using System.Diagnostics;
using System.Security.AccessControl;

namespace Calculadora
{
    internal class Program
    {
       static void Main(string[] args)
         {
             Console.WriteLine(" Qaula Operação deseja vazer:");
             Console.WriteLine("1- Adição");
             Console.WriteLine("2- Subtração");
             Console.WriteLine("3- Multplicacão"); 
             Console.WriteLine("4- Divisão \n");

             Console.ReadLine();


          int operacao = int.Parse(Console.ReadLine());

               Console.WriteLine("Digite o primeiro numero:");
                 int Num01 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro numero:");
                   int Num02 = int.Parse(Console.ReadLine());
            int resultado=0;


           switch(operacao)
           {
             case 1:
             {
                resultado = Adicao(Num01,Num02);
                break;
             }
             case 2:
             {
               
        
                resultado = Subtracao(Num01,Num02);
                break;
             
             }

            case 3:
            {
                  resultado = Multiplicacao(Num01,Num02);
                break;
             
            }
            case 4:
            {

                  resultado = Divisao(Num01,Num02);
                break;
             
            }
            default:
             Console.WriteLine("Numero Invalido");
             break;
           }

         Console.WriteLine("Oresultadi e: {0} e {1} é: {2}",Num01,Num02,resultado);

         Console.ReadLine();


         }






 
   public static int Adicao(int Num01,int Num02)
         {
            int resultado = Num01+Num02;
            return resultado;
         }
    public static int Subtracao(int Num01,int Num02)
         {
            int resultado = Num01-Num02;
            return resultado;
         }
     public static int Multiplicacao(int Num01,int Num02)
         {
            int resultado = Num01*Num02;
            return resultado;
         }
     public static int Divisao(int Num01,int Num02)
         {
            int resultado = Num01/Num02;
            return resultado;
         }          
    } 
}