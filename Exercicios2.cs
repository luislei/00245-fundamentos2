

 using System;
 
namespace Aula02EstruturaDeDados
{
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
 
      // ESCREVA SEU CÓDIGO AQUI
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
}


