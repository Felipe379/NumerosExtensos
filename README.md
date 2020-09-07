# NumerosExtensos
 Pacote que permite escrever os numerais da língua portuguesa por extenso.

## Introdução
Para começar instale o pacote [Nuget](https://www.nuget.org/packages/NumerosExtensos/).

Atualmente o pacote suporta os números:
* Cardinais: Suporta até a casa do vigintilhões.
* Ordinais: Suporta até a casa do vigintilionésimo.
* Romanos: Suporta até 3999.

## Uso

Para um exemplo complexo, veja o projeto "Exemplo", que contém um Form básico utilizando o pacote.

Exemplo de uso simplificado:

```csharp
using NumerosExtensos;
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
                Conector = "Vírgula",
                Tipo = ExtensoOptions.TipoNumerais.Cardinais,
                ZeroExplicitoDepoisDaVirgula = true,
                // Configure aqui o resto das opções
            };

            var extenso = new Extenso(extensoOptions);
            var numeroPorExtenso = extenso.EscreverNumero(meuNumero.ToString());
            Console.WriteLine(numeroPorExtenso);
            // Vinte E Cinco Vírgula Zero Três
        }
    }
}
  
```

Para facilitar uso, também é possível escolher algumas configurações já predefinidas, como por exemplo:

```csharp
    class Program
    {
        static void Main(string[] args)
        {
            var meuNumero = 25.03M;

            var extenso = new Extenso(PresetOptions.Presets[Preset.MonetarioBRL]);
            var numeroPorExtenso = extenso.EscreverNumero(meuNumero.ToString());
            Console.WriteLine(numeroPorExtenso);
            // Vinte E Cinco Reais E Três Centavos
        }
    }
  
```

## Autor
* Felipe de Camargo

## Licença
Esse projeto está licenciado sob a licença MIT - veja mais detalhes: [LICENSE](https://github.com/Felipe379/NumerosExtensos/blob/master/LICENSE)
