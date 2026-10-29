using System;

public class Program
{
        public static void Main()
        {
                //declaração de variaveis
                String clube1;
                String clube2;
                int FIFA1;
                int FIFA2;

                //coleta de informações
                Console.WriteLine("INFORME UM CLUBE BRASILEIRO");
                clube1 = Console.ReadLine();
                Console.WriteLine("QUANTOS MUNDIAIS DE CLUBES DA FIFA O " + clube1 + " TEM? ");
                FIFA1 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("INFORME UM OUTRO CLUBE BRASILEIRO");
                clube2 = Console.ReadLine();
                Console.WriteLine("QUANTOS MUNDIAIS DA FIFA O " + clube2 + " POSSUI? ");
                FIFA2 = Convert.ToInt16(Console.ReadLine());


           // comparação entre os titulos
       if (FIFA1 > FIFA2) 
       { 
       Console.WriteLine("O " + clube1 + " É INFINITAMENTE VEZES MAIOR QUE " + clube2); 
       } 
      else if (FIFA2 > FIFA1) 
      { 
      Console.WriteLine("O " + clube2 + " É INFINITAMENTE VEZES MAIOR QUE " + clube1); 
      }
      else 
      { 
     Console.WriteLine("OS DOIS CLUBES SÃO RUINS KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK"); 
     }



	}
}