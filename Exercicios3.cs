using System;
 
namespace Aula02EstruturaDeDados;

  /// <summary>
  /// 🎯 EXERCÍCIOS DE FUNÇÕES E MÉTODOS
  /// ==================================
  ///
  /// Exercício 1: Fatorial
  /// Exercício 2: Números primos
  /// Exercício 3: Função com parâmetros opcionais
  /// Exercício 4: Ordenação de array
  /// </summary>
  public class AlunoFuncoesMetodos
  {
    public void Executar()
    {
      Console.WriteLine("\n\n🎯 6. EXERCÍCIOS DE FUNÇÕES E MÉTODOS");
      Console.WriteLine("====================================\n");
 
      // ===================================================
      // EXERCÍCIO 1: Fatorial
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar um número ao usuário
      // 2. Criar um método chamado CalcularFatorial que:
      //    - Recebe um int como parâmetro
      //    - Retorna um long
      //    - Calcula o fatorial usando loop for
      //    - Trata casos especiais (0! = 1)
      // 3. Exibir o resultado
      //
      // 💡 Fórmula: 5! = 5 × 4 × 3 × 2 × 1 = 120
 
      Console.WriteLine("📝 Exercício 1: Cálculo do fatorial");
      Console.Write("Digite um número para calcular o fatorial: ");
 
      // ESCREVA SEU CÓDIGO AQUI
      Console.WriteLine("=== Cálculo de Fatorial ===");
            
            int numero = -1;
            bool entradaValida = false;

            // Loop para garantir que o programa não pare até ter um número válido
            while (!entradaValida)
            {
                Console.Write("\nDigite um número inteiro positivo: ");
                string input = Console.ReadLine();

                // Tenta converter e verifica se é positivo
                if (int.TryParse(input, out numero) && numero >= 0)
                {
                    entradaValida = true; // Sai do loop
                }
                else
                {
                    Console.WriteLine("❌ Entrada inválida! O número deve ser inteiro e maior ou igual a zero.");
                }
            }

            // Agora que temos um número válido, calculamos e exibimos
            long resultado = CalcularFatorial(numero);
            Console.WriteLine($"\n✅ O Fatorial de : {numero}! = {resultado}");


        

        static long CalcularFatorial(int n)
        {
            if (n == 0) return 1;

            long fatorial = 1;
            for (int i = 2; i <= n; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
      // Saida
      /*  � Exercício 1: Cálculo do fatorial
     Digite um número para calcular o fatorial: Número: 5
     5! = 120
      */

      Console.WriteLine();
 
      // ===================================================
      // EXERCÍCIO 2: Números primos
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar um número ao usuário
      // 2. Criar um método chamado VerificarPrimo que:
      //    - Recebe um int como parâmetro
      //    - Retorna bool (true se primo, false se não)
      //    - Verifica se número é primo
      // 3. Exibir o resultado
      //
      // 💡 Número primo: divisível apenas por 1 e por ele mesmo
 
      Console.WriteLine("\n📝 Exercício 2: Verificação de números primos");
     
 
      // ESCREVA SEU CÓDIGO AQUI

            int numeroprimo = 0;
            bool entradaValida1 = false;

            while (!entradaValida1)
            {
                 Console.Write("Digite um número para verificar se é primo: ");
                if (int.TryParse(Console.ReadLine(), out numeroprimo))
                {
                    entradaValida1 = true;
                }
                else
                {
                    Console.WriteLine("❌ Por favor, digite um número inteiro válido.");
                }
            }

            // 3. Exibir o resultado chamando o método
            if (VerificarPrimo(numeroprimo))
            {
                Console.WriteLine($"\n✅ O número {numeroprimo} é PRIMO.");
            }
            else
            {
                Console.WriteLine($"\n❌ O número {numeroprimo} NÃO é primo.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        

        // 2. Método VerificarPrimo
        static bool VerificarPrimo(int n)
        {
            // Números menores ou iguais a 1 não são primos
            if (n <= 1) return false;
            
            // O 2 é o único primo par
            if (n == 2) return true;
            
            // Elimina números pares logo de início
            if (n % 2 == 0) return false;

            // Verifica divisores ímpares a partir de 3
            // Vamos testar até a raiz quadrada de n (otimização matemática)
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false; // Encontrou um divisor, logo não é primo
                }
            }

            return true; // Se chegou aqui, é primo
        }


      //Saida
      /**� Exercício 2: Verificação de números primos
      Digite um número para verificar se é primo: Número: 13
      13 é primo? True*/
      Console.WriteLine();
 
      // ===================================================
      // EXERCÍCIO 3: Função com parâmetros opcionais
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar um método chamado SaudacaoPersonalizada que:
      //    - Parâmetro nome com valor padrão "Visitante"
      //    - Parâmetro formal com valor padrão false
      //    - Se formal → "Prezado(a) {nome}, seja bem-vindo(a)!"
      //    - Se informal → "Olá {nome}! Bem-vindo(a)!"
      // 2. Testar diferentes chamadas
      //
      // 💡 void Saudacao(string nome = "Visitante", bool formal = false)
 
      Console.WriteLine("\n📝 Exercício 3: Saudação com parâmetros opcionais");
 
      // ESCREVA SEU CÓDIGO AQUI

        Console.WriteLine("=== Teste de Saudações ===\n");

            // 2. Testar diferentes chamadas
            
            // Caso 1: Sem nenhum parâmetro (usa todos os padrões)
            SaudacaoPersonalizada();

            // Caso 2: Passando apenas o nome (formal assume o padrão false)
            SaudacaoPersonalizada("Luis");

            // Caso 3: Passando nome e mudando para formal
            SaudacaoPersonalizada("Luis Lei", true);

            // Caso 4: Usando argumentos nomeados (útil quando queremos pular um parâmetro)
            SaudacaoPersonalizada(formal: true); 

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        
        // 1. Método SaudacaoPersonalizada com parâmetros opcionais
        static void SaudacaoPersonalizada(string nome = "Visitante", bool formal = false)
        {
            if (formal)
            {
                Console.WriteLine($"Prezado(a) {nome}, seja bem-vindo(a)!");
            }
            else
            {
                Console.WriteLine($"Olá {nome}! Bem-vindo(a)!");
            }
        }


      //Saida
      /**� Exercício 3: Saudação com parâmetros opcionais
      Olá Visitante! Bem-vindo(a)!
      Olá Ana! Bem-vindo(a)!
      Prezado(a) Bruno, seja bem-vindo(a)!*/
      Console.WriteLine();
 
      // ===================================================
      // EXERCÍCIO 4: Ordenação de array
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar um array de inteiros: { 34, 7, 23, 32, 5, 62 }
      // 2. Exibir o array original
      // 3. Usar Array.Sort(array) para ordenar
      // 4. Exibir o array ordenado
      /**
      Explicação
       porque do Join?
       Console.WriteLine(array); //O resultado NÃO vai ser: 34, 7, 23, 32, 5, 62, porque não ITERIU
       Vai ser algo tipo: System.Int32[] // Porque o Console.WriteLine não sabe como transformar o array numa string legível.
       Para que serve o string.Join? //string.Join(", ", array)
       👉 Ele pega no array e:
       Converte cada número para texto
       Junta tudo numa única string
       Coloca ", " entre os valores
 
      👉 Aqui está a parte mais importante:
      Usa o método Sort da classe Array
      Ordena os números automaticamente
      Ordem padrão: crescente (menor → maior)*/
      // 💡 Array.Sort() ordena em ordem crescente
 
      Console.WriteLine("\n📝 Exercício 4: Ordenação de array");
 
      // ESCREVA SEU CÓDIGO AQUI

       Console.WriteLine("=== Ordenação de Arrays ===\n");

            // 1. Criar um array de inteiros
            int[] numeros = { 34, 7, 23, 32, 5, 62 };

            // 2. Exibir o array original
            // Usamos o string.Join para "colar" os números com uma vírgula entre eles
            Console.WriteLine("Array Original: " + string.Join(", ", numeros));

            // 3. Usar Array.Sort(array) para ordenar
            // Este método altera o array original diretamente (in-place)
            Array.Sort(numeros);

            // 4. Exibir o array ordenado
            Console.WriteLine("Array Ordenado: " + string.Join(", ", numeros));

            // extra: Se quisesses inverter a ordem (decrescente)
            Array.Reverse(numeros);
            Console.WriteLine("Array Decrescente: " + string.Join(", ", numeros));


            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
      //saida
      /**� Exercício 4: Ordenação de array
      Array original: [34, 7, 23, 32, 5, 62]
      Array ordenado: [5, 7, 23, 32, 34, 62]*/
      Console.WriteLine();
 
      // ===================================================
      // RESUMO FINAL
      // ===================================================
      Console.WriteLine("\n📌 Resumo sobre funções e métodos:");
      Console.WriteLine("static tipo Nome(parâmetros) { } → criar método");
      Console.WriteLine("return valor → retornar valor");
      Console.WriteLine("parâmetro = valor → parâmetro opcional");
      Console.WriteLine("Array.Sort() → ordenar array");
    }
    
    }
    