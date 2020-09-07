using NumerosExtensos.Enums;
using System;

namespace NumerosExtensos
{
    public class Extenso
    {
        private readonly ExtensoOptions _extenso;
        public Extenso(ExtensoOptions extenso)
        {
            _extenso = extenso;
        }

        public string EscreverNumero(string numero)
        {
            switch (_extenso.Tipo)
            {
                case TipoNumerais.Cardinais:
                    return Tipos.Cardinal.Escrever.Numero(numero, _extenso);
                case TipoNumerais.Ordinais:
                    return Tipos.Ordinal.Escrever.Numero(numero, _extenso);
                case TipoNumerais.Multiplicativos:
                    throw new NotSupportedException();
                case TipoNumerais.Fracionarios:
                    throw new NotSupportedException();
                case TipoNumerais.Coletivos:
                    throw new NotSupportedException();
                case TipoNumerais.Romanos:
                    return Tipos.Romano.Escrever.Numero(numero);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
