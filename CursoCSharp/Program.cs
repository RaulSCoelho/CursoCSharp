using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},

                // Estruturas de Controle
                {"Estrutura ForEach - Estruturas De Controle", EstruturaForEach.Executar},
                {"Estrutura Switch - Estruturas De Controle", EstruturaSwitch.Executar},

                // Classes e Metodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Parâmetros - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"GetSet - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Read Only - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Class Vs Struct - Classes e Métodos", ClassVsStruct.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},
                
                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstract - Orientação a Objetos", Abstract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},

                // Métodos E Funções
                {"Exemplo Lambda - Orientação a Objetos", ExemploLambda.Executar},
                {"Delegate com Lambda - Orientação a Objetos", LambdasDelegate.Executar},
                {"Usando Delegate - Orientação a Objetos", UsandoDelegates.Executar},
                {"Delegate com Funções Anônimas - Orientação a Objetos", DelegateFuncAnonima.Executar},
                {"Delegates Como Parametros - Orientação a Objetos", DelegatesComoParametros.Executar},
                {"Metodos De Extensao - Orientação a Objetos", MetodosDeExtensao.Executar},
                
                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},
                
                // Explorando API
                {"Primeiro Arquivo - Explorando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Explorando API", LendoArquivos.Executar},
                {"FileInfo - Explorando API", ExemploFileInfo.Executar},
                {"Diretórios - Explorando API", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Explorando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Explorando API", ExemploPath.Executar},
                {"Exemplo DateTime - Explorando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Explorando API", ExemploTimeSpan.Executar},

                // Tópicos Avançados
                {"LINQ1 - Explorando API", LINQ1.Executar},
                {"LINQ2 - Explorando API", LINQ2.Executar},
                {"Nullables - Explorando API", Nullables.Executar},
                {"Dynamics - Explorando API", Dynamics.Executar},
                {"Genericos - Explorando API", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
