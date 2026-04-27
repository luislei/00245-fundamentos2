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
 
      // ESCREVA SEU CÓDIGO AQUI
      // 1. Solicitar uma frase ao utilizador
            Console.Write("\nDigite uma frase ou palavra: ");
            string frase = Console.ReadLine();

            // 2. Definir o que é uma vogal e preparar o contador
            string vogais = "aeiouAEIOUáéíóúàèìòùâêîôûãõäëïöü"; // Incluímos acentuadas por precaução
            int contadorVogais = 0;

            // 3. Percorrer cada caractere da frase
            // Usamos o loop foreach que é perfeito para percorrer strings
            foreach (char c in frase)
            {
                // Verifica se o caractere atual está dentro da string de vogais
                if (vogais.Contains(c))
                {
                    contadorVogais++;
                }
            }

            // 4. Exibir o resultado
            Console.WriteLine($"\nFrase analisada: \"{frase}\"");
            Console.WriteLine($"Total de vogais encontradas: {contadorVogais}");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
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
 
      // ESCREVA SEU CÓDIGO AQUI

           // 1. Solicitar uma palavra ao utilizador
            Console.Write("\nDigite uma palavra para inverter: ");
            string original = Console.ReadLine();

            string invertida = "";

            // 2. Percorrer a palavra de trás para frente
            // Começamos no último índice e vamos até o 0
            for (int i = original.Length - 1; i >= 0; i--)
            {
                // 3. Construir a string invertida concatenando cada caractere
                invertida += original[i];
            }

            // 4. Exibir o resultado
            Console.WriteLine($"\nPalavra original: {original}");
            Console.WriteLine($"Palavra invertida: {invertida}");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

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
 
      // ESCREVA SEU CÓDIGO AQUI
            // 1. Solicitar uma palavra ao utilizador
            Console.Write("\nDigite uma palavra: ");
            string palavra = Console.ReadLine();

            // Chamada do método de verificação
            bool ehPalindromo = VerificarSeEPalindromo(palavra);

            // 3. Exibir o resultado
            if (ehPalindromo)
            {
                Console.WriteLine($"\n✅ A palavra \"{palavra}\" É um palíndromo!");
            }
            else
            {
                Console.WriteLine($"\n❌ A palavra \"{palavra}\" NÃO é um palíndromo.");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            static bool VerificarSeEPalindromo(string texto)
        {
            // Tratamento básico: remover espaços e converter para minúsculas
            // Isso garante que "Ana" seja considerado palíndromo
            string formatada = texto.Replace(" ", "").ToLower();

            // 4. Percorrer apenas até a metade da palavra
            for (int i = 0; i < formatada.Length / 2; i++)
            {
                // 3. Comparar caractere da esquerda (i) com o da direita (fim - i)
                if (formatada[i] != formatada[formatada.Length - 1 - i])
                {
                    return false; // Se um for diferente, interrompe e retorna falso
                }
            }

            return true; // Se o loop terminar sem divergências, é palíndromo
        }

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
 
      // ESCREVA SEU CÓDIGO AQUI

      // 1. Solicitar uma frase ao usuário
            Console.Write("\nDigite uma frase: ");
            string frase1 = Console.ReadLine();

            // 2. Dividir a frase em palavras usando Split(' ')
            // O StringSplitOptions.RemoveEmptyEntries evita contar espaços duplos como palavras
            string[] palavras = frase1.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // 3. Exibir o número de palavras
            Console.WriteLine($"\n📊 Análise da frase:");
            Console.WriteLine($"Total de palavras encontradas: {palavras.Length}");

            // 4. Exibir cada palavra individualmente
            Console.WriteLine("\nPalavras da lista:");
            for (int i = 0; i < palavras.Length; i++)
            {
                Console.WriteLine($"- Palavra {i + 1}: {palavras[i]}");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

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
 