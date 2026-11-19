using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Exemplo
{
    internal static class EnumExtensions
    {
        /// <summary>
        /// Obtém o texto do <see cref="DescriptionAttribute"/> do valor, ou o nome do enum se não houver.
        /// </summary>
        public static string ObterDescricao(this Enum valor)
        {
            var campo = valor.GetType().GetField(valor.ToString());
            return campo?.GetCustomAttribute<DescriptionAttribute>()?.Description ?? valor.ToString();
        }

        /// <summary>
        /// Preenche o combo com os valores do enum, exibindo a descrição de cada um.
        /// </summary>
        public static void PreencherCom<TEnum>(this ComboBox combo, params TEnum[] valores) where TEnum : struct, Enum
        {
            combo.FormattingEnabled = true;
            combo.Format += (_, e) =>
            {
                if (e.ListItem is Enum valor)
                    e.Value = valor.ObterDescricao();
            };
            combo.DataSource = valores.Length > 0 ? valores : Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToArray();
        }
    }
}
