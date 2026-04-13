namespace Aula02EstruturaDeDados;

public class ArrayUnidimensional
{
    public void ExecutarArrayUnidimensional()
    {
        Console.WriteLine("Array Unidimensional\n");

        // declaração de array
        int [] numeros = new int[5];
        string[] nomes = {"Ana", "Luis", "Humberto","Mauro"};

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = ( i + 1 ) * 10;
        }

        // Acesso e exibição
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Numeros [{i}] = {numeros[i]}");

        }
            Console.WriteLine("Array de string\n");
            foreach (string nome in nomes)
            {
                Console.WriteLine($"Valores no array Nomes: {nome}");
            }

        // propriedade de array
        Console.WriteLine("Propriedades de array \n");
        Console.WriteLine($"Minha propriedade de tamanho: {nomes.Length}");
        Console.WriteLine($"Minha propriedade de dimensão: {numeros.Rank}");

        // metodo de array
        Console.WriteLine("Metodo Sort");
        Array.Sort(nomes);
        Console.WriteLine("Array Ordenado");

        foreach (string item in nomes)
        {
            Console.WriteLine($"Array ordenado: {item}");
        }

        int index = Array.IndexOf(nomes, "Luis");

        Console.WriteLine($"Meu index: {index}");
    }
    
}
