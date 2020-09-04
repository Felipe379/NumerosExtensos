# NumerosExtensos
 Pacote que permite escrever os numerais da língua portuguesa por extenso.

## Introdução
Para começar instale o pacote [Nuget](https://www.nuget.org/packages/NumerosExtensos/1.0.0).

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
                Conector = "Vírugla",
                Tipo = ExtensoOptions.TipoNumerais.Cardinais,
                ZeroExplicitoDepoisDaVirgula = true,
                // Configure aqui o resto das opções
            };

            var extenso = new Extenso(extensoOptions);
            var numeroPorExtenso = extenso.EscreverNumero(meuNumero.ToString());
            Console.WriteLine(numeroPorExtenso);
            //Vinte E Cinco Vírugla Três
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
            //Vinte E Cinco Reais E Três Centavos
        }
    }
  
```

## Autor
* Felipe de Camargo

## Licença
Esse projeto está licenciado sob a licença MIT - veja mais detalhes: [LICENSE](https://github.com/Felipe379/NumerosExtensos/blob/master/LICENSE)
