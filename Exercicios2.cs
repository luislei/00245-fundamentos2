

 using System;
 
namespace Aula02EstruturaDeDados;

  /// <summary>
  /// 📊 EXERCÍCIOS DE ARRAYS UNIDIMENSIONAIS
  /// =======================================
  ///
  /// Exercício 1: Criação e exibição de array
  /// Exercício 2: Maior e menor valor
  /// Exercício 3: Cálculo da média
  /// Exercício 4: Inverter array
  /// </summary>
  public class AlunoArraysUnidimensionais
  {
    public void Executar()
    {
      Console.WriteLine("\n\n📊 3. EXERCÍCIOS DE ARRAYS UNIDIMENSIONAIS");
      Console.WriteLine("==========================================\n");
 
      // ===================================================
      // EXERCÍCIO 1: Criação e exibição de array
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar um array de inteiros com 5 posições
      // 2. Preencher com valores (ex: 10, 25, 8, 42, 15)
      // 3. Usar um loop for para exibir cada elemento
      //
      // 💡 int[] numeros = new int[5];
 
      Console.WriteLine("📝 Exercício 1: Array de números");
 
      // ESCREVA SEU CÓDIGO AQUI

      // 1. Criar um array de inteiros com 5 posições
            int[] numeros = new int[5];

            // 2. Preencher com valores
            numeros[0] = 10;
            numeros[1] = 25;
            numeros[2] = 8;
            numeros[3] = 42;
            numeros[4] = 15;

            Console.WriteLine("Array criado:");

            // 3. Usar um loop for para exibir cada elemento
            // numeros.Length garante que o loop percorra exatamente o tamanho do array
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"numeros[{i}] = {numeros[i]}");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();


      //Saida
      /**� Exercício 1: Array de números
      Array criado:
      numeros[0] = 10
      numeros[1] = 25
      numeros[2] = 8
      numeros[3] = 42
      numeros[4] = 15*/
      Console.WriteLine();
 
      // ===================================================
      // EXERCÍCIO 2: Maior e menor valor
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Usar o array do exercício anterior
      // 2. Inicializar variáveis maior e menor com o primeiro elemento
      // 3. Percorrer o array comparando cada elemento
      // 4. Exibir o maior e menor valor
      //
      // 💡 if (numeros[i] > maior) maior = numeros[i];
 
      Console.WriteLine("\n📝 Exercício 2: Maior e menor valor");
 
      // ESCREVA SEU CÓDIGO AQU
      // 1. Criar um array de inteiros com 5 posições
      int[] numeros1 = { 10, 25, 8, 42, 15 };

            // 2. Inicializar variáveis maior e menor com o primeiro elemento (índice 0)
            int maior = numeros1[0];
            int menor = numeros1[0];

            // 3. Percorrer o array comparando cada elemento
            // Começamos o loop em 1, pois já usamos o 0 para inicializar
            for (int i = 1; i < numeros1.Length; i++)
            {
                // Verifica se o número atual é maior que o guardado
                if (numeros1[i] > maior)
                {
                    maior = numeros1[i];
                }

                // Verifica se o número atual é menor que o guardado
                if (numeros1[i] < menor)
                {
                    menor = numeros1[i];
                }
            }

            // 4. Exibir o maior e menor valor
            Console.WriteLine($"\nArray analisado: {string.Join(", ", numeros1)}");
            Console.WriteLine($"O MAIOR valor encontrado é: {maior}");
            Console.WriteLine($"O MENOR valor encontrado é: {menor}");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
   
      // Saida
      /**� Exercício 2: Maior e menor valor
      Array: [10, 25, 8, 42, 15]
      Maior valor: 42
      Menor valor: 8*/
      Console.WriteLine();
 
      // ===================================================
      // EXERCÍCIO 3: Cálculo da média
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Somar todos os elementos do array
      // 2. Dividir pela quantidade de elementos
      // 3. Exibir a média com 2 casas decimais
      //
      // 💡 double media = soma / array.Length;
 
      Console.WriteLine("\n📝 Exercício 3: Cálculo da média");
 
      // ESCREVA SEU CÓDIGO AQUI

       // 1. Usar o array dos exercícios anteriores
            int[] numeros2 = { 10, 25, 8, 42, 15 };

            int soma = 0;

            // 1. Somar todos os elementos do array
            for (int i = 0; i < numeros2.Length; i++)
            {
                soma += numeros2[i];
            }

            // 2. Dividir pela quantidade de elementos
            // IMPORTANTE: Usamos (double) para garantir que o resultado tenha casas decimais
            double media = (double)soma / numeros2.Length;

            // 3. Exibir a média com 2 casas decimais
            // O formato ":F2" ou "N2" limita as casas decimais
            Console.WriteLine($"\nSoma total: {soma}");
            Console.WriteLine($"Quantidade de elementos: {numeros2.Length}");
            Console.WriteLine($"A média dos valores é: {media:F2}");
            
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();


      //saida
      /**� Exercício 3: Cálculo da média
       Soma dos valores: 100
       Quantidade de elementos: 5
       Média: 20.00*/
      Console.WriteLine();
 
      // ===================================================
      // EXERCÍCIO 4: Inverter array
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar um novo array do mesmo tamanho
      // 2. Preencher o novo array com elementos na ordem inversa
      // 3. Exibir o array invertido
      //
      // 💡 invertido[i] = original[original.Length - 1 - i];
 
      Console.WriteLine("\n📝 Exercício 4: Array invertido");
 
      // ESCREVA SEU CÓDIGO AQUI
      // 1. Array original
            int[] original = { 10, 25, 8, 42, 15 };
            
      // 2. Criar um novo array do mesmo tamanho
            int[] invertido = new int[original.Length];

      // 3. Preencher o novo array com elementos na ordem inversa
            for (int i = 0; i < original.Length; i++)
            {
                // A fórmula: original.Length - 1 dá o último índice (4)
                // Subtraindo 'i', vamos recuando conforme o loop avança
                invertido[i] = original[original.Length - 1 - i];
            }

            // Exibir resultados
            Console.WriteLine("\nArray Original:  " + string.Join(", ", original));
            Console.WriteLine("Array Invertido: " + string.Join(", ", invertido));
     
     
      Console.WriteLine("\nPressione qualquer tecla para continuar...");
      Console.ReadKey();

      //Saida
      /**� Exercício 4: Array invertido
      Array original: [10, 25, 8, 42, 15]
      Array invertido: [15, 42, 8, 25, 10]*/
      Console.WriteLine();
 
      // ===================================================
      // RESUMO FINAL
      // ===================================================
      Console.WriteLine("\n📌 Resumo sobre arrays:");
      Console.WriteLine("new tipo[tamanho] → criar array");
      Console.WriteLine("array[índice]     → acessar elemento");
      Console.WriteLine("array.Length      → tamanho do array");
      Console.WriteLine("foreach           → percorrer array");
    }
  }



