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

        ArrayUnidimensional arrayUnidimensional = new ArrayUnidimensional();
        arrayUnidimensional.ExecutarArrayUnidimensional();

        ManipulacaoDeString manipulacaoDeString = new ManipulacaoDeString();
        manipulacaoDeString.ExecutarMetodosBasicos();

        manipulacaoDeString.ExecutarBuscaExtraccao();

        manipulacaoDeString.ExecutarModificacao();

        manipulacaoDeString.ExecutarDivisaoJuncao();

        IntroducaoAObjetos introducaoAObjetos = new IntroducaoAObjetos();
        introducaoAObjetos.Executar();

        AlunoFuncoesMetodos alunoFuncoesMetodos = new AlunoFuncoesMetodos();
        alunoFuncoesMetodos.Executar();
        
           }    
}