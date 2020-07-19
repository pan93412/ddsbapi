namespace ddsbapi.Types.Generate
{
    /// <summary>
    /// The request for <c>/generate</c>.
    /// </summary>
    public class GenerateRequest
    {
        /// <summary>
        /// The url to be shorten.
        /// </summary>
#pragma warning disable CA1056 // It is from the request.
        public string Url { get; set; }
#pragma warning restore CA1056 // It is from the request.
        /// <summary>
        /// The password of the shorten url.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// The custom id for the shorten url.
        /// </summary>
        public string CustomId { get; set; }
    }
}
