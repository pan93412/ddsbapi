namespace ddsbapi.Types.Errors
{
    /// <summary>
    /// The response when the request is bad.
    /// </summary>
    public class ErrorResponse : BasicFailResponse
    {
        /// <summary>
        /// The error details.
        /// </summary>
        public ErrorDetails Error { get; set; }
    }
}
