# NumerosExtensos
 Pacote que permite escrever os numerais da língua portuguesa (PT-BR) por extenso.

## Introdução
Para começar instale o pacote [Nuget](https://www.nuget.org/packages/NumerosExtensos/).

Atualmente o pacote suporta os números:
* Cardinais: Suporta até a casa do vigintilhões.
* Ordinais: Suporta até a casa do vigintilionésimo.
* Romanos: Suporta até 3999.

## Uso

Exemplo de uso simplificado:

```csharp
using NumerosExtensos;
using NumerosExtensos.Enums;
using NumerosExtensos.Options;
using NumerosExtensos.Options.Numerais;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuNumero = 25.03M;

            var extensoOptions = new ExtensoOptions
            {
                Tipo = TipoNumerais.Cardinais,
                NumeraisOptions = new CardinaisOptions
                {
                    Conjuncao = "Vírgula",
                    ZeroExplicitoParteDecimal = true,
                    // Configure aqui o resto das opções
                }
            };

            var extenso = new Extenso();
            var escrever = extenso.Escrever(extensoOptions);
            var numeroPorExtenso = escrever.Numero(meuNumero.ToString());
            Console.WriteLine(numeroPorExtenso);
            // Vinte E Cinco Vírgula Zero Três
        }
    }
}
```

Para facilitar uso, também é possível escolher algumas configurações já predefinidas, como por exemplo:

```csharp
using NumerosExtensos;
using NumerosExtensos.Enums;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuNumero = 25.03M;

            var extenso = new Extenso();
            var escrever = extenso.Escrever(OpcoesPredefinidas.Predefinicoes[Predefinicoes.MonetarioBRL]);
            var numeroPorExtenso = escrever.Numero(meuNumero.ToString());
            Console.WriteLine(numeroPorExtenso);
            // Vinte E Cinco Reais E Três Centavos
        }
    }
}  
```

Para um exemplo complexo, veja o projeto "Exemplo", que contém um Form básico utilizando o pacote.

## Autor
* Felipe de Camargo

## Licença
Esse projeto está licenciado sob a licença MIT - veja mais detalhes: [LICENSE](https://github.com/Felipe379/NumerosExtensos/blob/master/LICENSE)
