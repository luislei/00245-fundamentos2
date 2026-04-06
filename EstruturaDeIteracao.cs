using System.Security.Cryptography.X509Certificates;

namespace Aula02EstruturaDeDados;

class EstruraDeIteracao
{
    public void ExecutarFor()
    {
        Console.WriteLine("Laço For\n");

        //Laço For ou loop For
        for (int i = 0; i < 5; i++)
        {
           Console.WriteLine($"Iteração: {i}"); 
        }
    }
        // For Each
        public void ExecutarForEach()
        {
            Console.WriteLine();
            Console.WriteLine("Laço For Each\n");
            string [] frutas = ["maça", "abacaxi", "banana", "1"];

            foreach (var fruta in frutas)
            {
              Console.WriteLine($"Minhas frutas no ForEach: {fruta}");  
            } 
        }

        // Break e Continue
        public void ExecutarForBreakContinue ()
        {
           Console.WriteLine();
           Console.WriteLine("Break & Continue \n");
            for (int i=0; i<10; i++)
        {
            if(i == 3) continue;
            if(i == 8)
            {
                break;
            }
            Console.WriteLine($"o Nosso numero: {i}");
        }
        }


        // loop while  ou laço while

        public void ExecutarWhile()
        {
            Console.WriteLine();
            Console.WriteLine("Loop While\n");
            int contador = 1;
            while (contador <=4)
            {
                Console.WriteLine($"Loop While: {contador}");
                contador++;
            }
        }

        // Loop Do While
        public void ExecutarDoWhile()
        {
            Console.WriteLine();
            Console.WriteLine("Loop Do While\n");
            int numero;
            do
            {
                Console.WriteLine("Digite um numero");
                numero = 5; // nsimulando uma entrada de dados
                Console.WriteLine($"Nosso numero: {numero}");

            } while (numero <=0 );
        } 

} // fim da class
