namespace DoAnNhom11.Extensions
{
    public static class LocalHost
    {
        public static string GetPort(IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor == null)
                throw new ArgumentNullException(nameof(httpContextAccessor));

            var request = httpContextAccessor.HttpContext.Request;
            var port = request.Host.Port;

            return $"{port}";
        }
    }
}
