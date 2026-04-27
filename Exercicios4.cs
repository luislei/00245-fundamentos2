using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Aula02EstruturaDeDados;
 
/// <summary>
/// 📋 EXERCÍCIOS DE LISTAS (LIST<T>)
/// =================================
///
/// Exercício 1: Adicionar pessoas à lista
/// Exercício 2: Remover pessoa pelo nome
/// Exercício 3: Filtrar pessoas com mais de 30 anos
/// Exercício 4: Contar pessoas com nome começando com "J"
/// </summary>
public class AlunoExercicio04
{
  /// <summary>
  /// Classe Pessoa para representar os dados
  /// </summary>
  public class Pessoa
  {
    //Atributos públicos para facilitar o acesso
    public string Nome;
    public int Idade;
 
    //Construtor para facilitar a criação de objetos
    // O construtor é um método especial que é chamado quando criamos um novo objeto da classe. Ele é usado para inicializar os atributos do objeto.
    public Pessoa(string nome, int idade)
    {
      Nome = nome;
      Idade = idade;
    }
 
    // "override "é forma de "Sobrescreve" qualquer  método, neste exemplo o ToString(). Usamos para exibir os dados de forma legível
    // isto faz parte do polimorfismo, onde cada classe pode ter sua própria implementação de um método
    // maiores detalhes na  UC00608 P.O.O .Assim, quando chamamos Console.WriteLine(pessoa), ele exibe o nome e idade formatados
    public override string ToString()
    {
      return $"{Nome} ({Idade} anos)";
    }
  }
 
  public void Executar()
  {
    Console.WriteLine("\n\n📋 3. EXERCÍCIOS DE LISTAS (LIST<T>)");
    Console.WriteLine("=====================================\n");
 
    // ===================================================
    // EXERCÍCIO 1: Adicionar pessoas à lista
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar uma List<Pessoa> com os dados iniciais
    // 2. Adicionar mais 3 pessoas à lista usando .Add()
    // 3. Exibir todas as pessoas da lista
    //
    // 💡 List<T> é uma coleção dinâmica que pode crescer
    // 💡 pessoas.Add(new Pessoa("Nome", idade));
 
    Console.WriteLine("📝 Exercício 1: Adicionar pessoas à lista");
 
    // Criando lista inicial
    // ESCREVA SEU CÓDIGO AQUI - Adicionar mais 3 pessoas

    Console.WriteLine("=== Gestão de Lista de Pessoas ===\n");

            // 1. Criar uma List<Pessoa> com dados iniciais
            List<Pessoa> listaPessoas = new List<Pessoa>
            {
                new Pessoa("Ana", 25),
                new Pessoa("Bruno", 30),
                new Pessoa("Carla", 35),
                new Pessoa("Daniel", 28),
                new Pessoa("Eduarda", 40)
            };

            // 2. Adicionar mais 3 pessoas à lista usando .Add()
            listaPessoas.Add(new Pessoa("Fernando", 22));
            listaPessoas.Add(new Pessoa("Grabiela", 45));
            listaPessoas.Add(new Pessoa("Hugo", 33));

            // 3. Exibir todas as pessoas da lista
            // Usamos o foreach para percorrer cada objeto 'p' dentro da lista
            Console.WriteLine("Lista Atualizada:");
            Console.WriteLine("----------------------------");
            foreach (Pessoa p in listaPessoas)
            {
                Console.WriteLine($"Nome: {p.Nome.PadRight(10)} | Idade: {p.Idade}");
            }
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Total de pessoas: {listaPessoas.Count}");

            
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
 
    //Saida esperada:
    /**📝 Exercício 1: Adicionar pessoas à lista
    Lista inicial:
      - Ana (25 anos)
      - Bruno (30 anos)
      - Carla (35 anos)
      - Daniel (28 anos)
      - Eduarda (40 anos)
 
    Lista após adicionar 3 pessoas:
      - Ana (25 anos)
      - Bruno (30 anos)
      - Carla (35 anos)
      - Daniel (28 anos)
      - Eduarda (40 anos)
      - Fernando (22 anos)
      - Gabriela (45 anos)
      - Hugo (33 anos)*/
    Console.WriteLine();
 
    // ===================================================
    // EXERCÍCIO 2: Remover pessoa pelo nome
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Usar o método RemoveAll() com uma condição (lambda)
    // 2. Remover a pessoa chamada "Ana" independente do índice
    // 3. Exibir a lista atualizada
    //
    // 💡 pessoas.RemoveAll(p => p.Nome == "Ana");
    // 💡 Lambda: p => condição (p é cada elemento da lista)
 
    Console.WriteLine("\n📝 Exercício 2: Remover pessoa pelo nome");
 
    // ESCREVA SEU CÓDIGO AQUI - Remover "Ana"
 
 // 1. Criar a lista 
            List<Pessoa> listaPessoas1 = new List<Pessoa>
            {
                new Pessoa("Ana", 25),
                new Pessoa("Carlos", 30),
                new Pessoa("Ricardo", 22),
                new Pessoa("Marta", 28),
                new Pessoa("João", 35)
            };

            Console.WriteLine("--- Lista antes da remoção ---");
            ExibirLista(listaPessoas1);

            // 2. Remover a pessoa chamada "Ana" usando Lambda
            // Esta linha lê-se: "Remova todos os 'p' onde o Nome de 'p' seja igual a Ana"
            int removidos = listaPessoas1.RemoveAll(p => p.Nome == "Ana");

            // 3. Exibir a lista atualizada
            Console.WriteLine($"\n--- Lista após remover 'Ana' ({removidos} remoção) ---");
            ExibirLista(listaPessoas1);
 
 // Método auxiliar para não repetir código de exibição
        static void ExibirLista(List<Pessoa> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("A lista está vazia.");
            }
            foreach (var p in lista)
            {
                Console.WriteLine($"- {p.Nome}, {p.Idade} anos");
            }
        }

        
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

    //Saida esperada:
    /**📝 Exercício 2: Remover pessoa pelo nome
    Pessoas removidas: 1
 
    Lista após remover 'Ana':
      - Bruno (30 anos)
      - Carla (35 anos)
      - Daniel (28 anos)
      - Eduarda (40 anos)
      - Fernando (22 anos)
      - Gabriela (45 anos)
      - Hugo (33 anos)*/
    Console.WriteLine();
 
    // ===================================================
    // EXERCÍCIO 3: Filtrar pessoas com mais de 30 anos
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Usar o método FindAll() para filtrar a lista
    // 2. Buscar todas as pessoas com idade > 30
    // 3. Exibir o resultado
    //
    // 💡 List<Pessoa> filtradas = pessoas.FindAll(p => p.Idade > 30);
    // 💡 Também pode usar LINQ: pessoas.Where(p => p.Idade > 30).ToList()
 
    Console.WriteLine("\n📝 Exercício 3: Buscar pessoas com mais de 30 anos");
  
    // ESCREVA SEU CÓDIGO AQUI - Filtrar pessoas com idade > 30
        // 1. Criar a lista

        List<Pessoa> listaPessoas2 = new List<Pessoa>
            {
                new Pessoa("Ana", 25),
                new Pessoa("Carlos", 30),
                new Pessoa("Ricardo", 22),
                new Pessoa("Marta", 32),
                new Pessoa("João", 45),
                new Pessoa("Sofia", 31)
            };

            Console.WriteLine("--- Lista Completa ---");
            ExibirLista2(listaPessoas2);

            // 2. Usar o método FindAll() para filtrar (Idade > 30)
            List<Pessoa> pessoasMaisDe30 = listaPessoas2.FindAll(p => p.Idade > 30);

            // 3. Exibir o resultado do FindAll
            Console.WriteLine("\n--- Pessoas com mais de 30 anos (FindAll) ---");
            ExibirLista2(pessoasMaisDe30);

            // Usando LINQ (forma muito comum em projetos profissionais)
            // O .Where filtra e o .ToList() converte o resultado de volta para uma lista
            var filtradasLinq = listaPessoas2.Where(p => p.Idade > 30).ToList();
            
            Console.WriteLine("\n--- Verificação com LINQ (mesmo resultado) ---");
            Console.WriteLine($"Total encontrado: {filtradasLinq.Count}");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        

        static void ExibirLista2(List<Pessoa> lista)
        {
            if (lista.Count == 0) Console.WriteLine("Nenhum resultado encontrado.");
            foreach (var p in lista)
            {
                Console.WriteLine($"- {p.Nome} ({p.Idade} anos)");
            }
        }
 
    //Saida esperada:
    /**📝 Exercício 3: Buscar pessoas com mais de 30 anos
    Pessoas com mais de 30 anos (3):
      - Carla (35 anos)
      - Eduarda (40 anos)
      - Gabriela (45 anos)*/
    Console.WriteLine();
 
    // ===================================================
    // EXERCÍCIO 4: Contar pessoas com nome começando com "J"
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar um método chamado ContarPessoasComJ
    // 2. O método deve receber a lista e retornar a quantidade
    // 3. Usar StartsWith() para verificar se o nome começa com "J"
    // 4. Chamar o método e exibir o resultado
    //
    // 💡 string.StartsWith("J", StringComparison.OrdinalIgnoreCase)
    // 💡 Para ignorar maiúsculas/minúsculas
 
    Console.WriteLine("\n📝 Exercício 4: Contar pessoas com nome começando com 'J'");
 
    // Adicionar algumas pessoas com nome começando com J para teste

 
    // ESCREVA SEU CÓDIGO AQUI - Chamar o método ContarPessoasComJ
 
 // 1. Criar a lista e adicionar as pessoas conforme a saída esperada
            List<Pessoa> listaPessoas3 = new List<Pessoa>
            {
                new Pessoa("Bruno", 30),
                new Pessoa("Carla", 35),
                new Pessoa("Daniel", 28),
                new Pessoa("Eduarda", 40),
                new Pessoa("Fernando", 22),
                new Pessoa("Gabriela", 45),
                new Pessoa("Hugo", 33),
                new Pessoa("João", 29),
                new Pessoa("Julia", 31),
                new Pessoa("Jéssica", 27),
                new Pessoa("José", 42)
            };

            // Exibir a lista completa
            Console.WriteLine("\nLista completa:");
            foreach (var p in listaPessoas3)
            {
                Console.WriteLine($"  - {p.Nome} ({p.Idade} anos)");
            }

            // 4. Chamar o método ContarPessoasComJ e exibir o resultado
            int quantidade = ContarPessoasComJ(listaPessoas3);

            Console.WriteLine($"\n✅ Total de pessoas cujo nome começa com 'J': {quantidade}");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        
        // 2. Método ContarPessoasComJ
        static int ContarPessoasComJ(List<Pessoa> pessoas)
        {
            int contador = 0;

            foreach (var p in pessoas)
            {
                // 3. Usar StartsWith() ignorando maiúsculas/minúsculas
                if (p.Nome.StartsWith("J", StringComparison.OrdinalIgnoreCase))
                {
                    contador++;
                }
            }

            return contador;
        }

    //Saida esperada:
    /**📝 Exercício 4: Contar pessoas com nome começando com 'J'
 
    Lista completa (com nomes começando com J):
      - Bruno (30 anos)
      - Carla (35 anos)
      - Daniel (28 anos)
      - Eduarda (40 anos)
      - Fernando (22 anos)
      - Gabriela (45 anos)
      - Hugo (33 anos)
      - João (29 anos)
      - Julia (31 anos)
      - Jéssica (27 anos)
      - José (42 anos)
 
    Número de pessoas com nome começando com 'J': 4*/
    Console.WriteLine();
 
    // ===================================================
    // RESUMO FINAL
    // ===================================================
    Console.WriteLine("\n📌 Resumo sobre Listas (List<T>):");
    Console.WriteLine("new List<T>()              → criar lista vazia");
    Console.WriteLine("lista.Add(item)            → adicionar item");
    Console.WriteLine("lista.RemoveAll(condição)  → remover por condição");
    Console.WriteLine("lista.FindAll(condição)    → filtrar itens");
    Console.WriteLine("lista.Count                → tamanho da lista");
    Console.WriteLine("lambda (p => p.Idade > 30) → expressão de condição");
    Console.WriteLine("StartsWith()               → verificar início da string");
  }
 
}
 
 