namespace ddsbapi.Types
{
    /// <summary>
    /// The basic response whose <c>Success</c> is false.
    /// </summary>
    public class BasicFailResponse : IResponse
    {
        /// <inheritdoc/>
        public bool Success => false;
    }
}
