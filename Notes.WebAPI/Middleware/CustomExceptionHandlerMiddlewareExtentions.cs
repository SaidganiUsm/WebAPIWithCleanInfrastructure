namespace Notes.WebAPI.Middleware
{
    public static class CustomExceptionHandlerMiddlewareExtentions
    {
        public static IApplicationBuilder UseCustomExcemptionHandler(this 
            IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
        }
    }
}
