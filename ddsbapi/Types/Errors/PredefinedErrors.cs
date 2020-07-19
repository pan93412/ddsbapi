namespace ddsbapi.Types.Errors
{
    /// <summary>
    /// The predefined errors.
    /// </summary>
    public static class PredefinedErrors
    {
        /// <summary>
        /// BAD_URL: The URL to shorten is invaild.
        /// </summary>
        public static readonly ErrorResponse BadUrl = new ErrorResponse
        {
            Error =
            {
                Code = "BAD_URL",
                Message = "The URL to shorten is invaild."
            }
        };
    }
}
