using System;
 
namespace Aula02EstruturaDeDados
{
  /// <summary>
  /// 🔤 EXERCÍCIOS DE MANIPULAÇÃO DE STRINGS
  /// =======================================
  ///
  /// Exercício 1: Contar vogais
  /// Exercício 2: Inverter string
  /// Exercício 3: Verificar palíndromo
  /// Exercício 4: Divisão e contagem de palavras
  /// </summary>
  public class AlunoManipulacaoStrings
  {
    public void Executar()
    {
      Console.WriteLine("\n\n🔤 5. EXERCÍCIOS DE MANIPULAÇÃO DE STRINGS");
      Console.WriteLine("==========================================\n");
 
      // ===================================================
      // EXERCÍCIO 1: Contar vogais
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar uma frase ao usuário
      // 2. Percorrer cada caractere da frase
      // 3. Verificar se é vogal (a, e, i, o, u, A, E, I, O, U)
      // 4. Contar e exibir o número de vogais
      //
      // 💡 string vogais = "aeiouAEIOU"; if (vogais.Contains(c))
 
      Console.WriteLine("📝 Exercício 1: Contagem de vogais");
      Console.Write("Digite uma frase: ");
 
      // ESCREVA SEU CÓDIGO AQUI
      //Saida
      /**� Exercício 1: Contagem de vogais
      Texto: 'Fundamentos de Programação C#'
      Número de vogais: 9*/
 
      Console.WriteLine();
 
      // ===================================================
      // EXERCÍCIO 2: Inverter string
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar uma palavra ao usuário
      // 2. Percorrer a palavra de trás para frente
      // 3. Construir a string invertida
      // 4. Exibir o resultado
      //
      // 💡 for (int i = palavra.Length - 1; i >= 0; i--)
      /*Explicação: 👉 Aqui acontece a "mágica":
       original.Length → tamanho da string (em "CSharp" é 6)
       Length - 1 → começa no último índice (5)
       i-- → vai andando para trás (5 → 4 → 3 → ... → 0)
💡     Ou seja: percorre a string do fim para o início**/
 
      Console.WriteLine("\n📝 Exercício 2: Inversão de string");
      Console.Write("Digite uma palavra: ");
 
      // ESCREVA SEU CÓDIGO AQUI
      //Saida
      /**� Exercício 2: Inversão de string
      String original: 'CSharp'
      String invertida: 'prahSC'*/
 
 
      Console.WriteLine();
 
      // ===================================================
      // EXERCÍCIO 3: Verificar palíndromo
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar uma palavra ao usuário
      // 2. Verificar se é palíndromo (lê-se igual de trás para frente)
      // 3. Comparar caractere da esquerda com caractere da direita
      // 4. Percorrer apenas até a metade da palavra
      //
      // 💡 palavra[i] != palavra[palavra.Length - 1 - i]
 
      Console.WriteLine("\n📝 Exercício 3: Verificação de palíndromo");
      Console.Write("Digite uma palavra: ");
 
      // ESCREVA SEU CÓDIGO AQUI
      //Saida
      /**� Exercício 3: Verificação de palíndromo
      Palavra: 'radar'
      É palíndromo? True*/
      Console.WriteLine();
 
      // ===================================================
      // EXERCÍCIO 4: Divisão e contagem de palavras
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar uma frase ao usuário
      // 2. Dividir a frase em palavras usando Split(' ')
      // 3. Exibir o número de palavras
      // 4. Exibir cada palavra individualmente
      //
      // 💡 string[] palavras = frase.Split(' ');
 
      Console.WriteLine("\n📝 Exercício 4: Divisão de frase em palavras");
      Console.Write("Digite uma frase: ");
 
      // ESCREVA SEU CÓDIGO AQUI
      //Saida
      /**� Exercício 4: Divisão de frase em palavras
      Frase: 'C# é uma linguagem de programação moderna'
      Número de palavras: 7
      Palavras individuais:
      - 'C#'
       - 'é'
      - 'uma'
      - 'linguagem'
      - 'de'
      - 'programação'
     - 'moderna'
     */
 
      Console.WriteLine();
 
      // ===================================================
      // RESUMO FINAL
      // ===================================================
      Console.WriteLine("\n📌 Resumo sobre manipulação de strings:");
      Console.WriteLine("Contains() → verificar se contém caractere");
      Console.WriteLine("ToUpper()  → converter para maiúsculas");
      Console.WriteLine("Split()    → dividir string");
      Console.WriteLine("Length     → tamanho da string");
    }
  }
}
 