namespace DoAnNhom11.Extensions
{
    public static class StringFormat
    {
        public static string CurrencyFormat(decimal number) {
            return number.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }
    }
}
