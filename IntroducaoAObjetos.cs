using System.ComponentModel.DataAnnotations;

namespace Aula02EstruturaDeDados;

public class IntroducaoAObjetos
{
public void Executar()
{
    Console.WriteLine("Introdução a Instancias e Objetos\n");

    Pessoa pessoa = new Pessoa("Luis Lei", 57);
    Pessoa pessoa1 = new Pessoa();

    // Usando o Objeto ou Instancia

    Console.WriteLine("Nosso Objeto\n");

    pessoa.Apresentar();
    pessoa1.Apresentar();

    // modificando valores
    Console.WriteLine("Modificando valores sem o Get e o Set \n");
    
    pessoa.Nome= "AHAHAH";
    pessoa.Idade=18;
    pessoa.Apresentar();

    // Usando metodo de retorno
    Console.WriteLine("Metodos com retorno \n");
    Console.WriteLine($"{pessoa1.Nome} é maior de idade ?{pessoa1.EmaiorDeIdade()} \n");
    Console.WriteLine($"Ano de Nascimento aproximado:{pessoa1.CalcularAnoNascimento()} \n");

   // Nossa Lista
    Console.WriteLine("Nossa lista de objetos \n");
    List<Pessoa> pessoas = new List<Pessoa>();
    pessoas.Add(pessoa);
    pessoas.Add(pessoa1);

    pessoas.Add(new Pessoa());
    pessoas.Add(new Pessoa("Luis", 57));
    
    List<Object> minhaString = new List<object>();
    minhaString.Add(1);
    minhaString.Add("Luis");
    minhaString.Add(new Pessoa());



    pessoas.ForEach(data =>
    {
            data.Apresentar();
    });

    foreach (var item in pessoas)
    {
        item.Apresentar();
    }


    }
}// fim da class
