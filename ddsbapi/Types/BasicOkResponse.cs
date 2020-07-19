namespace ddsbapi.Types
{
    /// <summary>
    /// The basic response whose <c>Success</c> is true.
    /// </summary>
    public class BasicOkResponse : IResponse
    {
        /// <inheritdoc/>
        public bool Success => true;
    }
}
