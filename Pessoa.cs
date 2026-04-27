namespace Aula02EstruturaDeDados;

public class Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa (string nome ="Luis", int idade=55)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
    
    public void Apresentar() => Console.WriteLine($"Nome: {this.Nome}, Idade: {this.Idade}");

    public bool EmaiorDeIdade() => this.Idade >= 18;

    public int CalcularAnoNascimento() => DateTime.Now.Year - this.Idade;

    
    }