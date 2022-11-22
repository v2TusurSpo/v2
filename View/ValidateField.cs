using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс для проверки вводимых в TextBox значений.
    /// </summary>
    public static class ValidateField
    {
        /// <summary>
        /// Метод проверки ввода только чисел формата double.
        /// </summary>
        public static void ValidateTextBox(object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                         && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
            if ((sender as TextBox).Text.Length == 0)
                if (e.KeyChar == ',')
                    e.Handled = true;
        }
    }
}