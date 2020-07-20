namespace ddsbapi.Types.Get
{
    /// <summary>
    /// The response of <c>/get</c>.
    /// </summary>
    public class GetResponse
    {
        /// <summary>
        /// The URL you should redirect to.
        /// </summary>
#pragma warning disable CA1056
        public string Url { get; set; }
#pragma warning restore CA1056
    }
}
