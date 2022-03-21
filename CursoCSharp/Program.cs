using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClasseeMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using static CursoCSharp.OO.Comida;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Coversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},{"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},{"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},{"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},{"Operadores Ternários - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controles
                {"Estruturas if - Estruturas de controle", EstruturaIf.Executar},
                {"Estruturas if/else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estruturas if/else/if - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controle", While.Executar},
                {"Estrutura Do While - Estruturas de controle", DoWhile.Executar},                {"Método com retorno - Classes e Metodos", MetodosComRetorno.Executar},

                {"Estrutura For - Estruturas de controle", For.Executar},
                {"Estrutura For Each - Estruturas de controle", ForEach.Executar},

                //Classes e Metodos
                {"Membros classes e metódos - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Métodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Parametros Variaveis - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Metodos Get e Set - Classes e Metodos", GetSet.Executar},
                {"Propriedades - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", EnumExemplo.Executar},
                {"Classe vs Struct- Classes e Metodos", ClasseVsStruct.Executar},
                {"Parametros por valor vs referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros por referencia - Classes e Metodos", ParametroPorReferencia.Executar},
                {"Parametros por padrão - Classes e Metodos", ParametroPorPadrao.Executar},
                //Colções
                 { "Array - Coleções", Colecoes.Array.Executar},
                 { "List - Coleções", List.Executar},
                 { "Array List - Coleções", ColecoesArrayList.Executar},
                 { "Set - Coleções", ColecoesSet.Executar},
                 { "Queeu - Coleções", ColecoesQueue.Executar},
                 { "Igualdade - Coleções", Igualdade.Executar},
                 { "Stack - Coleções", ColecoesStack.Executar},
                 { "Dicitionary - Coleções", ColecoesDictionary.Executar},

                 //OO
                   { "Herança - OO", Heranca.Executar},
                   { "Construtor This - OO", ConstrutorThis.Executar},
                   { "Encapsulamento - OO", OO.Encapsulamento.Executar},
                   { "Polimorfismo - OO", Polimorfismo.Executar},
                   { "Classe Asbtrata - OO", Abstract.Executar},
                   { "Selead - OO", Sealed.Executar},

                   //Metodos e Funções
                   { "Lambda Exemplo - Metodos & Funções", ExemploLambda.Executar},
                   { "Lambdas como Delegates - Metodos & Funções", LambdasDelegate.Executar},
                   { "Usando Delegates - Metodos & Funções", UsandoDelegate.Executar},
                   { "Delegates c/ Func anonimas - Metodos & Funções", DelegateFuncAnonima.Executar},
                   { "Delegates Parametros - Metodos & Funções", DelegatesParametro.Executar},
                   { "Metodos de Extensão - Metodos & Funções", MetodosDeExtensao.Executar},

                   //Exceções e Erros
                   { "Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                   { "Exceções Personalizada - Exceções", ExcecoesPersonalizadas.Executar},

                   //Explorando API
                   { "Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                   { "Lendo Arquivos - Usando API", LendoArquivos.Executar},
                   { "Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                   { "Diretorios - Usando API", Diretorios.Executar},
                   { "Diretory Info - Usando API", ExemploDirectoryInfo.Executar},
                   { "Usando Path - Usando API", UsandoPath.Executar},
                   { "Exemplo Date Time - Usando API", ExemploDateTime.Executar},
                   { "Exemplo TaimeSpan - Usando API", ExemploTimeSpan.Executar},

                   //Tópicos avançados
                   { "LINQ parte 1 - Tópicos Avançados", Linq1.Executar},
                   { "LINQ parte 2 - Tópicos Avançados", Linq2.Executar},
                   { "Nullables - Tópicos Avançados", Nullables.Executar},
                   { "Dynamic - Tópicos Avançados", Dynamic.Executar},
                   { "Generics - Tópicos Avançados", Genericos.Executar},
             });

            central.SelecionarEExecutar();
        }
    }
}