namespace Aula02EstruturaDeDados;

public class ManipulacaoDeString
{
    public void ExecutarMetodosBasicos()
{
    Console.WriteLine("Manipulação básica de strings\n");

    string texto = " Fundamentos de Programação C# ";
    string nome = "Luis Lei";
    string frase ="O rato roeu a corda";

    Console.WriteLine("String original\n");
    Console.WriteLine($"{texto}");


    Console.WriteLine("Executar Metodos Basicos\n");
    Console.WriteLine($"ToUpper() converte todos os carateres para Maiusculas: {texto.ToUpper()}");
    Console.WriteLine($"ToLower() converte todos os carateres para Minusculas: {texto.ToLower()}");

    Console.WriteLine($"Trim () remove espaços em branco do inicio e do fim: {texto.Trim()}");

    Console.WriteLine($"Lenght () retorna o numero de carateres {frase.Length}");

}
    public void ExecutarBuscaExtraccao()
    {
        Console.WriteLine("Manipulação básica de strings\n");
        string texto = " Fundamentos de Programação C# ";

        Console.WriteLine("Busca e Extração\n");
        int posicao = texto.IndexOf("C#");

        Console.WriteLine($"IndexOf ('C#') procura a posição (indice) da 1ª ocorrencia: {posicao}");
        
        Console.WriteLine($"Substring (5 , 10) extrai 10 carateres começando na posição 5: {texto.Substring(5, 10)}");

        Console.WriteLine($"startWith ('fund') verifica se a string começa por fund: {texto.TrimStart().StartsWith("fund")}");
        
        Console.WriteLine($"endWith ('C#') verifica se a string termina por c#: {texto.TrimEnd().EndsWith("C#")}");


    }

    public void ExecutarModificacao()
    {
        Console.WriteLine("Manipulação básica de strings\n");
        string texto = " Fundamentos de Programação C# ";

        Console.WriteLine("Modificação\n");


        Console.WriteLine($"Replace ('C#', CSharp) substitui o texto: {texto.Replace("C#","CSharp")}");

        Console.WriteLine($"Remove (5,10) remove 10 carateres a partir do 5: {texto.Remove(5,10)}");
        Console.WriteLine($"Insert (15, 'Avançados') insere avançados na posicão 15: {texto.Insert(15,"Avançados")}");
        
        

    }
    public void ExecutarDivisaoJuncao()
    {
        Console.WriteLine("Manipulação básica de strings\n");
        string texto = " Fundamentos de Programação C# ";

        Console.WriteLine("Divisão e Junção\n");


        Console.WriteLine($"Replace ('C#', CSharp) substitui o texto: {texto.Replace("C#","CSharp")}");

       string[] palavras = texto.Split(" ");
        Console.WriteLine("Split por espaço, divide a string num array");

        foreach (var item in palavras)
        {
            Console.WriteLine($" '{item}' ");
        }
        // join

        string novotexto = string.Join(" | ", palavras);
        Console.WriteLine($"Junta o array numa unica string {novotexto}");

        // Concatenação

        string nome = "Luis";
        string nick = "Lei";

        Console.WriteLine($"Concatenação de textos: {nome} {nick}");
        Console.WriteLine($"Concatenaçao de textos" +nome +" "+nick);
    }

}
