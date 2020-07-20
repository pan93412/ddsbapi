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
            Error = new ErrorDetails
            {
                Code = "BAD_URL",
                Message = "The URL to shorten is invaild."
            }
        };

        /// <summary>
        /// BAD_URL: The URL to shorten is invaild.
        /// </summary>
        public static readonly ErrorResponse IdHasBeenTaken = new ErrorResponse
        {
            Error = new ErrorDetails
            {
                Code = "ID_HAS_BEEN_TAKEN",
                Message = "This custom ID has been taken."
            }
        };
    }
}
