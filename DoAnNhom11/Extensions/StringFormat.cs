namespace DoAnNhom11.Extensions
{
    public static class StringFormat
    {
        public static string CurrencyFormat(decimal number) {
            return number.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }
        public static string DateFormat(DateTime datetime)
        {        
            return datetime.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
