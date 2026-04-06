namespace Aula02EstruturaDeDados;

class program

{
 static void Main(string[] args)
    {
        Console.WriteLine("US00606 Estrutura da Dados\n");

        EstruraDeIteracao estruraDeIteracao = new EstruraDeIteracao();
        estruraDeIteracao.ExecutarFor();

        estruraDeIteracao.ExecutarForEach();
        // em opção
        // new  EstruraDeIteracao.ExecutarForEach();

        estruraDeIteracao.ExecutarForBreakContinue();

        estruraDeIteracao.ExecutarWhile();

        estruraDeIteracao.ExecutarDoWhile();

    }    
}