# Change Log
#### v2.1.0 - 2023-10-06
- Altera target framework para netstandard2.0;
- Alterações internas;
- Adiciona overload para tipos numéricos;

#### v2.0.0 - 2021-03-08
- Atualiza as configurações de opções para utilizarem herança;
- Renomeia nome das propriedades das opções;
- Correção do flexionamento em feminino nos cardinais;
- Alterações internas;
- Alterações de algumas opções predefinidas;
- Novas opções de configurações:
-- NumeraisOptions: SepararClassesPorVirgula (bool);
-- CardinaisOptions: ConjuncaoExplicitaSeParteInteiraVazia (bool);
-- CaridinaisOptions: UmMilExplicito (bool);

#### v1.1.0 - 2020-09-09
- Renomeia as opções predefinidas;
- Melhora o ExtensoOptions para diferenciar as opções disponíveis para os números cardinais e ordinais;

#### v1.0.3 - 2022-09-09
- Corrige bug que não escrevia "Zero" quando houvessem mais de três dígitos zeros;
- Corrige bug ao escrever a conjunção "De" em alguns casos específicos;
- Corrige a escrita de números cardinais para seguir a regra de ortografia correta:
-- Número com centena cheia ou começando com zero na primeira classe:  utiliza-se a conjunção e para ligar a segunda classe (de mil) à primeira classe de números quando o primeiro algarismo da primeira classe for uma centena "cheia" ou iniciar-se com zero.

#### v1.0.2 - 2022-09-07
- Melhorias gerais no código;
- Reescreve o código de Escrever.Numero() do Cardinal;
- Adiciona configuração predefinida "Metro";

#### v1.0.1 - 2022-09-07
- Correção para a escrita dos cardinais para caso não exista uma vírgula ou ponto;

#### v1.0.0 - 2022-09-04
- Release inicial;