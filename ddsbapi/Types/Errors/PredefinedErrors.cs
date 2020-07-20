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
        /// ID_HAS_BEEN_TAKEN: This custom ID has been taken.
        /// </summary>
        public static readonly ErrorResponse IdHasBeenTaken = new ErrorResponse
        {
            Error = new ErrorDetails
            {
                Code = "ID_HAS_BEEN_TAKEN",
                Message = "This custom ID has been taken."
            }
        };

        /// <summary>
        /// NO_SUCH_URL: No such a short link.
        /// </summary>
        public static readonly ErrorResponse NoSuchUrl = new ErrorResponse
        {
            Error = new ErrorDetails
            {
                Code = "NO_SUCH_URL",
                Message = "No such a short link."
            }
        };

        /// <summary>
        /// WRONG_PASSWORD: The password is wrong.
        /// </summary>
        public static readonly ErrorResponse WrongPassword = new ErrorResponse
        {
            Error = new ErrorDetails
            {
                Code = "WRONG_PASSWORD",
                Message = "The password is wrong."
            }
        };
    }
}
