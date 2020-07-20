namespace ddsbapi.Types.Generate
{
    /// <summary>
    /// The response of <c>/generate</c>.
    /// </summary>
    public class GenerateResponse
    {
        /// <summary>
        /// The ID of this shortened URL.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The password of this dd.sb URL.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// A dd.sb URL pointed to the shortened URL.
        /// </summary>
        public string ShortLink => $"https://dd.sb/{Id}";
        /// <summary>
        /// A URL pointed to the statistic of this shortened URL.
        /// </summary>
        public string StatLink => $"https://dd.sb/stats.php?id={Id}";
    }
}
