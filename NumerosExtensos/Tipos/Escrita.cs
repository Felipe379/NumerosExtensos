namespace NumerosExtensos.Tipos
{
    /// <summary>
    /// Classe abstrata para os tipos de escrita.
    /// </summary>
    public abstract class Escrita
    {
        /// <summary>
        /// Método que retornar o número escrito por extenso.
        /// </summary>
        /// <param name="numero">Valor do número em string já formatado.</param>
        public abstract string Numero(string numero);
    }
}
